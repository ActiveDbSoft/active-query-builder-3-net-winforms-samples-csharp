namespace FullFeaturedMdiDemo.PropertiesForm
{
    partial class SqlGenerationPage
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
            this.lblCasing = new System.Windows.Forms.Label();
            this.cbObjectPrefixSkipping = new System.Windows.Forms.ComboBox();
            this.cbQuoteAllIdentifiers = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblCasing
            // 
            this.lblCasing.Location = new System.Drawing.Point(3, 35);
            this.lblCasing.Name = "lblCasing";
            this.lblCasing.Size = new System.Drawing.Size(164, 17);
            this.lblCasing.TabIndex = 10;
            this.lblCasing.Text = "Prefix skipping";
            this.lblCasing.UseCompatibleTextRendering = true;
            // 
            // cbObjectPrefixSkipping
            // 
            this.cbObjectPrefixSkipping.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbObjectPrefixSkipping.FormattingEnabled = true;
            this.cbObjectPrefixSkipping.Location = new System.Drawing.Point(195, 31);
            this.cbObjectPrefixSkipping.Name = "cbObjectPrefixSkipping";
            this.cbObjectPrefixSkipping.Size = new System.Drawing.Size(150, 21);
            this.cbObjectPrefixSkipping.TabIndex = 9;
            this.cbObjectPrefixSkipping.SelectedIndexChanged += new System.EventHandler(this.cbObjectPrefixSkipping_SelectedIndexChanged);
            // 
            // cbQuoteAllIdentifiers
            // 
            this.cbQuoteAllIdentifiers.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbQuoteAllIdentifiers.Location = new System.Drawing.Point(3, 3);
            this.cbQuoteAllIdentifiers.Name = "cbQuoteAllIdentifiers";
            this.cbQuoteAllIdentifiers.Size = new System.Drawing.Size(207, 26);
            this.cbQuoteAllIdentifiers.TabIndex = 8;
            this.cbQuoteAllIdentifiers.Text = "Quote all identifiers";
            this.cbQuoteAllIdentifiers.UseCompatibleTextRendering = true;
            this.cbQuoteAllIdentifiers.UseVisualStyleBackColor = true;
            this.cbQuoteAllIdentifiers.CheckedChanged += new System.EventHandler(this.cbQuoteAllIdentifiers_CheckedChanged);
            // 
            // SqlGenerationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCasing);
            this.Controls.Add(this.cbObjectPrefixSkipping);
            this.Controls.Add(this.cbQuoteAllIdentifiers);
            this.Name = "SqlGenerationPage";
            this.Size = new System.Drawing.Size(357, 69);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCasing;
        private System.Windows.Forms.ComboBox cbObjectPrefixSkipping;
        private System.Windows.Forms.CheckBox cbQuoteAllIdentifiers;
    }
}
