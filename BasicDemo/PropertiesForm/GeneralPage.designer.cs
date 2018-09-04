namespace BasicDemo
{
	partial class GeneralPage
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
			this.label12 = new System.Windows.Forms.Label();
			this.updownRightMargin = new System.Windows.Forms.NumericUpDown();
			this.cbWordWrap = new System.Windows.Forms.CheckBox();
			this.comboKeywordsCasing = new System.Windows.Forms.ComboBox();
			this.lblCasing = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize) (this.updownRightMargin)).BeginInit();
			this.SuspendLayout();
			//
			// label12
			//
			this.label12.Location = new System.Drawing.Point(3, 35);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(164, 17);
			this.label12.TabIndex = 5;
			this.label12.Text = "Maximum characters in line";
			this.label12.UseCompatibleTextRendering = true;
			//
			// updownRightMargin
			//
			this.updownRightMargin.Location = new System.Drawing.Point(196, 33);
			this.updownRightMargin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.updownRightMargin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.updownRightMargin.Name = "updownRightMargin";
			this.updownRightMargin.Size = new System.Drawing.Size(45, 20);
			this.updownRightMargin.TabIndex = 1;
			this.updownRightMargin.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
			//
			// cbWordWrap
			//
			this.cbWordWrap.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cbWordWrap.Location = new System.Drawing.Point(3, 3);
			this.cbWordWrap.Name = "cbWordWrap";
			this.cbWordWrap.Size = new System.Drawing.Size(207, 26);
			this.cbWordWrap.TabIndex = 0;
			this.cbWordWrap.Text = "Enable word wrap";
			this.cbWordWrap.UseCompatibleTextRendering = true;
			this.cbWordWrap.UseVisualStyleBackColor = true;
			//
			// comboKeywordsCasing
			//
			this.comboKeywordsCasing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboKeywordsCasing.FormattingEnabled = true;
			this.comboKeywordsCasing.Location = new System.Drawing.Point(196, 63);
			this.comboKeywordsCasing.Name = "comboKeywordsCasing";
			this.comboKeywordsCasing.Size = new System.Drawing.Size(155, 21);
			this.comboKeywordsCasing.TabIndex = 2;
			//
			// lblCasing
			//
			this.lblCasing.Location = new System.Drawing.Point(3, 66);
			this.lblCasing.Name = "lblCasing";
			this.lblCasing.Size = new System.Drawing.Size(164, 17);
			this.lblCasing.TabIndex = 7;
			this.lblCasing.Text = "Keywords casing";
			this.lblCasing.UseCompatibleTextRendering = true;
			//
			// GeneralPage
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblCasing);
			this.Controls.Add(this.comboKeywordsCasing);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.updownRightMargin);
			this.Controls.Add(this.cbWordWrap);
			this.Name = "GeneralPage";
			this.Size = new System.Drawing.Size(380, 93);
			((System.ComponentModel.ISupportInitialize) (this.updownRightMargin)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.NumericUpDown updownRightMargin;
		private System.Windows.Forms.CheckBox cbWordWrap;
		private System.Windows.Forms.ComboBox comboKeywordsCasing;
		private System.Windows.Forms.Label lblCasing;
	}
}
