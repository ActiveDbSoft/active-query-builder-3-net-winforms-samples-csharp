namespace FullFeaturedDemo.ConnectionFrames
{
	sealed partial class MSSQLConnectionFrame
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
			this.label5 = new System.Windows.Forms.Label();
			this.cmbInitialCatalog = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.tbUserID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbIntegratedSecurity = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbDataSource = new System.Windows.Forms.TextBox();
			this.btnEditConnectionString = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 111);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 13);
			this.label5.TabIndex = 21;
			this.label5.Text = "Database:";
			// 
			// cmbInitialCatalog
			// 
			this.cmbInitialCatalog.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cmbInitialCatalog.FormattingEnabled = true;
			this.cmbInitialCatalog.Items.AddRange(new object[] {
            "<default>"});
			this.cmbInitialCatalog.Location = new System.Drawing.Point(87, 108);
			this.cmbInitialCatalog.Name = "cmbInitialCatalog";
			this.cmbInitialCatalog.Size = new System.Drawing.Size(145, 21);
			this.cmbInitialCatalog.Sorted = true;
			this.cmbInitialCatalog.TabIndex = 20;
			this.cmbInitialCatalog.DropDown += new System.EventHandler(this.cmbInitialCatalog_DropDown);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 85);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 19;
			this.label4.Text = "Password:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 13);
			this.label3.TabIndex = 18;
			this.label3.Text = "Login:";
			// 
			// tbPassword
			// 
			this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbPassword.Location = new System.Drawing.Point(87, 82);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(145, 20);
			this.tbPassword.TabIndex = 16;
			this.tbPassword.UseSystemPasswordChar = true;
			// 
			// tbUserID
			// 
			this.tbUserID.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbUserID.Location = new System.Drawing.Point(87, 56);
			this.tbUserID.Name = "tbUserID";
			this.tbUserID.Size = new System.Drawing.Size(145, 20);
			this.tbUserID.TabIndex = 15;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 13);
			this.label2.TabIndex = 17;
			this.label2.Text = "Authentication:";
			// 
			// cmbIntegratedSecurity
			// 
			this.cmbIntegratedSecurity.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cmbIntegratedSecurity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbIntegratedSecurity.FormattingEnabled = true;
			this.cmbIntegratedSecurity.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
			this.cmbIntegratedSecurity.Location = new System.Drawing.Point(87, 29);
			this.cmbIntegratedSecurity.Name = "cmbIntegratedSecurity";
			this.cmbIntegratedSecurity.Size = new System.Drawing.Size(145, 21);
			this.cmbIntegratedSecurity.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "Server:";
			// 
			// tbDataSource
			// 
			this.tbDataSource.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbDataSource.Location = new System.Drawing.Point(87, 3);
			this.tbDataSource.Name = "tbDataSource";
			this.tbDataSource.Size = new System.Drawing.Size(145, 20);
			this.tbDataSource.TabIndex = 12;
			// 
			// btnEditConnectionString
			// 
			this.btnEditConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEditConnectionString.Location = new System.Drawing.Point(99, 143);
			this.btnEditConnectionString.Name = "btnEditConnectionString";
			this.btnEditConnectionString.Size = new System.Drawing.Size(133, 23);
			this.btnEditConnectionString.TabIndex = 22;
			this.btnEditConnectionString.Text = "Edit Connection String";
			this.btnEditConnectionString.UseVisualStyleBackColor = true;
			this.btnEditConnectionString.Click += new System.EventHandler(this.btnEditConnectionString_Click);
			// 
			// MSSQLConnectionFrame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnEditConnectionString);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cmbInitialCatalog);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.tbUserID);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cmbIntegratedSecurity);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbDataSource);
			this.Name = "MSSQLConnectionFrame";
			this.Size = new System.Drawing.Size(235, 169);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbInitialCatalog;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.TextBox tbUserID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbIntegratedSecurity;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbDataSource;
		private System.Windows.Forms.Button btnEditConnectionString;
	}
}
