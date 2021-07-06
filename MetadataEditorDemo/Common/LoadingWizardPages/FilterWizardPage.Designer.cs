namespace MetadataEditorDemo.Common.LoadingWizardPages
{
	partial class FilterWizardPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterWizardPage));
            this.label1 = new System.Windows.Forms.Label();
            this.lblLoadToStart = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cbLoadFields = new System.Windows.Forms.CheckBox();
            this.btnAdvanced = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbLoadFieldsDescr = new System.Windows.Forms.Label();
            this.lbAdvancedFilter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(566, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Metadata Loading Options";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLoadToStart
            // 
            this.lblLoadToStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoadToStart.Location = new System.Drawing.Point(159, 339);
            this.lblLoadToStart.Name = "lblLoadToStart";
            this.lblLoadToStart.Size = new System.Drawing.Size(396, 13);
            this.lblLoadToStart.TabIndex = 10;
            this.lblLoadToStart.Text = "Click Load to start loading or Cancel to quit the wizard.";
            this.lblLoadToStart.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "+.bmp");
            this.imageList1.Images.SetKeyName(1, "-.bmp");
            // 
            // cbLoadFields
            // 
            this.cbLoadFields.AutoSize = true;
            this.cbLoadFields.Location = new System.Drawing.Point(10, 72);
            this.cbLoadFields.Name = "cbLoadFields";
            this.cbLoadFields.Size = new System.Drawing.Size(77, 17);
            this.cbLoadFields.TabIndex = 11;
            this.cbLoadFields.Text = "Load fields";
            this.cbLoadFields.UseVisualStyleBackColor = true;
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.Location = new System.Drawing.Point(10, 153);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Size = new System.Drawing.Size(171, 23);
            this.btnAdvanced.TabIndex = 12;
            this.btnAdvanced.Text = "Advanced Metadata Filtration";
            this.btnAdvanced.UseVisualStyleBackColor = true;
            this.btnAdvanced.Click += new System.EventHandler(this.bntAdvanced_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInfo.Location = new System.Drawing.Point(7, 35);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(549, 19);
            this.lbInfo.TabIndex = 13;
            this.lbInfo.Text = "This step allows you to fine-tune the metadata loading process.";
            // 
            // lbLoadFieldsDescr
            // 
            this.lbLoadFieldsDescr.Location = new System.Drawing.Point(7, 92);
            this.lbLoadFieldsDescr.Name = "lbLoadFieldsDescr";
            this.lbLoadFieldsDescr.Size = new System.Drawing.Size(453, 46);
            this.lbLoadFieldsDescr.TabIndex = 14;
            this.lbLoadFieldsDescr.Text = resources.GetString("lbLoadFieldsDescr.Text");
            // 
            // lbAdvancedFilter
            // 
            this.lbAdvancedFilter.Location = new System.Drawing.Point(7, 182);
            this.lbAdvancedFilter.Name = "lbAdvancedFilter";
            this.lbAdvancedFilter.Size = new System.Drawing.Size(453, 22);
            this.lbAdvancedFilter.TabIndex = 15;
            this.lbAdvancedFilter.Text = "You can instruct to load only part of the schema by specifying masks for database" +
    " objects, schema and field names.";
            // 
            // FilterWizardPage
            // 
            this.Controls.Add(this.lbAdvancedFilter);
            this.Controls.Add(this.lbLoadFieldsDescr);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btnAdvanced);
            this.Controls.Add(this.cbLoadFields);
            this.Controls.Add(this.lblLoadToStart);
            this.Controls.Add(this.label1);
            this.Name = "FilterWizardPage";
            this.Size = new System.Drawing.Size(566, 363);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblLoadToStart;
		private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckBox cbLoadFields;
        private System.Windows.Forms.Button btnAdvanced;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label lbLoadFieldsDescr;
        private System.Windows.Forms.Label lbAdvancedFilter;
    }
}
