namespace ConsolidatedMetadataContainer
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
            this.components = new System.ComponentModel.Container();
            ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess linkPainterAccess2 = new ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.queryBuilder = new ActiveQueryBuilder.View.WinForms.QueryBuilder();
            this.syntaxProviderSql2003 = new ActiveQueryBuilder.Core.SQL2003SyntaxProvider(this.components);
            this.textSql = new System.Windows.Forms.TextBox();
            this.buttonStats = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder.SQLFormattingOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder.SQLGenerationOptions)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.queryBuilder);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonStats);
            this.splitContainer1.Panel2.Controls.Add(this.textSql);
            this.splitContainer1.Size = new System.Drawing.Size(916, 490);
            this.splitContainer1.SplitterDistance = 329;
            this.splitContainer1.TabIndex = 0;
            // 
            // queryBuilder
            // 
            this.queryBuilder.AddObjectDialogOptions.Location = new System.Drawing.Point(0, 0);
            this.queryBuilder.AddObjectDialogOptions.Size = new System.Drawing.Size(430, 430);
            this.queryBuilder.AddObjectDialogOptions.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.queryBuilder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.queryBuilder.DatabaseSchemaViewOptions.AllowDrop = true;
            this.queryBuilder.DatabaseSchemaViewOptions.DrawTreeLines = false;
            this.queryBuilder.DatabaseSchemaViewOptions.ImageList = null;
            this.queryBuilder.DataSourceOptions.ColumnsOptions.InformationButtonsColumnOptions.Color = System.Drawing.Color.Black;
            this.queryBuilder.DataSourceOptions.ColumnsOptions.NameColumnOptions.DrawOrder = 1;
            this.queryBuilder.DataSourceOptions.DefaultWidth = 210;
            this.queryBuilder.DesignPaneOptions.Background = System.Drawing.SystemColors.Window;
            linkPainterAccess2.LinkColor = System.Drawing.Color.Black;
            linkPainterAccess2.LinkColorFocused = System.Drawing.Color.Black;
            linkPainterAccess2.MarkColor = System.Drawing.SystemColors.Control;
            linkPainterAccess2.MarkColorFocused = System.Drawing.SystemColors.ControlDark;
            linkPainterAccess2.MarkStyle = ActiveQueryBuilder.View.QueryView.LinkMarkStyle.Access;
            this.queryBuilder.DesignPaneOptions.LinkPainterOptions = linkPainterAccess2;
            this.queryBuilder.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess;
            this.queryBuilder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryBuilder.Location = new System.Drawing.Point(0, 0);
            this.queryBuilder.MetadataLoadingOptions.ExcludeFilter.Types = ActiveQueryBuilder.Core.MetadataType.None;
            this.queryBuilder.Name = "queryBuilder";
            this.queryBuilder.PanesConfigurationOptions.PropertiesBarDockOptions.AutoHide = true;
            this.queryBuilder.PanesConfigurationOptions.PropertiesBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Right;
            this.queryBuilder.PanesConfigurationOptions.PropertiesBarEnabled = true;
            this.queryBuilder.PanesConfigurationOptions.SubQueryNavBarDockOptions.AutoHide = true;
            this.queryBuilder.PanesConfigurationOptions.SubQueryNavBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Left;
            this.queryBuilder.PanesConfigurationOptions.SubQueryNavBarEnabled = true;
            this.queryBuilder.QueryColumnListOptions.AlternateRowColor = System.Drawing.SystemColors.Highlight;
            this.queryBuilder.QueryColumnListOptions.InitialOrColumnsCount = 2;
            this.queryBuilder.QueryColumnListOptions.NullOrderingInOrderBy = false;
            this.queryBuilder.QueryColumnListOptions.TextColor = System.Drawing.SystemColors.ControlText;
            this.queryBuilder.QueryColumnListOptions.UseCustomExpressionBuilder = ActiveQueryBuilder.View.QueryView.AffectedColumns.None;
            this.queryBuilder.QueryNavBarOptions.ActionButtonBackColor = System.Drawing.Color.Empty;
            this.queryBuilder.QueryNavBarOptions.ActionButtonBorderColor = System.Drawing.Color.Empty;
            this.queryBuilder.QueryNavBarOptions.ActiveSubQueryItemBackColor = System.Drawing.Color.Empty;
            this.queryBuilder.QueryNavBarOptions.ActiveSubQueryItemBorderColor = System.Drawing.Color.Empty;
            this.queryBuilder.QueryNavBarOptions.AddCteCircleColor = System.Drawing.Color.Empty;
            this.queryBuilder.QueryNavBarOptions.AddUnionSubQueryCircleColor = System.Drawing.Color.Empty;
            this.queryBuilder.QueryNavBarOptions.BreadcrumbsBackgroundColor = System.Drawing.Color.Empty;
            this.queryBuilder.QueryNavBarOptions.CTEButtonBaseColor = System.Drawing.Color.Green;
            this.queryBuilder.QueryNavBarOptions.DisableQueryNavigationBarPopup = false;
            this.queryBuilder.QueryNavBarOptions.DragIndicatorColor = System.Drawing.Color.Empty;
            this.queryBuilder.QueryNavBarOptions.DragIndicatorHoverColor = System.Drawing.Color.Empty;
            this.queryBuilder.QueryNavBarOptions.ForeColor = System.Drawing.Color.Empty;
            this.queryBuilder.QueryNavBarOptions.GraphLineColor = System.Drawing.Color.Empty;
            this.queryBuilder.QueryNavBarOptions.GroupBackColor = System.Drawing.Color.Empty;
            this.queryBuilder.QueryNavBarOptions.GroupTextColor = System.Drawing.Color.Empty;
            this.queryBuilder.QueryNavBarOptions.OverflowButtonBaseColor = System.Drawing.Color.DarkRed;
            this.queryBuilder.QueryNavBarOptions.RootQueryButtonBaseColor = System.Drawing.Color.Black;
            this.queryBuilder.QueryNavBarOptions.SubQueryButtonBaseColor = System.Drawing.Color.Blue;
            this.queryBuilder.QueryNavBarOptions.SubQueryItemBackColor = System.Drawing.Color.Empty;
            this.queryBuilder.QueryNavBarOptions.SubQueryItemBorderColor = System.Drawing.Color.Empty;
            this.queryBuilder.QueryNavBarOptions.SubQueryMarkerColor = System.Drawing.Color.Empty;
            this.queryBuilder.QueryNavBarOptions.SubQueryPopupBackColor = System.Drawing.Color.Empty;
            this.queryBuilder.QueryNavBarOptions.TextHoverColor = System.Drawing.Color.Empty;
            this.queryBuilder.Size = new System.Drawing.Size(916, 329);
            // 
            // 
            // 
            this.queryBuilder.SQLFormattingOptions.CTESubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.queryBuilder.SQLFormattingOptions.CTESubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.queryBuilder.SQLFormattingOptions.CTESubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.queryBuilder.SQLFormattingOptions.DerivedQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.queryBuilder.SQLFormattingOptions.DerivedQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.queryBuilder.SQLFormattingOptions.DerivedQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.queryBuilder.SQLFormattingOptions.DynamicIndents = false;
            this.queryBuilder.SQLFormattingOptions.DynamicRightMargin = false;
            this.queryBuilder.SQLFormattingOptions.ExpandVirtualFields = false;
            this.queryBuilder.SQLFormattingOptions.ExpandVirtualObjects = false;
            this.queryBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.queryBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.FromClauseFormat.NewLineAfterDatasource = false;
            this.queryBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.queryBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.MainPartsFromNewLine = false;
            this.queryBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.queryBuilder.SQLFormattingOptions.MainQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.queryBuilder.SQLFormattingOptions.MainQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.queryBuilder.SQLFormattingOptions.MainQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            // 
            // 
            // 
            this.queryBuilder.SQLGenerationOptions.ExpandVirtualFields = true;
            this.queryBuilder.SQLGenerationOptions.ExpandVirtualObjects = true;
            this.queryBuilder.SQLGenerationOptions.UseAltNames = false;
            this.queryBuilder.SyntaxProvider = this.syntaxProviderSql2003;
            this.queryBuilder.TabIndex = 0;
            this.queryBuilder.VisualOptions.ActiveDockPanelCaptionColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(157)))));
            this.queryBuilder.VisualOptions.ActiveDockPanelCaptionFontColor = System.Drawing.Color.Black;
            this.queryBuilder.VisualOptions.DockPanelBackColor = System.Drawing.Color.Empty;
            this.queryBuilder.VisualOptions.DockTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.queryBuilder.VisualOptions.DockTabFontColor = System.Drawing.Color.White;
            this.queryBuilder.VisualOptions.DockTabFontHoverColor = System.Drawing.Color.White;
            this.queryBuilder.VisualOptions.DockTabHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.queryBuilder.VisualOptions.DockTabIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.queryBuilder.VisualOptions.DockTabIndicatorHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(167)))), ((int)(((byte)(183)))));
            this.queryBuilder.VisualOptions.InactiveDockPanelCaptionColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            this.queryBuilder.VisualOptions.InactiveDockPanelCaptionFontColor = System.Drawing.Color.White;
            this.queryBuilder.VisualOptions.TabsStripBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            // 
            // syntaxProviderSql2003
            // 
            this.syntaxProviderSql2003.DetectServerVersion = false;
            // 
            // textSql
            // 
            this.textSql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textSql.Location = new System.Drawing.Point(0, 0);
            this.textSql.Multiline = true;
            this.textSql.Name = "textSql";
            this.textSql.Size = new System.Drawing.Size(916, 157);
            this.textSql.TabIndex = 0;
            // 
            // buttonStats
            // 
            this.buttonStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStats.Location = new System.Drawing.Point(755, 116);
            this.buttonStats.Name = "buttonStats";
            this.buttonStats.Size = new System.Drawing.Size(158, 38);
            this.buttonStats.TabIndex = 1;
            this.buttonStats.Text = "Show DataSource stats";
            this.buttonStats.UseVisualStyleBackColor = true;
            this.buttonStats.Click += new System.EventHandler(this.buttonStats_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 490);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder.SQLFormattingOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder.SQLGenerationOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private ActiveQueryBuilder.View.WinForms.QueryBuilder queryBuilder;
        private System.Windows.Forms.TextBox textSql;
        private ActiveQueryBuilder.Core.SQL2003SyntaxProvider syntaxProviderSql2003;
        private System.Windows.Forms.Button buttonStats;
    }
}

