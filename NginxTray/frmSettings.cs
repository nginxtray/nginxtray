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
