using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommitMessageFormatter
{
    public partial class CommitMessageFormatterDlg : Form
    {
        private const int MaxHeaderLength = 50;
        private const int MaxBodyLength = 72;
        private const string HeaderTooLongText = " [HEADER TOO LONG]";

        private bool isReformatting = false;
        public CommitMessageFormatterDlg()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            LblStatus.Text = "";
            base.OnLoad(e);
        }

        private string FormattingCommitMessage(string message)
        {
            var endOfHeader = message.IndexOf(Environment.NewLine);
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
            if (!formatted.EndsWith(HeaderTooLongText) && formatted.Length > MaxHeaderLength)
            {
                formatted += HeaderTooLongText;
            }
            formatted += Environment.NewLine + Environment.NewLine;

            do
            {
                endOfHeader += Environment.NewLine.Length;
            } while (message.Substring(endOfHeader, Environment.NewLine.Length) == Environment.NewLine);

            var words = message
                .Substring(endOfHeader)
                .Replace(Environment.NewLine, " ")
                .Split(' ');

            var line = "";
            foreach (var word in words)
            {
                if (line.Any() && (line + " " + word).Length > MaxBodyLength)
                {
                    formatted += line + Environment.NewLine;
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

        private void CopyCommitMessageToClipboard()
        {

        }

        private void TxtCommitMessage_TextChanged(object sender, EventArgs e)
        {
            if (isReformatting)
            {
                return;
            }
            isReformatting = true;

            try
            {
                TxtCommitMessage.Text =
                    FormattingCommitMessage(TxtCommitMessage.Text);
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
                    TxtCommitMessage.Text,
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
