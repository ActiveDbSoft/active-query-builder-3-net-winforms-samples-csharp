namespace CustomColumnsDemo
{
	partial class CustomTextColumnDemoFrame
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomTextColumnDemoFrame));
			this.queryBuilder1 = new ActiveQueryBuilder.View.WinForms.QueryBuilder();
			this.SuspendLayout();
			// 
			// queryBuilder1
			// 
			this.queryBuilder1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.queryBuilder1.Location = new System.Drawing.Point(0, 0);
			this.queryBuilder1.Name = "queryBuilder1";
			this.queryBuilder1.PanesConfigurationOptions.DatabaseSchemaViewWidth = 230;
			this.queryBuilder1.Size = new System.Drawing.Size(640, 340);
			this.queryBuilder1.TabIndex = 2;
			this.queryBuilder1.QueryElementControlCreated += new ActiveQueryBuilder.View.QueryView.QueryElementControlCreatedEventHandler(this.queryBuilder1_QueryElementControlCreated);
			this.queryBuilder1.QueryElementControlDestroying += new ActiveQueryBuilder.View.QueryView.QueryElementControlDestroyingEventHandler(this.queryBuilder1_QueryElementControlDestroying);
			// 
			// CustomTextColumnDemoFrame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.queryBuilder1);
			this.Name = "CustomTextColumnDemoFrame";
			this.Size = new System.Drawing.Size(640, 340);
			this.ResumeLayout(false);

		}

		#endregion

		private ActiveQueryBuilder.View.WinForms.QueryBuilder queryBuilder1;
	}
}
