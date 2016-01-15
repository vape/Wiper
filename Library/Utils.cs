using System.Windows.Forms;

using static Wiper.Library.NativeMethods;

namespace Wiper.Library
{
    public static class Utils
    {
        public static void AddUACIcon(this Button button)
        {
            SendMessage(button.Handle, BCM_SETSHIELD, 0, 1);
        }

        public static void RemoveUACIcon(this Button button)
        {
            SendMessage(button.Handle, BCM_SETSHIELD, 0, 0);
        }
    }
}
