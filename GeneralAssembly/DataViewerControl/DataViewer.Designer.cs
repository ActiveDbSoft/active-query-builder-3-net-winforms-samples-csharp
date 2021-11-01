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
            this.pRowCounter = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lQueryExecuted = new System.Windows.Forms.Label();
            this.linkLabelClose = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.paginationPanel1 = new GeneralAssembly.DataViewerControl.PaginationPanel();
            this.infoPanel1 = new GeneralAssembly.DataViewerControl.InfoPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pLoading.SuspendLayout();
            this.pRowCounter.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.dataGridView1.Size = new System.Drawing.Size(726, 316);
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
            this.pLoading.Location = new System.Drawing.Point(301, 104);
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
            // pRowCounter
            // 
            this.pRowCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pRowCounter.AutoSize = true;
            this.pRowCounter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pRowCounter.BackColor = System.Drawing.SystemColors.Info;
            this.pRowCounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pRowCounter.Controls.Add(this.tableLayoutPanel1);
            this.pRowCounter.Location = new System.Drawing.Point(427, 278);
            this.pRowCounter.Name = "pRowCounter";
            this.pRowCounter.Padding = new System.Windows.Forms.Padding(10);
            this.pRowCounter.Size = new System.Drawing.Size(296, 35);
            this.pRowCounter.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lQueryExecuted, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.linkLabelClose, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(274, 13);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lQueryExecuted
            // 
            this.lQueryExecuted.AutoSize = true;
            this.lQueryExecuted.Location = new System.Drawing.Point(3, 0);
            this.lQueryExecuted.Name = "lQueryExecuted";
            this.lQueryExecuted.Size = new System.Drawing.Size(229, 13);
            this.lQueryExecuted.TabIndex = 0;
            this.lQueryExecuted.Text = "Query executed successfully. Loaded {0} rows.";
            // 
            // linkLabelClose
            // 
            this.linkLabelClose.AutoSize = true;
            this.linkLabelClose.Location = new System.Drawing.Point(238, 0);
            this.linkLabelClose.Name = "linkLabelClose";
            this.linkLabelClose.Size = new System.Drawing.Size(33, 13);
            this.linkLabelClose.TabIndex = 1;
            this.linkLabelClose.TabStop = true;
            this.linkLabelClose.Text = "Close";
            this.linkLabelClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelClose_LinkClicked);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.paginationPanel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(732, 357);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pLoading);
            this.panel1.Controls.Add(this.pRowCounter);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 316);
            this.panel1.TabIndex = 0;
            // 
            // paginationPanel1
            // 
            this.paginationPanel1.AutoSize = true;
            this.paginationPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.paginationPanel1.CurrentPage = 0;
            this.paginationPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paginationPanel1.IsSupportLimitCount = true;
            this.paginationPanel1.IsSupportLimitOffset = true;
            this.paginationPanel1.Location = new System.Drawing.Point(3, 325);
            this.paginationPanel1.Name = "paginationPanel1";
            this.paginationPanel1.PageSize = 10;
            this.paginationPanel1.RowsCount = 10;
            this.paginationPanel1.Size = new System.Drawing.Size(726, 29);
            this.paginationPanel1.TabIndex = 3;
            this.paginationPanel1.Visible = false;
            this.paginationPanel1.EnabledPaginationChanged += new System.EventHandler(this.paginationPanel1_EnabledPaginationChanged);
            this.paginationPanel1.CurrentPageChanged += new System.EventHandler(this.paginationPanel1_CurrentPageChanged);
            this.paginationPanel1.PageSizeChanged += new System.EventHandler(this.paginationPanel1_PageSizeChanged);
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
            // DataViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.infoPanel1);
            this.Name = "DataViewer";
            this.Size = new System.Drawing.Size(732, 357);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pLoading.ResumeLayout(false);
            this.pLoading.PerformLayout();
            this.pRowCounter.ResumeLayout(false);
            this.pRowCounter.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel pRowCounter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lQueryExecuted;
        private System.Windows.Forms.LinkLabel linkLabelClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
    }
}
