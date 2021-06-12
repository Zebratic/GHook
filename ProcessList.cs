using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;

namespace GHook
{
    public partial class ProcessList : Form
    {
        public Process SelectedProcess { get; set; }
        public ProcessList()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        List<Process> RunningProcesses = new List<Process>();
        private void ProcessList_Load(object sender, EventArgs e)
        {
            Processes.Items.Clear();
            RunningProcesses.Clear();
            Process[] AllProcesses = Process.GetProcesses();
            RunningProcesses.AddRange(AllProcesses);
            RunningProcesses = RunningProcesses.OrderBy(x => x.ProcessName).ToList();
            foreach (Process proName in RunningProcesses)
                Processes.Items.Add(proName.ProcessName);
        }
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (Processes.SelectedItem != null)
            {
                SelectedProcess = RunningProcesses[Processes.SelectedIndex];
                this.Close();
            }
        }

        private void Processes_DoubleClick(object sender, EventArgs e)
        {
            if (Processes.SelectedItem != null)
            {
                SelectedProcess = RunningProcesses[Processes.SelectedIndex];
                this.Close();
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ProcessList_Load(null, null);
        }
    }
}