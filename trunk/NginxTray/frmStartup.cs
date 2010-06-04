using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace NginxTray
{
    public partial class frmStartup : Form
    {
        public frmStartup()
        {
            InitializeComponent();

            base.SetVisibleCore(false); // Hide this form at startup
        }

        // Start Nginx
        private void StartNginxMenuItem_Click(object sender, EventArgs e)
        {
            ProcessManagement ProcM = new ProcessManagement();

            string nginxdirectory;

            nginxdirectory = Properties.Settings.Default.NginxDirectory; // Take Nginx Directory from settings

            string nginxprocess;

            nginxprocess = Properties.Settings.Default.NginxProcess; // Take Nginx Directory from settings

            ProcM.StartProcess(nginxdirectory, nginxprocess);
        }

        // Stop Nginx
        private void StopNginxMenuItem_Click(object sender, EventArgs e)
        {
            ProcessManagement ProcM = new ProcessManagement();

            string nginxprocess;

            nginxprocess = Properties.Settings.Default.NginxProcess.Replace(".exe", "");

            ProcM.StopProcess("nginx");
        }

        // Show Settings Form
        private void SettingsNginxMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings form = new frmSettings();
            form.Show();
        }

        // Show AboutBox form
        private void AboutNginxMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox form = new AboutBox();
            form.Show();
        }

        private void ExitNginxMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TryIcon_MouseClick(object sender, MouseEventArgs e)
        {
            System.Reflection.MethodInfo mi = typeof(NotifyIcon).GetMethod("ShowContextMenu", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            mi.Invoke(TryIcon, null);
        }

    }

}
