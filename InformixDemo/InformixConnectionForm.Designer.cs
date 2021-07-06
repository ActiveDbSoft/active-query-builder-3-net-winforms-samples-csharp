namespace InformixDemo
{
	partial class InformixConnectionForm
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
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.tbService = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tbProtocol = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbHost = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.tbDatabaseLocale = new System.Windows.Forms.TextBox();
			this.tbUser = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbServer = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbDatabase = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(202, 232);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 9;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonConnect
			// 
			this.buttonConnect.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonConnect.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonConnect.Location = new System.Drawing.Point(121, 232);
			this.buttonConnect.Name = "buttonConnect";
			this.buttonConnect.Size = new System.Drawing.Size(75, 23);
			this.buttonConnect.TabIndex = 8;
			this.buttonConnect.Text = "Connect";
			this.buttonConnect.UseVisualStyleBackColor = true;
			this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(7, 145);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(95, 13);
			this.label8.TabIndex = 43;
			this.label8.Text = "Database Locale:";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(7, 93);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(95, 13);
			this.label7.TabIndex = 42;
			this.label7.Text = "Service:";
			// 
			// tbService
			// 
			this.tbService.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbService.Location = new System.Drawing.Point(108, 90);
			this.tbService.Name = "tbService";
			this.tbService.Size = new System.Drawing.Size(169, 20);
			this.tbService.TabIndex = 3;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(7, 67);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(95, 13);
			this.label6.TabIndex = 41;
			this.label6.Text = "Protocol:";
			// 
			// tbProtocol
			// 
			this.tbProtocol.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbProtocol.Location = new System.Drawing.Point(108, 64);
			this.tbProtocol.Name = "tbProtocol";
			this.tbProtocol.Size = new System.Drawing.Size(169, 20);
			this.tbProtocol.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(7, 41);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(95, 13);
			this.label5.TabIndex = 40;
			this.label5.Text = "Host:";
			// 
			// tbHost
			// 
			this.tbHost.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbHost.Location = new System.Drawing.Point(108, 38);
			this.tbHost.Name = "tbHost";
			this.tbHost.Size = new System.Drawing.Size(169, 20);
			this.tbHost.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(7, 171);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(95, 13);
			this.label4.TabIndex = 39;
			this.label4.Text = "User:";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.DefaultExt = "*.fdb";
			this.openFileDialog1.Filter = "Firebird Databases (*.fdb)|*.fdb|All files|*.*";
			// 
			// tbDatabaseLocale
			// 
			this.tbDatabaseLocale.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbDatabaseLocale.Location = new System.Drawing.Point(108, 142);
			this.tbDatabaseLocale.Name = "tbDatabaseLocale";
			this.tbDatabaseLocale.Size = new System.Drawing.Size(169, 20);
			this.tbDatabaseLocale.TabIndex = 5;
			// 
			// tbUser
			// 
			this.tbUser.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbUser.Location = new System.Drawing.Point(108, 168);
			this.tbUser.Name = "tbUser";
			this.tbUser.Size = new System.Drawing.Size(169, 20);
			this.tbUser.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(7, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 13);
			this.label3.TabIndex = 38;
			this.label3.Text = "Server:";
			// 
			// tbServer
			// 
			this.tbServer.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbServer.Location = new System.Drawing.Point(108, 12);
			this.tbServer.Name = "tbServer";
			this.tbServer.Size = new System.Drawing.Size(169, 20);
			this.tbServer.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(7, 197);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 13);
			this.label2.TabIndex = 37;
			this.label2.Text = "Password:";
			// 
			// tbPassword
			// 
			this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbPassword.Location = new System.Drawing.Point(108, 194);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(169, 20);
			this.tbPassword.TabIndex = 7;
			this.tbPassword.UseSystemPasswordChar = true;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(7, 119);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 13);
			this.label1.TabIndex = 36;
			this.label1.Text = "Database:";
			// 
			// tbDatabase
			// 
			this.tbDatabase.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbDatabase.Location = new System.Drawing.Point(108, 116);
			this.tbDatabase.Name = "tbDatabase";
			this.tbDatabase.Size = new System.Drawing.Size(169, 20);
			this.tbDatabase.TabIndex = 4;
			// 
			// InformixConnectionForm
			// 
			this.AcceptButton = this.buttonConnect;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(289, 267);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.tbService);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tbProtocol);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tbHost);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbDatabaseLocale);
			this.Controls.Add(this.tbUser);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbServer);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbDatabase);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonConnect);
			this.Name = "InformixConnectionForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Connect to Informix database";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonConnect;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tbService;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbProtocol;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbHost;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TextBox tbDatabaseLocale;
		private System.Windows.Forms.TextBox tbUser;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbServer;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbDatabase;
	}
}