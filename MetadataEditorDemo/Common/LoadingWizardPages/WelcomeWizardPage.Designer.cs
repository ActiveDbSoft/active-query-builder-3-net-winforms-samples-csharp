namespace MetadataEditorDemo.Common.LoadingWizardPages
{
	partial class WelcomeWizardPage
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lWelcome = new System.Windows.Forms.Label();
            this.cbClearBeforeLoading = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNextToContinue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(566, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Active Query Builder Load Metadata Wizard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::MetadataEditorDemo.Properties.Resources.logo3;
            this.pictureBox1.Location = new System.Drawing.Point(3, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 330);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lWelcome
            // 
            this.lWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lWelcome.Location = new System.Drawing.Point(162, 37);
            this.lWelcome.Name = "lWelcome";
            this.lWelcome.Size = new System.Drawing.Size(388, 35);
            this.lWelcome.TabIndex = 2;
            this.lWelcome.Text = "This wizard will guide you through the metadata loading process.";
            // 
            // cbClearBeforeLoading
            // 
            this.cbClearBeforeLoading.AutoSize = true;
            this.cbClearBeforeLoading.Location = new System.Drawing.Point(165, 138);
            this.cbClearBeforeLoading.Name = "cbClearBeforeLoading";
            this.cbClearBeforeLoading.Size = new System.Drawing.Size(216, 17);
            this.cbClearBeforeLoading.TabIndex = 3;
            this.cbClearBeforeLoading.Text = "Clear Metadata Container before loading";
            this.cbClearBeforeLoading.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(162, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 63);
            this.label2.TabIndex = 4;
            this.label2.Text = "Please check the \"Clear Metadata Container before loading\" checkbox if you don\'t " +
    "want to save previous content of Metadata Container.";
            // 
            // lblNextToContinue
            // 
            this.lblNextToContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNextToContinue.Location = new System.Drawing.Point(159, 339);
            this.lblNextToContinue.Name = "lblNextToContinue";
            this.lblNextToContinue.Size = new System.Drawing.Size(396, 13);
            this.lblNextToContinue.TabIndex = 12;
            this.lblNextToContinue.Text = "Click Next to continue or Cancel to quit the wizard.";
            this.lblNextToContinue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // WelcomeWizardPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNextToContinue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbClearBeforeLoading);
            this.Controls.Add(this.lWelcome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "WelcomeWizardPage";
            this.Size = new System.Drawing.Size(566, 363);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lWelcome;
		public System.Windows.Forms.CheckBox cbClearBeforeLoading;
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNextToContinue;
    }
}
