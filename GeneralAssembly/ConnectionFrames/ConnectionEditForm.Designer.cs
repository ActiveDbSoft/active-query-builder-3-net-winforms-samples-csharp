namespace GeneralAssembly.ConnectionFrames
{
	partial class ConnectionEditForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbODBC = new System.Windows.Forms.RadioButton();
            this.rbOLEDB = new System.Windows.Forms.RadioButton();
            this.rbPostrgeSQL = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbMySQL = new System.Windows.Forms.RadioButton();
            this.rbOracle = new System.Windows.Forms.RadioButton();
            this.rbMSAccess = new System.Windows.Forms.RadioButton();
            this.rbMSSQL = new System.Windows.Forms.RadioButton();
            this.pnlFrames = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BoxSyntaxProvider = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbConnectionName = new System.Windows.Forms.TextBox();
            this.BoxServerVersion = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbODBC);
            this.panel1.Controls.Add(this.rbOLEDB);
            this.panel1.Controls.Add(this.rbPostrgeSQL);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rbMySQL);
            this.panel1.Controls.Add(this.rbOracle);
            this.panel1.Controls.Add(this.rbMSAccess);
            this.panel1.Controls.Add(this.rbMSSQL);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 356);
            this.panel1.TabIndex = 0;
            // 
            // rbODBC
            // 
            this.rbODBC.AutoSize = true;
            this.rbODBC.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbODBC.ForeColor = System.Drawing.Color.SteelBlue;
            this.rbODBC.Location = new System.Drawing.Point(10, 166);
            this.rbODBC.Name = "rbODBC";
            this.rbODBC.Size = new System.Drawing.Size(55, 17);
            this.rbODBC.TabIndex = 8;
            this.rbODBC.Text = "ODBC";
            this.rbODBC.UseVisualStyleBackColor = true;
            // 
            // rbOLEDB
            // 
            this.rbOLEDB.AutoSize = true;
            this.rbOLEDB.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbOLEDB.ForeColor = System.Drawing.Color.SteelBlue;
            this.rbOLEDB.Location = new System.Drawing.Point(10, 143);
            this.rbOLEDB.Name = "rbOLEDB";
            this.rbOLEDB.Size = new System.Drawing.Size(63, 17);
            this.rbOLEDB.TabIndex = 7;
            this.rbOLEDB.Text = "OLE DB";
            this.rbOLEDB.UseVisualStyleBackColor = true;
            // 
            // rbPostrgeSQL
            // 
            this.rbPostrgeSQL.AutoSize = true;
            this.rbPostrgeSQL.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbPostrgeSQL.ForeColor = System.Drawing.Color.SteelBlue;
            this.rbPostrgeSQL.Location = new System.Drawing.Point(10, 97);
            this.rbPostrgeSQL.Name = "rbPostrgeSQL";
            this.rbPostrgeSQL.Size = new System.Drawing.Size(90, 17);
            this.rbPostrgeSQL.TabIndex = 5;
            this.rbPostrgeSQL.Text = "PostgreSQL";
            this.rbPostrgeSQL.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "--------------------------------------------";
            // 
            // rbMySQL
            // 
            this.rbMySQL.AutoSize = true;
            this.rbMySQL.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbMySQL.ForeColor = System.Drawing.Color.SteelBlue;
            this.rbMySQL.Location = new System.Drawing.Point(10, 74);
            this.rbMySQL.Name = "rbMySQL";
            this.rbMySQL.Size = new System.Drawing.Size(63, 17);
            this.rbMySQL.TabIndex = 3;
            this.rbMySQL.Text = "MySQL";
            this.rbMySQL.UseVisualStyleBackColor = true;
            // 
            // rbOracle
            // 
            this.rbOracle.AutoSize = true;
            this.rbOracle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbOracle.ForeColor = System.Drawing.Color.SteelBlue;
            this.rbOracle.Location = new System.Drawing.Point(10, 51);
            this.rbOracle.Name = "rbOracle";
            this.rbOracle.Size = new System.Drawing.Size(61, 17);
            this.rbOracle.TabIndex = 2;
            this.rbOracle.Text = "Oracle";
            this.rbOracle.UseVisualStyleBackColor = true;
            // 
            // rbMSAccess
            // 
            this.rbMSAccess.AutoSize = true;
            this.rbMSAccess.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbMSAccess.ForeColor = System.Drawing.Color.SteelBlue;
            this.rbMSAccess.Location = new System.Drawing.Point(10, 28);
            this.rbMSAccess.Name = "rbMSAccess";
            this.rbMSAccess.Size = new System.Drawing.Size(120, 17);
            this.rbMSAccess.TabIndex = 1;
            this.rbMSAccess.Text = "Microsoft Access";
            this.rbMSAccess.UseVisualStyleBackColor = true;
            // 
            // rbMSSQL
            // 
            this.rbMSSQL.AutoSize = true;
            this.rbMSSQL.Checked = true;
            this.rbMSSQL.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbMSSQL.ForeColor = System.Drawing.Color.SteelBlue;
            this.rbMSSQL.Location = new System.Drawing.Point(10, 5);
            this.rbMSSQL.Margin = new System.Windows.Forms.Padding(10, 5, 10, 3);
            this.rbMSSQL.Name = "rbMSSQL";
            this.rbMSSQL.Size = new System.Drawing.Size(143, 17);
            this.rbMSSQL.TabIndex = 0;
            this.rbMSSQL.TabStop = true;
            this.rbMSSQL.Text = "Microsoft SQL Server";
            this.rbMSSQL.UseVisualStyleBackColor = true;
            // 
            // pnlFrames
            // 
            this.pnlFrames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFrames.BackColor = System.Drawing.Color.White;
            this.pnlFrames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFrames.Location = new System.Drawing.Point(177, 110);
            this.pnlFrames.Name = "pnlFrames";
            this.pnlFrames.Padding = new System.Windows.Forms.Padding(6);
            this.pnlFrames.Size = new System.Drawing.Size(364, 258);
            this.pnlFrames.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(385, 374);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(466, 374);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BoxSyntaxProvider);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbConnectionName);
            this.panel2.Location = new System.Drawing.Point(177, 12);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(6);
            this.panel2.Size = new System.Drawing.Size(364, 92);
            this.panel2.TabIndex = 1;
            // 
            // BoxSyntaxProvider
            // 
            this.BoxSyntaxProvider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxSyntaxProvider.Enabled = false;
            this.BoxSyntaxProvider.FormattingEnabled = true;
            this.BoxSyntaxProvider.Location = new System.Drawing.Point(120, 36);
            this.BoxSyntaxProvider.Name = "BoxSyntaxProvider";
            this.BoxSyntaxProvider.Size = new System.Drawing.Size(233, 21);
            this.BoxSyntaxProvider.TabIndex = 2;
            this.BoxSyntaxProvider.SelectedIndexChanged += new System.EventHandler(this.BoxSyntaxProvider_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Server Version";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Syntax Provider";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Connection Name";
            // 
            // tbConnectionName
            // 
            this.tbConnectionName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbConnectionName.Location = new System.Drawing.Point(120, 9);
            this.tbConnectionName.Name = "tbConnectionName";
            this.tbConnectionName.Size = new System.Drawing.Size(233, 20);
            this.tbConnectionName.TabIndex = 0;
            // 
            // BoxServerVersion
            // 
            this.BoxServerVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxServerVersion.Enabled = false;
            this.BoxServerVersion.FormattingEnabled = true;
            this.BoxServerVersion.Location = new System.Drawing.Point(298, 76);
            this.BoxServerVersion.Name = "BoxServerVersion";
            this.BoxServerVersion.Size = new System.Drawing.Size(233, 21);
            this.BoxServerVersion.TabIndex = 2;
            this.BoxServerVersion.SelectedIndexChanged += new System.EventHandler(this.BoxServerVersion_SelectedIndexChanged);
            // 
            // ConnectionEditForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(553, 409);
            this.Controls.Add(this.BoxServerVersion);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlFrames);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(480, 295);
            this.Name = "ConnectionEditForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Connection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConnectionEditForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel pnlFrames;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.RadioButton rbMSAccess;
		private System.Windows.Forms.RadioButton rbMSSQL;
		private System.Windows.Forms.RadioButton rbODBC;
		private System.Windows.Forms.RadioButton rbOLEDB;
		private System.Windows.Forms.RadioButton rbPostrgeSQL;
		private System.Windows.Forms.RadioButton rbMySQL;
		private System.Windows.Forms.RadioButton rbOracle;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbConnectionName;
        private System.Windows.Forms.ComboBox BoxSyntaxProvider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox BoxServerVersion;
	}
}