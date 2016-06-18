﻿using System.Drawing;
using System.Windows.Forms;
using KryBot.CommonResources.lang;
using KryBot.Core;
using KryBot.Gui.WinFormsGui.Properties;

namespace KryBot.Gui.WinFormsGui.Forms
{
	partial class FormAbout
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
			this.labelVersion = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.linkLabelGitHub = new System.Windows.Forms.LinkLabel();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelVersion
			// 
			this.labelVersion.AutoSize = true;
			this.labelVersion.Location = new System.Drawing.Point(12, 9);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new System.Drawing.Size(74, 13);
			this.labelVersion.TabIndex = 0;
			this.labelVersion.Text = $"KryBot - {Application.ProductVersion}";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.linkLabelGitHub);
			this.groupBox1.Controls.Add(this.linkLabel2);
			this.groupBox1.Controls.Add(this.linkLabel1);
			this.groupBox1.Location = new System.Drawing.Point(12, 25);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(260, 67);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = strings.AboutForm_groupBox1;
			// 
			// linkLabelGitHub
			// 
			this.linkLabelGitHub.AutoSize = true;
			this.linkLabelGitHub.Location = new System.Drawing.Point(6, 42);
			this.linkLabelGitHub.Name = "linkLabelGitHub";
			this.linkLabelGitHub.Size = new System.Drawing.Size(40, 13);
			this.linkLabelGitHub.TabIndex = 2;
			this.linkLabelGitHub.TabStop = true;
			this.linkLabelGitHub.Text = Links.GitHubRepo;
			this.linkLabelGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
			// 
			// linkLabel2
			// 
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.Location = new System.Drawing.Point(6, 29);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(215, 13);
			this.linkLabel2.TabIndex = 1;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = Links.SteamGroup;
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(6, 16);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(112, 13);
			this.linkLabel1.TabIndex = 0;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = Links.VkGroup;
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// FormAbout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 103);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.labelVersion);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormAbout";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = strings.AboutProgram;
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
			this.Icon = Icon.FromHandle(Resources.info.GetHicon());

		}

		#endregion

		private System.Windows.Forms.Label labelVersion;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.LinkLabel linkLabelGitHub;
		private System.Windows.Forms.LinkLabel linkLabel2;
	}
}