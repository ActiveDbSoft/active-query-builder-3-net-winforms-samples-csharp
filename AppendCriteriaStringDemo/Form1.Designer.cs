namespace AppendCriteriaStringDemo
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
			this.queryBuilder1 = new ActiveQueryBuilder.View.WinForms.QueryBuilder();
			this.sql92SyntaxProvider1 = new ActiveQueryBuilder.Core.SQL92SyntaxProvider(this.components);
			this.msAccessSyntaxProvider1 = new ActiveQueryBuilder.Core.MSAccessSyntaxProvider(this.components);
			this.textBoxQuery = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxNewWhere = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.buttonReplaceWhereAccess = new System.Windows.Forms.Button();
			this.buttonClearWhere = new System.Windows.Forms.Button();
			this.buttonReplaceWhereAll = new System.Windows.Forms.Button();
			this.buttonReplaceWhere = new System.Windows.Forms.Button();
			this.buttonAppend = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxNewWhereAccess = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// queryBuilder1
			// 
			this.queryBuilder1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.queryBuilder1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.queryBuilder1.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess;
			this.queryBuilder1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
			this.queryBuilder1.Location = new System.Drawing.Point(13, 13);
			this.queryBuilder1.Name = "queryBuilder1";
			this.queryBuilder1.PanesConfigurationOptions.DatabaseSchemaViewWidth = 230;
			this.queryBuilder1.Size = new System.Drawing.Size(937, 343);
			// 
			// 
			// 
			this.queryBuilder1.SQLFormattingOptions.ExpandVirtualFields = false;
			this.queryBuilder1.SQLFormattingOptions.ExpandVirtualObjects = false;
			// 
			// 
			// 
			this.queryBuilder1.SQLGenerationOptions.ExpandVirtualFields = true;
			this.queryBuilder1.SQLGenerationOptions.ExpandVirtualObjects = true;
			this.queryBuilder1.SyntaxProvider = this.sql92SyntaxProvider1;
			this.queryBuilder1.TabIndex = 0;
			this.queryBuilder1.SQLUpdated += new System.EventHandler(this.queryBuilder1_SQLUpdated);
			// 
			// msAccessSyntaxProvider1
			// 
			this.msAccessSyntaxProvider1.IdentCaseSens = ActiveQueryBuilder.Core.IdentCaseSensitivity.Insensitive;
			// 
			// textBoxQuery
			// 
			this.textBoxQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxQuery.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxQuery.Location = new System.Drawing.Point(98, 464);
			this.textBoxQuery.Multiline = true;
			this.textBoxQuery.Name = "textBoxQuery";
			this.textBoxQuery.Size = new System.Drawing.Size(851, 118);
			this.textBoxQuery.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 366);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "New WHERE:";
			// 
			// textBoxNewWhere
			// 
			this.textBoxNewWhere.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxNewWhere.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxNewWhere.Location = new System.Drawing.Point(98, 362);
			this.textBoxNewWhere.Multiline = true;
			this.textBoxNewWhere.Name = "textBoxNewWhere";
			this.textBoxNewWhere.Size = new System.Drawing.Size(236, 44);
			this.textBoxNewWhere.TabIndex = 3;
			this.textBoxNewWhere.Text = "o.\"Order Date\" > \'01.01.2010\'";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Controls.Add(this.buttonReplaceWhereAccess, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.buttonClearWhere, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.buttonReplaceWhereAll, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.buttonReplaceWhere, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.buttonAppend, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(340, 362);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(610, 94);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// buttonReplaceWhereAccess
			// 
			this.buttonReplaceWhereAccess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonReplaceWhereAccess.Location = new System.Drawing.Point(3, 50);
			this.buttonReplaceWhereAccess.Name = "buttonReplaceWhereAccess";
			this.buttonReplaceWhereAccess.Size = new System.Drawing.Size(146, 41);
			this.buttonReplaceWhereAccess.TabIndex = 4;
			this.buttonReplaceWhereAccess.Text = "Replace first WHERE clause";
			this.buttonReplaceWhereAccess.UseVisualStyleBackColor = true;
			this.buttonReplaceWhereAccess.Click += new System.EventHandler(this.buttonReplaceWhereAccess_Click);
			// 
			// buttonClearWhere
			// 
			this.buttonClearWhere.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonClearWhere.Location = new System.Drawing.Point(3, 3);
			this.buttonClearWhere.Name = "buttonClearWhere";
			this.buttonClearWhere.Size = new System.Drawing.Size(146, 41);
			this.buttonClearWhere.TabIndex = 0;
			this.buttonClearWhere.Text = "Clear first WHERE clause";
			this.buttonClearWhere.UseVisualStyleBackColor = true;
			this.buttonClearWhere.Click += new System.EventHandler(this.buttonClearWhere_Click);
			// 
			// buttonReplaceWhereAll
			// 
			this.buttonReplaceWhereAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonReplaceWhereAll.Location = new System.Drawing.Point(459, 3);
			this.buttonReplaceWhereAll.Name = "buttonReplaceWhereAll";
			this.buttonReplaceWhereAll.Size = new System.Drawing.Size(148, 41);
			this.buttonReplaceWhereAll.TabIndex = 3;
			this.buttonReplaceWhereAll.Text = "Replace all WHERE clauses";
			this.buttonReplaceWhereAll.UseVisualStyleBackColor = true;
			this.buttonReplaceWhereAll.Click += new System.EventHandler(this.buttonReplaceWhereAll_Click);
			// 
			// buttonReplaceWhere
			// 
			this.buttonReplaceWhere.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonReplaceWhere.Location = new System.Drawing.Point(307, 3);
			this.buttonReplaceWhere.Name = "buttonReplaceWhere";
			this.buttonReplaceWhere.Size = new System.Drawing.Size(146, 41);
			this.buttonReplaceWhere.TabIndex = 1;
			this.buttonReplaceWhere.Text = "Replace first WHERE clause";
			this.buttonReplaceWhere.UseVisualStyleBackColor = true;
			this.buttonReplaceWhere.Click += new System.EventHandler(this.buttonReplaceWhere_Click);
			// 
			// buttonAppend
			// 
			this.buttonAppend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAppend.Location = new System.Drawing.Point(155, 3);
			this.buttonAppend.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
			this.buttonAppend.Name = "buttonAppend";
			this.buttonAppend.Size = new System.Drawing.Size(149, 41);
			this.buttonAppend.TabIndex = 2;
			this.buttonAppend.Text = "Append to first WHERE clause";
			this.buttonAppend.UseVisualStyleBackColor = true;
			this.buttonAppend.Click += new System.EventHandler(this.buttonAppend_Click);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 468);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Source query:";
			// 
			// textBoxNewWhereAccess
			// 
			this.textBoxNewWhereAccess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBoxNewWhereAccess.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxNewWhereAccess.Location = new System.Drawing.Point(98, 412);
			this.textBoxNewWhereAccess.Multiline = true;
			this.textBoxNewWhereAccess.Name = "textBoxNewWhereAccess";
			this.textBoxNewWhereAccess.Size = new System.Drawing.Size(236, 44);
			this.textBoxNewWhereAccess.TabIndex = 6;
			this.textBoxNewWhereAccess.Text = "o.[Order Date] > #01.01.2011#";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 416);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "New WHERE:";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(10, 432);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "(ACCESS syntax)";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(962, 594);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxNewWhereAccess);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.textBoxNewWhere);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxQuery);
			this.Controls.Add(this.queryBuilder1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Append Criteria String Demo";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ActiveQueryBuilder.View.WinForms.QueryBuilder queryBuilder1;
		private System.Windows.Forms.TextBox textBoxQuery;
		private ActiveQueryBuilder.Core.SQL92SyntaxProvider sql92SyntaxProvider1;
		private ActiveQueryBuilder.Core.MSAccessSyntaxProvider msAccessSyntaxProvider1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxNewWhere;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button buttonAppend;
		private System.Windows.Forms.Button buttonReplaceWhere;
		private System.Windows.Forms.Button buttonClearWhere;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxNewWhereAccess;
		private System.Windows.Forms.Button buttonReplaceWhereAll;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonReplaceWhereAccess;
	}
}

