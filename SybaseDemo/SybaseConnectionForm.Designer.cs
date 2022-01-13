namespace SybaseDemo
{
    partial class SybaseConnectionForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textboxDataSourceName = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textboxUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxServerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxDatabaseFile = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.fd";
            this.openFileDialog1.Filter = "Sybase Database File (*.db)|*.db|All Files|*.*";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(210, 153);
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
            this.buttonConnect.Location = new System.Drawing.Point(129, 153);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 5;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(13, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Data Source Name:";
            // 
            // textboxDataSourceName
            // 
            this.textboxDataSourceName.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxDataSourceName.Location = new System.Drawing.Point(124, 38);
            this.textboxDataSourceName.Name = "textboxDataSourceName";
            this.textboxDataSourceName.Size = new System.Drawing.Size(131, 20);
            this.textboxDataSourceName.TabIndex = 31;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse.Location = new System.Drawing.Point(261, 62);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(24, 22);
            this.buttonBrowse.TabIndex = 24;
            this.buttonBrowse.Text = "...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(13, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "User:";
            // 
            // textboxUser
            // 
            this.textboxUser.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxUser.Location = new System.Drawing.Point(124, 90);
            this.textboxUser.Name = "textboxUser";
            this.textboxUser.Size = new System.Drawing.Size(131, 20);
            this.textboxUser.TabIndex = 25;
            this.textboxUser.Text = "DBA";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Server Name:";
            // 
            // textboxServerName
            // 
            this.textboxServerName.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxServerName.Location = new System.Drawing.Point(124, 12);
            this.textboxServerName.Name = "textboxServerName";
            this.textboxServerName.Size = new System.Drawing.Size(131, 20);
            this.textboxServerName.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Password:";
            // 
            // textboxPassword
            // 
            this.textboxPassword.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxPassword.Location = new System.Drawing.Point(124, 116);
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.Size = new System.Drawing.Size(131, 20);
            this.textboxPassword.TabIndex = 26;
            this.textboxPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Database File:";
            // 
            // textboxDatabaseFile
            // 
            this.textboxDatabaseFile.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxDatabaseFile.Location = new System.Drawing.Point(124, 64);
            this.textboxDatabaseFile.Name = "textboxDatabaseFile";
            this.textboxDatabaseFile.Size = new System.Drawing.Size(131, 20);
            this.textboxDatabaseFile.TabIndex = 23;
            // 
            // SybaseConnectionForm
            // 
            this.AcceptButton = this.buttonConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(297, 188);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textboxDataSourceName);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textboxUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textboxServerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxDatabaseFile);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConnect);
            this.Name = "SybaseConnectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connect to Sybase database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textboxDataSourceName;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textboxUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxServerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxDatabaseFile;
    }
}
