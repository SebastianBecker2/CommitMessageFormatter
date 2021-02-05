namespace CommitMessageFormatter
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.Drawing.Text;
    using System.Linq;
    using System.Windows.Forms;
    using CommitMessageFormatter.Hotkeys;

    public partial class ConfigDlg : Form
    {
        public Keys Key { get; set; } = Keys.None;
        public ModifierKeys Modifier { get; set; } = Hotkeys.ModifierKeys.None;
        public HotkeyManager HotkeyManager { get; set; }

        public Color BackgroundColor { get; set; }
        public Color ForegroundColor { get; set; }
        public Color SeparatorColor { get; set; }

        public string FontName { get; set; }
        public int FontSize { get; set; }
        public int LineCount { get; set; }

        private string currentHotkeyLabel;

        public ConfigDlg() => InitializeComponent();

        protected override void OnLoad(EventArgs e)
        {
            currentHotkeyLabel = LblCurrentButton.Text;

            UpdateCurrentHotkey(Key, Modifier);

            pibBackground.BackColor = BackgroundColor;
            pibForeground.BackColor = ForegroundColor;
            pibSeparator.BackColor = SeparatorColor;

            CmbFontName.Text = FontName;
            NudFontSize.Value = FontSize;
            NudLineCount.Value = LineCount;

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

            BackgroundColor = pibBackground.BackColor;
            ForegroundColor = pibForeground.BackColor;
            SeparatorColor = pibSeparator.BackColor;

            FontName = CmbFontName.Text;
            FontSize = (int)NudFontSize.Value;
            LineCount = (int)NudLineCount.Value;
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (sender is not PictureBox pib)
            {
                return;
            }
            using var colorPicker = new ColorDialog
            {
                Color = pib.BackColor
            };
            if (colorPicker.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            pib.BackColor = colorPicker.Color;
        }

        private static IEnumerable<string> GetMonospacedFonts()
        {
            var installedFontCollection = new InstalledFontCollection();
            var fontNames =
                installedFontCollection.Families.Select(f => f.Name);
            var testChars =
                new char[] { 'm', 'M', 'i', 'I', 'l', 'L', '1', '2', 'w', 'W' };
            return fontNames.Where(f =>
                    testChars
                        .Select(c => TextRenderer.MeasureText(
                            new string(c, 10),
                            new Font(f, 10)).Width)
                        .Distinct()
                        .Count() == 1);
        }

        private void CmbFontName_DropDown(object sender, EventArgs e)
        {
            if (CmbFontName.Items.Count > 0)
            {
                return;
            }
            CmbFontName.Items.AddRange(GetMonospacedFonts().ToArray());
        }
    }
}
