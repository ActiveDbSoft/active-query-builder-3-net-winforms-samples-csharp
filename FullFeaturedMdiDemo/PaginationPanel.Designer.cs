namespace FullFeaturedMdiDemo
{
    partial class PaginationPanel
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
            this.ceEnabled = new System.Windows.Forms.CheckBox();
            this.tbCurrentPage = new System.Windows.Forms.TextBox();
            this.tbPageSize = new System.Windows.Forms.TextBox();
            this.labelPageSize = new System.Windows.Forms.Label();
            this.labelCurrentPage = new System.Windows.Forms.Label();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ceEnabled
            // 
            this.ceEnabled.AutoSize = true;
            this.ceEnabled.Location = new System.Drawing.Point(3, 7);
            this.ceEnabled.Name = "ceEnabled";
            this.ceEnabled.Size = new System.Drawing.Size(111, 17);
            this.ceEnabled.TabIndex = 0;
            this.ceEnabled.Text = "Enable pagination";
            this.ceEnabled.UseVisualStyleBackColor = true;
            this.ceEnabled.CheckedChanged += new System.EventHandler(this.ceEnabled_CheckedChanged);
            // 
            // tbCurrentPage
            // 
            this.tbCurrentPage.Location = new System.Drawing.Point(158, 5);
            this.tbCurrentPage.Name = "tbCurrentPage";
            this.tbCurrentPage.ReadOnly = true;
            this.tbCurrentPage.Size = new System.Drawing.Size(81, 20);
            this.tbCurrentPage.TabIndex = 1;
            this.tbCurrentPage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPageSize_KeyDown);
            this.tbCurrentPage.Validating += new System.ComponentModel.CancelEventHandler(this.intTextBox_Validating);
            this.tbCurrentPage.Validated += new System.EventHandler(this.tbCurrentPage_Validated);
            // 
            // tbPageSize
            // 
            this.tbPageSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPageSize.Location = new System.Drawing.Point(376, 5);
            this.tbPageSize.Name = "tbPageSize";
            this.tbPageSize.ReadOnly = true;
            this.tbPageSize.Size = new System.Drawing.Size(57, 20);
            this.tbPageSize.TabIndex = 1;
            this.tbPageSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPageSize_KeyDown);
            this.tbPageSize.Validating += new System.ComponentModel.CancelEventHandler(this.intTextBox_Validating);
            this.tbPageSize.Validated += new System.EventHandler(this.tbPageSize_Validated);
            // 
            // labelPageSize
            // 
            this.labelPageSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPageSize.AutoSize = true;
            this.labelPageSize.Location = new System.Drawing.Point(317, 8);
            this.labelPageSize.Name = "labelPageSize";
            this.labelPageSize.Size = new System.Drawing.Size(53, 13);
            this.labelPageSize.TabIndex = 4;
            this.labelPageSize.Text = "Page size";
            // 
            // labelCurrentPage
            // 
            this.labelCurrentPage.AutoSize = true;
            this.labelCurrentPage.Location = new System.Drawing.Point(120, 8);
            this.labelCurrentPage.Name = "labelCurrentPage";
            this.labelCurrentPage.Size = new System.Drawing.Size(32, 13);
            this.labelCurrentPage.TabIndex = 4;
            this.labelCurrentPage.Text = "Page";
            // 
            // btnNextPage
            // 
            this.btnNextPage.Enabled = false;
            this.btnNextPage.Image = global::FullFeaturedMdiDemo.Properties.Resources.arrow_right;
            this.btnNextPage.Location = new System.Drawing.Point(274, 3);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(23, 23);
            this.btnNextPage.TabIndex = 3;
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Enabled = false;
            this.btnPrevPage.Image = global::FullFeaturedMdiDemo.Properties.Resources.arrow_left;
            this.btnPrevPage.Location = new System.Drawing.Point(245, 3);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(23, 23);
            this.btnPrevPage.TabIndex = 2;
            this.btnPrevPage.UseVisualStyleBackColor = true;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // PaginationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelCurrentPage);
            this.Controls.Add(this.labelPageSize);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnPrevPage);
            this.Controls.Add(this.tbPageSize);
            this.Controls.Add(this.tbCurrentPage);
            this.Controls.Add(this.ceEnabled);
            this.Name = "PaginationPanel";
            this.Size = new System.Drawing.Size(436, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ceEnabled;
        private System.Windows.Forms.TextBox tbCurrentPage;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.TextBox tbPageSize;
        private System.Windows.Forms.Label labelPageSize;
        private System.Windows.Forms.Label labelCurrentPage;
    }
}
