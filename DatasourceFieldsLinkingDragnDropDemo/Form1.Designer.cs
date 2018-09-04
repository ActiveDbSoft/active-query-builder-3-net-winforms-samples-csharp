namespace DatasourceFieldsLinkingDragnDropDemo
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CheckBoxBeforeDsFieldDrag = new System.Windows.Forms.CheckBox();
            this.CheckBoxLinkDragOver = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.QBuilder = new ActiveQueryBuilder.View.WinForms.QueryBuilder();
            this.TextBoxSQL = new System.Windows.Forms.RichTextBox();
            this.TextBoxReport = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxReport, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(999, 659);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 50);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.CheckBoxBeforeDsFieldDrag);
            this.flowLayoutPanel1.Controls.Add(this.CheckBoxLinkDragOver);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(993, 33);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // CheckBoxBeforeDsFieldDrag
            // 
            this.CheckBoxBeforeDsFieldDrag.AutoSize = true;
            this.CheckBoxBeforeDsFieldDrag.Checked = true;
            this.CheckBoxBeforeDsFieldDrag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxBeforeDsFieldDrag.Location = new System.Drawing.Point(8, 8);
            this.CheckBoxBeforeDsFieldDrag.Name = "CheckBoxBeforeDsFieldDrag";
            this.CheckBoxBeforeDsFieldDrag.Size = new System.Drawing.Size(157, 17);
            this.CheckBoxBeforeDsFieldDrag.TabIndex = 0;
            this.CheckBoxBeforeDsFieldDrag.Text = "BeforeDatasourceFieldDrag";
            this.CheckBoxBeforeDsFieldDrag.UseVisualStyleBackColor = true;
            // 
            // CheckBoxLinkDragOver
            // 
            this.CheckBoxLinkDragOver.AutoSize = true;
            this.CheckBoxLinkDragOver.Checked = true;
            this.CheckBoxLinkDragOver.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxLinkDragOver.Location = new System.Drawing.Point(171, 8);
            this.CheckBoxLinkDragOver.Name = "CheckBoxLinkDragOver";
            this.CheckBoxLinkDragOver.Size = new System.Drawing.Size(92, 17);
            this.CheckBoxLinkDragOver.TabIndex = 0;
            this.CheckBoxLinkDragOver.Text = "LinkDragOver";
            this.CheckBoxLinkDragOver.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stop on:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(3, 59);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.QBuilder);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TextBoxSQL);
            this.splitContainer1.Size = new System.Drawing.Size(993, 497);
            this.splitContainer1.SplitterDistance = 383;
            this.splitContainer1.TabIndex = 1;
            // 
            // QBuilder
            // 
            this.QBuilder.BehaviorOptions.ResolveColumnNamingConflictsAutomatically = false;
            this.QBuilder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QBuilder.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess;
            this.QBuilder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QBuilder.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QBuilder.Location = new System.Drawing.Point(0, 0);
            this.QBuilder.MetadataStructureOptions.ProceduresFolderText = "Procedures";
            this.QBuilder.MetadataStructureOptions.SynonymsFolderText = "Synonyms";
            this.QBuilder.MetadataStructureOptions.TablesFolderText = "Tables";
            this.QBuilder.MetadataStructureOptions.ViewsFolderText = "Views";
            this.QBuilder.Name = "QBuilder";
            this.QBuilder.Size = new System.Drawing.Size(993, 383);
            // 
            // 
            // 
            this.QBuilder.SQLFormattingOptions.ExpandVirtualFields = false;
            this.QBuilder.SQLFormattingOptions.ExpandVirtualObjects = false;
            this.QBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.FromClauseFormat.NewLineAfterDatasource = false;
            this.QBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.MainPartsFromNewLine = false;
            // 
            // 
            // 
            this.QBuilder.SQLGenerationOptions.ExpandVirtualFields = true;
            this.QBuilder.SQLGenerationOptions.ExpandVirtualObjects = true;
            this.QBuilder.SQLGenerationOptions.UseAltNames = false;
            this.QBuilder.TabIndex = 2;
            this.QBuilder.LinkDragOver += new ActiveQueryBuilder.View.QueryView.LinkDragOverEventhandler(this.QBuilder_LinkDragOver);
            this.QBuilder.BeforeDatasourceFieldDrag += new ActiveQueryBuilder.View.QueryView.BeforeDataSourceFieldDragEventHandler(this.QBuilder_BeforeDatasourceFieldDrag);
            this.QBuilder.SQLUpdated += new System.EventHandler(this.queryBuilder1_SQLUpdated);
            // 
            // TextBoxSQL
            // 
            this.TextBoxSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxSQL.Location = new System.Drawing.Point(0, 0);
            this.TextBoxSQL.Name = "TextBoxSQL";
            this.TextBoxSQL.Size = new System.Drawing.Size(993, 110);
            this.TextBoxSQL.TabIndex = 0;
            this.TextBoxSQL.Text = "";
            this.TextBoxSQL.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxSQL_Validating);
            // 
            // TextBoxReport
            // 
            this.TextBoxReport.BackColor = System.Drawing.SystemColors.Info;
            this.TextBoxReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxReport.Location = new System.Drawing.Point(3, 562);
            this.TextBoxReport.Name = "TextBoxReport";
            this.TextBoxReport.Size = new System.Drawing.Size(993, 94);
            this.TextBoxReport.TabIndex = 2;
            this.TextBoxReport.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 659);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Datasource Fields Linking Drag’n’Drop demo";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox CheckBoxBeforeDsFieldDrag;
        private System.Windows.Forms.CheckBox CheckBoxLinkDragOver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private ActiveQueryBuilder.View.WinForms.QueryBuilder QBuilder;
        private System.Windows.Forms.RichTextBox TextBoxSQL;
        private System.Windows.Forms.RichTextBox TextBoxReport;
    }
}

