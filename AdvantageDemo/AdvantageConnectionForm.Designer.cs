namespace AdvantageDemo
{
	partial class AdvantageConnectionForm
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
			this.textboxDataSource = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonBrowse = new System.Windows.Forms.Button();
			this.textboxPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonConnect = new System.Windows.Forms.Button();
			this.cbServerType = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textboxUser = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textboxDataSource
			// 
			this.textboxDataSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textboxDataSource.Location = new System.Drawing.Point(97, 12);
			this.textboxDataSource.Name = "textboxDataSource";
			this.textboxDataSource.Size = new System.Drawing.Size(220, 20);
			this.textboxDataSource.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Data Source:";
			// 
			// buttonBrowse
			// 
			this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonBrowse.Location = new System.Drawing.Point(323, 10);
			this.buttonBrowse.Name = "buttonBrowse";
			this.buttonBrowse.Size = new System.Drawing.Size(24, 23);
			this.buttonBrowse.TabIndex = 1;
			this.buttonBrowse.Text = "...";
			this.buttonBrowse.UseVisualStyleBackColor = true;
			this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
			// 
			// textboxPassword
			// 
			this.textboxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textboxPassword.Location = new System.Drawing.Point(97, 91);
			this.textboxPassword.Name = "textboxPassword";
			this.textboxPassword.Size = new System.Drawing.Size(220, 20);
			this.textboxPassword.TabIndex = 4;
			this.textboxPassword.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Password";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.DefaultExt = "*.add";
			this.openFileDialog1.Filter = "ADS Data Dictionary|*.add|All Files|*.*";
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(272, 134);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 6;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonConnect
			// 
			this.buttonConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonConnect.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonConnect.Location = new System.Drawing.Point(191, 134);
			this.buttonConnect.Name = "buttonConnect";
			this.buttonConnect.Size = new System.Drawing.Size(75, 23);
			this.buttonConnect.TabIndex = 5;
			this.buttonConnect.Text = "Connect";
			this.buttonConnect.UseVisualStyleBackColor = true;
			this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
			// 
			// cbServerType
			// 
			this.cbServerType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbServerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbServerType.FormattingEnabled = true;
			this.cbServerType.Items.AddRange(new object[] {
            "local",
            "remote"});
			this.cbServerType.Location = new System.Drawing.Point(97, 38);
			this.cbServerType.Name = "cbServerType";
			this.cbServerType.Size = new System.Drawing.Size(220, 21);
			this.cbServerType.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Server Type:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 68);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 13);
			this.label4.TabIndex = 13;
			this.label4.Text = "User:";
			// 
			// textboxUser
			// 
			this.textboxUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textboxUser.Location = new System.Drawing.Point(97, 65);
			this.textboxUser.Name = "textboxUser";
			this.textboxUser.Size = new System.Drawing.Size(220, 20);
			this.textboxUser.TabIndex = 3;
			// 
			// AdvantageConnectionForm
			// 
			this.AcceptButton = this.buttonConnect;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(359, 169);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textboxUser);
			this.Controls.Add(this.cbServerType);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonConnect);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textboxPassword);
			this.Controls.Add(this.buttonBrowse);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textboxDataSource);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AdvantageConnectionForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Connect to Advantage database";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textboxDataSource;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonBrowse;
		private System.Windows.Forms.TextBox textboxPassword;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonConnect;
		private System.Windows.Forms.ComboBox cbServerType;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textboxUser;
	}
}
