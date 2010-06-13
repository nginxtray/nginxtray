using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NginxTray
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();

            textBoxNginxDirectory.Text = Properties.Settings.Default.NginxDirectory;

            textBoxNginxProcess.Text = Properties.Settings.Default.NginxProcess;

            checkBoxPHPEnable.Checked = Properties.Settings.Default.PHPEnable;

            panelSettingsPHP.Enabled = checkBoxPHPEnable.Checked;

            textBoxPHPDirectory.Text = Properties.Settings.Default.PHPDirectory;

            textBoxPHPProcess.Text = Properties.Settings.Default.PHPProcess;

            textBoxPHPPort.Text = Properties.Settings.Default.PHPAddress;
        }

        //Save Settings textbox in settings variables
        private void NginxSettingsSaveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.NginxDirectory = textBoxNginxDirectory.Text;

            Properties.Settings.Default.NginxProcess = textBoxNginxProcess.Text;

            Properties.Settings.Default.Save();

        }

        // Close Settings Windows
        private void SettingsCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Enable and disable the PHP Settings panel
        private void checkBoxPHPEnable_CheckedChanged(object sender, EventArgs e)
        {
            panelSettingsPHP.Enabled = checkBoxPHPEnable.Checked;
        }

        // Save Settings textbox in settings variables
        private void PHPSettingsSaveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PHPEnable = checkBoxPHPEnable.Checked;

            Properties.Settings.Default.PHPDirectory = textBoxPHPDirectory.Text;

            Properties.Settings.Default.PHPProcess = textBoxPHPProcess.Text;

            Properties.Settings.Default.PHPAddress = textBoxPHPPort.Text;

            Properties.Settings.Default.Save();
        }

    }
}
