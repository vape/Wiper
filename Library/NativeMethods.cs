using System;
using System.Runtime.InteropServices;

namespace Wiper.Library
{
    static class NativeMethods
    {
        public const Int32 BCM_SETSHIELD = 0x160C;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);
    }
}
