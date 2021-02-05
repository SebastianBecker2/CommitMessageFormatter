namespace CommitMessageFormatter
{
    using System;
    using System.Windows.Forms;
    using CommitMessageFormatter.Hotkeys;

    public partial class ConfigDlg : Form
    {
        public Keys Key { get; set; } = Keys.None;
        public ModifierKeys Modifier { get; set; } = Hotkeys.ModifierKeys.None;
        public HotkeyManager HotkeyManager { get; set; }

        private string currentHotkeyLabel;

        public ConfigDlg() => InitializeComponent();

        protected override void OnLoad(EventArgs e)
        {
            currentHotkeyLabel = LblCurrentButton.Text;

            UpdateCurrentHotkey(Key, Modifier);

            base.OnLoad(e);
        }

        private void UpdateCurrentHotkey(Keys key, ModifierKeys modifier)
        {
            Key = key;
            Modifier = modifier;

            LblCurrentButton.Text = currentHotkeyLabel + Key.ToString();

            ChbShift.Checked = Modifier.HasFlag(Hotkeys.ModifierKeys.Shift);
            ChbControl.Checked = Modifier.HasFlag(Hotkeys.ModifierKeys.Control);
            ChbAlt.Checked = Modifier.HasFlag(Hotkeys.ModifierKeys.Alt);
            ChbWindows.Checked = Modifier.HasFlag(Hotkeys.ModifierKeys.Windows);
        }

        private void BtnNewHotkey_Click(object sender, EventArgs e)
        {
            BtnNewHotkey.Enabled = false;
            HotkeyManager.KeyPressed += HotkeyManager_KeyPressed;
        }

        private void HotkeyManager_KeyPressed(
            object sender,
            KeyPressedEventArgs e) =>
            BeginInvoke((MethodInvoker)delegate
            {
                UpdateCurrentHotkey(e.PressedKey, e.ModifierKeys);
                BtnNewHotkey.Enabled = true;
                HotkeyManager.KeyPressed -= HotkeyManager_KeyPressed;
            });

        private void BtnOkay_Click(object sender, EventArgs e)
        {
            Modifier = Hotkeys.ModifierKeys.None;
            if (ChbShift.Checked)
            {
                Modifier |= Hotkeys.ModifierKeys.Shift;
            }
            if (ChbControl.Checked)
            {
                Modifier |= Hotkeys.ModifierKeys.Control;
            }
            if (ChbAlt.Checked)
            {
                Modifier |= Hotkeys.ModifierKeys.Alt;
            }
            if (ChbWindows.Checked)
            {
                Modifier |= Hotkeys.ModifierKeys.Windows;
            }
        }
    }
}
