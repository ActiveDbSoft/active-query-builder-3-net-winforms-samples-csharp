using System.Drawing;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View;
using ActiveQueryBuilder.View.WinForms.ExpressionEditor;

namespace FullFeaturedMdiDemo
{
    partial class ChildForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChildForm));
            ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess linkPainterAccess1 = new ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess();
            this.toolStripPanel1 = new System.Windows.Forms.ToolStripPanel();
            this.contextMenuStripForRichTextBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pageQueryBuilder = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.QView = new ActiveQueryBuilder.View.WinForms.QueryView.QueryView();
            this.addObjectDialog1 = new ActiveQueryBuilder.View.WinForms.QueryView.AddObjectDialog(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dockManager1 = new ActiveQueryBuilder.View.WinForms.DockPanels.DockManager();
            this.designPaneControl1 = new ActiveQueryBuilder.View.WinForms.QueryView.DesignPaneControl();
            this.dockPanelProperties = new ActiveQueryBuilder.View.WinForms.DockPanels.DockPanel();
            this.propertiesBar1 = new ActiveQueryBuilder.View.WinForms.QueryView.PropertiesBar();
            this.dockPanelSubquery = new ActiveQueryBuilder.View.WinForms.DockPanels.DockPanel();
            this.subQueryNavBar1 = new ActiveQueryBuilder.View.WinForms.NavigationBar.SubQueryNavBar();
            this.queryColumnListControl1 = new ActiveQueryBuilder.View.WinForms.QueryView.QueryColumnListControl();
            this.expressionEditor1 = new ActiveQueryBuilder.View.WinForms.ExpressionEditor.ExpressionEditor(this.components);
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelSleepMode = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPageSQL = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.errorBox1 = new GeneralAssembly.Common.SqlErrorBox();
            this.rtbQueryText = new ActiveQueryBuilder.View.WinForms.ExpressionEditor.SqlTextEditor();
            this.tabPageCurrentSubQuery = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.errorBoxCurrent = new GeneralAssembly.Common.SqlErrorBox();
            this.TextBoxCurrentSubQuerySql = new ActiveQueryBuilder.View.WinForms.ExpressionEditor.SqlTextEditor();
            this.tabPageFastResult = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.resultGrid2 = new GeneralAssembly.DataViewerControl.DataViewer();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.checkBoxAutoRefresh = new System.Windows.Forms.CheckBox();
            this.NavBar = new ActiveQueryBuilder.View.WinForms.NavigationBar.QueryNavigationBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbQueryProperties = new System.Windows.Forms.ToolStripButton();
            this.tsbAddObject = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAddDerivedTable = new System.Windows.Forms.ToolStripButton();
            this.tsbAddUnionSubquery = new System.Windows.Forms.ToolStripButton();
            this.tsbCopyUnionSubquery = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveInFile = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveNewUserQuery = new System.Windows.Forms.ToolStripButton();
            this.pageQueryResult = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonGenerateReport = new System.Windows.Forms.Button();
            this.buttonExportExcel = new System.Windows.Forms.Button();
            this.buttonExportCsv = new System.Windows.Forms.Button();
            this.buttonExportExcelFlexCel = new System.Windows.Forms.Button();
            this.resultGrid1 = new GeneralAssembly.DataViewerControl.DataViewer();
            this.CBuilder = new ActiveQueryBuilder.View.WinForms.CriteriaBuilder.CriteriaBuilder();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.contextMenuStripForRichTextBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.pageQueryBuilder.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QView.SQLGenerationOptions)).BeginInit();
            this.QView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockManager1.SuspendLayout();
            this.dockPanelProperties.SuspendLayout();
            this.dockPanelSubquery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queryColumnListControl1)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPageSQL.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPageCurrentSubQuery.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPageFastResult.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pageQueryResult.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripPanel1
            // 
            this.toolStripPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolStripPanel1.Location = new System.Drawing.Point(0, 0);
            this.toolStripPanel1.Name = "toolStripPanel1";
            this.toolStripPanel1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.toolStripPanel1.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStripPanel1.Size = new System.Drawing.Size(1006, 0);
            // 
            // contextMenuStripForRichTextBox
            // 
            this.contextMenuStripForRichTextBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUndo,
            this.tsmiRedo,
            this.toolStripSeparator3,
            this.tsmiCut,
            this.tsmiCopy,
            this.tsmiPaste,
            this.toolStripSeparator4,
            this.tsmiSelectAll});
            this.contextMenuStripForRichTextBox.Name = "contextMenuStripForRichTextBox";
            this.contextMenuStripForRichTextBox.Size = new System.Drawing.Size(145, 148);
            this.contextMenuStripForRichTextBox.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripForRichTextBox_Opening);
            // 
            // tsmiUndo
            // 
            this.tsmiUndo.Name = "tsmiUndo";
            this.tsmiUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.tsmiUndo.Size = new System.Drawing.Size(144, 22);
            this.tsmiUndo.Text = "&Undo";
            this.tsmiUndo.Click += new System.EventHandler(this.tsmiUndo_Click);
            // 
            // tsmiRedo
            // 
            this.tsmiRedo.Name = "tsmiRedo";
            this.tsmiRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.tsmiRedo.Size = new System.Drawing.Size(144, 22);
            this.tsmiRedo.Text = "&Redo";
            this.tsmiRedo.Click += new System.EventHandler(this.tsmiRedo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // tsmiCut
            // 
            this.tsmiCut.Image = global::FullFeaturedMdiDemo.Properties.Resources.cut;
            this.tsmiCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiCut.Name = "tsmiCut";
            this.tsmiCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmiCut.Size = new System.Drawing.Size(144, 22);
            this.tsmiCut.Text = "Cu&t";
            this.tsmiCut.Click += new System.EventHandler(this.tsmiCut_Click);
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Image = global::FullFeaturedMdiDemo.Properties.Resources.page_copy;
            this.tsmiCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmiCopy.Size = new System.Drawing.Size(144, 22);
            this.tsmiCopy.Text = "&Copy";
            this.tsmiCopy.Click += new System.EventHandler(this.tsmiCopy_Click);
            // 
            // tsmiPaste
            // 
            this.tsmiPaste.Image = global::FullFeaturedMdiDemo.Properties.Resources.page_paste;
            this.tsmiPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiPaste.Name = "tsmiPaste";
            this.tsmiPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsmiPaste.Size = new System.Drawing.Size(144, 22);
            this.tsmiPaste.Text = "&Paste";
            this.tsmiPaste.Click += new System.EventHandler(this.tsmiPaste_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // tsmiSelectAll
            // 
            this.tsmiSelectAll.Name = "tsmiSelectAll";
            this.tsmiSelectAll.Size = new System.Drawing.Size(144, 22);
            this.tsmiSelectAll.Text = "Select &All";
            this.tsmiSelectAll.Click += new System.EventHandler(this.tsmiSelectAll_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "table.ico");
            this.imageList2.Images.SetKeyName(1, "table_lightning.ico");
            this.imageList2.Images.SetKeyName(2, "table_gear.ico");
            this.imageList2.Images.SetKeyName(3, "table_sort.ico");
            this.imageList2.Images.SetKeyName(4, "folder.ico");
            this.imageList2.Images.SetKeyName(5, "table_multiple.ico");
            this.imageList2.Images.SetKeyName(6, "database.ico");
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "chart_organisation.ico");
            this.imageList3.Images.SetKeyName(1, "folder_table.ico");
            this.imageList3.Images.SetKeyName(2, "database_table.ico");
            this.imageList3.Images.SetKeyName(3, "folder_bullet_green.ico");
            this.imageList3.Images.SetKeyName(4, "bullet_green.ico");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pageQueryBuilder);
            this.tabControl1.Controls.Add(this.pageQueryResult);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.ItemSize = new System.Drawing.Size(97, 23);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1006, 584);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // pageQueryBuilder
            // 
            this.pageQueryBuilder.Controls.Add(this.panel1);
            this.pageQueryBuilder.ImageIndex = 0;
            this.pageQueryBuilder.Location = new System.Drawing.Point(4, 27);
            this.pageQueryBuilder.Name = "pageQueryBuilder";
            this.pageQueryBuilder.Padding = new System.Windows.Forms.Padding(3);
            this.pageQueryBuilder.Size = new System.Drawing.Size(998, 553);
            this.pageQueryBuilder.TabIndex = 0;
            this.pageQueryBuilder.Text = "Query Builder";
            this.pageQueryBuilder.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.NavBar);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 547);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 65);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.QView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel4);
            this.splitContainer1.Size = new System.Drawing.Size(992, 482);
            this.splitContainer1.SplitterDistance = 251;
            this.splitContainer1.TabIndex = 4;
            // 
            // QView
            // 
            this.QView.ActiveUnionSubQuery = null;
            this.QView.AddObjectDialog = this.addObjectDialog1;
            this.QView.Controls.Add(this.splitContainer2);
            this.QView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QView.ExpressionEditor = this.expressionEditor1;
            this.QView.Location = new System.Drawing.Point(0, 0);
            this.QView.Name = "QView";
            this.QView.Query = null;
            this.QView.Size = new System.Drawing.Size(992, 251);
            // 
            // 
            // 
            this.QView.SQLGenerationOptions.ExpandVirtualFields = false;
            this.QView.SQLGenerationOptions.ExpandVirtualObjects = false;
            this.QView.TabIndex = 6;
            this.QView.DataSourceAdding += new ActiveQueryBuilder.View.QueryView.DataSourceAddingEventHandler(this.QView_DataSourceAdding);
            // 
            // addObjectDialog1
            // 
            this.addObjectDialog1.Options.ImageIndices.DatabaseImageIndex = 0;
            this.addObjectDialog1.Options.ImageIndices.FieldImageIndex = 0;
            this.addObjectDialog1.Options.ImageIndices.FilterImageIndex = 0;
            this.addObjectDialog1.Options.ImageIndices.FolderImageIndex = 0;
            this.addObjectDialog1.Options.ImageIndices.ForeignKeyImageIndex = 0;
            this.addObjectDialog1.Options.ImageIndices.PackageImageIndex = 0;
            this.addObjectDialog1.Options.ImageIndices.ParameterImageIndex = 0;
            this.addObjectDialog1.Options.ImageIndices.PrimaryKeyImageIndex = 0;
            this.addObjectDialog1.Options.ImageIndices.ServerImageIndex = 0;
            this.addObjectDialog1.Options.ImageIndices.SystemProcedureImageIndex = 0;
            this.addObjectDialog1.Options.ImageIndices.SystemSynonymImageIndex = 0;
            this.addObjectDialog1.Options.ImageIndices.SystemTableImageIndex = 0;
            this.addObjectDialog1.Options.ImageIndices.SystemViewImageIndex = 0;
            this.addObjectDialog1.Options.ImageIndices.UserProcedureImageIndex = 0;
            this.addObjectDialog1.Options.ImageIndices.UserSynonymImageIndex = 0;
            this.addObjectDialog1.Options.ImageIndices.UserViewImageIndex = 0;
            this.addObjectDialog1.Options.ImageIndices.VirtualFieldImageIndex = 0;
            this.addObjectDialog1.Options.Location = new System.Drawing.Point(0, 0);
            this.addObjectDialog1.Options.Size = new System.Drawing.Size(430, 430);
            this.addObjectDialog1.Options.SortingType = ActiveQueryBuilder.View.DatabaseSchemaView.ObjectsSortingType.Name;
            this.addObjectDialog1.Options.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.addObjectDialog1.Options.StartWithDefaultNamespaceType = ActiveQueryBuilder.Core.MetadataType.Database;
            this.addObjectDialog1.Options.StartWithMetadataStructurePath = null;
            this.addObjectDialog1.QueryView = this.QView;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dockManager1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.queryColumnListControl1);
            this.splitContainer2.Size = new System.Drawing.Size(992, 251);
            this.splitContainer2.SplitterDistance = 178;
            this.splitContainer2.TabIndex = 0;
            // 
            // dockManager1
            // 
            this.dockManager1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dockManager1.Controls.Add(this.designPaneControl1);
            this.dockManager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockManager1.DockPanels.AddRange(new ActiveQueryBuilder.View.WinForms.DockPanels.DockPanel[] {
            this.dockPanelProperties,
            this.dockPanelSubquery});
            this.dockManager1.Location = new System.Drawing.Point(0, 0);
            this.dockManager1.Name = "dockManager1";
            this.dockManager1.Options.ActiveDockPanelCaptionColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(157)))));
            this.dockManager1.Options.ActiveDockPanelCaptionFontColor = System.Drawing.Color.Black;
            this.dockManager1.Options.DockPanelBackColor = System.Drawing.Color.Empty;
            this.dockManager1.Options.DockTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.dockManager1.Options.DockTabFontColor = System.Drawing.Color.White;
            this.dockManager1.Options.DockTabFontHoverColor = System.Drawing.Color.White;
            this.dockManager1.Options.DockTabHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.dockManager1.Options.DockTabIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.dockManager1.Options.DockTabIndicatorHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(167)))), ((int)(((byte)(183)))));
            this.dockManager1.Options.InactiveDockPanelCaptionColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            this.dockManager1.Options.InactiveDockPanelCaptionFontColor = System.Drawing.Color.White;
            this.dockManager1.Options.TabFont = null;
            this.dockManager1.Options.TabsStripBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.dockManager1.Size = new System.Drawing.Size(992, 178);
            this.dockManager1.TabIndex = 0;
            // 
            // designPaneControl1
            // 
            this.designPaneControl1.AllowDrop = true;
            this.designPaneControl1.AutoScroll = true;
            this.designPaneControl1.AutoScrollMargin = new System.Drawing.Size(20, 20);
            this.designPaneControl1.DataSourceOptions.ColumnsOptions.InformationButtonsColumnOptions.Color = System.Drawing.Color.Black;
            this.designPaneControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.designPaneControl1.Location = new System.Drawing.Point(34, 0);
            this.designPaneControl1.Name = "designPaneControl1";
            this.designPaneControl1.Options.Background = System.Drawing.SystemColors.Window;
            linkPainterAccess1.LinkColor = System.Drawing.Color.Black;
            linkPainterAccess1.LinkColorFocused = System.Drawing.Color.Black;
            linkPainterAccess1.MarkColor = System.Drawing.SystemColors.Control;
            linkPainterAccess1.MarkColorFocused = System.Drawing.SystemColors.ControlDark;
            linkPainterAccess1.MarkStyle = ActiveQueryBuilder.View.QueryView.LinkMarkStyle.Access;
            this.designPaneControl1.Options.LinkPainterOptions = linkPainterAccess1;
            this.designPaneControl1.Options.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess;
            this.designPaneControl1.Size = new System.Drawing.Size(753, 176);
            this.designPaneControl1.TabIndex = 1;
            // 
            // dockPanelProperties
            // 
            this.dockPanelProperties.AutoHide = false;
            this.dockPanelProperties.Controls.Add(this.propertiesBar1);
            this.dockPanelProperties.Docking = ActiveQueryBuilder.View.Docking.Right;
            this.dockPanelProperties.Location = new System.Drawing.Point(0, 0);
            this.dockPanelProperties.Name = "dockPanelProperties";
            this.dockPanelProperties.Size = new System.Drawing.Size(200, 176);
            this.dockPanelProperties.TabIndex = 2;
            this.dockPanelProperties.TabStop = false;
            this.dockPanelProperties.Text = "Properties";
            // 
            // propertiesBar1
            // 
            this.propertiesBar1.AutoScroll = true;
            this.propertiesBar1.BackColor = System.Drawing.SystemColors.Window;
            this.propertiesBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertiesBar1.InformationMessageHost = this.QView;
            this.propertiesBar1.Location = new System.Drawing.Point(0, 21);
            this.propertiesBar1.Name = "propertiesBar1";
            this.propertiesBar1.Size = new System.Drawing.Size(199, 154);
            this.propertiesBar1.TabIndex = 1;
            // 
            // dockPanelSubquery
            // 
            this.dockPanelSubquery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dockPanelSubquery.Controls.Add(this.subQueryNavBar1);
            this.dockPanelSubquery.Docking = ActiveQueryBuilder.View.Docking.Left;
            this.dockPanelSubquery.Location = new System.Drawing.Point(630, 0);
            this.dockPanelSubquery.Name = "dockPanelSubquery";
            this.dockPanelSubquery.Size = new System.Drawing.Size(200, 251);
            this.dockPanelSubquery.TabIndex = 3;
            this.dockPanelSubquery.TabStop = false;
            this.dockPanelSubquery.Text = "Sub-query structure";
            // 
            // subQueryNavBar1
            // 
            this.subQueryNavBar1.AutoScroll = true;
            this.subQueryNavBar1.BackColor = System.Drawing.SystemColors.Window;
            this.subQueryNavBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subQueryNavBar1.Location = new System.Drawing.Point(0, 21);
            this.subQueryNavBar1.Name = "subQueryNavBar1";
            this.subQueryNavBar1.Options.ActionButtonBackColor = System.Drawing.Color.Empty;
            this.subQueryNavBar1.Options.ActionButtonBorderColor = System.Drawing.Color.Empty;
            this.subQueryNavBar1.Options.ActiveSubQueryItemBackColor = System.Drawing.Color.Empty;
            this.subQueryNavBar1.Options.ActiveSubQueryItemBorderColor = System.Drawing.Color.Empty;
            this.subQueryNavBar1.Options.AddCteCircleColor = System.Drawing.Color.Empty;
            this.subQueryNavBar1.Options.AddUnionSubQueryCircleColor = System.Drawing.Color.Empty;
            this.subQueryNavBar1.Options.BreadcrumbsBackgroundColor = System.Drawing.Color.Empty;
            this.subQueryNavBar1.Options.CTEButtonBaseColor = System.Drawing.Color.Green;
            this.subQueryNavBar1.Options.DragIndicatorColor = System.Drawing.Color.Empty;
            this.subQueryNavBar1.Options.DragIndicatorHoverColor = System.Drawing.Color.Empty;
            this.subQueryNavBar1.Options.Font = null;
            this.subQueryNavBar1.Options.ForeColor = System.Drawing.Color.Empty;
            this.subQueryNavBar1.Options.GraphLineColor = System.Drawing.Color.Empty;
            this.subQueryNavBar1.Options.GroupBackColor = System.Drawing.Color.Empty;
            this.subQueryNavBar1.Options.GroupTextColor = System.Drawing.Color.Empty;
            this.subQueryNavBar1.Options.OverflowButtonBaseColor = System.Drawing.Color.DarkRed;
            this.subQueryNavBar1.Options.RootQueryButtonBaseColor = System.Drawing.Color.Black;
            this.subQueryNavBar1.Options.SubQueryButtonBaseColor = System.Drawing.Color.Blue;
            this.subQueryNavBar1.Options.SubQueryItemBackColor = System.Drawing.Color.Empty;
            this.subQueryNavBar1.Options.SubQueryItemBorderColor = System.Drawing.Color.Empty;
            this.subQueryNavBar1.Options.SubQueryMarkerColor = System.Drawing.Color.Empty;
            this.subQueryNavBar1.Options.TextHoverColor = System.Drawing.Color.Empty;
            this.subQueryNavBar1.Size = new System.Drawing.Size(196, 229);
            this.subQueryNavBar1.TabIndex = 1;
            // 
            // queryColumnListControl1
            // 
            this.queryColumnListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryColumnListControl1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.queryColumnListControl1.Location = new System.Drawing.Point(0, 0);
            this.queryColumnListControl1.Name = "queryColumnListControl1";
            this.queryColumnListControl1.Options.ColumnsOptions.AggregateColumn.Index = 0;
            this.queryColumnListControl1.Options.ColumnsOptions.AggregateColumn.Width = 90D;
            this.queryColumnListControl1.Options.ColumnsOptions.AliasColumn.Index = 2;
            this.queryColumnListControl1.Options.ColumnsOptions.AliasColumn.Width = 100D;
            this.queryColumnListControl1.Options.ColumnsOptions.ConditionTypeColumn.Index = 5;
            this.queryColumnListControl1.Options.ColumnsOptions.ConditionTypeColumn.Width = 140D;
            this.queryColumnListControl1.Options.ColumnsOptions.CriteriaColumn.Index = 6;
            this.queryColumnListControl1.Options.ColumnsOptions.CriteriaColumn.Width = 200D;
            this.queryColumnListControl1.Options.ColumnsOptions.CriteriaOrColumns.Index = 0;
            this.queryColumnListControl1.Options.ColumnsOptions.CriteriaOrColumns.Width = 60D;
            this.queryColumnListControl1.Options.ColumnsOptions.ExpressionColumn.Index = 1;
            this.queryColumnListControl1.Options.ColumnsOptions.ExpressionColumn.Width = 250D;
            this.queryColumnListControl1.Options.ColumnsOptions.GroupingAndAggregateColumn.Index = 4;
            this.queryColumnListControl1.Options.ColumnsOptions.GroupingAndAggregateColumn.Width = 140D;
            this.queryColumnListControl1.Options.ColumnsOptions.GroupingColumn.Index = 0;
            this.queryColumnListControl1.Options.ColumnsOptions.GroupingColumn.Width = 100D;
            this.queryColumnListControl1.Options.ColumnsOptions.OutputColumn.Index = 0;
            this.queryColumnListControl1.Options.ColumnsOptions.OutputColumn.Width = 55D;
            this.queryColumnListControl1.Options.ColumnsOptions.SortColumn.Index = 3;
            this.queryColumnListControl1.Options.ColumnsOptions.SortColumn.Width = 150D;
            this.queryColumnListControl1.Options.ColumnsOptions.SortOrderColumn.Index = 0;
            this.queryColumnListControl1.Options.ColumnsOptions.SortOrderColumn.Width = 100D;
            this.queryColumnListControl1.Options.ColumnsOptions.SortTypeColumn.Index = 0;
            this.queryColumnListControl1.Options.ColumnsOptions.SortTypeColumn.Width = 60D;
            this.queryColumnListControl1.Options.Font = null;
            this.queryColumnListControl1.Options.InitialOrColumnsCount = 2;
            this.queryColumnListControl1.Options.NullOrderingInOrderBy = false;
            this.queryColumnListControl1.Options.UseCustomExpressionBuilder = ActiveQueryBuilder.View.QueryView.AffectedColumns.None;
            this.queryColumnListControl1.SelectedItems = new int[0];
            this.queryColumnListControl1.Size = new System.Drawing.Size(992, 69);
            this.queryColumnListControl1.TabIndex = 0;
            // 
            // expressionEditor1
            // 
            this.expressionEditor1.BackColor = System.Drawing.Color.White;
            this.expressionEditor1.SQLFormattingOptions = null;
            this.expressionEditor1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.labelSleepMode, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tabControl2, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(992, 227);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // labelSleepMode
            // 
            this.labelSleepMode.AutoSize = true;
            this.labelSleepMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelSleepMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSleepMode.Location = new System.Drawing.Point(3, 0);
            this.labelSleepMode.Name = "labelSleepMode";
            this.labelSleepMode.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.labelSleepMode.Size = new System.Drawing.Size(986, 23);
            this.labelSleepMode.TabIndex = 3;
            this.labelSleepMode.Text = "Unsupported SQL statement. Visual Query Builder has been disabled. Either type a " +
    "SELECT statement or start building a query visually to turn this mode off";
            this.labelSleepMode.Visible = false;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPageSQL);
            this.tabControl2.Controls.Add(this.tabPageCurrentSubQuery);
            this.tabControl2.Controls.Add(this.tabPageFastResult);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 26);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(986, 198);
            this.tabControl2.TabIndex = 1;
            this.tabControl2.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl2_Selected);
            // 
            // tabPageSQL
            // 
            this.tabPageSQL.Controls.Add(this.tableLayoutPanel1);
            this.tabPageSQL.Location = new System.Drawing.Point(4, 22);
            this.tabPageSQL.Name = "tabPageSQL";
            this.tabPageSQL.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSQL.Size = new System.Drawing.Size(978, 172);
            this.tabPageSQL.TabIndex = 0;
            this.tabPageSQL.Text = "SQL Query Text";
            this.tabPageSQL.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(972, 166);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.errorBox1);
            this.panel4.Controls.Add(this.rtbQueryText);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(966, 160);
            this.panel4.TabIndex = 0;
            // 
            // errorBox1
            // 
            this.errorBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.errorBox1.AutoSize = true;
            this.errorBox1.BackColor = System.Drawing.Color.LightPink;
            this.errorBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorBox1.CurrentSyntaxProvider = null;
            this.errorBox1.IsVisibleCheckSyntaxPanel = false;
            this.errorBox1.Location = new System.Drawing.Point(662, 96);
            this.errorBox1.Name = "errorBox1";
            this.errorBox1.Padding = new System.Windows.Forms.Padding(5);
            this.errorBox1.Size = new System.Drawing.Size(290, 61);
            this.errorBox1.TabIndex = 3;
            this.errorBox1.Visible = false;
            this.errorBox1.GoToErrorPosition += new System.EventHandler(this.errorBox1_GoToErrorPosition);
            this.errorBox1.RevertValidText += new System.EventHandler(this.errorBox1_RevertValidText);
            // 
            // rtbQueryText
            // 
            this.rtbQueryText.AllowShowSuggestionByMouse = false;
            this.rtbQueryText.BackColor = System.Drawing.SystemColors.Window;
            this.rtbQueryText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbQueryText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbQueryText.Location = new System.Drawing.Point(0, 0);
            this.rtbQueryText.Margin = new System.Windows.Forms.Padding(4);
            this.rtbQueryText.Name = "rtbQueryText";
            this.rtbQueryText.Options.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.rtbQueryText.QueryProvider = null;
            this.rtbQueryText.Size = new System.Drawing.Size(966, 160);
            this.rtbQueryText.SQLContext = null;
            this.rtbQueryText.SqlOptions.ShowSuggestionAfterCharCount = 0;
            this.rtbQueryText.SqlOptions.SuggestionWindowSize = new System.Drawing.Size(200, 200);
            this.rtbQueryText.TabIndex = 2;
            this.rtbQueryText.Validating += new System.ComponentModel.CancelEventHandler(this.rtbQueryText_Validating);
            // 
            // tabPageCurrentSubQuery
            // 
            this.tabPageCurrentSubQuery.Controls.Add(this.tableLayoutPanel2);
            this.tabPageCurrentSubQuery.Location = new System.Drawing.Point(4, 22);
            this.tabPageCurrentSubQuery.Name = "tabPageCurrentSubQuery";
            this.tabPageCurrentSubQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCurrentSubQuery.Size = new System.Drawing.Size(978, 172);
            this.tabPageCurrentSubQuery.TabIndex = 1;
            this.tabPageCurrentSubQuery.Text = "Current SubQuery Text";
            this.tabPageCurrentSubQuery.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(972, 166);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.errorBoxCurrent);
            this.panel3.Controls.Add(this.TextBoxCurrentSubQuerySql);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(966, 160);
            this.panel3.TabIndex = 3;
            // 
            // errorBoxCurrent
            // 
            this.errorBoxCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.errorBoxCurrent.AutoSize = true;
            this.errorBoxCurrent.BackColor = System.Drawing.Color.LightPink;
            this.errorBoxCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorBoxCurrent.CurrentSyntaxProvider = null;
            this.errorBoxCurrent.IsVisibleCheckSyntaxPanel = false;
            this.errorBoxCurrent.Location = new System.Drawing.Point(618, 96);
            this.errorBoxCurrent.Name = "errorBoxCurrent";
            this.errorBoxCurrent.Padding = new System.Windows.Forms.Padding(5);
            this.errorBoxCurrent.Size = new System.Drawing.Size(334, 61);
            this.errorBoxCurrent.TabIndex = 2;
            this.errorBoxCurrent.Visible = false;
            this.errorBoxCurrent.GoToErrorPosition += new System.EventHandler(this.errorBoxCurrent_GoToErrorPosition);
            this.errorBoxCurrent.RevertValidText += new System.EventHandler(this.errorBoxCurrent_RevertValidText);
            // 
            // TextBoxCurrentSubQuerySql
            // 
            this.TextBoxCurrentSubQuerySql.AllowShowSuggestionByMouse = false;
            this.TextBoxCurrentSubQuerySql.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxCurrentSubQuerySql.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxCurrentSubQuerySql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxCurrentSubQuerySql.Location = new System.Drawing.Point(0, 0);
            this.TextBoxCurrentSubQuerySql.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxCurrentSubQuerySql.Name = "TextBoxCurrentSubQuerySql";
            this.TextBoxCurrentSubQuerySql.Options.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.TextBoxCurrentSubQuerySql.QueryProvider = null;
            this.TextBoxCurrentSubQuerySql.Size = new System.Drawing.Size(966, 160);
            this.TextBoxCurrentSubQuerySql.SQLContext = null;
            this.TextBoxCurrentSubQuerySql.SqlOptions.ShowSuggestionAfterCharCount = 0;
            this.TextBoxCurrentSubQuerySql.SqlOptions.SuggestionWindowSize = new System.Drawing.Size(200, 200);
            this.TextBoxCurrentSubQuerySql.TabIndex = 0;
            this.TextBoxCurrentSubQuerySql.TextChanged += new System.EventHandler(this.TextBoxCurrentSubQuerySql_TextChanged);
            this.TextBoxCurrentSubQuerySql.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxCurrentSubQuerySql_Validating);
            // 
            // tabPageFastResult
            // 
            this.tabPageFastResult.Controls.Add(this.tableLayoutPanel3);
            this.tabPageFastResult.Location = new System.Drawing.Point(4, 22);
            this.tabPageFastResult.Name = "tabPageFastResult";
            this.tabPageFastResult.Size = new System.Drawing.Size(978, 172);
            this.tabPageFastResult.TabIndex = 2;
            this.tabPageFastResult.Text = "Current SubQuery Results Preview";
            this.tabPageFastResult.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(978, 172);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(972, 166);
            this.panel2.TabIndex = 3;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.resultGrid2, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(972, 166);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // resultGrid2
            // 
            this.resultGrid2.AutoSize = true;
            this.resultGrid2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultGrid2.EnabledSorting = false;
            this.resultGrid2.IsVisiblePaginationPanel = false;
            this.resultGrid2.Location = new System.Drawing.Point(3, 35);
            this.resultGrid2.Name = "resultGrid2";
            this.resultGrid2.QueryTransformer = null;
            this.resultGrid2.Size = new System.Drawing.Size(966, 128);
            this.resultGrid2.SqlQuery = null;
            this.resultGrid2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.buttonRefresh);
            this.panel5.Controls.Add(this.checkBoxAutoRefresh);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(966, 26);
            this.panel5.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(241, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "First 10 records of the current subquery resultset";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRefresh.Location = new System.Drawing.Point(872, 0);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(94, 23);
            this.buttonRefresh.TabIndex = 10;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // checkBoxAutoRefresh
            // 
            this.checkBoxAutoRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAutoRefresh.AutoSize = true;
            this.checkBoxAutoRefresh.Checked = true;
            this.checkBoxAutoRefresh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoRefresh.Location = new System.Drawing.Point(738, 4);
            this.checkBoxAutoRefresh.Name = "checkBoxAutoRefresh";
            this.checkBoxAutoRefresh.Size = new System.Drawing.Size(123, 17);
            this.checkBoxAutoRefresh.TabIndex = 11;
            this.checkBoxAutoRefresh.Text = "Auto-refresh preview";
            this.checkBoxAutoRefresh.UseVisualStyleBackColor = true;
            this.checkBoxAutoRefresh.CheckedChanged += new System.EventHandler(this.checkBoxAutoRefresh_CheckedChanged);
            // 
            // NavBar
            // 
            this.NavBar.AutoSize = true;
            this.NavBar.BackColor = System.Drawing.SystemColors.Control;
            this.NavBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavBar.Location = new System.Drawing.Point(0, 25);
            this.NavBar.Name = "NavBar";
            this.NavBar.Options.ActionButtonBackColor = System.Drawing.Color.Empty;
            this.NavBar.Options.ActionButtonBorderColor = System.Drawing.Color.Empty;
            this.NavBar.Options.ActiveSubQueryItemBackColor = System.Drawing.Color.Empty;
            this.NavBar.Options.ActiveSubQueryItemBorderColor = System.Drawing.Color.Empty;
            this.NavBar.Options.AddCteCircleColor = System.Drawing.Color.Empty;
            this.NavBar.Options.AddUnionSubQueryCircleColor = System.Drawing.Color.Empty;
            this.NavBar.Options.BreadcrumbsBackgroundColor = System.Drawing.Color.Empty;
            this.NavBar.Options.CTEButtonBaseColor = System.Drawing.Color.Green;
            this.NavBar.Options.DisableQueryNavigationBarPopup = false;
            this.NavBar.Options.DragIndicatorColor = System.Drawing.Color.Empty;
            this.NavBar.Options.DragIndicatorHoverColor = System.Drawing.Color.Empty;
            this.NavBar.Options.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.NavBar.Options.ForeColor = System.Drawing.Color.Empty;
            this.NavBar.Options.GraphLineColor = System.Drawing.Color.Empty;
            this.NavBar.Options.GroupBackColor = System.Drawing.Color.Empty;
            this.NavBar.Options.GroupTextColor = System.Drawing.Color.Empty;
            this.NavBar.Options.OverflowButtonBaseColor = System.Drawing.Color.DarkRed;
            this.NavBar.Options.RootQueryButtonBaseColor = System.Drawing.Color.Black;
            this.NavBar.Options.SubQueryButtonBaseColor = System.Drawing.Color.Blue;
            this.NavBar.Options.SubQueryItemBackColor = System.Drawing.Color.Empty;
            this.NavBar.Options.SubQueryItemBorderColor = System.Drawing.Color.Empty;
            this.NavBar.Options.SubQueryMarkerColor = System.Drawing.Color.Empty;
            this.NavBar.Options.SubQueryPopupBackColor = System.Drawing.Color.Empty;
            this.NavBar.Options.TextHoverColor = System.Drawing.Color.Empty;
            this.NavBar.Query = null;
            this.NavBar.QueryView = null;
            this.NavBar.Size = new System.Drawing.Size(992, 40);
            this.NavBar.TabIndex = 3;
            this.NavBar.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbQueryProperties,
            this.tsbAddObject,
            this.toolStripSeparator5,
            this.tsbAddDerivedTable,
            this.tsbAddUnionSubquery,
            this.tsbCopyUnionSubquery,
            this.toolStripSeparator1,
            this.tsbSave,
            this.tsbSaveInFile,
            this.tsbSaveNewUserQuery});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(992, 25);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 2;
            // 
            // tsbQueryProperties
            // 
            this.tsbQueryProperties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbQueryProperties.Image = global::FullFeaturedMdiDemo.Properties.Resources.query_properties;
            this.tsbQueryProperties.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQueryProperties.Name = "tsbQueryProperties";
            this.tsbQueryProperties.Size = new System.Drawing.Size(23, 22);
            this.tsbQueryProperties.Text = "Properties";
            this.tsbQueryProperties.Click += new System.EventHandler(this.tsbQueryProperties_Click);
            // 
            // tsbAddObject
            // 
            this.tsbAddObject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddObject.Image = global::FullFeaturedMdiDemo.Properties.Resources.new_object;
            this.tsbAddObject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddObject.Name = "tsbAddObject";
            this.tsbAddObject.Size = new System.Drawing.Size(23, 22);
            this.tsbAddObject.Text = "Add Object";
            this.tsbAddObject.Click += new System.EventHandler(this.tsbAddObject_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAddDerivedTable
            // 
            this.tsbAddDerivedTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddDerivedTable.Image = global::FullFeaturedMdiDemo.Properties.Resources.add_derived_table;
            this.tsbAddDerivedTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddDerivedTable.Name = "tsbAddDerivedTable";
            this.tsbAddDerivedTable.Size = new System.Drawing.Size(23, 22);
            this.tsbAddDerivedTable.Text = "Add Derived Table";
            this.tsbAddDerivedTable.Click += new System.EventHandler(this.tsbAddDerivedTable_Click);
            // 
            // tsbAddUnionSubquery
            // 
            this.tsbAddUnionSubquery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddUnionSubquery.Image = global::FullFeaturedMdiDemo.Properties.Resources.add_union_subquery;
            this.tsbAddUnionSubquery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddUnionSubquery.Name = "tsbAddUnionSubquery";
            this.tsbAddUnionSubquery.Size = new System.Drawing.Size(23, 22);
            this.tsbAddUnionSubquery.Text = "New union sub-query";
            this.tsbAddUnionSubquery.Click += new System.EventHandler(this.tsbAddUnionSubquery_Click);
            // 
            // tsbCopyUnionSubquery
            // 
            this.tsbCopyUnionSubquery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCopyUnionSubquery.Image = global::FullFeaturedMdiDemo.Properties.Resources.copy_union_subquery;
            this.tsbCopyUnionSubquery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCopyUnionSubquery.Name = "tsbCopyUnionSubquery";
            this.tsbCopyUnionSubquery.Size = new System.Drawing.Size(23, 22);
            this.tsbCopyUnionSubquery.Text = "Copy Union Sub-query";
            this.tsbCopyUnionSubquery.Click += new System.EventHandler(this.tsbCopyUnionSubquery_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = global::FullFeaturedMdiDemo.Properties.Resources.disk;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 22);
            this.tsbSave.Text = "Save the current query";
            this.tsbSave.ToolTipText = "Save the current query";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbSaveInFile
            // 
            this.tsbSaveInFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSaveInFile.Image = global::FullFeaturedMdiDemo.Properties.Resources.drive_disk;
            this.tsbSaveInFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveInFile.Name = "tsbSaveInFile";
            this.tsbSaveInFile.Size = new System.Drawing.Size(23, 22);
            this.tsbSaveInFile.Text = "Save query to file as...";
            this.tsbSaveInFile.Click += new System.EventHandler(this.tsbSaveInFile_Click);
            // 
            // tsbSaveNewUserQuery
            // 
            this.tsbSaveNewUserQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSaveNewUserQuery.Image = global::FullFeaturedMdiDemo.Properties.Resources.database_save;
            this.tsbSaveNewUserQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveNewUserQuery.Name = "tsbSaveNewUserQuery";
            this.tsbSaveNewUserQuery.Size = new System.Drawing.Size(23, 22);
            this.tsbSaveNewUserQuery.Text = "Save query into connection as...";
            this.tsbSaveNewUserQuery.Click += new System.EventHandler(this.tsbSaveNewUserQuery_Click);
            // 
            // pageQueryResult
            // 
            this.pageQueryResult.Controls.Add(this.resultGrid1);
            this.pageQueryResult.Controls.Add(this.tableLayoutPanel5);
            this.pageQueryResult.Controls.Add(this.CBuilder);
            this.pageQueryResult.Controls.Add(this.richTextBox1);
            this.pageQueryResult.ImageIndex = 1;
            this.pageQueryResult.Location = new System.Drawing.Point(4, 27);
            this.pageQueryResult.Name = "pageQueryResult";
            this.pageQueryResult.Padding = new System.Windows.Forms.Padding(3);
            this.pageQueryResult.Size = new System.Drawing.Size(998, 553);
            this.pageQueryResult.TabIndex = 1;
            this.pageQueryResult.Text = "Query Result";
            this.pageQueryResult.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.LightGray;
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Controls.Add(this.buttonGenerateReport, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.buttonExportExcel, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.buttonExportCsv, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.buttonExportExcelFlexCel, 3, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 421);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(992, 37);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // buttonGenerateReport
            // 
            this.buttonGenerateReport.AutoSize = true;
            this.buttonGenerateReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGenerateReport.Enabled = false;
            this.buttonGenerateReport.Location = new System.Drawing.Point(3, 3);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(242, 31);
            this.buttonGenerateReport.TabIndex = 0;
            this.buttonGenerateReport.Text = "Generate report";
            this.buttonGenerateReport.UseVisualStyleBackColor = true;
            this.buttonGenerateReport.Click += new System.EventHandler(this.buttonGenerateReport_Click);
            // 
            // buttonExportExcel
            // 
            this.buttonExportExcel.AutoSize = true;
            this.buttonExportExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExportExcel.Enabled = false;
            this.buttonExportExcel.Location = new System.Drawing.Point(251, 3);
            this.buttonExportExcel.Name = "buttonExportExcel";
            this.buttonExportExcel.Size = new System.Drawing.Size(242, 31);
            this.buttonExportExcel.TabIndex = 1;
            this.buttonExportExcel.Text = "Export to Excel (NPOI)";
            this.buttonExportExcel.UseVisualStyleBackColor = true;
            this.buttonExportExcel.Click += new System.EventHandler(this.buttonExportExcel_Click);
            // 
            // buttonExportCsv
            // 
            this.buttonExportCsv.AutoSize = true;
            this.buttonExportCsv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExportCsv.Enabled = false;
            this.buttonExportCsv.Location = new System.Drawing.Point(499, 3);
            this.buttonExportCsv.Name = "buttonExportCsv";
            this.buttonExportCsv.Size = new System.Drawing.Size(242, 31);
            this.buttonExportCsv.TabIndex = 2;
            this.buttonExportCsv.Text = "Export to CSV";
            this.buttonExportCsv.UseVisualStyleBackColor = true;
            this.buttonExportCsv.Click += new System.EventHandler(this.buttonExportCsv_Click);
            // 
            // buttonExportExcelFlexCel
            // 
            this.buttonExportExcelFlexCel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExportExcelFlexCel.Location = new System.Drawing.Point(747, 3);
            this.buttonExportExcelFlexCel.Name = "buttonExportExcelFlexCel";
            this.buttonExportExcelFlexCel.Size = new System.Drawing.Size(242, 31);
            this.buttonExportExcelFlexCel.TabIndex = 3;
            this.buttonExportExcelFlexCel.Text = "Export to Excel (FlexCel)";
            this.buttonExportExcelFlexCel.UseVisualStyleBackColor = true;
            this.buttonExportExcelFlexCel.Click += new System.EventHandler(this.buttonExportExcelFlexCel_Click);
            // 
            // resultGrid1
            // 
            this.resultGrid1.AutoSize = true;
            this.resultGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultGrid1.IsVisiblePaginationPanel = true;
            this.resultGrid1.Location = new System.Drawing.Point(3, 54);
            this.resultGrid1.Name = "resultGrid1";
            this.resultGrid1.QueryTransformer = null;
            this.resultGrid1.Size = new System.Drawing.Size(992, 367);
            this.resultGrid1.SqlQuery = null;
            this.resultGrid1.TabIndex = 4;
            // 
            // CBuilder
            // 
            this.CBuilder.AutoSize = true;
            this.CBuilder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CBuilder.Dock = System.Windows.Forms.DockStyle.Top;
            this.CBuilder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.CBuilder.Location = new System.Drawing.Point(3, 3);
            this.CBuilder.MinimumSize = new System.Drawing.Size(188, 51);
            this.CBuilder.Name = "CBuilder";
            this.CBuilder.QueryTransformer = null;
            this.CBuilder.RootItemFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.CBuilder.RootJunctionPrefix = null;
            this.CBuilder.Size = new System.Drawing.Size(992, 51);
            this.CBuilder.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox1.Location = new System.Drawing.Point(3, 458);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(992, 92);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "SQL";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "bricks.ico");
            this.imageList1.Images.SetKeyName(1, "database_go.ico");
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 584);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(1006, 22);
            this.statusStrip1.TabIndex = 5;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(146, 17);
            this.toolStripStatusLabel1.Text = "Query builder state: Active";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.Location = new System.Drawing.Point(130, 3);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(866, 25);
            this.miniToolStrip.Stretch = true;
            this.miniToolStrip.TabIndex = 0;
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 606);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStripPanel1);
            this.Controls.Add(this.statusStrip1);
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "ChildForm";
            this.Text = "ChildForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChildForm_FormClosing);
            this.contextMenuStripForRichTextBox.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.pageQueryBuilder.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QView.SQLGenerationOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QView)).EndInit();
            this.QView.ResumeLayout(false);
            this.QView.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockManager1.ResumeLayout(false);
            this.dockManager1.PerformLayout();
            this.dockPanelProperties.ResumeLayout(false);
            this.dockPanelSubquery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.queryColumnListControl1)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPageSQL.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPageCurrentSubQuery.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPageFastResult.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pageQueryResult.ResumeLayout(false);
            this.pageQueryResult.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripPanel toolStripPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pageQueryResult;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripForRichTextBox;
        private System.Windows.Forms.ToolStripMenuItem tsmiUndo;
        private System.Windows.Forms.ToolStripMenuItem tsmiRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiCut;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectAll;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabPage pageQueryBuilder;
        private ActiveQueryBuilder.View.WinForms.CriteriaBuilder.CriteriaBuilder CBuilder;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private ActiveQueryBuilder.View.WinForms.ExpressionEditor.ExpressionEditor expressionEditor1;
        private System.Windows.Forms.Panel panel1;
        private ActiveQueryBuilder.View.WinForms.NavigationBar.QueryNavigationBar NavBar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbQueryProperties;
        private System.Windows.Forms.ToolStripButton tsbAddObject;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbAddDerivedTable;
        private System.Windows.Forms.ToolStripButton tsbAddUnionSubquery;
        private System.Windows.Forms.ToolStripButton tsbCopyUnionSubquery;
        private System.Windows.Forms.ToolStrip miniToolStrip;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private ActiveQueryBuilder.View.WinForms.QueryView.QueryView QView;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private ActiveQueryBuilder.View.WinForms.DockPanels.DockManager dockManager1;
        private ActiveQueryBuilder.View.WinForms.QueryView.DesignPaneControl designPaneControl1;
        private ActiveQueryBuilder.View.WinForms.DockPanels.DockPanel dockPanelProperties;
        private ActiveQueryBuilder.View.WinForms.QueryView.PropertiesBar propertiesBar1;
        private ActiveQueryBuilder.View.WinForms.QueryView.QueryColumnListControl queryColumnListControl1;
        private ActiveQueryBuilder.View.WinForms.QueryView.AddObjectDialog addObjectDialog1;
        private ActiveQueryBuilder.View.WinForms.DockPanels.DockPanel dockPanelSubquery;
        private ActiveQueryBuilder.View.WinForms.NavigationBar.SubQueryNavBar subQueryNavBar1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbSaveInFile;
        private System.Windows.Forms.ToolStripButton tsbSaveNewUserQuery;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPageSQL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage tabPageCurrentSubQuery;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private SqlTextEditor TextBoxCurrentSubQuerySql;
        private System.Windows.Forms.TabPage tabPageFastResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label labelSleepMode;
        private GeneralAssembly.DataViewerControl.DataViewer resultGrid2;
        private GeneralAssembly.DataViewerControl.DataViewer resultGrid1;
        private System.Windows.Forms.Panel panel4;
        private SqlTextEditor rtbQueryText;
        private GeneralAssembly.Common.SqlErrorBox errorBox1;
        private GeneralAssembly.Common.SqlErrorBox errorBoxCurrent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.Button buttonExportExcel;
        private System.Windows.Forms.Button buttonExportCsv;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.CheckBox checkBoxAutoRefresh;
        private System.Windows.Forms.Button buttonExportExcelFlexCel;
    }
}
