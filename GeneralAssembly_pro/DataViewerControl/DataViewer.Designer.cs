namespace GeneralAssembly.DataViewerControl
{
    partial class DataViewer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pLoading = new System.Windows.Forms.Panel();
            this.bCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.infoPanel1 = new GeneralAssembly.DataViewerControl.InfoPanel();
            this.paginationPanel1 = new GeneralAssembly.DataViewerControl.PaginationPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pLoading.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(620, 343);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // pLoading
            // 
            this.pLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pLoading.AutoSize = true;
            this.pLoading.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pLoading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLoading.Controls.Add(this.bCancel);
            this.pLoading.Controls.Add(this.label1);
            this.pLoading.Location = new System.Drawing.Point(243, 135);
            this.pLoading.Name = "pLoading";
            this.pLoading.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.pLoading.Size = new System.Drawing.Size(128, 67);
            this.pLoading.TabIndex = 1;
            this.pLoading.Visible = false;
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(27, 34);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 1;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.ButtonCancelExecutingSql_OnClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loading...";
            // 
            // infoPanel1
            // 
            this.infoPanel1.AutoSize = true;
            this.infoPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.infoPanel1.BackColor = System.Drawing.Color.LightCoral;
            this.infoPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.infoPanel1.Location = new System.Drawing.Point(0, 306);
            this.infoPanel1.Message = "";
            this.infoPanel1.Name = "infoPanel1";
            this.infoPanel1.Size = new System.Drawing.Size(620, 37);
            this.infoPanel1.TabIndex = 2;
            this.infoPanel1.Visible = false;
            // 
            // paginationPanel1
            // 
            this.paginationPanel1.CurrentPage = 0;
            this.paginationPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paginationPanel1.IsSupportLimitCount = true;
            this.paginationPanel1.IsSupportLimitOffset = true;
            this.paginationPanel1.Location = new System.Drawing.Point(0, 314);
            this.paginationPanel1.Name = "paginationPanel1";
            this.paginationPanel1.PageSize = 10;
            this.paginationPanel1.RowsCount = 10;
            this.paginationPanel1.Size = new System.Drawing.Size(620, 29);
            this.paginationPanel1.TabIndex = 3;
            this.paginationPanel1.EnabledPaginationChanged += new System.EventHandler(this.paginationPanel1_EnabledPaginationChanged);
            this.paginationPanel1.CurrentPageChanged += new System.EventHandler(this.paginationPanel1_CurrentPageChanged);
            this.paginationPanel1.PageSizeChanged += new System.EventHandler(this.paginationPanel1_PageSizeChanged);
            // 
            // DataViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.paginationPanel1);
            this.Controls.Add(this.infoPanel1);
            this.Controls.Add(this.pLoading);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataViewer";
            this.Size = new System.Drawing.Size(620, 343);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pLoading.ResumeLayout(false);
            this.pLoading.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pLoading;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label label1;
        private InfoPanel infoPanel1;
        private PaginationPanel paginationPanel1;
    }
}
