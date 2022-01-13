namespace GeneralAssembly.ConnectionFrames
{
    sealed partial class OracleConnectionFrame
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Login:";
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.Location = new System.Drawing.Point(87, 82);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(130, 20);
            this.tbPassword.TabIndex = 14;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbUserID
            // 
            this.tbUserID.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUserID.Location = new System.Drawing.Point(87, 56);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.Size = new System.Drawing.Size(130, 20);
            this.tbUserID.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 15;
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
            "Oracle Server Authentication"});
            this.cmbIntegratedSecurity.Location = new System.Drawing.Point(87, 29);
            this.cmbIntegratedSecurity.Name = "cmbIntegratedSecurity";
            this.cmbIntegratedSecurity.Size = new System.Drawing.Size(130, 21);
            this.cmbIntegratedSecurity.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Server Name:";
            // 
            // tbDataSource
            // 
            this.tbDataSource.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDataSource.Location = new System.Drawing.Point(87, 3);
            this.tbDataSource.Name = "tbDataSource";
            this.tbDataSource.Size = new System.Drawing.Size(130, 20);
            this.tbDataSource.TabIndex = 10;
            // 
            // btnEditConnectionString
            // 
            this.btnEditConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditConnectionString.Location = new System.Drawing.Point(84, 113);
            this.btnEditConnectionString.Name = "btnEditConnectionString";
            this.btnEditConnectionString.Size = new System.Drawing.Size(133, 23);
            this.btnEditConnectionString.TabIndex = 24;
            this.btnEditConnectionString.Text = "Edit Connection String";
            this.btnEditConnectionString.UseVisualStyleBackColor = true;
            this.btnEditConnectionString.Click += new System.EventHandler(this.btnEditConnectionString_Click);
            // 
            // OracleConnectionFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEditConnectionString);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbIntegratedSecurity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDataSource);
            this.Name = "OracleConnectionFrame";
            this.Size = new System.Drawing.Size(220, 139);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
