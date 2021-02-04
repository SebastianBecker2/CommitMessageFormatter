namespace CommitMessageFormatter.Hotkeys
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    public class HotkeyManager : IDisposable
    {
        private enum HookType
        {
            CallWndProc = 4,
            CallWndProCret = 12,
            Cbt = 5,
            Debug = 9,
            ForeGroundIdle = 11,
            GetMessage = 3,
            JournalPlayBkac = 1,
            JournalRecord = 0,
            Keyboard = 2,
            KeyboardLowLevel = 13,
            Mouse = 7,
            MouseLowLevel = 14,
            MsgFilter = -1,
            Shell = 10,
            SysMsgFilter = 6,
        }

        private enum KeyPressEventType
        {
            KeyDown = 0x0100,
            KeyUp = 0x0101,
            SysKeyDown = 0x0104,
            SysKeyUp = 0x0105,
        }

        private class Hotkey : IEquatable<Hotkey>
        {
            public Keys Key { get; set; }
            public ModifierKeys ModifierKeys { get; set; }

            public override bool Equals(object obj) =>
                Equals(obj as Hotkey);
            public bool Equals(Hotkey other) =>
                other != null
                && Key == other.Key
                && ModifierKeys == other.ModifierKeys;
            public override int GetHashCode() =>
                HashCode.Combine(Key, ModifierKeys);

            public static bool operator ==(Hotkey left, Hotkey right) =>
                EqualityComparer<Hotkey>.Default.Equals(left, right);
            public static bool operator !=(Hotkey left, Hotkey right) =>
                !(left == right);
        }

        [StructLayout(LayoutKind.Sequential)]
        private class KeyboardLowLevelInputEvent
        {
            public Keys VirtualKeyCode { get; set; }
            public int ScanCode { get; set; }
            public int Flags { get; set; }
            public int Time { get; set; }
            public UIntPtr ExtraInfo { get; set; }
        }

        private delegate IntPtr LowLevelKeyboardProc(
            int hookCode,
            IntPtr keyPressEventType,
            KeyboardLowLevelInputEvent keyboardEvent);

        private static LowLevelKeyboardProc lowLevelKeyboardCallbackDelegate;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(
            HookType hookType,
            LowLevelKeyboardProc callback,
            IntPtr library,
            uint threadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hookHandle);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(
            IntPtr hookHandle,
            int hookCode,
            IntPtr keyPressEventType,
            KeyboardLowLevelInputEvent keyboardEvent);

        public event EventHandler<HotkeyPressedEventArgs> HotkeyPressed;
        protected virtual void OnHotkeyPressed(
            Keys key,
            ModifierKeys modifierKeys) =>
            HotkeyPressed?.Invoke(this, new HotkeyPressedEventArgs
            {
                PressedKey = key,
                ModifierKeys = modifierKeys,
            });

        private HashSet<Hotkey> RegisteredHotkeys { get; set; } =
            new HashSet<Hotkey>();
        private IntPtr? KeyboardHookHandle { get; set; }
        private ModifierKeys CurrentModifierKeys { get; set; }

        private bool disposedValue;

        public HotkeyManager()
        {
            lowLevelKeyboardCallbackDelegate =
                new LowLevelKeyboardProc(LowLevelKeyboardCallback);
            KeyboardHookHandle = SetWindowsHookEx(
                HookType.KeyboardLowLevel,
                lowLevelKeyboardCallbackDelegate,
                IntPtr.Zero,
                0);
        }

        public bool AddHotkey(
            Keys key,
            ModifierKeys modifierKeys = ModifierKeys.None)
        {
            // Local copy to avoid locking
            var localCopy = new HashSet<Hotkey>(RegisteredHotkeys);
            var result = localCopy.Add(new Hotkey
            {
                Key = key,
                ModifierKeys = modifierKeys,
            });
            RegisteredHotkeys = localCopy;
            return result;
        }

        public bool RemoveHotkey(
            Keys key,
            ModifierKeys modifierKeys = ModifierKeys.None)
        {
            // Local copy to avoid locking
            var localCopy = new HashSet<Hotkey>(RegisteredHotkeys);
            var result = localCopy.Remove(new Hotkey
            {
                Key = key,
                ModifierKeys = modifierKeys,
            });
            RegisteredHotkeys = localCopy;
            return result;
        }

        private void UpdateModifierKeys(
            IntPtr keyPressEventType,
            Keys pressedKey)
        {
            // We assume key down. Should be right about 50% of the time. ;)
            Action<ModifierKeys> applyModifier =
                (ModifierKeys modifierKey) => CurrentModifierKeys |= modifierKey;

#pragma warning disable IDE0078 // Use pattern matching
            if (keyPressEventType == (IntPtr)KeyPressEventType.KeyUp
                    || keyPressEventType == (IntPtr)KeyPressEventType.SysKeyUp)
#pragma warning restore IDE0078 // Use pattern matching
            {
                applyModifier = (ModifierKeys modifierKey) =>
                   CurrentModifierKeys &= ~modifierKey;
            }

#pragma warning disable IDE0010 // Add missing cases
            switch (pressedKey)
#pragma warning restore IDE0010 // Add missing cases
            {
                case Keys.ShiftKey:
                case Keys.LShiftKey:
                case Keys.RShiftKey:
                    applyModifier(ModifierKeys.Shift);
                    break;

                case Keys.ControlKey:
                case Keys.LControlKey:
                case Keys.RControlKey:
                    applyModifier(ModifierKeys.Control);
                    break;

                case Keys.Menu:
                case Keys.LMenu:
                case Keys.RMenu:
                    applyModifier(ModifierKeys.Alt);
                    break;

                case Keys.LWin:
                case Keys.RWin:
                    applyModifier(ModifierKeys.Windows);
                    break;
            }
        }

        private IntPtr LowLevelKeyboardCallback(
            int hookCode,
            IntPtr keyPressEventType,
            KeyboardLowLevelInputEvent keyboardEvent)
        {
            var hookResult = CallNextHookEx(
                (IntPtr)0,
                hookCode,
                keyPressEventType,
                keyboardEvent);

            if (hookCode < 0)
            {
                return hookResult;
            }

            try
            {
                UpdateModifierKeys(
                    keyPressEventType,
                    keyboardEvent.VirtualKeyCode);

                // We only care about key down
#pragma warning disable IDE0078 // Use pattern matching
                if (keyPressEventType == (IntPtr)KeyPressEventType.KeyDown
                    || keyPressEventType == (IntPtr)KeyPressEventType.SysKeyDown)
#pragma warning restore IDE0078 // Use pattern matching
                {
                    var localRef = RegisteredHotkeys;
                    var hotkey = new Hotkey
                    {
                        Key = keyboardEvent.VirtualKeyCode,
                        ModifierKeys = CurrentModifierKeys,
                    };
                    if (localRef.Contains(hotkey))
                    {
                        OnHotkeyPressed(hotkey.Key, CurrentModifierKeys);
                    }
                }
            }
            catch (Exception)
            {
                CurrentModifierKeys = ModifierKeys.None;
            }
            return hookResult;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (KeyboardHookHandle.HasValue)
                    {
                        _ = UnhookWindowsHookEx(KeyboardHookHandle.Value);
                    }
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
