namespace FullFeaturedDemo.ConnectionFrames
{
	sealed partial class MSAccessConnectionFrame
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
			this.btnBrowse = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.tbUserID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbDataSource = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.btnEditConnectionString = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnBrowse
			// 
			this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowse.Location = new System.Drawing.Point(235, 1);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(25, 23);
			this.btnBrowse.TabIndex = 1;
			this.btnBrowse.Text = "...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 58);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 16;
			this.label4.Text = "Password:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 15;
			this.label3.Text = "User:";
			// 
			// tbPassword
			// 
			this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbPassword.Location = new System.Drawing.Point(65, 55);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(164, 20);
			this.tbPassword.TabIndex = 3;
			this.tbPassword.UseSystemPasswordChar = true;
			// 
			// tbUserID
			// 
			this.tbUserID.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbUserID.Location = new System.Drawing.Point(65, 29);
			this.tbUserID.Name = "tbUserID";
			this.tbUserID.Size = new System.Drawing.Size(164, 20);
			this.tbUserID.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Database:";
			// 
			// tbDataSource
			// 
			this.tbDataSource.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbDataSource.Location = new System.Drawing.Point(65, 3);
			this.tbDataSource.Name = "tbDataSource";
			this.tbDataSource.Size = new System.Drawing.Size(164, 20);
			this.tbDataSource.TabIndex = 0;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.DefaultExt = "mdb";
			this.openFileDialog1.Filter = "Microsoft Access databases (*.accdb;*.mdb)|*.accdb;*.mdb|ACCDB databases (*.accdb" +
    ")|*.accdb|MDB databases (*.mdb)|*.mdb|All files|*.*";
			// 
			// btnEditConnectionString
			// 
			this.btnEditConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEditConnectionString.Location = new System.Drawing.Point(127, 86);
			this.btnEditConnectionString.Name = "btnEditConnectionString";
			this.btnEditConnectionString.Size = new System.Drawing.Size(133, 23);
			this.btnEditConnectionString.TabIndex = 23;
			this.btnEditConnectionString.Text = "Edit Connection String";
			this.btnEditConnectionString.UseVisualStyleBackColor = true;
			this.btnEditConnectionString.Click += new System.EventHandler(this.btnEditConnectionString_Click);
			// 
			// MSAccessConnectionFrame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnEditConnectionString);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.tbUserID);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbDataSource);
			this.Name = "MSAccessConnectionFrame";
			this.Size = new System.Drawing.Size(263, 112);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.TextBox tbUserID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbDataSource;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button btnEditConnectionString;
	}
}
