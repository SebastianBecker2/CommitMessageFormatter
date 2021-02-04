namespace CommitMessageFormatter
{
    using System;
    using System.Threading;
    using System.Windows.Forms;
    using CommitMessageFormatter.Hotkeys;
    using CommitMessageFormatter.Properties;

    // Properly implement ApplicationContext

    internal class CommitMessageFormatterApp : ApplicationContext, IDisposable
    {
        private NotifyIcon NotifyIcon { get; set; }
        private HotkeyManager HotkeyManager { get; set; }

        private int isDialogOpen;

        public CommitMessageFormatterApp()
        {
            NotifyIcon = new NotifyIcon
            {
                Visible = true,
                Icon = Resources.comments,
                ContextMenuStrip = new ContextMenuStrip(),
            };
            NotifyIcon.ContextMenuStrip.Items.AddRange(new ToolStripItem[]
            {
                new ToolStripMenuItem("Show", null, (s,e) => ShowDialog()),
                //new ToolStripMenuItem("Config", null, (s,e) => ShowDialog()),
                new ToolStripSeparator(),
                new ToolStripMenuItem("Close", null, (s,e) => ExitThread()),
            });
            NotifyIcon.DoubleClick += (s, e) => ShowDialog();

            HotkeyManager = new HotkeyManager();
            HotkeyManager.AddHotkey(
                Keys.F10,
                ModifierKeys.Alt | ModifierKeys.Shift);
            HotkeyManager.HotkeyPressed += (s, e) =>
            {
                if (Interlocked.Exchange(ref isDialogOpen, 1) > 0)
                {
                    return;
                }
                var t = new Thread(() =>
                {
                    using var dlg = new CommitMessageFormatterDlg();
                    dlg.ShowDialog();
                    isDialogOpen = 0;
                });
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
            };
        }

        public void ShowDialog()
        {
            if (Interlocked.Exchange(ref isDialogOpen, 1) > 0)
            {
                return;
            }
            using var dlg = new CommitMessageFormatterDlg();
            dlg.ShowDialog();
            isDialogOpen = 0;
        }

        private bool disposedValue;

        protected override void Dispose(bool disposing)
        {
            if (disposedValue)
            {
                return;
            }

            if (disposing)
            {
                HotkeyManager?.Dispose();
                NotifyIcon?.Dispose();
                //Dlg?.Dispose();
            }

            disposedValue = true;
            base.Dispose(disposing);
        }
    }
}
