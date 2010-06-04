namespace NginxTray
{
    partial class frmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nginxSettingsTab = new System.Windows.Forms.TabPage();
            this.SettingsTabs = new System.Windows.Forms.TabControl();
            this.textBoxNginxDirectory = new System.Windows.Forms.TextBox();
            this.textBoxNginxProcess = new System.Windows.Forms.TextBox();
            this.NginxDirectoryLabel = new System.Windows.Forms.Label();
            this.NginxProcessLabel = new System.Windows.Forms.Label();
            this.NginxSettingsSaveButton = new System.Windows.Forms.Button();
            this.ExampleLabel1 = new System.Windows.Forms.Label();
            this.ExampleLabel2 = new System.Windows.Forms.Label();
            this.NginxSettingsCloseButton = new System.Windows.Forms.Button();
            this.nginxSettingsTab.SuspendLayout();
            this.SettingsTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // nginxSettingsTab
            // 
            this.nginxSettingsTab.Controls.Add(this.NginxSettingsCloseButton);
            this.nginxSettingsTab.Controls.Add(this.ExampleLabel2);
            this.nginxSettingsTab.Controls.Add(this.ExampleLabel1);
            this.nginxSettingsTab.Controls.Add(this.NginxSettingsSaveButton);
            this.nginxSettingsTab.Controls.Add(this.NginxProcessLabel);
            this.nginxSettingsTab.Controls.Add(this.NginxDirectoryLabel);
            this.nginxSettingsTab.Controls.Add(this.textBoxNginxProcess);
            this.nginxSettingsTab.Controls.Add(this.textBoxNginxDirectory);
            this.nginxSettingsTab.Location = new System.Drawing.Point(4, 22);
            this.nginxSettingsTab.Name = "nginxSettingsTab";
            this.nginxSettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.nginxSettingsTab.Size = new System.Drawing.Size(401, 342);
            this.nginxSettingsTab.TabIndex = 0;
            this.nginxSettingsTab.Text = "Nginx";
            this.nginxSettingsTab.UseVisualStyleBackColor = true;
            // 
            // SettingsTabs
            // 
            this.SettingsTabs.Controls.Add(this.nginxSettingsTab);
            this.SettingsTabs.Location = new System.Drawing.Point(9, 13);
            this.SettingsTabs.Name = "SettingsTabs";
            this.SettingsTabs.SelectedIndex = 0;
            this.SettingsTabs.Size = new System.Drawing.Size(409, 368);
            this.SettingsTabs.TabIndex = 0;
            // 
            // textBoxNginxDirectory
            // 
            this.textBoxNginxDirectory.Location = new System.Drawing.Point(95, 65);
            this.textBoxNginxDirectory.Name = "textBoxNginxDirectory";
            this.textBoxNginxDirectory.Size = new System.Drawing.Size(278, 20);
            this.textBoxNginxDirectory.TabIndex = 0;
            // 
            // textBoxNginxProcess
            // 
            this.textBoxNginxProcess.Location = new System.Drawing.Point(95, 131);
            this.textBoxNginxProcess.Name = "textBoxNginxProcess";
            this.textBoxNginxProcess.Size = new System.Drawing.Size(278, 20);
            this.textBoxNginxProcess.TabIndex = 1;
            // 
            // NginxDirectoryLabel
            // 
            this.NginxDirectoryLabel.AutoSize = true;
            this.NginxDirectoryLabel.Location = new System.Drawing.Point(10, 68);
            this.NginxDirectoryLabel.Name = "NginxDirectoryLabel";
            this.NginxDirectoryLabel.Size = new System.Drawing.Size(79, 13);
            this.NginxDirectoryLabel.TabIndex = 2;
            this.NginxDirectoryLabel.Text = "Nginx Directory";
            // 
            // NginxProcessLabel
            // 
            this.NginxProcessLabel.AutoSize = true;
            this.NginxProcessLabel.Location = new System.Drawing.Point(14, 131);
            this.NginxProcessLabel.Name = "NginxProcessLabel";
            this.NginxProcessLabel.Size = new System.Drawing.Size(75, 13);
            this.NginxProcessLabel.TabIndex = 3;
            this.NginxProcessLabel.Text = "Nginx Process";
            // 
            // NginxSettingsSaveButton
            // 
            this.NginxSettingsSaveButton.Location = new System.Drawing.Point(161, 307);
            this.NginxSettingsSaveButton.Name = "NginxSettingsSaveButton";
            this.NginxSettingsSaveButton.Size = new System.Drawing.Size(111, 29);
            this.NginxSettingsSaveButton.TabIndex = 4;
            this.NginxSettingsSaveButton.Text = "Save";
            this.NginxSettingsSaveButton.UseVisualStyleBackColor = true;
            this.NginxSettingsSaveButton.Click += new System.EventHandler(this.NginxSettingsSaveButton_Click);
            // 
            // ExampleLabel1
            // 
            this.ExampleLabel1.AutoSize = true;
            this.ExampleLabel1.Location = new System.Drawing.Point(92, 88);
            this.ExampleLabel1.Name = "ExampleLabel1";
            this.ExampleLabel1.Size = new System.Drawing.Size(93, 13);
            this.ExampleLabel1.TabIndex = 5;
            this.ExampleLabel1.Text = "Example: C:\\nginx";
            // 
            // ExampleLabel2
            // 
            this.ExampleLabel2.AutoSize = true;
            this.ExampleLabel2.Location = new System.Drawing.Point(92, 154);
            this.ExampleLabel2.Name = "ExampleLabel2";
            this.ExampleLabel2.Size = new System.Drawing.Size(98, 13);
            this.ExampleLabel2.TabIndex = 6;
            this.ExampleLabel2.Text = "Example: nginx.exe";
            // 
            // NginxSettingsCloseButton
            // 
            this.NginxSettingsCloseButton.Location = new System.Drawing.Point(284, 307);
            this.NginxSettingsCloseButton.Name = "NginxSettingsCloseButton";
            this.NginxSettingsCloseButton.Size = new System.Drawing.Size(111, 29);
            this.NginxSettingsCloseButton.TabIndex = 7;
            this.NginxSettingsCloseButton.Text = "Close";
            this.NginxSettingsCloseButton.UseVisualStyleBackColor = true;
            this.NginxSettingsCloseButton.Click += new System.EventHandler(this.NginxSettingsCloseButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 393);
            this.Controls.Add(this.SettingsTabs);
            this.Name = "Settings";
            this.Text = "Settings";
            this.nginxSettingsTab.ResumeLayout(false);
            this.nginxSettingsTab.PerformLayout();
            this.SettingsTabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage nginxSettingsTab;
        private System.Windows.Forms.TabControl SettingsTabs;
        private System.Windows.Forms.Button NginxSettingsSaveButton;
        private System.Windows.Forms.Label NginxProcessLabel;
        private System.Windows.Forms.Label NginxDirectoryLabel;
        private System.Windows.Forms.TextBox textBoxNginxProcess;
        private System.Windows.Forms.TextBox textBoxNginxDirectory;
        private System.Windows.Forms.Label ExampleLabel2;
        private System.Windows.Forms.Label ExampleLabel1;
        private System.Windows.Forms.Button NginxSettingsCloseButton;

    }
}