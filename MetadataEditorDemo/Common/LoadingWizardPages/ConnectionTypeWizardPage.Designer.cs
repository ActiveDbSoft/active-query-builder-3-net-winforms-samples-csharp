namespace MetadataEditorDemo.Common.LoadingWizardPages
{
    partial class ConnectionTypeWizardPage
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
            this.lbType = new System.Windows.Forms.Label();
            this.lblNextToContinue = new System.Windows.Forms.Label();
            this.cbConnectionType = new System.Windows.Forms.ComboBox();
            this.labelConnection = new System.Windows.Forms.Label();
            this.lWelcome = new System.Windows.Forms.Label();
            this.cbSyntax = new System.Windows.Forms.ComboBox();
            this.labelSyntax = new System.Windows.Forms.Label();
            this.panelSyntaxOpts = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbType
            // 
            this.lbType.BackColor = System.Drawing.SystemColors.Window;
            this.lbType.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbType.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbType.Location = new System.Drawing.Point(0, 0);
            this.lbType.Name = "lbType";
            this.lbType.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lbType.Size = new System.Drawing.Size(566, 27);
            this.lbType.TabIndex = 2;
            this.lbType.Text = "Connection Type";
            this.lbType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNextToContinue
            // 
            this.lblNextToContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNextToContinue.Location = new System.Drawing.Point(159, 339);
            this.lblNextToContinue.Name = "lblNextToContinue";
            this.lblNextToContinue.Size = new System.Drawing.Size(396, 13);
            this.lblNextToContinue.TabIndex = 15;
            this.lblNextToContinue.Text = "Click Next to continue or Cancel to quit the wizard.";
            this.lblNextToContinue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbConnectionType
            // 
            this.cbConnectionType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbConnectionType.DropDownHeight = 200;
            this.cbConnectionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConnectionType.IntegralHeight = false;
            this.cbConnectionType.Location = new System.Drawing.Point(241, 77);
            this.cbConnectionType.Name = "cbConnectionType";
            this.cbConnectionType.Size = new System.Drawing.Size(314, 21);
            this.cbConnectionType.TabIndex = 14;
            // 
            // labelConnection
            // 
            this.labelConnection.Location = new System.Drawing.Point(5, 80);
            this.labelConnection.Name = "labelConnection";
            this.labelConnection.Size = new System.Drawing.Size(230, 21);
            this.labelConnection.TabIndex = 13;
            this.labelConnection.Text = "Select connection type:";
            // 
            // lWelcome
            // 
            this.lWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lWelcome.Location = new System.Drawing.Point(5, 36);
            this.lWelcome.Name = "lWelcome";
            this.lWelcome.Size = new System.Drawing.Size(549, 36);
            this.lWelcome.TabIndex = 12;
            this.lWelcome.Text = "This step allows you to specify database server from which you want to load metad" +
    "ata.";
            // 
            // cbSyntax
            // 
            this.cbSyntax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSyntax.DropDownHeight = 200;
            this.cbSyntax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSyntax.IntegralHeight = false;
            this.cbSyntax.Location = new System.Drawing.Point(241, 104);
            this.cbSyntax.Name = "cbSyntax";
            this.cbSyntax.Size = new System.Drawing.Size(314, 21);
            this.cbSyntax.TabIndex = 17;
            this.cbSyntax.Visible = false;
            // 
            // labelSyntax
            // 
            this.labelSyntax.Location = new System.Drawing.Point(5, 107);
            this.labelSyntax.Name = "labelSyntax";
            this.labelSyntax.Size = new System.Drawing.Size(230, 21);
            this.labelSyntax.TabIndex = 16;
            this.labelSyntax.Text = "Select SQL syntax provider:";
            this.labelSyntax.Visible = false;
            // 
            // panelSyntaxOpts
            // 
            this.panelSyntaxOpts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSyntaxOpts.Location = new System.Drawing.Point(8, 131);
            this.panelSyntaxOpts.Name = "panelSyntaxOpts";
            this.panelSyntaxOpts.Size = new System.Drawing.Size(547, 125);
            this.panelSyntaxOpts.TabIndex = 18;
            // 
            // ConnectionTypeWizardPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelSyntaxOpts);
            this.Controls.Add(this.cbSyntax);
            this.Controls.Add(this.labelSyntax);
            this.Controls.Add(this.lblNextToContinue);
            this.Controls.Add(this.cbConnectionType);
            this.Controls.Add(this.labelConnection);
            this.Controls.Add(this.lWelcome);
            this.Controls.Add(this.lbType);
            this.Name = "ConnectionTypeWizardPage";
            this.Size = new System.Drawing.Size(566, 363);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lblNextToContinue;
        public System.Windows.Forms.ComboBox cbConnectionType;
        private System.Windows.Forms.Label labelConnection;
        private System.Windows.Forms.Label lWelcome;
        public System.Windows.Forms.ComboBox cbSyntax;
        private System.Windows.Forms.Label labelSyntax;
        public System.Windows.Forms.Panel panelSyntaxOpts;
    }
}
