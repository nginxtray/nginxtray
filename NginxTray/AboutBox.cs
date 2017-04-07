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
using System.Threading;

namespace NginxTray
{
    public partial class AboutBox : Form
    {
        public bool NeedUpdate = false;

        public bool UpdateCheckError = false;

        public AboutBox()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Link to site project
        private void linkLabelSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://nginxtray.github.io/nginxtray/"); 
        }

        // Check update button
        private void checkupdateButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/nginxtray/nginxtray/releases");

            /*checkupdateButton.Visible = false;

            CheckUpdateprogressBar.MarqueeAnimationSpeed = 30;

            CheckUpdateprogressBar.Visible = true;

            CheckUpdateLabel.Text = "Checking new software version...";

            CheckUpdateLabel.Visible = true;

            CheckUpdateWorker.RunWorkerAsync();*/


        }

        // Work to check new update
        private void CheckUpdateWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            UpdateManagementClass CheckUpdateWorker = new UpdateManagementClass();

            if (CheckUpdateWorker.CheckFailed == true)
            {
                UpdateCheckError = true;
            }
            else
            {
                CheckUpdateWorker.CheckUpdate();

                NeedUpdate = CheckUpdateWorker.NeedUpdate;
            }
        }

        // Show results of work to check new update
        private void CheckUpdateWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (UpdateCheckError == true)
            {
                CheckUpdateLabel.Text = "Unable to check new version";
            }
            else
            {

                if (NeedUpdate == true)
                {
                    CheckUpdateLabel.Text = "A New Version is Available";
                }
                else
                {

                    CheckUpdateLabel.Text = "No update available";
                }
            }
            CheckUpdateprogressBar.Style = ProgressBarStyle.Continuous;
            CheckUpdateprogressBar.Value = 100;
            CheckUpdateprogressBar.Enabled = false;

        }
    }
}
