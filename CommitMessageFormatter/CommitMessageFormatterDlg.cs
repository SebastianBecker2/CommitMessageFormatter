using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeCantSpell.Hunspell;

namespace CommitMessageFormatter
{
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
        public CommitMessageFormatterDlg()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
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

        private static string FormattingCommitMessage(string message)
        {
            var endOfHeader = message.IndexOf(ActualNewLine);
            // If it's header only
            if (endOfHeader == -1)
            {
                if (message.Length > MaxHeaderLength)
                {
                    return message.Substring(0, endOfHeader) + HeaderTooLongText;
                }
                return message;
            }

            var formatted = message.Substring(0, endOfHeader);
            if (!formatted.EndsWith(HeaderTooLongText)
                && formatted.Length > MaxHeaderLength)
            {
                formatted += HeaderTooLongText;
            }
            formatted += ActualNewLine + ActualNewLine;

            do
            {
                endOfHeader += ActualNewLine.Length;
            } while (message
                .Substring(endOfHeader)
                .StartsWith(ActualNewLine));

            var words = message
                .Substring(endOfHeader)
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
