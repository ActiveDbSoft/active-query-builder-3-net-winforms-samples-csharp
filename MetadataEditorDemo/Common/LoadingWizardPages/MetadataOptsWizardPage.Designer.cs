namespace MetadataEditorDemo.Common.LoadingWizardPages
{
	partial class MetadataOptsWizardPage
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.lWelcome = new System.Windows.Forms.Label();
            this.bConnectionTest = new System.Windows.Forms.Button();
            this.panelMetadataOpts = new System.Windows.Forms.Panel();
            this.lblNextToContinue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(566, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Database Connection Options";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lWelcome
            // 
            this.lWelcome.Location = new System.Drawing.Point(5, 36);
            this.lWelcome.Name = "lWelcome";
            this.lWelcome.Size = new System.Drawing.Size(550, 23);
            this.lWelcome.TabIndex = 3;
            this.lWelcome.Text = "This step allows you to setup chosen database connection.";
            // 
            // bConnectionTest
            // 
            this.bConnectionTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bConnectionTest.AutoSize = true;
            this.bConnectionTest.Location = new System.Drawing.Point(414, 304);
            this.bConnectionTest.Name = "bConnectionTest";
            this.bConnectionTest.Size = new System.Drawing.Size(141, 23);
            this.bConnectionTest.TabIndex = 9;
            this.bConnectionTest.Text = "Test Connection";
            this.bConnectionTest.UseVisualStyleBackColor = true;
            // 
            // panelMetadataOpts
            // 
            this.panelMetadataOpts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMetadataOpts.Location = new System.Drawing.Point(8, 62);
            this.panelMetadataOpts.Name = "panelMetadataOpts";
            this.panelMetadataOpts.Size = new System.Drawing.Size(547, 236);
            this.panelMetadataOpts.TabIndex = 10;
            // 
            // lblNextToContinue
            // 
            this.lblNextToContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNextToContinue.Location = new System.Drawing.Point(159, 339);
            this.lblNextToContinue.Name = "lblNextToContinue";
            this.lblNextToContinue.Size = new System.Drawing.Size(396, 13);
            this.lblNextToContinue.TabIndex = 11;
            this.lblNextToContinue.Text = "Click Next to continue or Cancel to quit the wizard.";
            this.lblNextToContinue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MetadataOptsWizardPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNextToContinue);
            this.Controls.Add(this.panelMetadataOpts);
            this.Controls.Add(this.bConnectionTest);
            this.Controls.Add(this.lWelcome);
            this.Controls.Add(this.label1);
            this.Name = "MetadataOptsWizardPage";
            this.Size = new System.Drawing.Size(566, 363);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lWelcome;
		public System.Windows.Forms.Button bConnectionTest;
		public System.Windows.Forms.Panel panelMetadataOpts;
		private System.Windows.Forms.Label lblNextToContinue;
	}
}
