namespace CommitMessageFormatter
{
    using System;
    using System.Windows.Forms;

    internal class NotifyIconContextMenu : ContextMenuStrip
    {
        private ToolStripMenuItem ShowDialog { get; set; } =
            new ToolStripMenuItem
            {
                Text = "Show",
            };
        private ToolStripMenuItem ShowConfig { get; set; } =
            new ToolStripMenuItem
            {
                Text = "Config",
            };
        private ToolStripMenuItem ExitApp { get; set; } =
            new ToolStripMenuItem
            {
                Text = "Close",
            };

        public NotifyIconContextMenu()
        {
            ShowDialog.Click += Show_Click;
            Items.Add(ShowDialog);

            ShowConfig.Click += Config_Click;
            Items.Add(ShowConfig);

            Items.Add(new ToolStripSeparator());

            ExitApp.Click += Exit_Click;
            Items.Add(ExitApp);
        }

        private void Show_Click(object sender, EventArgs e)
        {
            using var dlg = new CommitMessageFormatterDlg();
            dlg.ShowDialog();
        }

        private void Config_Click(object sender, EventArgs e)
        {
            using var dlg = new CommitMessageFormatterDlg();
            dlg.ShowDialog();
        }

        private static void Exit_Click(object sender, EventArgs e) =>
            Application.Exit();
    }
}
