namespace MetadataEditorDemo.Common.LoadingWizardPages
{
	partial class SyntaxWizardPage
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lSyntax = new System.Windows.Forms.Label();
			this.lWelcome = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.comboSelectSyntax = new System.Windows.Forms.ComboBox();
			this.lblNextToContinue = new System.Windows.Forms.Label();
			this.lblWarning = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lSyntax
			// 
			this.lSyntax.BackColor = System.Drawing.SystemColors.Window;
			this.lSyntax.Dock = System.Windows.Forms.DockStyle.Top;
			this.lSyntax.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.lSyntax.Location = new System.Drawing.Point(0, 0);
			this.lSyntax.Name = "lSyntax";
			this.lSyntax.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
			this.lSyntax.Size = new System.Drawing.Size(566, 27);
			this.lSyntax.TabIndex = 1;
			this.lSyntax.Text = "Syntax Provider";
			this.lSyntax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lWelcome
			// 
			this.lWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lWelcome.Location = new System.Drawing.Point(5, 36);
			this.lWelcome.Name = "lWelcome";
			this.lWelcome.Size = new System.Drawing.Size(549, 36);
			this.lWelcome.TabIndex = 3;
			this.lWelcome.Text = "This step allows you to specify database server from which you want to load metadata.";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(5, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(230, 21);
			this.label1.TabIndex = 4;
			this.label1.Text = "Select SQL syntax provider:";
			// 
			// comboSelectSyntax
			// 
			this.comboSelectSyntax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboSelectSyntax.DropDownHeight = 200;
			this.comboSelectSyntax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboSelectSyntax.IntegralHeight = false;
			this.comboSelectSyntax.Location = new System.Drawing.Point(241, 77);
			this.comboSelectSyntax.Name = "comboSelectSyntax";
			this.comboSelectSyntax.Size = new System.Drawing.Size(314, 21);
			this.comboSelectSyntax.TabIndex = 5;
			this.comboSelectSyntax.SelectedIndexChanged += new System.EventHandler(this.comboSelectSyntax_SelectedIndexChanged);
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
			// lblWarning
			// 
			this.lblWarning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblWarning.ForeColor = System.Drawing.Color.Red;
			this.lblWarning.Location = new System.Drawing.Point(238, 107);
			this.lblWarning.Name = "lblWarning";
			this.lblWarning.Size = new System.Drawing.Size(317, 39);
			this.lblWarning.TabIndex = 12;
			// 
			// SyntaxWizardPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblWarning);
			this.Controls.Add(this.lblNextToContinue);
			this.Controls.Add(this.comboSelectSyntax);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lWelcome);
			this.Controls.Add(this.lSyntax);
			this.Name = "SyntaxWizardPage";
			this.Size = new System.Drawing.Size(566, 363);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lSyntax;
		private System.Windows.Forms.Label lWelcome;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.ComboBox comboSelectSyntax;
		private System.Windows.Forms.Label lblNextToContinue;
		public System.Windows.Forms.Label lblWarning;

	}
}
