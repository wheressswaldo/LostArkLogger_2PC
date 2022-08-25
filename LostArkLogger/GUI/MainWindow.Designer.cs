﻿namespace LostArkLogger
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.loggedPacketCountLabel = new System.Windows.Forms.Label();
            this.weblink = new System.Windows.Forms.LinkLabel();
            this.debugLog = new System.Windows.Forms.CheckBox();
            this.versionLabel = new System.Windows.Forms.Label();
            this.regionSelector = new System.Windows.Forms.ComboBox();
            this.displayName = new System.Windows.Forms.CheckBox();
            this.nicListBox = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.addBgColor = new System.Windows.Forms.CheckBox();
            this.lblSetBGColor = new System.Windows.Forms.Label();
            this.cbox_lockNic = new System.Windows.Forms.CheckBox();
            this.cboxEnableLogger = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // loggedPacketCountLabel
            // 
            this.loggedPacketCountLabel.Location = new System.Drawing.Point(10, 9);
            this.loggedPacketCountLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.loggedPacketCountLabel.Name = "loggedPacketCountLabel";
            this.loggedPacketCountLabel.Size = new System.Drawing.Size(178, 12);
            this.loggedPacketCountLabel.TabIndex = 2;
            this.loggedPacketCountLabel.Text = "Packets: 0";
            // 
            // weblink
            // 
            this.weblink.Location = new System.Drawing.Point(144, 9);
            this.weblink.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.weblink.Name = "weblink";
            this.weblink.Size = new System.Drawing.Size(127, 12);
            this.weblink.TabIndex = 4;
            this.weblink.TabStop = true;
            this.weblink.Text = "by shalzuth";
            this.weblink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.weblink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.weblink_LinkClicked);
            // 
            // debugLog
            // 
            this.debugLog.AutoSize = true;
            this.debugLog.Location = new System.Drawing.Point(12, 24);
            this.debugLog.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.debugLog.Name = "debugLog";
            this.debugLog.Size = new System.Drawing.Size(60, 16);
            this.debugLog.TabIndex = 9;
            this.debugLog.Text = "Debug";
            this.debugLog.UseVisualStyleBackColor = true;
            this.debugLog.CheckedChanged += new System.EventHandler(this.debugLog_CheckedChanged);
            // 
            // versionLabel
            // 
            this.versionLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.versionLabel.Enabled = false;
            this.versionLabel.Location = new System.Drawing.Point(11, 69);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(92, 22);
            this.versionLabel.TabIndex = 10;
            this.versionLabel.Text = "2022.08.25";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.versionLabel.Click += new System.EventHandler(this.versionLabel_Click);
            // 
            // regionSelector
            // 
            this.regionSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regionSelector.FormattingEnabled = true;
            this.regionSelector.Location = new System.Drawing.Point(190, 46);
            this.regionSelector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.regionSelector.Name = "regionSelector";
            this.regionSelector.Size = new System.Drawing.Size(81, 20);
            this.regionSelector.TabIndex = 12;
            this.regionSelector.SelectedIndexChanged += new System.EventHandler(this.regionSelector_SelectedIndexChanged);
            // 
            // displayName
            // 
            this.displayName.AutoSize = true;
            this.displayName.Checked = true;
            this.displayName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.displayName.Location = new System.Drawing.Point(206, 24);
            this.displayName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.displayName.Name = "displayName";
            this.displayName.Size = new System.Drawing.Size(65, 16);
            this.displayName.TabIndex = 14;
            this.displayName.Text = "Names";
            this.displayName.UseVisualStyleBackColor = true;
            // 
            // nicListBox
            // 
            this.nicListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nicListBox.FormattingEnabled = true;
            this.nicListBox.Location = new System.Drawing.Point(13, 46);
            this.nicListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nicListBox.Name = "nicListBox";
            this.nicListBox.Size = new System.Drawing.Size(175, 20);
            this.nicListBox.TabIndex = 15;
            this.nicListBox.SelectedIndexChanged += new System.EventHandler(this.nicListBox_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // addBgColor
            // 
            this.addBgColor.Checked = true;
            this.addBgColor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.addBgColor.Enabled = false;
            this.addBgColor.Location = new System.Drawing.Point(180, 73);
            this.addBgColor.Name = "addBgColor";
            this.addBgColor.Size = new System.Drawing.Size(65, 16);
            this.addBgColor.TabIndex = 17;
            this.addBgColor.Text = "addBG";
            this.addBgColor.UseVisualStyleBackColor = true;
            this.addBgColor.CheckedChanged += new System.EventHandler(this.addBgColor_CheckedChanged);
            // 
            // lblSetBGColor
            // 
            this.lblSetBGColor.AutoSize = true;
            this.lblSetBGColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSetBGColor.Enabled = false;
            this.lblSetBGColor.Location = new System.Drawing.Point(236, 74);
            this.lblSetBGColor.Name = "lblSetBGColor";
            this.lblSetBGColor.Size = new System.Drawing.Size(35, 12);
            this.lblSetBGColor.TabIndex = 18;
            this.lblSetBGColor.Text = "Color";
            this.lblSetBGColor.Click += new System.EventHandler(this.lblSetBGColor_Click);
            // 
            // cbox_lockNic
            // 
            this.cbox_lockNic.Enabled = false;
            this.cbox_lockNic.Location = new System.Drawing.Point(12, 48);
            this.cbox_lockNic.Name = "cbox_lockNic";
            this.cbox_lockNic.Size = new System.Drawing.Size(259, 16);
            this.cbox_lockNic.TabIndex = 19;
            this.cbox_lockNic.Text = "Lock NIC/Region";
            this.cbox_lockNic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbox_lockNic.UseVisualStyleBackColor = true;
            this.cbox_lockNic.Visible = false;
            this.cbox_lockNic.CheckedChanged += new System.EventHandler(this.cbox_lockNic_CheckedChanged);
            // 
            // cboxEnableLogger
            // 
            this.cboxEnableLogger.AutoSize = true;
            this.cboxEnableLogger.Enabled = false;
            this.cboxEnableLogger.Location = new System.Drawing.Point(80, 24);
            this.cboxEnableLogger.Name = "cboxEnableLogger";
            this.cboxEnableLogger.Size = new System.Drawing.Size(63, 16);
            this.cboxEnableLogger.TabIndex = 20;
            this.cboxEnableLogger.Text = "Logger";
            this.cboxEnableLogger.UseVisualStyleBackColor = true;
            this.cboxEnableLogger.CheckedChanged += new System.EventHandler(this.cboxEnableLogger_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 98);
            this.Controls.Add(this.cboxEnableLogger);
            this.Controls.Add(this.cbox_lockNic);
            this.Controls.Add(this.lblSetBGColor);
            this.Controls.Add(this.addBgColor);
            this.Controls.Add(this.nicListBox);
            this.Controls.Add(this.displayName);
            this.Controls.Add(this.regionSelector);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.debugLog);
            this.Controls.Add(this.weblink);
            this.Controls.Add(this.loggedPacketCountLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "2PC";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label loggedPacketCountLabel;
        private System.Windows.Forms.LinkLabel weblink;
        private System.Windows.Forms.CheckBox debugLog;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.ComboBox regionSelector;
        private System.Windows.Forms.CheckBox displayName;
        private System.Windows.Forms.ComboBox nicListBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox addBgColor;
        private System.Windows.Forms.Label lblSetBGColor;
        private System.Windows.Forms.CheckBox cbox_lockNic;
        private System.Windows.Forms.CheckBox cboxEnableLogger;
    }
}
