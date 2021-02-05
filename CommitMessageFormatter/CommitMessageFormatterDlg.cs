namespace CommitMessageFormatter
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;
    using CommitMessageFormatter.Properties;
    using WeCantSpell.Hunspell;

    public partial class CommitMessageFormatterDlg : Form
    {
        private const int MaxHeaderLength = 50;
        private const int MaxBodyLength = 72;
        private const string HeaderTooLongText = " [HEADER TOO LONG]";
        // Since RichTextBox is forcing every \r\n to \n
        private const string ActualNewLine = "\n";

#pragma warning disable CA1805 // Do not initialize unnecessarily
        private bool isReformatting = false;
#pragma warning restore CA1805 // Do not initialize unnecessarily
        private readonly Dictionary<string, bool> spellcheckedWords =
            new Dictionary<string, bool>();

        public CommitMessageFormatterDlg() => InitializeComponent();

        protected override void OnLoad(EventArgs e)
        {
            var font = new Font(
                Settings.Default.FontName,
                Settings.Default.FontSize);

            var size = TextRenderer.MeasureText(
                new string(' ', MaxBodyLength),
                font);

            RtbCommitMessage.Font = font;
            LblStatus.Font = font;
            var lineCount = Settings.Default.LineCount;
            // Add one to the line count fo the status bar
            // And 3 to the height for the separator
            Size = new Size(size.Width, (size.Height * (lineCount + 1)) + 3);

            RtbCommitMessage.BackColor =
                Color.FromArgb(Settings.Default.BackgroundColor);
            LblStatus.BackColor =
                Color.FromArgb(Settings.Default.BackgroundColor);
            RtbCommitMessage.ForeColor =
                Color.FromArgb(Settings.Default.ForegroundColor);
            LblStatus.ForeColor =
                Color.FromArgb(Settings.Default.ForegroundColor);
            BackColor = Color.FromArgb(Settings.Default.SeparatorColor);

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

            SetPositionToTaskbar();

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

            var rx = new Regex(
                @"((\b[^\s]+\b)((?<=\.\w).)?)",
                RegexOptions.Compiled | RegexOptions.IgnoreCase);
            var matches = rx.Matches(RtbCommitMessage.Text);

            foreach (var word in matches.Select(w => w.ToString()))
            {
                if (spellcheckedWords.TryGetValue(word, out var isCorrect))
                {
                    if (isCorrect)
                    {
                        continue;
                    }
                    UnderlineWord(word);
                }
                else
                {
                    if (dictionary.Check(word))
                    {
                        spellcheckedWords[word] = true;
                        continue;
                    }

                    spellcheckedWords[word] = false;
                    UnderlineWord(word);
                }
            }
        }

        private void UnderlineWord(string word)
        {
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
        }

        private void RtbCommitMessage_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RtbCommitMessage.Text))
            {
                return;
            }

            if (isReformatting)
            {
                return;
            }
            isReformatting = true;

            var selectionStart = RtbCommitMessage.SelectionStart;
            var selectionLength = RtbCommitMessage.SelectionLength;
            try
            {
                RtbCommitMessage.Text =
                    FormattingCommitMessage(RtbCommitMessage.Text);
                CheckSpelling();
            }
            finally
            {
                RtbCommitMessage.SelectionStart = selectionStart;
                RtbCommitMessage.SelectionLength = selectionLength;
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
