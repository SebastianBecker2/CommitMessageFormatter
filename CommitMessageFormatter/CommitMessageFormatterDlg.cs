namespace CommitMessageFormatter
{
    using System;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using WeCantSpell.Hunspell;

    public partial class CommitMessageFormatterDlg : Form
    {
        private readonly Color darkBackground = Color.FromArgb(30, 30, 30);
        private readonly Color darkForeground =
            Color.FromKnownColor(KnownColor.WhiteSmoke);
        private readonly Color darkSeparatorColor =
            Color.FromKnownColor(KnownColor.MidnightBlue);

        private const int MaxHeaderLength = 50;
        private const int MaxBodyLength = 72;
        private const string HeaderTooLongText = " [HEADER TOO LONG]";
        // Since RichTextBox is forcing every \r\n to \n
        private const string ActualNewLine = "\n";

#pragma warning disable CA1805 // Do not initialize unnecessarily
        private bool isReformatting = false;
#pragma warning restore CA1805 // Do not initialize unnecessarily
        public CommitMessageFormatterDlg() => InitializeComponent();

        protected override void OnLoad(EventArgs e)
        {
            SetPositionToTaskbar();

            RtbCommitMessage.BackColor = darkBackground;
            LblStatus.BackColor = darkBackground;
            RtbCommitMessage.ForeColor = darkForeground;
            LblStatus.ForeColor = darkForeground;
            BackColor = darkSeparatorColor;

            LblStatus.Text = "";

            try
            {
                var clipboardData = Clipboard.GetDataObject();
                if (clipboardData.GetFormats().Contains("Text"))
                {
                    RtbCommitMessage.Text =
                        clipboardData.GetData("Text") as string;
                }
            }
            catch (ExternalException)
            {
                LblStatus.Text = "Unable to insert from clipboard.";
            }

            base.OnLoad(e);
        }

        protected override void OnShown(EventArgs e)
        {
            // Brute force the dialog to frontmostestest topmostest
            WindowState = FormWindowState.Minimized;
            Show();
            WindowState = FormWindowState.Normal;
            BringToFront();
            Activate();
            Focus();

            base.OnShown(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }

            base.OnKeyDown(e);
        }

        private void SetPositionToTaskbar()
        {
            switch (Taskbar.Position)
            {
                case TaskbarPosition.Left:
                    Location = Taskbar.CurrentBounds.Location +
                        Taskbar.CurrentBounds.Size;
                    Location = new Point(Location.X, Location.Y - Size.Height);
                    break;

                case TaskbarPosition.Top:
                    Location = Taskbar.CurrentBounds.Location +
                        Taskbar.CurrentBounds.Size;
                    Location = new Point(Location.X - Size.Width, Location.Y);
                    break;

                case TaskbarPosition.Right:
                    Location = Taskbar.CurrentBounds.Location - Size;
                    Location = new Point(
                        Location.X,
                        Location.Y + Taskbar.CurrentBounds.Height);
                    break;

                case TaskbarPosition.Bottom:
                    Location = Taskbar.CurrentBounds.Location - Size;
                    Location = new Point(
                        Location.X + Taskbar.CurrentBounds.Width,
                        Location.Y);
                    break;

                case TaskbarPosition.Unknown:
                default:
                    StartPosition = FormStartPosition.WindowsDefaultLocation;
                    break;
            }
        }

        private static string FormattingCommitMessage(string message)
        {
            var endOfHeader = message.IndexOf(ActualNewLine);
            // If it's header only
            if (endOfHeader == -1)
            {
                message = message.Replace(HeaderTooLongText, "");
                if (message.Length > MaxHeaderLength)
                {
                    return message + HeaderTooLongText;
                }
                return message;
            }

            var formatted = message
                .Substring(0, endOfHeader)
                .Replace(HeaderTooLongText, "");
            ;
            if (formatted.Length > MaxHeaderLength)
            {
                formatted += HeaderTooLongText;
            }
            formatted += ActualNewLine + ActualNewLine;

            do
            {
                endOfHeader += ActualNewLine.Length;
            } while (message[endOfHeader..].StartsWith(ActualNewLine));

            var words = message[endOfHeader..]
                .Replace(ActualNewLine, " ")
                .Split(' ');

            var line = "";
            foreach (var word in words)
            {
                if (line.Any() && (line + " " + word).Length > MaxBodyLength)
                {
                    formatted += line + ActualNewLine;
                    line = "";
                }
                if (line.Any())
                {
                    line += " " + word;
                }
                else
                {
                    line += word;
                }
            }
            return formatted + line;
        }

        private void CheckSpelling()
        {
            var dictionary = WordList.CreateFromFiles(
                    @"dictionary\en_US.dic",
                    @"dictionary\en_US.aff");

            var words = RtbCommitMessage.Text
                .Split(' ', '.', ',', ';', '-', '_', '\n')
                .Where(w => !string.IsNullOrWhiteSpace(w));

            foreach (var word in words)
            {
                if (dictionary.Check(word))
                {
                    continue;
                }

                var index = -1;
                while (true)
                {
                    index = RtbCommitMessage.Text.IndexOf(word, index + 1);
                    if (index == -1)
                    {
                        break;
                    }
                    RtbCommitMessage.SelectionStart = index;
                    RtbCommitMessage.SelectionLength = word.Length;
                    RtbCommitMessage.SelectionFont = new Font(
                        RtbCommitMessage.SelectionFont,
                        FontStyle.Underline);
                }

                //Debug.Print($"Wrong much? {word}");
                //var suggestions = dictionary.Suggest(word);
                //foreach (var suggestion in suggestions)
                //{
                //    Debug.Print($"What about: {suggestion}");
                //}
            }
        }

        private void RtbCommitMessage_TextChanged(object sender, EventArgs e)
        {
            if (isReformatting)
            {
                return;
            }
            isReformatting = true;

            try
            {
                var selectionStart = RtbCommitMessage.SelectionStart;
                var selectionLength = RtbCommitMessage.SelectionLength;
                RtbCommitMessage.Text =
                    FormattingCommitMessage(RtbCommitMessage.Text);
                CheckSpelling();
                RtbCommitMessage.SelectionStart = selectionStart;
                RtbCommitMessage.SelectionLength = selectionLength;
            }
            finally
            {
                isReformatting = false;
                TimClipboard.Enabled = true;
            }
        }

        private void TimClipboard_Tick(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetDataObject(
                    RtbCommitMessage.Text.Replace(ActualNewLine, Environment.NewLine),
                    true,
                    5, // number of retries
                    10); // delay between retries
                LblStatus.Text = "Copied to clipboard.";
            }
            catch (ExternalException)
            {
                LblStatus.Text = "Unable to copy clipboard.";
            }
            finally
            {
                TimClipboard.Enabled = false;
            }
        }
    }
}
