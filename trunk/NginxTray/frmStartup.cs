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

            if (Properties.Settings.Default.PHPEnable == true)
            {
                this.StartPHP(); // Call function to start PHP
            }
        }

        // Stop Nginx
        private void StopNginxMenuItem_Click(object sender, EventArgs e)
        {
            ProcessManagement ProcM = new ProcessManagement();

            string nginxprocess;

            nginxprocess = Properties.Settings.Default.NginxProcess.Replace(".exe", "");

            ProcM.StopProcess(nginxprocess);

            this.StopPHP(); // Call function to stop PHP
        }

        // Start PHP
        private void StartPHP()
        {
            ProcessManagement ProcM = new ProcessManagement();

            string phpdirectory;

            phpdirectory = Properties.Settings.Default.PHPDirectory; // Take Nginx Directory from settings

            string phpprocess;

            phpprocess = Properties.Settings.Default.PHPProcess; // Take Nginx Directory from settings

            string phparguments;

            phparguments = "-b " + Properties.Settings.Default.PHPAddress;

            ProcM.StartProcess(phpdirectory, phpprocess, phparguments);
        }

        // Stop PHP
        private void StopPHP()
        {
            ProcessManagement ProcM = new ProcessManagement();

            string phpprocess;

            phpprocess = Properties.Settings.Default.PHPProcess.Replace(".exe", "");

            ProcM.StopProcess(phpprocess);
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

        // Exit NginxTray
        private void ExitNginxMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Enable contextstripmenu with left click
        private void TryIcon_MouseClick(object sender, MouseEventArgs e)
        {
            System.Reflection.MethodInfo mi = typeof(NotifyIcon).GetMethod("ShowContextMenu", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            mi.Invoke(TryIcon, null);
        }

    }

}
