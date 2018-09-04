namespace PostgreSQLDemo
{
	partial class PostgreSQLConnectionForm
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
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonConnect = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.tbPort = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.tbLogin = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbServer = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbDatabase = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(167, 154);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 6;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonConnect
			// 
			this.buttonConnect.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonConnect.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonConnect.Location = new System.Drawing.Point(86, 154);
			this.buttonConnect.Name = "buttonConnect";
			this.buttonConnect.Size = new System.Drawing.Size(75, 23);
			this.buttonConnect.TabIndex = 5;
			this.buttonConnect.Text = "Connect";
			this.buttonConnect.UseVisualStyleBackColor = true;
			this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 13);
			this.label2.TabIndex = 27;
			this.label2.Text = "Port:";
			// 
			// tbPort
			// 
			this.tbPort.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbPort.Location = new System.Drawing.Point(98, 38);
			this.tbPort.Name = "tbPort";
			this.tbPort.Size = new System.Drawing.Size(144, 20);
			this.tbPort.TabIndex = 1;
			this.tbPort.Text = "5432";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 13);
			this.label3.TabIndex = 25;
			this.label3.Text = "Login:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 119);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 13);
			this.label4.TabIndex = 24;
			this.label4.Text = "Password:";
			// 
			// tbPassword
			// 
			this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbPassword.Location = new System.Drawing.Point(98, 116);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(144, 20);
			this.tbPassword.TabIndex = 4;
			this.tbPassword.UseSystemPasswordChar = true;
			// 
			// tbLogin
			// 
			this.tbLogin.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbLogin.Location = new System.Drawing.Point(98, 90);
			this.tbLogin.Name = "tbLogin";
			this.tbLogin.Size = new System.Drawing.Size(144, 20);
			this.tbLogin.TabIndex = 3;
			this.tbLogin.Text = "postgres";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 13);
			this.label1.TabIndex = 21;
			this.label1.Text = "Server:";
			// 
			// tbServer
			// 
			this.tbServer.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbServer.Location = new System.Drawing.Point(98, 12);
			this.tbServer.Name = "tbServer";
			this.tbServer.Size = new System.Drawing.Size(144, 20);
			this.tbServer.TabIndex = 0;
			this.tbServer.Text = "localhost";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 67);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 13);
			this.label5.TabIndex = 29;
			this.label5.Text = "Database:";
			// 
			// tbDatabase
			// 
			this.tbDatabase.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbDatabase.Location = new System.Drawing.Point(98, 64);
			this.tbDatabase.Name = "tbDatabase";
			this.tbDatabase.Size = new System.Drawing.Size(144, 20);
			this.tbDatabase.TabIndex = 2;
			// 
			// PostgreSQLConnectionForm
			// 
			this.AcceptButton = this.buttonConnect;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(254, 189);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tbDatabase);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbPort);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.tbLogin);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbServer);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonConnect);
			this.Name = "PostgreSQLConnectionForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Connect to PostgreSQL database";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonConnect;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbPort;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.TextBox tbLogin;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbServer;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbDatabase;
	}
}
