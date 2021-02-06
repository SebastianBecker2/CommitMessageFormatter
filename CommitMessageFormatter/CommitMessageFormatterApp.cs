namespace CommitMessageFormatter
{
    using System;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;
    using CommitMessageFormatter.Hotkeys;
    using CommitMessageFormatter.Properties;

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
                new ToolStripMenuItem("Config", null, (s,e) => ShowConfig()),
                new ToolStripSeparator(),
                new ToolStripMenuItem("Close", null, (s,e) => ExitThread()),
            });
            NotifyIcon.DoubleClick += (s, e) => ShowDialog();

            HotkeyManager = new HotkeyManager();
            RegisterHotkey();
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

        private void RegisterHotkey()
        {
            var key = (Keys)Settings.Default.HotkeyButton;
            if (key != Keys.None)
            {
                var modifierKeys = (ModifierKeys)Settings.Default.HotkeyModifier;
                HotkeyManager.AddHotkey(key, modifierKeys);
            }
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

        public void ShowConfig()
        {
            HotkeyManager.RemoveAllHotkeys();
            try
            {
                using var dlg = new ConfigDlg
                {
                    Key = (Keys)Settings.Default.HotkeyButton,
                    Modifier = (ModifierKeys)Settings.Default.HotkeyModifier,
                    HotkeyManager = HotkeyManager,
                    BackgroundColor =
                        Color.FromArgb(Settings.Default.BackgroundColor),
                    ForegroundColor =
                        Color.FromArgb(Settings.Default.ForegroundColor),
                    SeparatorColor =
                        Color.FromArgb(Settings.Default.SeparatorColor),
                    FontName = Settings.Default.FontName,
                    FontSize = Settings.Default.FontSize,
                    LineCount = Settings.Default.LineCount,
                    MaxHeaderLength = Settings.Default.MaxHeaderLength,
                    MaxBodyLength = Settings.Default.MaxBodyLength,
                    HeaderToBodySeparatorLines =
                        Settings.Default.HeaderToBodySeparatorLines,
                };

                if (dlg.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                Settings.Default.HotkeyButton = (int)dlg.Key;
                Settings.Default.HotkeyModifier = (int)dlg.Modifier;
                Settings.Default.BackgroundColor = dlg.BackgroundColor.ToArgb();
                Settings.Default.ForegroundColor = dlg.ForegroundColor.ToArgb();
                Settings.Default.SeparatorColor = dlg.SeparatorColor.ToArgb();
                Settings.Default.FontName = dlg.FontName;
                Settings.Default.FontSize = dlg.FontSize;
                Settings.Default.LineCount = dlg.LineCount;
                Settings.Default.MaxHeaderLength = dlg.MaxHeaderLength;
                Settings.Default.MaxBodyLength = dlg.MaxBodyLength;
                Settings.Default.HeaderToBodySeparatorLines =
                    dlg.HeaderToBodySeparatorLines;
                Settings.Default.Save();
            }
            finally
            {
                RegisterHotkey();
            }
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
            }

            disposedValue = true;
            base.Dispose(disposing);
        }
    }
}
