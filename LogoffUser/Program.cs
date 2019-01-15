using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LogoffUser
{
    class Program
    {
        static void Main(string[] args)
        {
            LockWorkStation();
            ExitWindowsEx(20, 0);
            //20 = EWX_FORCEIFHUNG (0x00000010) + EWX_FORCE (0x00000004)
        }

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool ExitWindowsEx(uint uFlags, uint dwReason);
        //https://docs.microsoft.com/en-us/windows/desktop/api/winuser/nf-winuser-exitwindowsex

        [DllImport("user32.dll")]
        public static extern bool LockWorkStation();
        //https://docs.microsoft.com/en-us/windows/desktop/api/winuser/nf-winuser-lockworkstation

    }
}
