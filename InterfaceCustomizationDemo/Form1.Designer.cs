namespace InterfaceCustomizationDemo
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
            ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess linkPainterAccess1 = new ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TextBoxReport = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.QBuilder = new ActiveQueryBuilder.View.WinForms.QueryBuilder();
            this.TextBoxSQL = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.QElementCreated = new System.Windows.Forms.CheckBox();
            this.QElementDestroying = new System.Windows.Forms.CheckBox();
            this.ValidateContextMenu = new System.Windows.Forms.CheckBox();
            this.CustomizeDataSourceCaption = new System.Windows.Forms.CheckBox();
            this.CustomizeDataSourceFieldList = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorBox1 = new GeneralAssembly.Common.SqlErrorBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QBuilder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QBuilder.SQLFormattingOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QBuilder.SQLGenerationOptions)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.TextBoxReport, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1108, 741);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TextBoxReport
            // 
            this.TextBoxReport.BackColor = System.Drawing.SystemColors.Info;
            this.TextBoxReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxReport.Location = new System.Drawing.Point(3, 644);
            this.TextBoxReport.Name = "TextBoxReport";
            this.TextBoxReport.Size = new System.Drawing.Size(1102, 94);
            this.TextBoxReport.TabIndex = 0;
            this.TextBoxReport.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(3, 71);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.QBuilder);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.errorBox1);
            this.splitContainer1.Panel2.Controls.Add(this.TextBoxSQL);
            this.splitContainer1.Size = new System.Drawing.Size(1102, 567);
            this.splitContainer1.SplitterDistance = 445;
            this.splitContainer1.TabIndex = 0;
            // 
            // QBuilder
            // 
            this.QBuilder.AddObjectDialogOptions.Location = new System.Drawing.Point(0, 0);
            this.QBuilder.AddObjectDialogOptions.Size = new System.Drawing.Size(430, 430);
            this.QBuilder.AddObjectDialogOptions.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.QBuilder.BehaviorOptions.ResolveColumnNamingConflictsAutomatically = false;
            this.QBuilder.DatabaseSchemaViewOptions.DrawTreeLines = false;
            this.QBuilder.DatabaseSchemaViewOptions.ImageList = null;
            this.QBuilder.DesignPaneOptions.Background = System.Drawing.SystemColors.Window;
            linkPainterAccess1.LinkColor = System.Drawing.Color.Black;
            linkPainterAccess1.LinkColorFocused = System.Drawing.Color.Black;
            linkPainterAccess1.MarkColor = System.Drawing.SystemColors.Control;
            linkPainterAccess1.MarkColorFocused = System.Drawing.SystemColors.ControlDark;
            linkPainterAccess1.MarkStyle = ActiveQueryBuilder.View.QueryView.LinkMarkStyle.Access;
            this.QBuilder.DesignPaneOptions.LinkPainterOptions = linkPainterAccess1;
            this.QBuilder.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess;
            this.QBuilder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QBuilder.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.QBuilder.Location = new System.Drawing.Point(0, 0);
            this.QBuilder.Name = "QBuilder";
            this.QBuilder.PanesConfigurationOptions.PropertiesBarDockOptions.AutoHide = true;
            this.QBuilder.PanesConfigurationOptions.PropertiesBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Right;
            this.QBuilder.PanesConfigurationOptions.PropertiesBarEnabled = true;
            this.QBuilder.PanesConfigurationOptions.SubQueryNavBarDockOptions.AutoHide = true;
            this.QBuilder.PanesConfigurationOptions.SubQueryNavBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Left;
            this.QBuilder.PanesConfigurationOptions.SubQueryNavBarEnabled = true;
            this.QBuilder.QueryColumnListOptions.Font = null;
            this.QBuilder.QueryColumnListOptions.InitialOrColumnsCount = 2;
            this.QBuilder.QueryColumnListOptions.NullOrderingInOrderBy = false;
            this.QBuilder.QueryColumnListOptions.UseCustomExpressionBuilder = ActiveQueryBuilder.View.QueryView.AffectedColumns.None;
            this.QBuilder.QueryNavBarOptions.CTEButtonBaseColor = System.Drawing.Color.Green;
            this.QBuilder.QueryNavBarOptions.DisableQueryNavigationBarPopup = false;
            this.QBuilder.QueryNavBarOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QBuilder.QueryNavBarOptions.OverflowButtonBaseColor = System.Drawing.Color.DarkRed;
            this.QBuilder.QueryNavBarOptions.RootQueryButtonBaseColor = System.Drawing.Color.Black;
            this.QBuilder.QueryNavBarOptions.SubQueryButtonBaseColor = System.Drawing.Color.Blue;
            this.QBuilder.Size = new System.Drawing.Size(1102, 445);
            // 
            // 
            // 
            this.QBuilder.SQLFormattingOptions.CTESubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.QBuilder.SQLFormattingOptions.CTESubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.QBuilder.SQLFormattingOptions.CTESubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.QBuilder.SQLFormattingOptions.DerivedQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.QBuilder.SQLFormattingOptions.DerivedQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.QBuilder.SQLFormattingOptions.DerivedQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.QBuilder.SQLFormattingOptions.DynamicIndents = false;
            this.QBuilder.SQLFormattingOptions.DynamicRightMargin = false;
            this.QBuilder.SQLFormattingOptions.ExpandVirtualFields = false;
            this.QBuilder.SQLFormattingOptions.ExpandVirtualObjects = false;
            this.QBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.QBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.FromClauseFormat.NewLineAfterDatasource = false;
            this.QBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.QBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.MainPartsFromNewLine = false;
            this.QBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.QBuilder.SQLFormattingOptions.MainQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.QBuilder.SQLFormattingOptions.MainQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.QBuilder.SQLFormattingOptions.MainQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            // 
            // 
            // 
            this.QBuilder.SQLGenerationOptions.ExpandVirtualFields = true;
            this.QBuilder.SQLGenerationOptions.ExpandVirtualObjects = true;
            this.QBuilder.SQLGenerationOptions.UseAltNames = false;
            this.QBuilder.TabIndex = 0;
            this.QBuilder.VisualOptions.ActiveDockPanelCaptionColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(157)))));
            this.QBuilder.VisualOptions.ActiveDockPanelCaptionFontColor = System.Drawing.Color.Black;
            this.QBuilder.VisualOptions.DockTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.QBuilder.VisualOptions.DockTabFontColor = System.Drawing.Color.White;
            this.QBuilder.VisualOptions.DockTabFontHoverColor = System.Drawing.Color.White;
            this.QBuilder.VisualOptions.DockTabHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.QBuilder.VisualOptions.DockTabIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.QBuilder.VisualOptions.DockTabIndicatorHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(167)))), ((int)(((byte)(183)))));
            this.QBuilder.VisualOptions.InactiveDockPanelCaptionColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            this.QBuilder.VisualOptions.InactiveDockPanelCaptionFontColor = System.Drawing.Color.White;
            this.QBuilder.VisualOptions.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QBuilder.VisualOptions.TabsStripBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.QBuilder.ValidateContextMenu += new ActiveQueryBuilder.View.QueryView.ContextMenuEventHandler(this.QBuilder_ValidateContextMenu);
            this.QBuilder.CustomizeDataSourceFieldList += new ActiveQueryBuilder.View.QueryView.CustomizeDataSourceFieldListEventHandler(this.QBuilder_CustomizeDataSourceFieldList);
            this.QBuilder.CustomizeDataSourceCaption += new ActiveQueryBuilder.View.QueryView.CustomizeDataSourceCaptionEventHandler(this.QBuilder_CustomizeDataSourceCaption);
            this.QBuilder.SQLUpdated += new System.EventHandler(this.QBuilder_SQLUpdated);
            this.QBuilder.QueryElementControlCreated += new ActiveQueryBuilder.View.QueryView.QueryElementControlCreatedEventHandler(this.QBuilder_QueryElementControlCreated);
            this.QBuilder.QueryElementControlDestroying += new ActiveQueryBuilder.View.QueryView.QueryElementControlDestroyingEventHandler(this.QBuilder_QueryElementControlDestroying);
            // 
            // TextBoxSQL
            // 
            this.TextBoxSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxSQL.Location = new System.Drawing.Point(0, 0);
            this.TextBoxSQL.Name = "TextBoxSQL";
            this.TextBoxSQL.Size = new System.Drawing.Size(1102, 118);
            this.TextBoxSQL.TabIndex = 0;
            this.TextBoxSQL.Text = "";
            this.TextBoxSQL.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxSQL_Validating);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(1102, 62);
            this.panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.QElementCreated);
            this.flowLayoutPanel1.Controls.Add(this.QElementDestroying);
            this.flowLayoutPanel1.Controls.Add(this.ValidateContextMenu);
            this.flowLayoutPanel1.Controls.Add(this.CustomizeDataSourceCaption);
            this.flowLayoutPanel1.Controls.Add(this.CustomizeDataSourceFieldList);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1096, 37);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // QElementCreated
            // 
            this.QElementCreated.AutoSize = true;
            this.QElementCreated.Checked = true;
            this.QElementCreated.CheckState = System.Windows.Forms.CheckState.Checked;
            this.QElementCreated.Location = new System.Drawing.Point(6, 6);
            this.QElementCreated.Name = "QElementCreated";
            this.QElementCreated.Size = new System.Drawing.Size(162, 17);
            this.QElementCreated.TabIndex = 0;
            this.QElementCreated.Text = "QueryElementControlCreated";
            this.QElementCreated.UseVisualStyleBackColor = true;
            // 
            // QElementDestroying
            // 
            this.QElementDestroying.AutoSize = true;
            this.QElementDestroying.Checked = true;
            this.QElementDestroying.CheckState = System.Windows.Forms.CheckState.Checked;
            this.QElementDestroying.Location = new System.Drawing.Point(174, 6);
            this.QElementDestroying.Name = "QElementDestroying";
            this.QElementDestroying.Size = new System.Drawing.Size(175, 17);
            this.QElementDestroying.TabIndex = 0;
            this.QElementDestroying.Text = "QueryElementControlDestroying";
            this.QElementDestroying.UseVisualStyleBackColor = true;
            // 
            // ValidateContextMenu
            // 
            this.ValidateContextMenu.AutoSize = true;
            this.ValidateContextMenu.Checked = true;
            this.ValidateContextMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ValidateContextMenu.Location = new System.Drawing.Point(355, 6);
            this.ValidateContextMenu.Name = "ValidateContextMenu";
            this.ValidateContextMenu.Size = new System.Drawing.Size(127, 17);
            this.ValidateContextMenu.TabIndex = 0;
            this.ValidateContextMenu.Text = "ValidateContextMenu";
            this.ValidateContextMenu.UseVisualStyleBackColor = true;
            // 
            // CustomizeDataSourceCaption
            // 
            this.CustomizeDataSourceCaption.AutoSize = true;
            this.CustomizeDataSourceCaption.Checked = true;
            this.CustomizeDataSourceCaption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CustomizeDataSourceCaption.Location = new System.Drawing.Point(488, 6);
            this.CustomizeDataSourceCaption.Name = "CustomizeDataSourceCaption";
            this.CustomizeDataSourceCaption.Size = new System.Drawing.Size(167, 17);
            this.CustomizeDataSourceCaption.TabIndex = 0;
            this.CustomizeDataSourceCaption.Text = "CustomizeDataSourceCaption";
            this.CustomizeDataSourceCaption.UseVisualStyleBackColor = true;
            // 
            // CustomizeDataSourceFieldList
            // 
            this.CustomizeDataSourceFieldList.AutoSize = true;
            this.CustomizeDataSourceFieldList.Checked = true;
            this.CustomizeDataSourceFieldList.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CustomizeDataSourceFieldList.Location = new System.Drawing.Point(661, 6);
            this.CustomizeDataSourceFieldList.Name = "CustomizeDataSourceFieldList";
            this.CustomizeDataSourceFieldList.Size = new System.Drawing.Size(169, 17);
            this.CustomizeDataSourceFieldList.TabIndex = 0;
            this.CustomizeDataSourceFieldList.Text = "CustomizeDataSourceFieldList";
            this.CustomizeDataSourceFieldList.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stop on:";
            // 
            // errorBox1
            // 
            this.errorBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.errorBox1.AutoSize = true;
            this.errorBox1.BackColor = System.Drawing.Color.LightPink;
            this.errorBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorBox1.CurrentSyntaxProvider = null;
            this.errorBox1.IsVisibleCheckSyntaxPanel = false;
            this.errorBox1.Location = new System.Drawing.Point(769, 54);
            this.errorBox1.Name = "errorBox1";
            this.errorBox1.Padding = new System.Windows.Forms.Padding(5);
            this.errorBox1.Size = new System.Drawing.Size(324, 61);
            this.errorBox1.TabIndex = 1;
            this.errorBox1.Visible = false;
            this.errorBox1.GoToErrorPosition += new System.EventHandler(this.ErrorBox1_GoToErrorPosition);
            this.errorBox1.RevertValidText += new System.EventHandler(this.ErrorBox1_RevertValidText);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 741);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Interface Customization demo";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QBuilder.SQLFormattingOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QBuilder.SQLGenerationOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QBuilder)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox TextBoxReport;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private ActiveQueryBuilder.View.WinForms.QueryBuilder QBuilder;
        private System.Windows.Forms.RichTextBox TextBoxSQL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox QElementCreated;
        private System.Windows.Forms.CheckBox QElementDestroying;
        private System.Windows.Forms.CheckBox ValidateContextMenu;
        private System.Windows.Forms.CheckBox CustomizeDataSourceCaption;
        private System.Windows.Forms.CheckBox CustomizeDataSourceFieldList;
        private System.Windows.Forms.Label label1;
        private GeneralAssembly.Common.SqlErrorBox errorBox1;
    }
}

