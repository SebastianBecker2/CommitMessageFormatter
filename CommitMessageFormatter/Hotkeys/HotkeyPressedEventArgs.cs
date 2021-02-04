namespace CommitMessageFormatter.Hotkeys
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public class HotkeyPressedEventArgs : EventArgs
    {
        public Keys PressedKey { get; set; }
        public ModifierKeys ModifierKeys { get; set; }
    }
}
