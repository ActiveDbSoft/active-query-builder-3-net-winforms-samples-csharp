using ActiveQueryBuilder.View.WinForms.QueryView;
using ActiveQueryBuilder.View.WinForms.DatabaseSchemaView;
namespace FullFeaturedMdiDemo
{
    partial class EditConnectionForm
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbMenu = new System.Windows.Forms.ListBox();
            this.tcProperties = new System.Windows.Forms.TabControl();
            this.tpConnection = new System.Windows.Forms.TabPage();
            this.pbConnection = new ActiveQueryBuilder.View.WinForms.QueryView.PropertiesBar();
            this.pbSyntax = new ActiveQueryBuilder.View.WinForms.QueryView.PropertiesBar();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSyntax = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbConnectionType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbConnectionName = new System.Windows.Forms.TextBox();
            this.tpFilter = new System.Windows.Forms.TabPage();
            this.tcFilters = new System.Windows.Forms.TabControl();
            this.tpInclude = new System.Windows.Forms.TabPage();
            this.lvInclude = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.tpExclude = new System.Windows.Forms.TabPage();
            this.lvExclude = new System.Windows.Forms.ListView();
            this.databaseSchemaView1 = new ActiveQueryBuilder.View.WinForms.DatabaseSchemaView.DatabaseSchemaView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteFilter = new System.Windows.Forms.Button();
            this.btnAddFilter = new System.Windows.Forms.Button();
            this.pnlFilterInfo = new FullFeaturedMdiDemo.Common.InformationPanel();
            this.tpMetadataLoading = new System.Windows.Forms.TabPage();
            this.pbMetadataLoading = new ActiveQueryBuilder.View.WinForms.QueryView.PropertiesBar();
            this.tpStructureOptions = new System.Windows.Forms.TabPage();
            this.pbStructureOptions = new ActiveQueryBuilder.View.WinForms.QueryView.PropertiesBar();
            this.tcProperties.SuspendLayout();
            this.tpConnection.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.tpFilter.SuspendLayout();
            this.tcFilters.SuspendLayout();
            this.tpInclude.SuspendLayout();
            this.tpExclude.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpMetadataLoading.SuspendLayout();
            this.tpStructureOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(436, 387);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(517, 387);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lbMenu
            // 
            this.lbMenu.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenu.FormattingEnabled = true;
            this.lbMenu.ItemHeight = 16;
            this.lbMenu.Items.AddRange(new object[] {
            "Connection",
            "Filter",
            "Loading Options",
            "Tree Options"});
            this.lbMenu.Location = new System.Drawing.Point(8, 13);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(139, 356);
            this.lbMenu.TabIndex = 7;
            this.lbMenu.SelectedIndexChanged += new System.EventHandler(this.lbMenu_SelectedIndexChanged);
            // 
            // tcProperties
            // 
            this.tcProperties.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcProperties.Controls.Add(this.tpConnection);
            this.tcProperties.Controls.Add(this.tpFilter);
            this.tcProperties.Controls.Add(this.tpMetadataLoading);
            this.tcProperties.Controls.Add(this.tpStructureOptions);
            this.tcProperties.ItemSize = new System.Drawing.Size(0, 1);
            this.tcProperties.Location = new System.Drawing.Point(150, 8);
            this.tcProperties.Margin = new System.Windows.Forms.Padding(0);
            this.tcProperties.Name = "tcProperties";
            this.tcProperties.Padding = new System.Drawing.Point(0, 0);
            this.tcProperties.SelectedIndex = 0;
            this.tcProperties.Size = new System.Drawing.Size(445, 368);
            this.tcProperties.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcProperties.TabIndex = 9;
            // 
            // tpConnection
            // 
            this.tpConnection.Controls.Add(this.pbConnection);
            this.tpConnection.Controls.Add(this.pbSyntax);
            this.tpConnection.Controls.Add(this.pnlTop);
            this.tpConnection.Location = new System.Drawing.Point(4, 5);
            this.tpConnection.Margin = new System.Windows.Forms.Padding(0);
            this.tpConnection.Name = "tpConnection";
            this.tpConnection.Size = new System.Drawing.Size(437, 359);
            this.tpConnection.TabIndex = 0;
            this.tpConnection.Text = "tabPage1";
            this.tpConnection.UseVisualStyleBackColor = true;
            // 
            // pbConnection
            // 
            this.pbConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbConnection.EditorsOptions.CaptionsMaxWidth = 100;
            this.pbConnection.EditorsOptions.CaptionsMinWidth = 100;
            this.pbConnection.InformationMessageHost = null;
            this.pbConnection.Location = new System.Drawing.Point(0, 130);
            this.pbConnection.Name = "pbConnection";
            this.pbConnection.Size = new System.Drawing.Size(437, 229);
            this.pbConnection.TabIndex = 0;
            // 
            // pbSyntax
            // 
            this.pbSyntax.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbSyntax.EditorsOptions.CaptionsMaxWidth = 100;
            this.pbSyntax.EditorsOptions.CaptionsMinWidth = 100;
            this.pbSyntax.InformationMessageHost = null;
            this.pbSyntax.Location = new System.Drawing.Point(0, 65);
            this.pbSyntax.Name = "pbSyntax";
            this.pbSyntax.Size = new System.Drawing.Size(437, 65);
            this.pbSyntax.TabIndex = 2;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Controls.Add(this.cbSyntax);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.cbConnectionType);
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.tbConnectionName);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(6);
            this.pnlTop.Size = new System.Drawing.Size(437, 65);
            this.pnlTop.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Syntax";
            // 
            // cbSyntax
            // 
            this.cbSyntax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSyntax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSyntax.FormattingEnabled = true;
            this.cbSyntax.Location = new System.Drawing.Point(120, 64);
            this.cbSyntax.Name = "cbSyntax";
            this.cbSyntax.Size = new System.Drawing.Size(306, 21);
            this.cbSyntax.TabIndex = 4;
            this.cbSyntax.SelectedIndexChanged += new System.EventHandler(this.cbSyntax_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Connection Type";
            // 
            // cbConnectionType
            // 
            this.cbConnectionType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbConnectionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConnectionType.FormattingEnabled = true;
            this.cbConnectionType.Location = new System.Drawing.Point(120, 36);
            this.cbConnectionType.Name = "cbConnectionType";
            this.cbConnectionType.Size = new System.Drawing.Size(306, 21);
            this.cbConnectionType.TabIndex = 2;
            this.cbConnectionType.SelectedIndexChanged += new System.EventHandler(this.cbConnectionType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Connection Name";
            // 
            // tbConnectionName
            // 
            this.tbConnectionName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbConnectionName.Location = new System.Drawing.Point(120, 9);
            this.tbConnectionName.Name = "tbConnectionName";
            this.tbConnectionName.Size = new System.Drawing.Size(306, 20);
            this.tbConnectionName.TabIndex = 0;
            this.tbConnectionName.TextChanged += new System.EventHandler(this.tbConnectionName_TextChanged);
            // 
            // tpFilter
            // 
            this.tpFilter.Controls.Add(this.tcFilters);
            this.tpFilter.Controls.Add(this.databaseSchemaView1);
            this.tpFilter.Controls.Add(this.panel1);
            this.tpFilter.Controls.Add(this.pnlFilterInfo);
            this.tpFilter.Location = new System.Drawing.Point(4, 5);
            this.tpFilter.Name = "tpFilter";
            this.tpFilter.Padding = new System.Windows.Forms.Padding(3);
            this.tpFilter.Size = new System.Drawing.Size(437, 359);
            this.tpFilter.TabIndex = 1;
            this.tpFilter.Text = "tabPage2";
            this.tpFilter.UseVisualStyleBackColor = true;
            // 
            // tcFilters
            // 
            this.tcFilters.Controls.Add(this.tpInclude);
            this.tcFilters.Controls.Add(this.tpExclude);
            this.tcFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcFilters.Location = new System.Drawing.Point(180, 10);
            this.tcFilters.Name = "tcFilters";
            this.tcFilters.SelectedIndex = 0;
            this.tcFilters.Size = new System.Drawing.Size(254, 324);
            this.tcFilters.TabIndex = 1;
            // 
            // tpInclude
            // 
            this.tpInclude.Controls.Add(this.lvInclude);
            this.tpInclude.Location = new System.Drawing.Point(4, 22);
            this.tpInclude.Name = "tpInclude";
            this.tpInclude.Padding = new System.Windows.Forms.Padding(3);
            this.tpInclude.Size = new System.Drawing.Size(246, 298);
            this.tpInclude.TabIndex = 0;
            this.tpInclude.Text = "Include";
            this.tpInclude.UseVisualStyleBackColor = true;
            // 
            // lvInclude
            // 
            this.lvInclude.AllowDrop = true;
            this.lvInclude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvInclude.Location = new System.Drawing.Point(3, 3);
            this.lvInclude.Name = "lvInclude";
            this.lvInclude.Size = new System.Drawing.Size(240, 292);
            this.lvInclude.SmallImageList = this.imageList;
            this.lvInclude.TabIndex = 6;
            this.lvInclude.UseCompatibleStateImageBehavior = false;
            this.lvInclude.View = System.Windows.Forms.View.List;
            this.lvInclude.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbInclude_DragDrop);
            this.lvInclude.DragOver += new System.Windows.Forms.DragEventHandler(this.lbInclude_DragOver);
            this.lvInclude.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvInclude_KeyDown);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tpExclude
            // 
            this.tpExclude.Controls.Add(this.lvExclude);
            this.tpExclude.Location = new System.Drawing.Point(4, 22);
            this.tpExclude.Name = "tpExclude";
            this.tpExclude.Padding = new System.Windows.Forms.Padding(3);
            this.tpExclude.Size = new System.Drawing.Size(211, 298);
            this.tpExclude.TabIndex = 1;
            this.tpExclude.Text = "Exclude";
            this.tpExclude.UseVisualStyleBackColor = true;
            // 
            // lvExclude
            // 
            this.lvExclude.AllowDrop = true;
            this.lvExclude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvExclude.Location = new System.Drawing.Point(3, 3);
            this.lvExclude.Name = "lvExclude";
            this.lvExclude.Size = new System.Drawing.Size(205, 292);
            this.lvExclude.SmallImageList = this.imageList;
            this.lvExclude.TabIndex = 7;
            this.lvExclude.UseCompatibleStateImageBehavior = false;
            this.lvExclude.View = System.Windows.Forms.View.List;
            this.lvExclude.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbExclude_DragDrop);
            this.lvExclude.DragOver += new System.Windows.Forms.DragEventHandler(this.lbExclude_DragOver);
            this.lvExclude.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvExclude_KeyDown);
            // 
            // databaseSchemaView1
            // 
            this.databaseSchemaView1.BackColor = System.Drawing.SystemColors.Window;
            this.databaseSchemaView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.databaseSchemaView1.Location = new System.Drawing.Point(3, 10);
            this.databaseSchemaView1.Name = "databaseSchemaView1";
            this.databaseSchemaView1.Options.DrawTreeLines = false;
            this.databaseSchemaView1.Options.ImageList = null;
            this.databaseSchemaView1.QueryView = null;
            this.databaseSchemaView1.SelectedItems = new ActiveQueryBuilder.Core.MetadataStructureItem[0];
            this.databaseSchemaView1.Size = new System.Drawing.Size(177, 324);
            this.databaseSchemaView1.SQLContext = null;
            this.databaseSchemaView1.TabIndex = 4;
            this.databaseSchemaView1.ItemDoubleClick += new ActiveQueryBuilder.View.MetadataStructureView.MetadataStructureItemEventHandler(this.databaseSchemaView1_ItemDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeleteFilter);
            this.panel1.Controls.Add(this.btnAddFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 334);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 22);
            this.panel1.TabIndex = 3;
            // 
            // btnDeleteFilter
            // 
            this.btnDeleteFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteFilter.Location = new System.Drawing.Point(177, 0);
            this.btnDeleteFilter.Name = "btnDeleteFilter";
            this.btnDeleteFilter.Size = new System.Drawing.Size(254, 22);
            this.btnDeleteFilter.TabIndex = 1;
            this.btnDeleteFilter.Text = "Remove";
            this.btnDeleteFilter.UseVisualStyleBackColor = true;
            this.btnDeleteFilter.Click += new System.EventHandler(this.btnDeleteFilter_Click);
            // 
            // btnAddFilter
            // 
            this.btnAddFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddFilter.Location = new System.Drawing.Point(0, 0);
            this.btnAddFilter.Name = "btnAddFilter";
            this.btnAddFilter.Size = new System.Drawing.Size(177, 22);
            this.btnAddFilter.TabIndex = 0;
            this.btnAddFilter.Text = "Add";
            this.btnAddFilter.UseVisualStyleBackColor = true;
            this.btnAddFilter.Click += new System.EventHandler(this.btnAddFilter_Click);
            // 
            // pnlFilterInfo
            // 
            this.pnlFilterInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterInfo.IconLocation = ActiveQueryBuilder.View.InfoIconLocation.Left;
            this.pnlFilterInfo.InfoText = "";
            this.pnlFilterInfo.Location = new System.Drawing.Point(3, 3);
            this.pnlFilterInfo.Name = "pnlFilterInfo";
            this.pnlFilterInfo.ShowIcon = true;
            this.pnlFilterInfo.Size = new System.Drawing.Size(431, 7);
            this.pnlFilterInfo.TabIndex = 6;
            this.pnlFilterInfo.Tooltip = "By adding a namespace (database, schema, etc.) you instruct to include or exclude" +
    " all objects from this namespace.";
            // 
            // tpMetadataLoading
            // 
            this.tpMetadataLoading.Controls.Add(this.pbMetadataLoading);
            this.tpMetadataLoading.Location = new System.Drawing.Point(4, 5);
            this.tpMetadataLoading.Name = "tpMetadataLoading";
            this.tpMetadataLoading.Padding = new System.Windows.Forms.Padding(3);
            this.tpMetadataLoading.Size = new System.Drawing.Size(402, 359);
            this.tpMetadataLoading.TabIndex = 2;
            this.tpMetadataLoading.Text = "tabPage1";
            this.tpMetadataLoading.UseVisualStyleBackColor = true;
            // 
            // pbMetadataLoading
            // 
            this.pbMetadataLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMetadataLoading.InformationMessageHost = null;
            this.pbMetadataLoading.Location = new System.Drawing.Point(3, 3);
            this.pbMetadataLoading.Name = "pbMetadataLoading";
            this.pbMetadataLoading.Size = new System.Drawing.Size(396, 353);
            this.pbMetadataLoading.TabIndex = 0;
            // 
            // tpStructureOptions
            // 
            this.tpStructureOptions.Controls.Add(this.pbStructureOptions);
            this.tpStructureOptions.Location = new System.Drawing.Point(4, 5);
            this.tpStructureOptions.Name = "tpStructureOptions";
            this.tpStructureOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tpStructureOptions.Size = new System.Drawing.Size(402, 359);
            this.tpStructureOptions.TabIndex = 3;
            this.tpStructureOptions.Text = "tabPage2";
            this.tpStructureOptions.UseVisualStyleBackColor = true;
            // 
            // pbStructureOptions
            // 
            this.pbStructureOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbStructureOptions.InformationMessageHost = null;
            this.pbStructureOptions.Location = new System.Drawing.Point(3, 3);
            this.pbStructureOptions.Name = "pbStructureOptions";
            this.pbStructureOptions.Size = new System.Drawing.Size(396, 353);
            this.pbStructureOptions.TabIndex = 0;
            // 
            // EditConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 418);
            this.Controls.Add(this.tcProperties);
            this.Controls.Add(this.lbMenu);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditConnectionForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Connection";
            this.tcProperties.ResumeLayout(false);
            this.tpConnection.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.tpFilter.ResumeLayout(false);
            this.tcFilters.ResumeLayout(false);
            this.tpInclude.ResumeLayout(false);
            this.tpExclude.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tpMetadataLoading.ResumeLayout(false);
            this.tpStructureOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lbMenu;
        private System.Windows.Forms.TabControl tcProperties;
        private System.Windows.Forms.TabPage tpConnection;
        private System.Windows.Forms.TabPage tpFilter;
        private PropertiesBar pbConnection;
        private System.Windows.Forms.TabControl tcFilters;
        private System.Windows.Forms.TabPage tpInclude;
        private System.Windows.Forms.TabPage tpExclude;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbConnectionType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbConnectionName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteFilter;
        private System.Windows.Forms.Button btnAddFilter;
        private System.Windows.Forms.ListView lvInclude;
        private System.Windows.Forms.ListView lvExclude;
        private System.Windows.Forms.ImageList imageList;
        private PropertiesBar pbSyntax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSyntax;
        private System.Windows.Forms.TabPage tpMetadataLoading;
        private System.Windows.Forms.TabPage tpStructureOptions;
        private PropertiesBar pbMetadataLoading;
        private PropertiesBar pbStructureOptions;
        private DatabaseSchemaView databaseSchemaView1;
        private FullFeaturedMdiDemo.Common.InformationPanel pnlFilterInfo;
    }
}
