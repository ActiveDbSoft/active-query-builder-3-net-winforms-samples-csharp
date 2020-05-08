namespace MetadataEditorDemo.Common.LoadingWizardPages
{
	partial class LoadingWizardPage
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
            this.label2 = new System.Windows.Forms.Label();
            this.textLog = new System.Windows.Forms.TextBox();
            this.lblLoaded = new System.Windows.Forms.Label();
            this.pbSuccess = new System.Windows.Forms.PictureBox();
            this.lbSuccess = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSuccess)).BeginInit();
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
            this.label1.Text = "Loading Metadata Progress";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please wait while Active Query builder loads the metadata information...";
            // 
            // textLog
            // 
            this.textLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textLog.BackColor = System.Drawing.SystemColors.Window;
            this.textLog.Location = new System.Drawing.Point(10, 86);
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.ReadOnly = true;
            this.textLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textLog.Size = new System.Drawing.Size(544, 237);
            this.textLog.TabIndex = 2;
            // 
            // lblLoaded
            // 
            this.lblLoaded.AutoSize = true;
            this.lblLoaded.Location = new System.Drawing.Point(7, 59);
            this.lblLoaded.Name = "lblLoaded";
            this.lblLoaded.Size = new System.Drawing.Size(46, 13);
            this.lblLoaded.TabIndex = 3;
            this.lblLoaded.Text = "Loaded:";
            // 
            // pbSuccess
            // 
            this.pbSuccess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbSuccess.Image = global::MetadataEditorDemo.Properties.Resources.check_icon;
            this.pbSuccess.Location = new System.Drawing.Point(10, 329);
            this.pbSuccess.Name = "pbSuccess";
            this.pbSuccess.Size = new System.Drawing.Size(30, 30);
            this.pbSuccess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbSuccess.TabIndex = 4;
            this.pbSuccess.TabStop = false;
            this.pbSuccess.Visible = false;
            // 
            // lbSuccess
            // 
            this.lbSuccess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbSuccess.AutoSize = true;
            this.lbSuccess.Location = new System.Drawing.Point(43, 337);
            this.lbSuccess.Name = "lbSuccess";
            this.lbSuccess.Size = new System.Drawing.Size(56, 13);
            this.lbSuccess.TabIndex = 5;
            this.lbSuccess.Text = "lbSuccess";
            this.lbSuccess.Visible = false;
            // 
            // LoadingWizardPage
            // 
            this.Controls.Add(this.lbSuccess);
            this.Controls.Add(this.pbSuccess);
            this.Controls.Add(this.lblLoaded);
            this.Controls.Add(this.textLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoadingWizardPage";
            this.Size = new System.Drawing.Size(566, 365);
            ((System.ComponentModel.ISupportInitialize)(this.pbSuccess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox textLog;
		public System.Windows.Forms.Label lblLoaded;
        private System.Windows.Forms.PictureBox pbSuccess;
        private System.Windows.Forms.Label lbSuccess;
    }
}
