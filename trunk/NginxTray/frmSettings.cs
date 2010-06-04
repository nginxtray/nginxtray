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
        }

        //Save Settings textbox in settings variables
        private void NginxSettingsSaveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.NginxDirectory = textBoxNginxDirectory.Text;

            Properties.Settings.Default.NginxProcess = textBoxNginxProcess.Text;

            Properties.Settings.Default.Save();
        }

        private void NginxSettingsCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
