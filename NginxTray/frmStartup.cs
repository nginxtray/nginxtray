/*
 * NginxTray - A tray icon to manage Nginx and other components.
 * 
 * This file is part of NginxTray <https://github.com/nginxtray/nginxtray>.
 * 
 * Copyright (C) 2010-2017 by Emiliano del Gobbo
 * <https://emilianodelgobbo.com> and other contributors.
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License version 2 as 
 * published by the Free Software Foundation.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License version 2 for more details.
 * 
 * You should have received a copy of the GNU General Public License 
 * version 2 along with this program.  If not, see
 * <http://www.gnu.org/licenses/>.
*/

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

        // Start Nginx function
        private void StartNginx()
        {
            ProcessManagement ProcM = new ProcessManagement();

            string nginxdirectory;

            nginxdirectory = Properties.Settings.Default.NginxDirectory; // Take Nginx Directory from settings

            string nginxprocess;

            nginxprocess = Properties.Settings.Default.NginxProcess; // Take Nginx Directory from settings

            if (ProcM.StartProcess(nginxdirectory, nginxprocess) == false) // If there are problems, show a ballontip error
            {
                TrayIcon.ShowBalloonTip(20000, "Nginx does not start", "The file path or process name could be wrong", ToolTipIcon.Error);
            };
        }

        // Stop Nginx function
        private void StopNginx()
        {
            ProcessManagement ProcM = new ProcessManagement();

            string nginxprocess;

            nginxprocess = Properties.Settings.Default.NginxProcess.Replace(".exe", "");

            ProcM.StopProcess(nginxprocess);
        }

        // Start PHP function
        private void StartPHP()
        {
            ProcessManagement ProcM = new ProcessManagement();

            string phpdirectory;

            phpdirectory = Properties.Settings.Default.PHPDirectory; // Take Nginx Directory from settings

            string phpprocess;

            phpprocess = Properties.Settings.Default.PHPProcess; // Take Nginx Directory from settings

            string phparguments;

            phparguments = "-b " + Properties.Settings.Default.PHPAddress;

            if (ProcM.StartProcess(phpdirectory, phpprocess, phparguments) == false) // If there are problems, show a ballontip error
            {
                TrayIcon.ShowBalloonTip(20000, "PHP does not start", "The file path, process name or address could be wrong", ToolTipIcon.Error);
            };
        }

        // Stop PHP function
        private void StopPHP()
        {
            ProcessManagement ProcM = new ProcessManagement();

            string phpprocess;

            phpprocess = Properties.Settings.Default.PHPProcess.Replace(".exe", "");

            ProcM.StopProcess(phpprocess);
        }

        // Start Nginx Group
        private void StartNginxMenuItem_Click(object sender, EventArgs e)
        {
            this.StartNginx(); // Call function to start Nginx

            if (Properties.Settings.Default.PHPEnable == true)
            {
                this.StartPHP(); // Call function to start PHP
            }
        }

        // Stop Nginx Group
        private void StopNginxMenuItem_Click(object sender, EventArgs e)
        {
            this.StopNginx(); // Call function to stop Nginx

            this.StopPHP(); // Call function to stop PHP
        }

        // Restart Nginx Group
        private void RestartNginxMenuItem_Click(object sender, EventArgs e)
        {
            this.StopNginx(); // Call function to stop Nginx

            this.StopPHP(); // Call function to stop PHP

            this.StartNginx(); // Call function to start Nginx

            if (Properties.Settings.Default.PHPEnable == true)
            {
                this.StartPHP(); // Call function to start PHP
            }
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
            mi.Invoke(TrayIcon, null);
        }

    }

}
