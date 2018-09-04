namespace FullFeaturedMdiDemo
{
	partial class AboutForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.lblQueryBuilderVersion = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.bClose = new System.Windows.Forms.Button();
			this.linkHome = new System.Windows.Forms.LinkLabel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.label4 = new System.Windows.Forms.Label();
			this.lblDemoVersion = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(143, 19);
			this.label1.TabIndex = 3;
			this.label1.Text = "Demo Application";
			// 
			// lblQueryBuilderVersion
			// 
			this.lblQueryBuilderVersion.Location = new System.Drawing.Point(164, 9);
			this.lblQueryBuilderVersion.Name = "lblQueryBuilderVersion";
			this.lblQueryBuilderVersion.Size = new System.Drawing.Size(217, 13);
			this.lblQueryBuilderVersion.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(336, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Copyright � 2008-2015 Active Database Software. All rights reserved.";
			// 
			// bClose
			// 
			this.bClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.bClose.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.bClose.Location = new System.Drawing.Point(306, 119);
			this.bClose.Name = "bClose";
			this.bClose.Size = new System.Drawing.Size(75, 23);
			this.bClose.TabIndex = 2;
			this.bClose.Text = "Close";
			this.bClose.UseVisualStyleBackColor = true;
			// 
			// linkHome
			// 
			this.linkHome.AutoSize = true;
			this.linkHome.Location = new System.Drawing.Point(13, 82);
			this.linkHome.Name = "linkHome";
			this.linkHome.Size = new System.Drawing.Size(143, 13);
			this.linkHome.TabIndex = 0;
			this.linkHome.TabStop = true;
			this.linkHome.Text = "www.activequerybuilder.com";
			this.linkHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHome_LinkClicked);
			// 
			// linkLabel1
			// 
			this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkLabel1.Location = new System.Drawing.Point(13, 124);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(190, 13);
			this.linkLabel1.TabIndex = 1;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Icons by Mark James (famfamfam.com)";
			this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(143, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Active Query Builder .NET";
			// 
			// lblDemoVersion
			// 
			this.lblDemoVersion.Location = new System.Drawing.Point(164, 32);
			this.lblDemoVersion.Name = "lblDemoVersion";
			this.lblDemoVersion.Size = new System.Drawing.Size(217, 13);
			this.lblDemoVersion.TabIndex = 13;
			// 
			// AboutForm
			// 
			this.AcceptButton = this.bClose;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(393, 154);
			this.Controls.Add(this.lblDemoVersion);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.linkHome);
			this.Controls.Add(this.bClose);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblQueryBuilderVersion);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "AboutForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About Demo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblQueryBuilderVersion;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button bClose;
		private System.Windows.Forms.LinkLabel linkHome;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblDemoVersion;
	}
}
