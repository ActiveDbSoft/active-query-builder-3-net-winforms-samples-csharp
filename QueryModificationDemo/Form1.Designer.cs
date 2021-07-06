using ActiveQueryBuilder.View;

namespace QueryModificationDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnApply = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOrderDate = new System.Windows.Forms.TextBox();
            this.cbOrderDate = new System.Windows.Forms.CheckBox();
            this.cbOrders = new System.Windows.Forms.CheckBox();
            this.tbCompanyName = new System.Windows.Forms.TextBox();
            this.cbCompanyName = new System.Windows.Forms.CheckBox();
            this.cbCustomers = new System.Windows.Forms.CheckBox();
            this.btnQueryCustomersOrders = new System.Windows.Forms.Button();
            this.btnQueryOrders = new System.Windows.Forms.Button();
            this.btnQueryCustomers = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbSQL = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.genericSyntaxProvider1 = new ActiveQueryBuilder.Core.GenericSyntaxProvider(this.components);
            this.queryBuilder1 = new ActiveQueryBuilder.View.WinForms.QueryBuilder();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(923, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnApply);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnQueryCustomersOrders);
            this.panel1.Controls.Add(this.btnQueryOrders);
            this.panel1.Controls.Add(this.btnQueryCustomers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(5, 469);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 160);
            this.panel1.TabIndex = 2;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnApply.Location = new System.Drawing.Point(782, 137);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(141, 23);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply Changes";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbOrderDate);
            this.groupBox1.Controls.Add(this.cbOrderDate);
            this.groupBox1.Controls.Add(this.cbOrders);
            this.groupBox1.Controls.Add(this.tbCompanyName);
            this.groupBox1.Controls.Add(this.cbCompanyName);
            this.groupBox1.Controls.Add(this.cbCustomers);
            this.groupBox1.Location = new System.Drawing.Point(0, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(776, 154);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modification Settings:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(5, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Check tables you wish to add to the query.\r\nCheck fields you wish to define crite" +
    "ria for.";
            // 
            // tbOrderDate
            // 
            this.tbOrderDate.Enabled = false;
            this.tbOrderDate.Location = new System.Drawing.Point(131, 123);
            this.tbOrderDate.Name = "tbOrderDate";
            this.tbOrderDate.Size = new System.Drawing.Size(231, 20);
            this.tbOrderDate.TabIndex = 5;
            this.tbOrderDate.Text = "= \'01/01/2007\'";
            // 
            // cbOrderDate
            // 
            this.cbOrderDate.AutoSize = true;
            this.cbOrderDate.Enabled = false;
            this.cbOrderDate.Location = new System.Drawing.Point(27, 125);
            this.cbOrderDate.Name = "cbOrderDate";
            this.cbOrderDate.Size = new System.Drawing.Size(75, 17);
            this.cbOrderDate.TabIndex = 4;
            this.cbOrderDate.Text = "OrderDate";
            this.cbOrderDate.UseVisualStyleBackColor = true;
            this.cbOrderDate.CheckedChanged += new System.EventHandler(this.cbOrderDate_CheckedChanged);
            // 
            // cbOrders
            // 
            this.cbOrders.AutoSize = true;
            this.cbOrders.Location = new System.Drawing.Point(8, 102);
            this.cbOrders.Name = "cbOrders";
            this.cbOrders.Size = new System.Drawing.Size(57, 17);
            this.cbOrders.TabIndex = 3;
            this.cbOrders.Text = "Orders";
            this.cbOrders.UseVisualStyleBackColor = true;
            this.cbOrders.CheckedChanged += new System.EventHandler(this.cbOrders_CheckedChanged);
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.Enabled = false;
            this.tbCompanyName.Location = new System.Drawing.Point(131, 77);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.Size = new System.Drawing.Size(231, 20);
            this.tbCompanyName.TabIndex = 2;
            this.tbCompanyName.Text = "Like \'C%\'";
            // 
            // cbCompanyName
            // 
            this.cbCompanyName.AutoSize = true;
            this.cbCompanyName.Enabled = false;
            this.cbCompanyName.Location = new System.Drawing.Point(27, 79);
            this.cbCompanyName.Name = "cbCompanyName";
            this.cbCompanyName.Size = new System.Drawing.Size(98, 17);
            this.cbCompanyName.TabIndex = 1;
            this.cbCompanyName.Text = "CompanyName";
            this.cbCompanyName.UseVisualStyleBackColor = true;
            this.cbCompanyName.CheckedChanged += new System.EventHandler(this.cbCompanyName_CheckedChanged);
            // 
            // cbCustomers
            // 
            this.cbCustomers.AutoSize = true;
            this.cbCustomers.Location = new System.Drawing.Point(8, 56);
            this.cbCustomers.Name = "cbCustomers";
            this.cbCustomers.Size = new System.Drawing.Size(75, 17);
            this.cbCustomers.TabIndex = 0;
            this.cbCustomers.Text = "Customers";
            this.cbCustomers.UseVisualStyleBackColor = true;
            this.cbCustomers.CheckedChanged += new System.EventHandler(this.cbCustomers_CheckedChanged);
            // 
            // btnQueryCustomersOrders
            // 
            this.btnQueryCustomersOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQueryCustomersOrders.Location = new System.Drawing.Point(782, 69);
            this.btnQueryCustomersOrders.Name = "btnQueryCustomersOrders";
            this.btnQueryCustomersOrders.Size = new System.Drawing.Size(141, 23);
            this.btnQueryCustomersOrders.TabIndex = 2;
            this.btnQueryCustomersOrders.Text = "Load Sample Query 3";
            this.btnQueryCustomersOrders.UseVisualStyleBackColor = true;
            this.btnQueryCustomersOrders.Click += new System.EventHandler(this.btnQueryCustomersOrders_Click);
            // 
            // btnQueryOrders
            // 
            this.btnQueryOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQueryOrders.Location = new System.Drawing.Point(782, 40);
            this.btnQueryOrders.Name = "btnQueryOrders";
            this.btnQueryOrders.Size = new System.Drawing.Size(141, 23);
            this.btnQueryOrders.TabIndex = 1;
            this.btnQueryOrders.Text = "Load Sample Query 2";
            this.btnQueryOrders.UseVisualStyleBackColor = true;
            this.btnQueryOrders.Click += new System.EventHandler(this.btnQueryOrders_Click);
            // 
            // btnQueryCustomers
            // 
            this.btnQueryCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQueryCustomers.Location = new System.Drawing.Point(782, 11);
            this.btnQueryCustomers.Name = "btnQueryCustomers";
            this.btnQueryCustomers.Size = new System.Drawing.Size(141, 23);
            this.btnQueryCustomers.TabIndex = 0;
            this.btnQueryCustomers.Text = "Load Sample Query 1";
            this.btnQueryCustomers.UseVisualStyleBackColor = true;
            this.btnQueryCustomers.Click += new System.EventHandler(this.btnQueryCustomers_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(5, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(923, 420);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbSQL);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(915, 394);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SQL Text";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbSQL
            // 
            this.tbSQL.AcceptsReturn = true;
            this.tbSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSQL.HideSelection = false;
            this.tbSQL.Location = new System.Drawing.Point(3, 3);
            this.tbSQL.Multiline = true;
            this.tbSQL.Name = "tbSQL";
            this.tbSQL.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbSQL.Size = new System.Drawing.Size(909, 388);
            this.tbSQL.TabIndex = 0;
            this.tbSQL.Validating += new System.ComponentModel.CancelEventHandler(this.tbSQL_Validating);
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.queryBuilder1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(915, 394);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Query Builder";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // genericSyntaxProvider1
            // 
            this.genericSyntaxProvider1.IdentCaseSens = ActiveQueryBuilder.Core.IdentCaseSensitivity.Insensitive;
            this.genericSyntaxProvider1.OnCalcExpressionType = null;
            // 
            // queryBuilder1
            // 
            this.queryBuilder1.BehaviorOptions.ResolveColumnNamingConflictsAutomatically = false;
            this.queryBuilder1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.queryBuilder1.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess;
            this.queryBuilder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryBuilder1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.queryBuilder1.Location = new System.Drawing.Point(3, 3);
            this.queryBuilder1.MetadataStructureOptions.ProceduresFolderText = "Procedures";
            this.queryBuilder1.MetadataStructureOptions.SynonymsFolderText = "Synonyms";
            this.queryBuilder1.MetadataStructureOptions.TablesFolderText = "Tables";
            this.queryBuilder1.MetadataStructureOptions.ViewsFolderText = "Views";
            this.queryBuilder1.Name = "queryBuilder1";        
            this.queryBuilder1.Size = new System.Drawing.Size(907, 386);
            // 
            // 
            // 
            this.queryBuilder1.SQLFormattingOptions.ExpandVirtualFields = false;
            this.queryBuilder1.SQLFormattingOptions.ExpandVirtualObjects = false;
            this.queryBuilder1.SQLFormattingOptions.ExpressionSubQueryFormat.FromClauseFormat.NewLineAfterDatasource = false;
            this.queryBuilder1.SQLFormattingOptions.ExpressionSubQueryFormat.MainPartsFromNewLine = false;
            // 
            // 
            // 
            this.queryBuilder1.SQLGenerationOptions.ExpandVirtualFields = true;
            this.queryBuilder1.SQLGenerationOptions.ExpandVirtualObjects = true;
            this.queryBuilder1.SQLGenerationOptions.UseAltNames = false;
            this.queryBuilder1.SyntaxProvider = this.genericSyntaxProvider1;
            this.queryBuilder1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 634);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Query Modification Demo";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox tbSQL;
		private System.Windows.Forms.Button btnApply;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnQueryCustomersOrders;
		private System.Windows.Forms.Button btnQueryOrders;
		private System.Windows.Forms.Button btnQueryCustomers;
		private System.Windows.Forms.TextBox tbOrderDate;
		private System.Windows.Forms.CheckBox cbOrderDate;
		private System.Windows.Forms.CheckBox cbOrders;
		private System.Windows.Forms.TextBox tbCompanyName;
		private System.Windows.Forms.CheckBox cbCompanyName;
		private System.Windows.Forms.CheckBox cbCustomers;
		private System.Windows.Forms.Label label2;
        private ActiveQueryBuilder.Core.GenericSyntaxProvider genericSyntaxProvider1;
        private ActiveQueryBuilder.View.WinForms.QueryBuilder queryBuilder1;

	}
}

