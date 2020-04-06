namespace ExpressionEditorDemo
{
    partial class ExpressionEditorControl
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
            this.components = new System.ComponentModel.Container();
            this.dockManager1 = new ActiveQueryBuilder.View.WinForms.DockPanels.DockManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sqlTextEditor1 = new ActiveQueryBuilder.View.WinForms.ExpressionEditor.SqlTextEditor();
            this.dockPanelSqlContext = new ActiveQueryBuilder.View.WinForms.DockPanels.DockPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFunctions = new System.Windows.Forms.Panel();
            this.treeFunctions = new ExpressionEditorDemo.Common.TreeViewMod();
            this.cbFilterFunctions = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbFilterForFunctions = new System.Windows.Forms.TextBox();
            this.pnlObjects = new System.Windows.Forms.Panel();
            this.treeQueryObjects = new ActiveQueryBuilder.View.WinForms.DatabaseSchemaView.DatabaseSchemaView();
            this.pnlOperators = new System.Windows.Forms.FlowLayoutPanel();
            this.dockPanelDatabaseSchema = new ActiveQueryBuilder.View.WinForms.DockPanels.DockPanel();
            this.treeObjects = new ActiveQueryBuilder.View.WinForms.DatabaseSchemaView.DatabaseSchemaView();
            this.pnlNotification = new GeneralAssembly.Common.InformationPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockManager1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.dockPanelSqlContext.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlFunctions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlObjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeQueryObjects)).BeginInit();
            this.dockPanelDatabaseSchema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeObjects)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.Controls.Add(this.panel1);
            this.dockManager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockManager1.DockPanels.AddRange(new ActiveQueryBuilder.View.WinForms.DockPanels.DockPanel[] {
            this.dockPanelSqlContext,
            this.dockPanelDatabaseSchema});
            this.dockManager1.Location = new System.Drawing.Point(0, 0);
            this.dockManager1.Margin = new System.Windows.Forms.Padding(0);
            this.dockManager1.Name = "dockManager1";
            this.dockManager1.Options.ActiveDockPanelCaptionColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(157)))));
            this.dockManager1.Options.ActiveDockPanelCaptionFontColor = System.Drawing.Color.Black;
            this.dockManager1.Options.DockTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.dockManager1.Options.DockTabFontColor = System.Drawing.Color.White;
            this.dockManager1.Options.DockTabFontHoverColor = System.Drawing.Color.White;
            this.dockManager1.Options.DockTabHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.dockManager1.Options.DockTabIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.dockManager1.Options.DockTabIndicatorHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(167)))), ((int)(((byte)(183)))));
            this.dockManager1.Options.InactiveDockPanelCaptionColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            this.dockManager1.Options.InactiveDockPanelCaptionFontColor = System.Drawing.Color.White;
            this.dockManager1.Options.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dockManager1.Options.TabsStripBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.dockManager1.Size = new System.Drawing.Size(764, 505);
            this.dockManager1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sqlTextEditor1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(232, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 505);
            this.panel1.TabIndex = 0;
            // 
            // sqlTextEditor1
            // 
            this.sqlTextEditor1.Options.AcceptTabs = false;
            this.sqlTextEditor1.ExpressionContext = null;
            this.sqlTextEditor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sqlTextEditor1.CaretOffset = 0;
            this.sqlTextEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqlTextEditor1.Location = new System.Drawing.Point(0, 0);
            this.sqlTextEditor1.Margin = new System.Windows.Forms.Padding(0);
            this.sqlTextEditor1.Name = "sqlTextEditor1";
            this.sqlTextEditor1.Options.Padding = new System.Windows.Forms.Padding(5);
            this.sqlTextEditor1.Query = null;
            this.sqlTextEditor1.QueryProvider = null;
            this.sqlTextEditor1.SelectedText = "";
            this.sqlTextEditor1.SelectionLength = 0;
            this.sqlTextEditor1.SelectionStart = 0;
            this.sqlTextEditor1.Size = new System.Drawing.Size(532, 505);
            this.sqlTextEditor1.SQLContext = null;
            this.sqlTextEditor1.SqlOptions.SuggestionWindowSize = new System.Drawing.Size(200, 200);
            this.sqlTextEditor1.TabIndex = 0;
            // 
            // dockPanelSqlContext
            // 
            this.dockPanelSqlContext.AutoHide = false;
            this.dockPanelSqlContext.Controls.Add(this.tableLayoutPanel1);
            this.dockPanelSqlContext.Docking = ActiveQueryBuilder.View.Docking.Left;
            this.dockPanelSqlContext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dockPanelSqlContext.Location = new System.Drawing.Point(0, 0);
            this.dockPanelSqlContext.Name = "dockPanelSqlContext";
            this.dockPanelSqlContext.Size = new System.Drawing.Size(200, 505);
            this.dockPanelSqlContext.TabIndex = 2;
            this.dockPanelSqlContext.TabStop = false;
            this.dockPanelSqlContext.Text = "Sql Context";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pnlFunctions, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pnlObjects, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlOperators, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 21);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(199, 483);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // pnlFunctions
            // 
            this.pnlFunctions.Controls.Add(this.treeFunctions);
            this.pnlFunctions.Controls.Add(this.cbFilterFunctions);
            this.pnlFunctions.Controls.Add(this.pictureBox2);
            this.pnlFunctions.Controls.Add(this.tbFilterForFunctions);
            this.pnlFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFunctions.Location = new System.Drawing.Point(3, 268);
            this.pnlFunctions.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.pnlFunctions.Name = "pnlFunctions";
            this.pnlFunctions.Size = new System.Drawing.Size(193, 215);
            this.pnlFunctions.TabIndex = 8;
            // 
            // treeFunctions
            // 
            this.treeFunctions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeFunctions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeFunctions.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.treeFunctions.FullRowSelect = true;
            this.treeFunctions.HideSelection = false;
            this.treeFunctions.Location = new System.Drawing.Point(3, 27);
            this.treeFunctions.Name = "treeFunctions";
            this.treeFunctions.ShowNodeToolTips = true;
            this.treeFunctions.ShowRootLines = false;
            this.treeFunctions.Size = new System.Drawing.Size(190, 183);
            this.treeFunctions.TabIndex = 8;
            // 
            // cbFilterFunctions
            // 
            this.cbFilterFunctions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFilterFunctions.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbFilterFunctions.Image = global::ExpressionEditorDemo.Properties.Resources.filter;
            this.cbFilterFunctions.Location = new System.Drawing.Point(172, 3);
            this.cbFilterFunctions.Margin = new System.Windows.Forms.Padding(1, 3, 3, 1);
            this.cbFilterFunctions.Name = "cbFilterFunctions";
            this.cbFilterFunctions.Size = new System.Drawing.Size(21, 20);
            this.cbFilterFunctions.TabIndex = 7;
            this.cbFilterFunctions.UseVisualStyleBackColor = true;
            this.cbFilterFunctions.CheckedChanged += new System.EventHandler(this.cbFilterFunctions_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ExpressionEditorDemo.Properties.Resources.find;
            this.pictureBox2.Location = new System.Drawing.Point(3, 6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 13);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // tbFilterForFunctions
            // 
            this.tbFilterForFunctions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilterForFunctions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFilterForFunctions.Location = new System.Drawing.Point(22, 3);
            this.tbFilterForFunctions.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.tbFilterForFunctions.Name = "tbFilterForFunctions";
            this.tbFilterForFunctions.Size = new System.Drawing.Size(146, 20);
            this.tbFilterForFunctions.TabIndex = 6;
            this.tbFilterForFunctions.TextChanged += new System.EventHandler(this.tbFilterForFunctions_TextChanged);
            // 
            // pnlObjects
            // 
            this.pnlObjects.Controls.Add(this.treeQueryObjects);
            this.pnlObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlObjects.Location = new System.Drawing.Point(3, 3);
            this.pnlObjects.Name = "pnlObjects";
            this.pnlObjects.Size = new System.Drawing.Size(193, 259);
            this.pnlObjects.TabIndex = 6;
            // 
            // treeQueryObjects
            // 
            this.treeQueryObjects.BackColor = System.Drawing.Color.White;
            this.treeQueryObjects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeQueryObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeQueryObjects.Location = new System.Drawing.Point(0, 0);
            this.treeQueryObjects.Margin = new System.Windows.Forms.Padding(0);
            this.treeQueryObjects.Name = "treeQueryObjects";
            this.treeQueryObjects.Options.DrawTreeLines = false;
            this.treeQueryObjects.Options.ImageList = null;
            this.treeQueryObjects.QueryView = null;
            this.treeQueryObjects.SelectedItems = new ActiveQueryBuilder.Core.MetadataStructureItem[0];
            this.treeQueryObjects.Size = new System.Drawing.Size(193, 259);
            this.treeQueryObjects.SQLContext = null;
            this.treeQueryObjects.TabIndex = 1;
            // 
            // pnlOperators
            // 
            this.pnlOperators.AutoSize = true;
            this.pnlOperators.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlOperators.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOperators.Location = new System.Drawing.Point(3, 265);
            this.pnlOperators.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.pnlOperators.Name = "pnlOperators";
            this.pnlOperators.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.pnlOperators.Size = new System.Drawing.Size(193, 1);
            this.pnlOperators.TabIndex = 9;
            // 
            // dockPanelDatabaseSchema
            // 
            this.dockPanelDatabaseSchema.Controls.Add(this.treeObjects);
            this.dockPanelDatabaseSchema.Docking = ActiveQueryBuilder.View.Docking.Left;
            this.dockPanelDatabaseSchema.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dockPanelDatabaseSchema.Location = new System.Drawing.Point(34, 0);
            this.dockPanelDatabaseSchema.Name = "dockPanelDatabaseSchema";
            this.dockPanelDatabaseSchema.Size = new System.Drawing.Size(200, 252);
            this.dockPanelDatabaseSchema.TabIndex = 4;
            this.dockPanelDatabaseSchema.TabStop = false;
            this.dockPanelDatabaseSchema.Text = "Database Schema";
            // 
            // treeObjects
            // 
            this.treeObjects.BackColor = System.Drawing.Color.White;
            this.treeObjects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeObjects.Location = new System.Drawing.Point(0, 21);
            this.treeObjects.Name = "treeObjects";
            this.treeObjects.Options.DrawTreeLines = false;
            this.treeObjects.Options.ImageList = null;
            this.treeObjects.QueryView = null;
            this.treeObjects.SelectedItems = new ActiveQueryBuilder.Core.MetadataStructureItem[0];
            this.treeObjects.Size = new System.Drawing.Size(199, 230);
            this.treeObjects.SQLContext = null;
            this.treeObjects.TabIndex = 0;
            // 
            // pnlNotification
            // 
            this.pnlNotification.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNotification.IconLocation = ActiveQueryBuilder.View.InfoIconLocation.Right;
            this.pnlNotification.InfoText = "";
            this.pnlNotification.Location = new System.Drawing.Point(0, 505);
            this.pnlNotification.Name = "pnlNotification";
            this.pnlNotification.ShowIcon = false;
            this.pnlNotification.Size = new System.Drawing.Size(764, 7);
            this.pnlNotification.TabIndex = 6;
            this.pnlNotification.Visible = false;
            // 
            // ExpressionEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dockManager1);
            this.Controls.Add(this.pnlNotification);
            this.Name = "ExpressionEditorControl";
            this.Size = new System.Drawing.Size(764, 512);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockManager1.ResumeLayout(false);
            this.dockManager1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.dockPanelSqlContext.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlFunctions.ResumeLayout(false);
            this.pnlFunctions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlObjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeQueryObjects)).EndInit();
            this.dockPanelDatabaseSchema.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeObjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlObjects;
        private System.Windows.Forms.Panel pnlFunctions;
        private ExpressionEditorDemo.Common.TreeViewMod treeFunctions;
        private System.Windows.Forms.CheckBox cbFilterFunctions;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbFilterForFunctions;
        private System.Windows.Forms.FlowLayoutPanel pnlOperators;
        private ActiveQueryBuilder.View.WinForms.DatabaseSchemaView.DatabaseSchemaView treeQueryObjects;
        private ActiveQueryBuilder.View.WinForms.DockPanels.DockManager dockManager1;
        private ActiveQueryBuilder.View.WinForms.DockPanels.DockPanel dockPanelSqlContext;
        private ActiveQueryBuilder.View.WinForms.DockPanels.DockPanel dockPanelDatabaseSchema;
        private ActiveQueryBuilder.View.WinForms.DatabaseSchemaView.DatabaseSchemaView treeObjects;
        private GeneralAssembly.Common.InformationPanel pnlNotification;
        private System.Windows.Forms.Panel panel1;
        private ActiveQueryBuilder.View.WinForms.ExpressionEditor.SqlTextEditor sqlTextEditor1;
    }
}
