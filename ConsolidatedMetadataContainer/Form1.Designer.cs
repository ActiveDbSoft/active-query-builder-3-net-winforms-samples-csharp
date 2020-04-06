﻿namespace ConsolidatedMetadataContainer
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
            ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess linkPainterAccess1 = new ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.queryBuilder = new ActiveQueryBuilder.View.WinForms.QueryBuilder();
            this.syntaxProviderSql2003 = new ActiveQueryBuilder.Core.SQL2003SyntaxProvider(this.components);
            this.textSql = new System.Windows.Forms.TextBox();
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
            this.queryBuilder.DataSourceOptions.ColumnsOptions.NameColumnOptions.DrawOrder = 1;
            this.queryBuilder.DataSourceOptions.DefaultWidth = 210;
            this.queryBuilder.DesignPaneOptions.Background = System.Drawing.SystemColors.Window;
            linkPainterAccess1.LinkColor = System.Drawing.Color.Black;
            linkPainterAccess1.LinkColorFocused = System.Drawing.Color.Black;
            linkPainterAccess1.MarkColor = System.Drawing.SystemColors.Control;
            linkPainterAccess1.MarkColorFocused = System.Drawing.SystemColors.ControlDark;
            linkPainterAccess1.MarkStyle = ActiveQueryBuilder.View.QueryView.LinkMarkStyle.Access;
            this.queryBuilder.DesignPaneOptions.LinkPainterOptions = linkPainterAccess1;
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
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.AggregateColumn.Index = 5;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.AggregateColumn.Width = 90D;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.AliasColumn.Index = 2;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.AliasColumn.Width = 100D;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.ConditionTypeColumn.Index = 7;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.ConditionTypeColumn.Width = 140D;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaColumn.Index = 8;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaColumn.Width = 200D;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaOrColumns.Caption = null;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaOrColumns.Index = 0;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaOrColumns.Width = 60D;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.ExpressionColumn.Index = 1;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.ExpressionColumn.Width = 250D;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.GroupingColumn.Index = 6;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.GroupingColumn.Width = 100D;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.OutputColumn.Index = 0;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.OutputColumn.Width = 55D;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.SortOrderColumn.Index = 4;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.SortOrderColumn.Width = 100D;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.SortTypeColumn.Index = 3;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.SortTypeColumn.Width = 60D;
            this.queryBuilder.QueryColumnListOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.queryBuilder.QueryNavBarOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.queryBuilder.VisualOptions.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.queryBuilder.VisualOptions.TabsStripBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            // 
            // syntaxProviderSql2003
            // 
            this.syntaxProviderSql2003.DetectServerVersion = false;
            this.syntaxProviderSql2003.OnCalcExpressionType = null;
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
    }
}

