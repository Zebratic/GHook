using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GHook
{
    class GHook
    {
        private delegate int HookProc(int code, IntPtr wParam, IntPtr lParam);
        static IntPtr hHook;

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("User32.dll")]
        public static extern bool SetWindowText(IntPtr hWnd, string lParam);

        [DllImport("User32.dll")]
        private static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string strClassName, string strWindowName);

        [DllImport("User32")]
        private static extern int ShowWindow(IntPtr hwnd, int nCmdShow);

        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        static extern IntPtr FindWindowByCaption(int ZeroOnly, string lpWindowName);

        [DllImport("user32.dll", EntryPoint = "SetWindowsHookEx", SetLastError = true)]
        static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll")]
        static extern int CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        [DllImport("kernel32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);
        public static int PaintHookProc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            return CallNextHookEx(hHook, nCode, wParam, lParam);
        }

        private const int WH_GETMESSAGE = 3;

        private static readonly Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!#¤%&/()=?`´'*¨^@£$€{[]}|";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static void HookProcess(IntPtr processHook, IntPtr ProcessClient)
        {
            SetParent(ProcessClient, processHook);
            MoveWindow(ProcessClient, -8, -32, 520, 450, true);
            MoveWindow(processHook, 0, 0, 520, 450, true);
            SetForegroundWindow(GetConsoleWindow());
            SendKeys.SendWait("{F11}");
        }

        public static void HideProcess(string ParentName, string ClientName)
        {
            Process[] pros = Process.GetProcessesByName(ParentName);
            Process[] pros1 = Process.GetProcessesByName(ClientName);
            foreach (Process pro in pros)
            {
                foreach (Process pro1 in pros1)
                {
                    SpoofHideProcess(pro.MainWindowHandle, pro1.MainWindowHandle);
                }
            }
        }

        public static void SpoofProcess(string hookName, string SpoofedTitle)
        {
            Process[] pros = Process.GetProcessesByName(hookName);
            foreach (Process pro in pros)
            {
                SetWindowText(pro.MainWindowHandle, SpoofedTitle);
            }
        }

        public static void ProcessChecker(string processName)
        {
            while (true)
            {
                SpoofProcess(processName, RandomString(150));
                Process[] pro = Process.GetProcessesByName(processName);
                if (pro.Length < 1)
                    Environment.Exit(5);
            }
        }

        public static void SpoofHideProcess(IntPtr HookedParent, IntPtr Client)
        {
            var hWnd = FindWindowEx(HookedParent, Client, null, null);
            HookProc PaintHookProcedure = new HookProc(PaintHookProc);
            uint threadID = GetWindowThreadProcessId(HookedParent, out uint processHandle);

            hHook = SetWindowsHookEx(WH_GETMESSAGE, PaintHookProcedure, HookedParent, threadID);
            ShowWindow(hWnd, 9);
        }
    }
}
