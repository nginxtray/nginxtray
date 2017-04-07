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

namespace NginxTray
{
    partial class AboutBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            this.buttonOk = new System.Windows.Forms.Button();
            this.linkLabelSite = new System.Windows.Forms.LinkLabel();
            this.LicenseBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.checkupdateButton = new System.Windows.Forms.Button();
            this.CheckUpdateprogressBar = new System.Windows.Forms.ProgressBar();
            this.CheckUpdateLabel = new System.Windows.Forms.Label();
            this.CheckUpdateWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(381, 279);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(72, 27);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // linkLabelSite
            // 
            this.linkLabelSite.AutoSize = true;
            this.linkLabelSite.Location = new System.Drawing.Point(218, 75);
            this.linkLabelSite.Name = "linkLabelSite";
            this.linkLabelSite.Size = new System.Drawing.Size(154, 13);
            this.linkLabelSite.TabIndex = 1;
            this.linkLabelSite.TabStop = true;
            this.linkLabelSite.Text = "https://nginxtray.github.io/nginxtray/";
            this.linkLabelSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSite_LinkClicked);
            // 
            // LicenseBox
            // 
            this.LicenseBox.Location = new System.Drawing.Point(140, 128);
            this.LicenseBox.Multiline = true;
            this.LicenseBox.Name = "LicenseBox";
            this.LicenseBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LicenseBox.Size = new System.Drawing.Size(312, 145);
            this.LicenseBox.TabIndex = 2;
            this.LicenseBox.Text = resources.GetString("LicenseBox.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Versione:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NginxTray";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Emiliano del Gobbo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "GNU General Public License v2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Site Project:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Prodotto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Versione: 1.0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(137, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Autore:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(137, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Licenza:";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(131, 311);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 13;
            this.logoPictureBox.TabStop = false;
            // 
            // checkupdateButton
            // 
            this.checkupdateButton.Location = new System.Drawing.Point(140, 279);
            this.checkupdateButton.Name = "checkupdateButton";
            this.checkupdateButton.Size = new System.Drawing.Size(88, 27);
            this.checkupdateButton.TabIndex = 14;
            this.checkupdateButton.Text = "Check Update";
            this.checkupdateButton.UseVisualStyleBackColor = true;
            this.checkupdateButton.Click += new System.EventHandler(this.checkupdateButton_Click);
            // 
            // CheckUpdateprogressBar
            // 
            this.CheckUpdateprogressBar.Location = new System.Drawing.Point(140, 279);
            this.CheckUpdateprogressBar.MarqueeAnimationSpeed = 0;
            this.CheckUpdateprogressBar.Name = "CheckUpdateprogressBar";
            this.CheckUpdateprogressBar.Size = new System.Drawing.Size(28, 27);
            this.CheckUpdateprogressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.CheckUpdateprogressBar.TabIndex = 15;
            this.CheckUpdateprogressBar.Visible = false;
            // 
            // CheckUpdateLabel
            // 
            this.CheckUpdateLabel.AutoSize = true;
            this.CheckUpdateLabel.Location = new System.Drawing.Point(174, 286);
            this.CheckUpdateLabel.Name = "CheckUpdateLabel";
            this.CheckUpdateLabel.Size = new System.Drawing.Size(102, 13);
            this.CheckUpdateLabel.TabIndex = 16;
            this.CheckUpdateLabel.Text = "Click Check Update";
            this.CheckUpdateLabel.Visible = false;
            // 
            // CheckUpdateWorker
            // 
            this.CheckUpdateWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CheckUpdateWorker_DoWork);
            this.CheckUpdateWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.CheckUpdateWorker_RunWorkerCompleted);
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 311);
            this.Controls.Add(this.CheckUpdateLabel);
            this.Controls.Add(this.CheckUpdateprogressBar);
            this.Controls.Add(this.checkupdateButton);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LicenseBox);
            this.Controls.Add(this.linkLabelSite);
            this.Controls.Add(this.buttonOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutBox";
            this.Text = "About NginxTray";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.LinkLabel linkLabelSite;
        private System.Windows.Forms.TextBox LicenseBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button checkupdateButton;
        private System.Windows.Forms.ProgressBar CheckUpdateprogressBar;
        private System.Windows.Forms.Label CheckUpdateLabel;
        private System.ComponentModel.BackgroundWorker CheckUpdateWorker;
    }
}