using System.Windows.Forms;

namespace MetadataEditorDemo.Common
{
	public sealed partial class MetadataEditorControl
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
            this.menuMetadata = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miAddLinkedServer = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddSchema = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddPackage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.miAddTable = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddView = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddProcedure = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddSynonym = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.miAddField = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddForeignKey = new System.Windows.Forms.ToolStripMenuItem();
            this.tsddbAdd = new System.Windows.Forms.ToolStripDropDownButton();
            this.splitContainerOuter = new SplitContainerWithButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.treeDatabaseSchema = new ActiveQueryBuilder.View.WinForms.DatabaseSchemaView.DatabaseSchemaView();
            this.menuSchemaTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiConnectAndLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.miLoadAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteSchema = new System.Windows.Forms.ToolStripMenuItem();
            this.miClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAddLinkedServer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddSchema = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddPackage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddTable = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddProcedure = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddSynonym = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddField = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddForeignKey = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSortContainer = new System.Windows.Forms.ToolStripMenuItem();
            this.byNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMoveToTopContainer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMoveToBotContainer = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbMetadataLoadAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbMetadataDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainerInner = new System.Windows.Forms.SplitContainer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.treeStructure = new ActiveQueryBuilder.View.WinForms.DatabaseSchemaView.DatabaseSchemaView();
            this.menuStructureTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddStructureItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteStructureItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miStructureLoadAll = new System.Windows.Forms.ToolStripMenuItem();
            this.miStructureClear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSortStructure = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSortStructureByName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSortStructureByType = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMoveStructureToTop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMoveStructureToBot = new System.Windows.Forms.ToolStripMenuItem();
            this.panel8 = new System.Windows.Forms.Panel();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.tsbStructureAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbStructureDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.miFillFromSchema = new System.Windows.Forms.ToolStripButton();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.propertiesBar = new ActiveQueryBuilder.View.WinForms.QueryView.PropertiesBar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.popupFillStructure = new System.Windows.Forms.Panel();
            this.lbWarningFillStructure = new System.Windows.Forms.Label();
            this.btnCancelGenerate = new System.Windows.Forms.Button();
            this.btnGenerateStructure = new System.Windows.Forms.Button();
            this.cbGenerateObjects = new System.Windows.Forms.CheckBox();
            this.cbGroupByTypes = new System.Windows.Forms.CheckBox();
            this.cbGroupBySchema = new System.Windows.Forms.CheckBox();
            this.cbGroupByDatabase = new System.Windows.Forms.CheckBox();
            this.cbGroupByServer = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuMetadata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerOuter)).BeginInit();
            this.splitContainerOuter.Panel1.SuspendLayout();
            this.splitContainerOuter.Panel2.SuspendLayout();
            this.splitContainerOuter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeDatabaseSchema)).BeginInit();
            this.menuSchemaTree.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerInner)).BeginInit();
            this.splitContainerInner.Panel1.SuspendLayout();
            this.splitContainerInner.Panel2.SuspendLayout();
            this.splitContainerInner.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeStructure)).BeginInit();
            this.menuStructureTree.SuspendLayout();
            this.panel8.SuspendLayout();
            this.toolStrip4.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.popupFillStructure.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMetadata
            // 
            this.menuMetadata.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAddLinkedServer,
            this.miAddDatabase,
            this.miAddSchema,
            this.miAddPackage,
            this.toolStripSeparator6,
            this.miAddTable,
            this.miAddView,
            this.miAddProcedure,
            this.miAddSynonym,
            this.toolStripSeparator7,
            this.miAddField,
            this.miAddForeignKey});
            this.menuMetadata.Name = "contextMenu";
            this.menuMetadata.OwnerItem = this.tsddbAdd;
            this.menuMetadata.Size = new System.Drawing.Size(154, 236);
            // 
            // miAddLinkedServer
            // 
            this.miAddLinkedServer.Image = global::MetadataEditorDemo.Properties.Resources.server_database;
            this.miAddLinkedServer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miAddLinkedServer.Name = "miAddLinkedServer";
            this.miAddLinkedServer.Size = new System.Drawing.Size(153, 22);
            this.miAddLinkedServer.Text = "Linked Server";
            // 
            // miAddDatabase
            // 
            this.miAddDatabase.Image = global::MetadataEditorDemo.Properties.Resources.database;
            this.miAddDatabase.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miAddDatabase.Name = "miAddDatabase";
            this.miAddDatabase.Size = new System.Drawing.Size(153, 22);
            this.miAddDatabase.Text = "Database";
            this.miAddDatabase.ToolTipText = "Add database";
            // 
            // miAddSchema
            // 
            this.miAddSchema.Image = global::MetadataEditorDemo.Properties.Resources.schema;
            this.miAddSchema.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miAddSchema.Name = "miAddSchema";
            this.miAddSchema.Size = new System.Drawing.Size(153, 22);
            this.miAddSchema.Text = "Schema";
            this.miAddSchema.ToolTipText = "Add schema";
            // 
            // miAddPackage
            // 
            this.miAddPackage.Image = global::MetadataEditorDemo.Properties.Resources.package;
            this.miAddPackage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miAddPackage.Name = "miAddPackage";
            this.miAddPackage.Size = new System.Drawing.Size(153, 22);
            this.miAddPackage.Text = "Package";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(150, 6);
            // 
            // miAddTable
            // 
            this.miAddTable.Image = global::MetadataEditorDemo.Properties.Resources.table;
            this.miAddTable.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miAddTable.Name = "miAddTable";
            this.miAddTable.Size = new System.Drawing.Size(153, 22);
            this.miAddTable.Text = "Table";
            this.miAddTable.ToolTipText = "Add table";
            // 
            // miAddView
            // 
            this.miAddView.Image = global::MetadataEditorDemo.Properties.Resources.view;
            this.miAddView.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miAddView.Name = "miAddView";
            this.miAddView.Size = new System.Drawing.Size(153, 22);
            this.miAddView.Text = "View";
            this.miAddView.ToolTipText = "Add view";
            // 
            // miAddProcedure
            // 
            this.miAddProcedure.Image = global::MetadataEditorDemo.Properties.Resources.procedure;
            this.miAddProcedure.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miAddProcedure.Name = "miAddProcedure";
            this.miAddProcedure.Size = new System.Drawing.Size(153, 22);
            this.miAddProcedure.Text = "Procedure";
            this.miAddProcedure.ToolTipText = "Add procedure";
            // 
            // miAddSynonym
            // 
            this.miAddSynonym.Image = global::MetadataEditorDemo.Properties.Resources.synonym;
            this.miAddSynonym.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miAddSynonym.Name = "miAddSynonym";
            this.miAddSynonym.Size = new System.Drawing.Size(153, 22);
            this.miAddSynonym.Text = "Synonym";
            this.miAddSynonym.ToolTipText = "Add synonym";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(150, 6);
            // 
            // miAddField
            // 
            this.miAddField.Image = global::MetadataEditorDemo.Properties.Resources.field;
            this.miAddField.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miAddField.Name = "miAddField";
            this.miAddField.Size = new System.Drawing.Size(153, 22);
            this.miAddField.Text = "Field (Column)";
            this.miAddField.ToolTipText = "Add field (column)";
            // 
            // miAddForeignKey
            // 
            this.miAddForeignKey.Image = global::MetadataEditorDemo.Properties.Resources.relation;
            this.miAddForeignKey.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miAddForeignKey.Name = "miAddForeignKey";
            this.miAddForeignKey.Size = new System.Drawing.Size(153, 22);
            this.miAddForeignKey.Text = "Foreign Key";
            this.miAddForeignKey.ToolTipText = "Add foreign key (link)";
            // 
            // tsddbAdd
            // 
            this.tsddbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsddbAdd.DropDown = this.menuMetadata;
            this.tsddbAdd.Image = global::MetadataEditorDemo.Properties.Resources.add;
            this.tsddbAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsddbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbAdd.Name = "tsddbAdd";
            this.tsddbAdd.Size = new System.Drawing.Size(29, 22);
            this.tsddbAdd.Text = "toolStripDropDownButton1";
            this.tsddbAdd.ToolTipText = "Add";
            this.tsddbAdd.DropDownOpening += new System.EventHandler(this.tsddbAdd_DropDownOpening);
            // 
            // splitContainerOuter
            // 
            this.splitContainerOuter.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainerOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerOuter.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerOuter.Location = new System.Drawing.Point(0, 0);
            this.splitContainerOuter.Name = "splitContainerOuter";
            // 
            // splitContainerOuter.Panel1
            // 
            this.splitContainerOuter.Panel1.Controls.Add(this.panel1);
            this.splitContainerOuter.Panel1.Controls.Add(this.panel9);
            this.splitContainerOuter.Panel1.Padding = new System.Windows.Forms.Padding(3, 3, 0, 2);
            // 
            // splitContainerOuter.Panel2
            // 
            this.splitContainerOuter.Panel2.Controls.Add(this.splitContainerInner);
            this.splitContainerOuter.Panel2.Padding = new System.Windows.Forms.Padding(0, 3, 3, 2);
            this.splitContainerOuter.Size = new System.Drawing.Size(1009, 506);
            this.splitContainerOuter.SplitterDistance = 336;
            this.splitContainerOuter.TabIndex = 16;
            this.toolTip1.SetToolTip(this.splitContainerOuter, "Show/Hide the Metadata Structure Tree");
            this.splitContainerOuter.ButtonDottedClick += new MouseEventHandler(this.splitContainerOuter_ButtonDottedClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 472);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.treeDatabaseSchema);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 27);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(331, 443);
            this.panel6.TabIndex = 1;
            // 
            // treeDatabaseSchema
            // 
            this.treeDatabaseSchema.BackColor = System.Drawing.SystemColors.Window;
            this.treeDatabaseSchema.ContextMenuStrip = this.menuSchemaTree;
            this.treeDatabaseSchema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeDatabaseSchema.Location = new System.Drawing.Point(0, 0);
            this.treeDatabaseSchema.Name = "treeDatabaseSchema";
            this.treeDatabaseSchema.Options.DefaultExpandMetadataType = ActiveQueryBuilder.Core.MetadataType.None;
            this.treeDatabaseSchema.Options.DrawTreeLines = false;
            this.treeDatabaseSchema.Options.ImageList = null;
            this.treeDatabaseSchema.Options.SortingType = ActiveQueryBuilder.View.DatabaseSchemaView.ObjectsSortingType.None;
            this.treeDatabaseSchema.QueryView = null;
            this.treeDatabaseSchema.SelectedItems = new ActiveQueryBuilder.Core.MetadataStructureItem[0];
            this.treeDatabaseSchema.Size = new System.Drawing.Size(329, 441);
            this.treeDatabaseSchema.SQLContext = null;
            this.treeDatabaseSchema.TabIndex = 2;
            // 
            // menuSchemaTree
            // 
            this.menuSchemaTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiConnectAndLoad,
            this.miLoadAll,
            this.tsmiDeleteSchema,
            this.miClear,
            this.toolStripSeparator2,
            this.tsmiAddLinkedServer,
            this.tsmiAddDatabase,
            this.tsmiAddSchema,
            this.tsmiAddPackage,
            this.tsmiAddTable,
            this.tsmiAddView,
            this.tsmiAddProcedure,
            this.tsmiAddSynonym,
            this.tsmiAddField,
            this.tsmiAddForeignKey,
            this.tsmiSortContainer,
            this.tsmiMoveToTopContainer,
            this.tsmiMoveToBotContainer});
            this.menuSchemaTree.Name = "menuSchemaTree";
            this.menuSchemaTree.Size = new System.Drawing.Size(301, 384);
            this.menuSchemaTree.Opening += new System.ComponentModel.CancelEventHandler(this.menuSchemaTree_Opening);
            // 
            // tsmiConnectAndLoad
            // 
            this.tsmiConnectAndLoad.Name = "tsmiConnectAndLoad";
            this.tsmiConnectAndLoad.Size = new System.Drawing.Size(300, 22);
            this.tsmiConnectAndLoad.Text = "Connect and load metadata from database";
            // 
            // miLoadAll
            // 
            this.miLoadAll.Name = "miLoadAll";
            this.miLoadAll.Size = new System.Drawing.Size(300, 22);
            this.miLoadAll.Text = "Load child items from database";
            // 
            // tsmiDeleteSchema
            // 
            this.tsmiDeleteSchema.Image = global::MetadataEditorDemo.Properties.Resources.delete;
            this.tsmiDeleteSchema.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiDeleteSchema.Name = "tsmiDeleteSchema";
            this.tsmiDeleteSchema.Size = new System.Drawing.Size(300, 22);
            this.tsmiDeleteSchema.Text = "Delete";
            // 
            // miClear
            // 
            this.miClear.Name = "miClear";
            this.miClear.Size = new System.Drawing.Size(300, 22);
            this.miClear.Text = "Clear child items";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(297, 6);
            // 
            // tsmiAddLinkedServer
            // 
            this.tsmiAddLinkedServer.Image = global::MetadataEditorDemo.Properties.Resources.server_database;
            this.tsmiAddLinkedServer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAddLinkedServer.Name = "tsmiAddLinkedServer";
            this.tsmiAddLinkedServer.Size = new System.Drawing.Size(300, 22);
            this.tsmiAddLinkedServer.Text = "Add Linked Server";
            // 
            // tsmiAddDatabase
            // 
            this.tsmiAddDatabase.Image = global::MetadataEditorDemo.Properties.Resources.database;
            this.tsmiAddDatabase.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAddDatabase.Name = "tsmiAddDatabase";
            this.tsmiAddDatabase.Size = new System.Drawing.Size(300, 22);
            this.tsmiAddDatabase.Text = "Add Database";
            // 
            // tsmiAddSchema
            // 
            this.tsmiAddSchema.Image = global::MetadataEditorDemo.Properties.Resources.schema;
            this.tsmiAddSchema.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAddSchema.Name = "tsmiAddSchema";
            this.tsmiAddSchema.Size = new System.Drawing.Size(300, 22);
            this.tsmiAddSchema.Text = "Add Schema";
            // 
            // tsmiAddPackage
            // 
            this.tsmiAddPackage.Image = global::MetadataEditorDemo.Properties.Resources.package;
            this.tsmiAddPackage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAddPackage.Name = "tsmiAddPackage";
            this.tsmiAddPackage.Size = new System.Drawing.Size(300, 22);
            this.tsmiAddPackage.Text = "Add Package";
            // 
            // tsmiAddTable
            // 
            this.tsmiAddTable.Image = global::MetadataEditorDemo.Properties.Resources.table;
            this.tsmiAddTable.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAddTable.Name = "tsmiAddTable";
            this.tsmiAddTable.Size = new System.Drawing.Size(300, 22);
            this.tsmiAddTable.Text = "Add Table";
            // 
            // tsmiAddView
            // 
            this.tsmiAddView.Image = global::MetadataEditorDemo.Properties.Resources.view;
            this.tsmiAddView.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAddView.Name = "tsmiAddView";
            this.tsmiAddView.Size = new System.Drawing.Size(300, 22);
            this.tsmiAddView.Text = "Add View";
            // 
            // tsmiAddProcedure
            // 
            this.tsmiAddProcedure.Image = global::MetadataEditorDemo.Properties.Resources.procedure;
            this.tsmiAddProcedure.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAddProcedure.Name = "tsmiAddProcedure";
            this.tsmiAddProcedure.Size = new System.Drawing.Size(300, 22);
            this.tsmiAddProcedure.Text = "Add Procedure";
            // 
            // tsmiAddSynonym
            // 
            this.tsmiAddSynonym.Image = global::MetadataEditorDemo.Properties.Resources.synonym;
            this.tsmiAddSynonym.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAddSynonym.Name = "tsmiAddSynonym";
            this.tsmiAddSynonym.Size = new System.Drawing.Size(300, 22);
            this.tsmiAddSynonym.Text = "Add Synonym";
            // 
            // tsmiAddField
            // 
            this.tsmiAddField.Image = global::MetadataEditorDemo.Properties.Resources.field;
            this.tsmiAddField.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAddField.Name = "tsmiAddField";
            this.tsmiAddField.Size = new System.Drawing.Size(300, 22);
            this.tsmiAddField.Text = "Add Field (Column)";
            // 
            // tsmiAddForeignKey
            // 
            this.tsmiAddForeignKey.Image = global::MetadataEditorDemo.Properties.Resources.relation;
            this.tsmiAddForeignKey.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAddForeignKey.Name = "tsmiAddForeignKey";
            this.tsmiAddForeignKey.Size = new System.Drawing.Size(300, 22);
            this.tsmiAddForeignKey.Text = "Add Foreign Key";
            // 
            // tsmiSortContainer
            // 
            this.tsmiSortContainer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byNameToolStripMenuItem,
            this.byTypeToolStripMenuItem});
            this.tsmiSortContainer.Name = "tsmiSortContainer";
            this.tsmiSortContainer.Size = new System.Drawing.Size(300, 22);
            this.tsmiSortContainer.Text = "Sort";
            // 
            // byNameToolStripMenuItem
            // 
            this.byNameToolStripMenuItem.Name = "byNameToolStripMenuItem";
            this.byNameToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.byNameToolStripMenuItem.Text = "By Name";
            // 
            // byTypeToolStripMenuItem
            // 
            this.byTypeToolStripMenuItem.Name = "byTypeToolStripMenuItem";
            this.byTypeToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.byTypeToolStripMenuItem.Text = "By Type And Name";
            // 
            // tsmiMoveToTopContainer
            // 
            this.tsmiMoveToTopContainer.Name = "tsmiMoveToTopContainer";
            this.tsmiMoveToTopContainer.Size = new System.Drawing.Size(300, 22);
            this.tsmiMoveToTopContainer.Text = "Move To Top";
            // 
            // tsmiMoveToBotContainer
            // 
            this.tsmiMoveToBotContainer.Name = "tsmiMoveToBotContainer";
            this.tsmiMoveToBotContainer.Size = new System.Drawing.Size(300, 22);
            this.tsmiMoveToBotContainer.Text = "Move To Bottom";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.toolStrip2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 27);
            this.panel2.TabIndex = 0;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.CanOverflow = false;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbMetadataLoadAll,
            this.toolStripSeparator5,
            this.tsddbAdd,
            this.tsbMetadataDelete,
            this.toolStripSeparator1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(3, 0, 1, 0);
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(329, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbMetadataLoadAll
            // 
            this.tsbMetadataLoadAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMetadataLoadAll.Image = global::MetadataEditorDemo.Properties.Resources.load;
            this.tsbMetadataLoadAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbMetadataLoadAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMetadataLoadAll.Name = "tsbMetadataLoadAll";
            this.tsbMetadataLoadAll.Size = new System.Drawing.Size(23, 22);
            this.tsbMetadataLoadAll.ToolTipText = "Load all objects from database";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbMetadataDelete
            // 
            this.tsbMetadataDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMetadataDelete.Image = global::MetadataEditorDemo.Properties.Resources.delete;
            this.tsbMetadataDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbMetadataDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMetadataDelete.Name = "tsbMetadataDelete";
            this.tsbMetadataDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbMetadataDelete.Text = "Delete";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DimGray;
            this.panel9.Controls.Add(this.label1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.panel9.Size = new System.Drawing.Size(333, 29);
            this.panel9.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(329, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database Schema";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainerInner
            // 
            this.splitContainerInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerInner.Location = new System.Drawing.Point(0, 3);
            this.splitContainerInner.Name = "splitContainerInner";
            // 
            // splitContainerInner.Panel1
            // 
            this.splitContainerInner.Panel1.Controls.Add(this.panel4);
            this.splitContainerInner.Panel1.Controls.Add(this.panel10);
            // 
            // splitContainerInner.Panel2
            // 
            this.splitContainerInner.Panel2.Controls.Add(this.panel3);
            this.splitContainerInner.Size = new System.Drawing.Size(666, 501);
            this.splitContainerInner.SplitterDistance = 336;
            this.splitContainerInner.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(336, 472);
            this.panel4.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.treeStructure);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 27);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(334, 443);
            this.panel7.TabIndex = 1;
            // 
            // treeStructure
            // 
            this.treeStructure.BackColor = System.Drawing.SystemColors.Window;
            this.treeStructure.ContextMenuStrip = this.menuStructureTree;
            this.treeStructure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeStructure.Location = new System.Drawing.Point(0, 0);
            this.treeStructure.Name = "treeStructure";
            this.treeStructure.Options.DefaultExpandMetadataType = ActiveQueryBuilder.Core.MetadataType.None;
            this.treeStructure.Options.DrawTreeLines = false;
            this.treeStructure.Options.ImageList = null;
            this.treeStructure.Options.SortingType = ActiveQueryBuilder.View.DatabaseSchemaView.ObjectsSortingType.None;
            this.treeStructure.QueryView = null;
            this.treeStructure.SelectedItems = new ActiveQueryBuilder.Core.MetadataStructureItem[0];
            this.treeStructure.Size = new System.Drawing.Size(332, 441);
            this.treeStructure.SQLContext = null;
            this.treeStructure.TabIndex = 0;
            // 
            // menuStructureTree
            // 
            this.menuStructureTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddStructureItem,
            this.tsmiDeleteStructureItem,
            this.miStructureLoadAll,
            this.miStructureClear,
            this.tsmiSortStructure,
            this.tsmiMoveStructureToTop,
            this.tsmiMoveStructureToBot});
            this.menuStructureTree.Name = "menuStructureTree";
            this.menuStructureTree.Size = new System.Drawing.Size(189, 158);
            // 
            // tsmiAddStructureItem
            // 
            this.tsmiAddStructureItem.Image = global::MetadataEditorDemo.Properties.Resources.add;
            this.tsmiAddStructureItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiAddStructureItem.Name = "tsmiAddStructureItem";
            this.tsmiAddStructureItem.Size = new System.Drawing.Size(188, 22);
            this.tsmiAddStructureItem.Text = "Add Item";
            // 
            // tsmiDeleteStructureItem
            // 
            this.tsmiDeleteStructureItem.Image = global::MetadataEditorDemo.Properties.Resources.delete;
            this.tsmiDeleteStructureItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiDeleteStructureItem.Name = "tsmiDeleteStructureItem";
            this.tsmiDeleteStructureItem.Size = new System.Drawing.Size(188, 22);
            this.tsmiDeleteStructureItem.Text = "Delete";
            // 
            // miStructureLoadAll
            // 
            this.miStructureLoadAll.Name = "miStructureLoadAll";
            this.miStructureLoadAll.Size = new System.Drawing.Size(188, 22);
            this.miStructureLoadAll.Text = "Create child elements";
            // 
            // miStructureClear
            // 
            this.miStructureClear.Name = "miStructureClear";
            this.miStructureClear.Size = new System.Drawing.Size(188, 22);
            this.miStructureClear.Text = "Clear child items";
            // 
            // tsmiSortStructure
            // 
            this.tsmiSortStructure.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSortStructureByName,
            this.tsmiSortStructureByType});
            this.tsmiSortStructure.Name = "tsmiSortStructure";
            this.tsmiSortStructure.Size = new System.Drawing.Size(188, 22);
            this.tsmiSortStructure.Text = "Sort";
            // 
            // tsmiSortStructureByName
            // 
            this.tsmiSortStructureByName.Name = "tsmiSortStructureByName";
            this.tsmiSortStructureByName.Size = new System.Drawing.Size(174, 22);
            this.tsmiSortStructureByName.Text = "By Name";
            // 
            // tsmiSortStructureByType
            // 
            this.tsmiSortStructureByType.Name = "tsmiSortStructureByType";
            this.tsmiSortStructureByType.Size = new System.Drawing.Size(174, 22);
            this.tsmiSortStructureByType.Text = "By Type And Name";
            // 
            // tsmiMoveStructureToTop
            // 
            this.tsmiMoveStructureToTop.Name = "tsmiMoveStructureToTop";
            this.tsmiMoveStructureToTop.Size = new System.Drawing.Size(188, 22);
            this.tsmiMoveStructureToTop.Text = "Move To Top";
            // 
            // tsmiMoveStructureToBot
            // 
            this.tsmiMoveStructureToBot.Name = "tsmiMoveStructureToBot";
            this.tsmiMoveStructureToBot.Size = new System.Drawing.Size(188, 22);
            this.tsmiMoveStructureToBot.Text = "Move To Bottom";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.toolStrip4);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(334, 27);
            this.panel8.TabIndex = 0;
            // 
            // toolStrip4
            // 
            this.toolStrip4.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip4.CanOverflow = false;
            this.toolStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbStructureAdd,
            this.tsbStructureDelete,
            this.toolStripSeparator10,
            this.miFillFromSchema});
            this.toolStrip4.Location = new System.Drawing.Point(0, 0);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.toolStrip4.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip4.Size = new System.Drawing.Size(332, 25);
            this.toolStrip4.TabIndex = 0;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // tsbStructureAdd
            // 
            this.tsbStructureAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStructureAdd.Image = global::MetadataEditorDemo.Properties.Resources.add;
            this.tsbStructureAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbStructureAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStructureAdd.Name = "tsbStructureAdd";
            this.tsbStructureAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbStructureAdd.Text = "toolStripButton1";
            // 
            // tsbStructureDelete
            // 
            this.tsbStructureDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStructureDelete.Image = global::MetadataEditorDemo.Properties.Resources.delete;
            this.tsbStructureDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbStructureDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStructureDelete.Name = "tsbStructureDelete";
            this.tsbStructureDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbStructureDelete.Text = "Delete";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // miFillFromSchema
            // 
            this.miFillFromSchema.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.miFillFromSchema.Image = global::MetadataEditorDemo.Properties.Resources.wand;
            this.miFillFromSchema.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.miFillFromSchema.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.miFillFromSchema.Name = "miFillFromSchema";
            this.miFillFromSchema.Size = new System.Drawing.Size(165, 22);
            this.miFillFromSchema.Text = "Fill structure from schema";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DimGray;
            this.panel10.Controls.Add(this.label2);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.panel10.Size = new System.Drawing.Size(336, 29);
            this.panel10.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Ivory;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(2, 2);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(332, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Metadata Structure";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.propertiesBar);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 501);
            this.panel3.TabIndex = 0;
            // 
            // propertiesBar
            // 
            this.propertiesBar.AutoScroll = true;
            this.propertiesBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertiesBar.EditorsOptions.CaptionsMaxWidth = 250;
            this.propertiesBar.EditorsOptions.MultiLineEditorsCaptionPosition = ActiveQueryBuilder.Core.PropertiesEditors.MultiLineEditorCaptionPosition.Left;
            this.propertiesBar.EditorsOptions.MultiLineEditorsMaxWidth = 420;
            this.propertiesBar.EditorsOptions.MultiLineEditorsMinWidth = 150;
            this.propertiesBar.EditorsOptions.NarrowEditControlsMaxWidth = 50;
            this.propertiesBar.EditorsOptions.NarrowEditControlsMinWidth = 50;
            this.propertiesBar.EditorsOptions.WideEditControlsMaxWidth = 350;
            this.propertiesBar.EditorsOptions.WideEditControlsMinWidth = 185;
            this.propertiesBar.InformationMessageHost = null;
            this.propertiesBar.Location = new System.Drawing.Point(0, 27);
            this.propertiesBar.Name = "propertiesBar";
            this.propertiesBar.Size = new System.Drawing.Size(324, 472);
            this.propertiesBar.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblHeader);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(324, 27);
            this.panel5.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.Silver;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHeader.ForeColor = System.Drawing.Color.Transparent;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(322, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Properties";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // popupFillStructure
            // 
            this.popupFillStructure.Controls.Add(this.lbWarningFillStructure);
            this.popupFillStructure.Controls.Add(this.btnCancelGenerate);
            this.popupFillStructure.Controls.Add(this.btnGenerateStructure);
            this.popupFillStructure.Controls.Add(this.cbGenerateObjects);
            this.popupFillStructure.Controls.Add(this.cbGroupByTypes);
            this.popupFillStructure.Controls.Add(this.cbGroupBySchema);
            this.popupFillStructure.Controls.Add(this.cbGroupByDatabase);
            this.popupFillStructure.Controls.Add(this.cbGroupByServer);
            this.popupFillStructure.Location = new System.Drawing.Point(385, 160);
            this.popupFillStructure.Name = "popupFillStructure";
            this.popupFillStructure.Size = new System.Drawing.Size(239, 187);
            this.popupFillStructure.TabIndex = 19;
            this.popupFillStructure.Visible = false;
            // 
            // lbWarningFillStructure
            // 
            this.lbWarningFillStructure.ForeColor = System.Drawing.Color.Maroon;
            this.lbWarningFillStructure.Location = new System.Drawing.Point(4, 120);
            this.lbWarningFillStructure.Name = "lbWarningFillStructure";
            this.lbWarningFillStructure.Size = new System.Drawing.Size(232, 30);
            this.lbWarningFillStructure.TabIndex = 14;
            this.lbWarningFillStructure.Text = "Warning: the current metadata stucture tree will be deleted!";
            // 
            // btnCancelGenerate
            // 
            this.btnCancelGenerate.Location = new System.Drawing.Point(139, 158);
            this.btnCancelGenerate.Name = "btnCancelGenerate";
            this.btnCancelGenerate.Size = new System.Drawing.Size(88, 23);
            this.btnCancelGenerate.TabIndex = 13;
            this.btnCancelGenerate.Text = "Cancel";
            this.btnCancelGenerate.UseVisualStyleBackColor = true;
            // 
            // btnGenerateStructure
            // 
            this.btnGenerateStructure.Location = new System.Drawing.Point(12, 158);
            this.btnGenerateStructure.Name = "btnGenerateStructure";
            this.btnGenerateStructure.Size = new System.Drawing.Size(88, 23);
            this.btnGenerateStructure.TabIndex = 12;
            this.btnGenerateStructure.Text = "Proceed";
            this.btnGenerateStructure.UseVisualStyleBackColor = true;
            // 
            // cbGenerateObjects
            // 
            this.cbGenerateObjects.AutoSize = true;
            this.cbGenerateObjects.Location = new System.Drawing.Point(3, 95);
            this.cbGenerateObjects.Name = "cbGenerateObjects";
            this.cbGenerateObjects.Size = new System.Drawing.Size(107, 17);
            this.cbGenerateObjects.TabIndex = 11;
            this.cbGenerateObjects.Text = "Generate objects";
            this.cbGenerateObjects.UseVisualStyleBackColor = true;
            // 
            // cbGroupByTypes
            // 
            this.cbGroupByTypes.AutoSize = true;
            this.cbGroupByTypes.Location = new System.Drawing.Point(3, 72);
            this.cbGroupByTypes.Name = "cbGroupByTypes";
            this.cbGroupByTypes.Size = new System.Drawing.Size(97, 17);
            this.cbGroupByTypes.TabIndex = 10;
            this.cbGroupByTypes.Text = "Group by types";
            this.cbGroupByTypes.UseVisualStyleBackColor = true;
            // 
            // cbGroupBySchema
            // 
            this.cbGroupBySchema.AutoSize = true;
            this.cbGroupBySchema.Location = new System.Drawing.Point(3, 49);
            this.cbGroupBySchema.Name = "cbGroupBySchema";
            this.cbGroupBySchema.Size = new System.Drawing.Size(109, 17);
            this.cbGroupBySchema.TabIndex = 9;
            this.cbGroupBySchema.Text = "Group by schema";
            this.cbGroupBySchema.UseVisualStyleBackColor = true;
            // 
            // cbGroupByDatabase
            // 
            this.cbGroupByDatabase.AutoSize = true;
            this.cbGroupByDatabase.Location = new System.Drawing.Point(3, 26);
            this.cbGroupByDatabase.Name = "cbGroupByDatabase";
            this.cbGroupByDatabase.Size = new System.Drawing.Size(116, 17);
            this.cbGroupByDatabase.TabIndex = 8;
            this.cbGroupByDatabase.Text = "Group by database";
            this.cbGroupByDatabase.UseVisualStyleBackColor = true;
            // 
            // cbGroupByServer
            // 
            this.cbGroupByServer.AutoSize = true;
            this.cbGroupByServer.Location = new System.Drawing.Point(3, 3);
            this.cbGroupByServer.Name = "cbGroupByServer";
            this.cbGroupByServer.Size = new System.Drawing.Size(101, 17);
            this.cbGroupByServer.TabIndex = 7;
            this.cbGroupByServer.Text = "Group by server";
            this.cbGroupByServer.UseVisualStyleBackColor = true;
            // 
            // MetadataEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.popupFillStructure);
            this.Controls.Add(this.splitContainerOuter);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "MetadataEditorControl";
            this.Size = new System.Drawing.Size(1009, 506);
            this.menuMetadata.ResumeLayout(false);
            this.splitContainerOuter.Panel1.ResumeLayout(false);
            this.splitContainerOuter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerOuter)).EndInit();
            this.splitContainerOuter.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeDatabaseSchema)).EndInit();
            this.menuSchemaTree.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.splitContainerInner.Panel1.ResumeLayout(false);
            this.splitContainerInner.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerInner)).EndInit();
            this.splitContainerInner.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeStructure)).EndInit();
            this.menuStructureTree.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.popupFillStructure.ResumeLayout(false);
            this.popupFillStructure.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip menuMetadata;
		private System.Windows.Forms.ToolStripMenuItem miAddDatabase;
		private System.Windows.Forms.ToolStripMenuItem miAddSchema;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripMenuItem miAddTable;
		private System.Windows.Forms.ToolStripMenuItem miAddView;
		private System.Windows.Forms.ToolStripMenuItem miAddProcedure;
		private System.Windows.Forms.ToolStripMenuItem miAddSynonym;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripMenuItem miAddField;
		private System.Windows.Forms.ToolStripMenuItem miAddForeignKey;
		private System.Windows.Forms.ToolStripDropDownButton tsddbAdd;
		private SplitContainerWithButton splitContainerOuter;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripButton tsbMetadataDelete;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		public System.Windows.Forms.SplitContainer splitContainerInner;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.ToolStrip toolStrip4;
		private System.Windows.Forms.ToolStripButton tsbStructureDelete;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label lblHeader;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.Label label2;
        private ActiveQueryBuilder.View.WinForms.QueryView.PropertiesBar propertiesBar;
        private ActiveQueryBuilder.View.WinForms.DatabaseSchemaView.DatabaseSchemaView treeDatabaseSchema;
        private ActiveQueryBuilder.View.WinForms.DatabaseSchemaView.DatabaseSchemaView treeStructure;
        private System.Windows.Forms.ToolStripButton tsbStructureAdd;
        private System.Windows.Forms.ContextMenuStrip menuSchemaTree;
        private System.Windows.Forms.ToolStripMenuItem miLoadAll;
        private System.Windows.Forms.ToolStripMenuItem miClear;
        private System.Windows.Forms.ToolStripButton miFillFromSchema;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddDatabase;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddSchema;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddTable;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddView;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddProcedure;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddSynonym;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddField;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddForeignKey;
        private System.Windows.Forms.ContextMenuStrip menuStructureTree;
        private System.Windows.Forms.ToolStripMenuItem miStructureLoadAll;
        private System.Windows.Forms.ToolStripMenuItem miStructureClear;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddLinkedServer;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddPackage;
        private System.Windows.Forms.ToolStripMenuItem miAddPackage;
        private System.Windows.Forms.ToolStripMenuItem miAddLinkedServer;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteSchema;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddStructureItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteStructureItem;
        public System.Windows.Forms.ToolStripButton tsbMetadataLoadAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiSortContainer;
        private System.Windows.Forms.ToolStripMenuItem byNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoveToTopContainer;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoveToBotContainer;
        private System.Windows.Forms.ToolStripMenuItem tsmiSortStructure;
        private System.Windows.Forms.ToolStripMenuItem tsmiSortStructureByName;
        private System.Windows.Forms.ToolStripMenuItem tsmiSortStructureByType;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoveStructureToTop;
        private System.Windows.Forms.ToolStripMenuItem tsmiMoveStructureToBot;
        private System.Windows.Forms.ToolStripMenuItem tsmiConnectAndLoad;
        private System.Windows.Forms.Panel popupFillStructure;
        private System.Windows.Forms.Label lbWarningFillStructure;
        private System.Windows.Forms.Button btnCancelGenerate;
        private System.Windows.Forms.Button btnGenerateStructure;
        private System.Windows.Forms.CheckBox cbGenerateObjects;
        private System.Windows.Forms.CheckBox cbGroupByTypes;
        private System.Windows.Forms.CheckBox cbGroupBySchema;
        private System.Windows.Forms.CheckBox cbGroupByDatabase;
        private System.Windows.Forms.CheckBox cbGroupByServer;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
