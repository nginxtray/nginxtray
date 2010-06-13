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
            System.Diagnostics.Process.Start("http://nginxtray.codeplex.com/"); 
        }

        // Check update button
        private void checkupdateButton_Click(object sender, EventArgs e)
        {
            checkupdateButton.Visible = false;

            CheckUpdateprogressBar.MarqueeAnimationSpeed = 30;

            CheckUpdateprogressBar.Visible = true;

            CheckUpdateLabel.Text = "Checking new software version...";

            CheckUpdateLabel.Visible = true;

            CheckUpdateWorker.RunWorkerAsync();

            
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
