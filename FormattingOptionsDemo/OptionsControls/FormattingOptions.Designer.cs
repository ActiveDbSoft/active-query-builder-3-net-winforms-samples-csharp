using System.Windows.Forms;

namespace FormattingOptionsDemo.OptionsControls
{
    partial class FormattingOptions
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
            this.components = new System.ComponentModel.Container();
            this.currentTabPanel = new System.Windows.Forms.Panel();
            this.sqlTextEditor1 = new RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // currentTabPanel
            // 
            this.currentTabPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentTabPanel.ImeMode = System.Windows.Forms.ImeMode.On;
            this.currentTabPanel.Location = new System.Drawing.Point(220, 3);
            this.currentTabPanel.Name = "currentTabPanel";
            this.currentTabPanel.Size = new System.Drawing.Size(856, 329);
            this.currentTabPanel.TabIndex = 2;
            // 
            // sqlTextEditor1
            // 
           // this.sqlTextEditor1.AcceptTabs = true;
            this.sqlTextEditor1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sqlTextEditor1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.sqlTextEditor1.Location = new System.Drawing.Point(220, 338);
            this.sqlTextEditor1.Name = "sqlTextEditor1";
            this.sqlTextEditor1.Size = new System.Drawing.Size(856, 332);
            this.sqlTextEditor1.TabIndex = 3;
            this.sqlTextEditor1.Text = "Select * From Orders";
            this.sqlTextEditor1.Validating += new System.ComponentModel.CancelEventHandler(this.sqlTextEditor1_Validating);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "Main Query",
            "    Common",
            "    Expression",
            "Sub - Queries in expression",
            "    Common",
            "    Expression",
            "Derived Tables",
            "    Common",
            "    Expression",
            "Common Table Expression",
            "    Common",
            "    Expression"});
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(214, 667);
            this.listBox1.TabIndex = 4;
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // FormattingOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.sqlTextEditor1);
            this.Controls.Add(this.currentTabPanel);
            this.Name = "FormattingOptions";
            this.Size = new System.Drawing.Size(1079, 676);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel currentTabPanel;
        private RichTextBox sqlTextEditor1;
        private System.Windows.Forms.ListBox listBox1;
    }
}
