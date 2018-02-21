namespace DragDropDemo
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
			this.genericSyntaxProvider1 = new ActiveQueryBuilder.Core.GenericSyntaxProvider(this.components);
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
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
			this.queryBuilder1.Location = new System.Drawing.Point(12, 12);
			this.queryBuilder1.Name = "queryBuilder1";
			this.queryBuilder1.PanesConfigurationOptions.DatabaseSchemaViewVisible = false;
			this.queryBuilder1.Size = new System.Drawing.Size(721, 468);
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
			this.queryBuilder1.SyntaxProvider = this.genericSyntaxProvider1;
			this.queryBuilder1.TabIndex = 0;
			this.queryBuilder1.SQLUpdated += new System.EventHandler(this.queryBuilder1_SQLUpdated);
			// 
			// genericSyntaxProvider1
			// 
			this.genericSyntaxProvider1.IdentCaseSens = ActiveQueryBuilder.Core.IdentCaseSensitivity.Insensitive;
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Location = new System.Drawing.Point(12, 486);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(876, 130);
			this.textBox1.TabIndex = 1;
			this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.Maroon;
			this.label1.Location = new System.Drawing.Point(739, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(149, 60);
			this.label1.TabIndex = 3;
			this.label1.Text = "Drag an item from this custom list and drop it to the query builder\'s diagram pan" +
    "e";
			// 
			// listBox1
			// 
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.IntegralHeight = false;
			this.listBox1.Items.AddRange(new object[] {
            "Orders",
            "Order Details",
            "Products",
            "Customers",
            "Employees",
            "Categories"});
			this.listBox1.Location = new System.Drawing.Point(739, 71);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(149, 409);
			this.listBox1.TabIndex = 4;
			this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
			this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
			this.listBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseMove);
			this.listBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseUp);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(900, 628);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.queryBuilder1);
			this.Name = "Form1";
			this.Text = "Drag\'n\'Drop Demo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ActiveQueryBuilder.View.WinForms.QueryBuilder queryBuilder1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private ActiveQueryBuilder.Core.GenericSyntaxProvider genericSyntaxProvider1;
		private System.Windows.Forms.ListBox listBox1;
	}
}

