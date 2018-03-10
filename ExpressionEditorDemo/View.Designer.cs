namespace ExpressionEditorDemo
{
    partial class View
    {
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbFilterFunctions = new System.Windows.Forms.CheckBox();
            this.tbFilterForFunctions = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dockManager1 = new ActiveQueryBuilder.View.WinForms.DockPanels.DockManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dockPanelSqlContext = new ActiveQueryBuilder.View.WinForms.DockPanels.DockPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFunctions = new System.Windows.Forms.Panel();
            this.treeFunctions = new ExpressionEditorDemo.Common.TreeViewMod();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlObjects = new System.Windows.Forms.Panel();
            this.treeQueryObjects = new ActiveQueryBuilder.View.WinForms.DatabaseSchemaView.DatabaseSchemaView();
            this.pnlOperators = new System.Windows.Forms.FlowLayoutPanel();
            this.dockPanelDatabaseSchema = new ActiveQueryBuilder.View.WinForms.DockPanels.DockPanel();
            this.treeObjects = new ActiveQueryBuilder.View.WinForms.DatabaseSchemaView.DatabaseSchemaView();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockManager1.SuspendLayout();
            this.dockPanelSqlContext.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlFunctions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlObjects.SuspendLayout();
            this.dockPanelDatabaseSchema.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbFilterFunctions
            // 
            this.cbFilterFunctions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFilterFunctions.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbFilterFunctions.Image = global::ExpressionEditorDemo.Properties.Resources.filter;
            this.cbFilterFunctions.Location = new System.Drawing.Point(152, 3);
            this.cbFilterFunctions.Margin = new System.Windows.Forms.Padding(1, 3, 3, 1);
            this.cbFilterFunctions.Name = "cbFilterFunctions";
            this.cbFilterFunctions.Size = new System.Drawing.Size(21, 20);
            this.cbFilterFunctions.TabIndex = 7;
            this.toolTip1.SetToolTip(this.cbFilterFunctions, "Functions filtering on/off");
            this.cbFilterFunctions.UseVisualStyleBackColor = true;
            // 
            // tbFilterForFunctions
            // 
            this.tbFilterForFunctions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilterForFunctions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFilterForFunctions.Location = new System.Drawing.Point(22, 3);
            this.tbFilterForFunctions.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.tbFilterForFunctions.Name = "tbFilterForFunctions";
            this.tbFilterForFunctions.Size = new System.Drawing.Size(126, 20);
            this.tbFilterForFunctions.TabIndex = 6;
            this.toolTip1.SetToolTip(this.tbFilterForFunctions, "Functions filter and search pattern.\nPress F3 to search forward, Shift-F3 to sear" +
        "ch backward.");
            this.tbFilterForFunctions.TextChanged += new System.EventHandler(this.tbFilterForFunctions_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 457);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(738, 35);
            this.panel3.TabIndex = 5;
            // 
            // dockManager1
            // 
            this.dockManager1.ActiveDockPanelCaptionColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(157)))));
            this.dockManager1.ActiveDockPanelCaptionFontColor = System.Drawing.Color.Black;
            this.dockManager1.Controls.Add(this.panel1);
            this.dockManager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockManager1.DockPanels.AddRange(new ActiveQueryBuilder.View.WinForms.DockPanels.DockPanel[] {
            this.dockPanelSqlContext,
            this.dockPanelDatabaseSchema});
            this.dockManager1.DockTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.dockManager1.DockTabFontColor = System.Drawing.Color.White;
            this.dockManager1.DockTabFontHoverColor = System.Drawing.Color.White;
            this.dockManager1.DockTabHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.dockManager1.DockTabIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.dockManager1.DockTabIndicatorHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(167)))), ((int)(((byte)(183)))));
            this.dockManager1.InactiveDockPanelCaptionColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            this.dockManager1.InactiveDockPanelCaptionFontColor = System.Drawing.Color.White;
            this.dockManager1.Location = new System.Drawing.Point(0, 0);
            this.dockManager1.Name = "dockManager1";
            this.dockManager1.Size = new System.Drawing.Size(738, 457);
            this.dockManager1.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dockManager1.TabIndex = 4;
            this.dockManager1.TabsStripBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(215, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 457);
            this.panel1.TabIndex = 0;
            // 
            // dockPanelSqlContext
            // 
            this.dockPanelSqlContext.AutoHide = false;
            this.dockPanelSqlContext.Controls.Add(this.tableLayoutPanel1);
            this.dockPanelSqlContext.Docking = ActiveQueryBuilder.View.Docking.Left;
            this.dockPanelSqlContext.Location = new System.Drawing.Point(0, 0);
            this.dockPanelSqlContext.Name = "dockPanelSqlContext";
            this.dockPanelSqlContext.Size = new System.Drawing.Size(183, 457);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(182, 435);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // pnlFunctions
            // 
            this.pnlFunctions.Controls.Add(this.treeFunctions);
            this.pnlFunctions.Controls.Add(this.cbFilterFunctions);
            this.pnlFunctions.Controls.Add(this.pictureBox2);
            this.pnlFunctions.Controls.Add(this.tbFilterForFunctions);
            this.pnlFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFunctions.Location = new System.Drawing.Point(3, 242);
            this.pnlFunctions.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.pnlFunctions.Name = "pnlFunctions";
            this.pnlFunctions.Size = new System.Drawing.Size(176, 193);
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
            this.treeFunctions.Size = new System.Drawing.Size(170, 166);
            this.treeFunctions.TabIndex = 8;
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
            // pnlObjects
            // 
            this.pnlObjects.Controls.Add(this.treeQueryObjects);
            this.pnlObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlObjects.Location = new System.Drawing.Point(3, 3);
            this.pnlObjects.Name = "pnlObjects";
            this.pnlObjects.Size = new System.Drawing.Size(176, 233);
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
            this.treeQueryObjects.QueryView = null;
            this.treeQueryObjects.Size = new System.Drawing.Size(176, 233);
            this.treeQueryObjects.SQLContext = null;
            this.treeQueryObjects.TabIndex = 1;
            // 
            // pnlOperators
            // 
            this.pnlOperators.AutoSize = true;
            this.pnlOperators.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlOperators.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOperators.Location = new System.Drawing.Point(3, 239);
            this.pnlOperators.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.pnlOperators.Name = "pnlOperators";
            this.pnlOperators.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.pnlOperators.Size = new System.Drawing.Size(176, 1);
            this.pnlOperators.TabIndex = 9;
            // 
            // dockPanelDatabaseSchema
            // 
            this.dockPanelDatabaseSchema.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dockPanelDatabaseSchema.Controls.Add(this.treeObjects);
            this.dockPanelDatabaseSchema.Docking = ActiveQueryBuilder.View.Docking.Left;
            this.dockPanelDatabaseSchema.Location = new System.Drawing.Point(34, 0);
            this.dockPanelDatabaseSchema.Name = "dockPanelDatabaseSchema";
            this.dockPanelDatabaseSchema.Size = new System.Drawing.Size(200, 457);
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
            this.treeObjects.QueryView = null;
            this.treeObjects.Size = new System.Drawing.Size(196, 435);
            this.treeObjects.SQLContext = null;
            this.treeObjects.TabIndex = 0;
            // 
            // View
            // 
            this.AccessibleName = "ExpressionEditorForm";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dockManager1);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "View";
            this.Size = new System.Drawing.Size(738, 492);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockManager1.ResumeLayout(false);
            this.dockManager1.PerformLayout();
            this.dockPanelSqlContext.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlFunctions.ResumeLayout(false);
            this.pnlFunctions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlObjects.ResumeLayout(false);
            this.dockPanelDatabaseSchema.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlObjects;
        private System.Windows.Forms.Panel pnlFunctions;
        private Common.TreeViewMod treeFunctions;
        private System.Windows.Forms.CheckBox cbFilterFunctions;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbFilterForFunctions;
        private System.Windows.Forms.FlowLayoutPanel pnlOperators;
        private System.Windows.Forms.ToolTip toolTip1;
        private ActiveQueryBuilder.View.WinForms.DatabaseSchemaView.DatabaseSchemaView treeQueryObjects;
        private System.Windows.Forms.Panel panel1;
        private ActiveQueryBuilder.View.WinForms.DockPanels.DockManager dockManager1;
        private System.Windows.Forms.Panel panel3;
        private ActiveQueryBuilder.View.WinForms.DockPanels.DockPanel dockPanelSqlContext;
        private ActiveQueryBuilder.View.WinForms.DockPanels.DockPanel dockPanelDatabaseSchema;
        private ActiveQueryBuilder.View.WinForms.DatabaseSchemaView.DatabaseSchemaView treeObjects;
    }
}
