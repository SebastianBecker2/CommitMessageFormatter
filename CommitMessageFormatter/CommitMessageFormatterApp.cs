namespace CommitMessageFormatter
{
    using System;
    using System.Windows.Forms;
    using CommitMessageFormatter.Properties;

    internal class CommitMessageFormatterApp : IDisposable
    {
        private NotifyIcon NotifyIcon { get; set; } = new NotifyIcon();

        public CommitMessageFormatterApp()
        {
            NotifyIcon.Visible = true;
            NotifyIcon.Icon = Resources.comments;
            NotifyIcon.ContextMenuStrip = new NotifyIconContextMenu();
            NotifyIcon.DoubleClick += NotifyIcon_DoubleClick;
        }

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            using var dlg = new CommitMessageFormatterDlg();
            dlg.ShowDialog();
        }

        private bool disposedValue;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    NotifyIcon?.Dispose();
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
