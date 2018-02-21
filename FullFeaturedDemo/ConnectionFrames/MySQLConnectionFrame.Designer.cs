namespace FullFeaturedDemo.ConnectionFrames
{
	sealed partial class MySQLConnectionFrame
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
			this.btnEditConnectionString = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.tbUserID = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbServer = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbDatabase = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnEditConnectionString
			// 
			this.btnEditConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEditConnectionString.Location = new System.Drawing.Point(82, 117);
			this.btnEditConnectionString.Name = "btnEditConnectionString";
			this.btnEditConnectionString.Size = new System.Drawing.Size(133, 23);
			this.btnEditConnectionString.TabIndex = 4;
			this.btnEditConnectionString.Text = "Edit Connection String";
			this.btnEditConnectionString.UseVisualStyleBackColor = true;
			this.btnEditConnectionString.Click += new System.EventHandler(this.btnEditConnectionString_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 58);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 13);
			this.label4.TabIndex = 34;
			this.label4.Text = "User";
			// 
			// tbUserID
			// 
			this.tbUserID.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbUserID.Location = new System.Drawing.Point(62, 55);
			this.tbUserID.Name = "tbUserID";
			this.tbUserID.Size = new System.Drawing.Size(153, 20);
			this.tbUserID.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 6);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 33;
			this.label3.Text = "Server";
			// 
			// tbServer
			// 
			this.tbServer.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbServer.Location = new System.Drawing.Point(62, 3);
			this.tbServer.Name = "tbServer";
			this.tbServer.Size = new System.Drawing.Size(153, 20);
			this.tbServer.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 32;
			this.label2.Text = "Password";
			// 
			// tbPassword
			// 
			this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbPassword.Location = new System.Drawing.Point(62, 81);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(153, 20);
			this.tbPassword.TabIndex = 3;
			this.tbPassword.UseSystemPasswordChar = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 13);
			this.label1.TabIndex = 29;
			this.label1.Text = "Database";
			// 
			// tbDatabase
			// 
			this.tbDatabase.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbDatabase.Location = new System.Drawing.Point(62, 29);
			this.tbDatabase.Name = "tbDatabase";
			this.tbDatabase.Size = new System.Drawing.Size(153, 20);
			this.tbDatabase.TabIndex = 1;
			// 
			// MySQLConnectionFrame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbUserID);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbServer);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbDatabase);
			this.Controls.Add(this.btnEditConnectionString);
			this.Name = "MySQLConnectionFrame";
			this.Size = new System.Drawing.Size(218, 143);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnEditConnectionString;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbUserID;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbServer;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbDatabase;

	}
}
