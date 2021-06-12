using GHook;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GHook
{
    public partial class Ghook : Form
    {
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("User32.dll")]
        public static extern bool SetWindowText(IntPtr hWnd, string lParam);
        public Ghook()
        {
            InitializeComponent();
        }
       
        private void BtnSpoof_Click(object sender, EventArgs e)
        {
            SpoofProcess(ProcessHook.Text, NewTitle.Text);
        }

        public static void SpoofProcess(string hookName, string SpoofedTitle)
        {
            Process[] pros = Process.GetProcessesByName(hookName);
            foreach(Process pro in pros)
            {
                SetWindowText(pro.MainWindowHandle, SpoofedTitle);
            }
        }
        
        private void HideProcess_Click(object sender, EventArgs e)
        {
            Process[] pros = Process.GetProcessesByName(ProcessHook.Text);
            foreach (Process pro in pros)
            {
                Process[] pros1 = Process.GetProcessesByName(ProcessClient.Text);
                foreach (Process pro1 in pros1)
                {
                    GHook.SpoofHideProcess(pro.MainWindowHandle, pro1.MainWindowHandle);
                }
            }
        }

        private void Hook_Click(object sender, EventArgs e)
        {
            Process[] pros = Process.GetProcessesByName(ProcessHook.Text);
            foreach (Process pro in pros)
            {
                Process[] pros1 = Process.GetProcessesByName(ProcessClient.Text);
                foreach (Process pro1 in pros1)
                {
                    GHook.HookProcess(pro.MainWindowHandle, pro1.MainWindowHandle);
                }
            }
        }

        private void BtnParentBrowse_Click(object sender, EventArgs e)
        {
            ProcessList processlist = new ProcessList();
            processlist.ShowDialog();
            try { ProcessHook.Text = processlist.SelectedProcess.ProcessName; } catch { }
        }

        private void BtnChildBrowse_Click(object sender, EventArgs e)
        {
            ProcessList processlist = new ProcessList();
            processlist.ShowDialog();
            try { ProcessClient.Text = processlist.SelectedProcess.ProcessName; } catch { }
        }
    }
}