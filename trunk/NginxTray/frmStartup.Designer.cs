namespace NginxTray
{
    partial class frmStartup
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStartup));
            this.TryIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ManageMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.StartNginxMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StopNginxMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SettingsNginxMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenuSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutNginxMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitNginxMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TryIcon
            // 
            this.TryIcon.ContextMenuStrip = this.ManageMenuStrip;
            this.TryIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TryIcon.Icon")));
            this.TryIcon.Text = "NginxTray";
            this.TryIcon.Visible = true;
            this.TryIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TryIcon_MouseClick);
            // 
            // ManageMenuStrip
            // 
            this.ManageMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartNginxMenuItem,
            this.StopNginxMenuItem,
            this.SettingsMenuSeparator1,
            this.SettingsNginxMenuItem,
            this.SettingsMenuSeparator2,
            this.AboutNginxMenuItem,
            this.ExitNginxMenuItem});
            this.ManageMenuStrip.Name = "ManageStrip";
            this.ManageMenuStrip.Size = new System.Drawing.Size(159, 126);
            // 
            // StartNginxMenuItem
            // 
            this.StartNginxMenuItem.Name = "StartNginxMenuItem";
            this.StartNginxMenuItem.Size = new System.Drawing.Size(158, 22);
            this.StartNginxMenuItem.Text = "Start Nginx";
            this.StartNginxMenuItem.Click += new System.EventHandler(this.StartNginxMenuItem_Click);
            // 
            // StopNginxMenuItem
            // 
            this.StopNginxMenuItem.Name = "StopNginxMenuItem";
            this.StopNginxMenuItem.Size = new System.Drawing.Size(158, 22);
            this.StopNginxMenuItem.Text = "Stop Nginx";
            this.StopNginxMenuItem.Click += new System.EventHandler(this.StopNginxMenuItem_Click);
            // 
            // SettingsMenuSeparator1
            // 
            this.SettingsMenuSeparator1.Name = "SettingsMenuSeparator1";
            this.SettingsMenuSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // SettingsNginxMenuItem
            // 
            this.SettingsNginxMenuItem.Name = "SettingsNginxMenuItem";
            this.SettingsNginxMenuItem.Size = new System.Drawing.Size(158, 22);
            this.SettingsNginxMenuItem.Text = "Settings";
            this.SettingsNginxMenuItem.Click += new System.EventHandler(this.SettingsNginxMenuItem_Click);
            // 
            // SettingsMenuSeparator2
            // 
            this.SettingsMenuSeparator2.Name = "SettingsMenuSeparator2";
            this.SettingsMenuSeparator2.Size = new System.Drawing.Size(155, 6);
            // 
            // AboutNginxMenuItem
            // 
            this.AboutNginxMenuItem.Name = "AboutNginxMenuItem";
            this.AboutNginxMenuItem.Size = new System.Drawing.Size(158, 22);
            this.AboutNginxMenuItem.Text = "About NginxTray";
            this.AboutNginxMenuItem.Click += new System.EventHandler(this.AboutNginxMenuItem_Click);
            // 
            // ExitNginxMenuItem
            // 
            this.ExitNginxMenuItem.Name = "ExitNginxMenuItem";
            this.ExitNginxMenuItem.Size = new System.Drawing.Size(158, 22);
            this.ExitNginxMenuItem.Text = "Exit";
            this.ExitNginxMenuItem.Click += new System.EventHandler(this.ExitNginxMenuItem_Click);
            // 
            // frmStartup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "frmStartup";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.Text = "NginxTray";
            this.ManageMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon TryIcon;
        private System.Windows.Forms.ContextMenuStrip ManageMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem StartNginxMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StopNginxMenuItem;
        private System.Windows.Forms.ToolStripSeparator SettingsMenuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SettingsNginxMenuItem;
        private System.Windows.Forms.ToolStripSeparator SettingsMenuSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ExitNginxMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutNginxMenuItem;
    }
}

