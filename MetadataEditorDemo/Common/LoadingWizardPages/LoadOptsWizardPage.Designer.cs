namespace MetadataEditorDemo.Common.LoadingWizardPages
{
    partial class LoadOptsWizardPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.lWelcome = new System.Windows.Forms.Label();
            this.checklistDatabases = new System.Windows.Forms.CheckedListBox();
            this.lblNextToContinue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(566, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Databases";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lWelcome
            // 
            this.lWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lWelcome.Location = new System.Drawing.Point(6, 36);
            this.lWelcome.Name = "lWelcome";
            this.lWelcome.Size = new System.Drawing.Size(549, 34);
            this.lWelcome.TabIndex = 2;
            this.lWelcome.Text = "Select databases you want to load metadata from:";
            // 
            // checklistDatabases
            // 
            this.checklistDatabases.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checklistDatabases.CheckOnClick = true;
            this.checklistDatabases.FormattingEnabled = true;
            this.checklistDatabases.IntegralHeight = false;
            this.checklistDatabases.Location = new System.Drawing.Point(9, 73);
            this.checklistDatabases.Name = "checklistDatabases";
            this.checklistDatabases.Size = new System.Drawing.Size(546, 255);
            this.checklistDatabases.TabIndex = 10;
            // 
            // lblNextToContinue
            // 
            this.lblNextToContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNextToContinue.Location = new System.Drawing.Point(159, 339);
            this.lblNextToContinue.Name = "lblNextToContinue";
            this.lblNextToContinue.Size = new System.Drawing.Size(396, 13);
            this.lblNextToContinue.TabIndex = 11;
            this.lblNextToContinue.Text = "Click Next to continue or Cancel to quit the wizard.";
            this.lblNextToContinue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LoadOptsWizardPage
            // 
            this.Controls.Add(this.lblNextToContinue);
            this.Controls.Add(this.checklistDatabases);
            this.Controls.Add(this.lWelcome);
            this.Controls.Add(this.label1);
            this.Name = "LoadOptsWizardPage";
            this.Size = new System.Drawing.Size(566, 363);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lWelcome;
        public System.Windows.Forms.CheckedListBox checklistDatabases;
        private System.Windows.Forms.Label lblNextToContinue;
    }
}
