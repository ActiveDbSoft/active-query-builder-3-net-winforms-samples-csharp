using Microsoft.VisualBasic;
using System;
namespace QueryCreationDemo
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
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region "Windows Form Designer generated code"

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.SqlBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSyntax = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonQueryStatistics = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxExamples = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SqlBox
            // 
            this.SqlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SqlBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SqlBox.Location = new System.Drawing.Point(74, 68);
            this.SqlBox.Multiline = true;
            this.SqlBox.Name = "SqlBox";
            this.SqlBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SqlBox.Size = new System.Drawing.Size(498, 280);
            this.SqlBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 66);
            this.label1.TabIndex = 2;
            this.label1.Text = "See the source code for:\r\n- how to fill the metadata container with custom object" +
    "s\r\n- how to create a query programmatically\r\n- how to get objects from the metad" +
    "ata container";
            // 
            // comboBoxSyntax
            // 
            this.comboBoxSyntax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSyntax.FormattingEnabled = true;
            this.comboBoxSyntax.Items.AddRange(new object[] {
            "ANSI SQL-2003",
            "ANSI SQL-89",
            "ANSI SQL-92",
            "Firebird",
            "IBM DB2",
            "IBM Informix",
            "MS Access",
            "MS SQL Server",
            "MySQL",
            "Oracle",
            "PostgreSQL",
            "SQLite",
            "Sybase",
            "VistaDB"});
            this.comboBoxSyntax.Location = new System.Drawing.Point(74, 12);
            this.comboBoxSyntax.Name = "comboBoxSyntax";
            this.comboBoxSyntax.Size = new System.Drawing.Size(306, 21);
            this.comboBoxSyntax.TabIndex = 3;
            this.comboBoxSyntax.SelectedIndexChanged += new System.EventHandler(this.comboBoxSyntax_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Syntax:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.BackColor = System.Drawing.Color.LightSlateGray;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 280);
            this.label3.TabIndex = 5;
            this.label3.Text = "Query:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonQueryStatistics
            // 
            this.buttonQueryStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonQueryStatistics.Location = new System.Drawing.Point(428, 354);
            this.buttonQueryStatistics.Name = "buttonQueryStatistics";
            this.buttonQueryStatistics.Size = new System.Drawing.Size(144, 33);
            this.buttonQueryStatistics.TabIndex = 1;
            this.buttonQueryStatistics.Text = "Query statistics";
            this.buttonQueryStatistics.UseVisualStyleBackColor = true;
            this.buttonQueryStatistics.Click += new System.EventHandler(this.buttonQueryStatistics_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SteelBlue;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Example:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxExamples
            // 
            this.comboBoxExamples.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExamples.FormattingEnabled = true;
            this.comboBoxExamples.Items.AddRange(new object[] {
            "Simple query",
            "Query with Left Join custom expression",
            "Query with Aggregate and Grouping",
            "Query with Derived Table and CTE",
            "Query with Unions",
            "Query with SubQuery in expression"});
            this.comboBoxExamples.Location = new System.Drawing.Point(74, 39);
            this.comboBoxExamples.Name = "comboBoxExamples";
            this.comboBoxExamples.Size = new System.Drawing.Size(306, 21);
            this.comboBoxExamples.TabIndex = 3;
            this.comboBoxExamples.SelectedIndexChanged += new System.EventHandler(this.comboBoxExamples_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 512);
            this.Controls.Add(this.buttonQueryStatistics);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxExamples);
            this.Controls.Add(this.comboBoxSyntax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SqlBox);
            this.Name = "Form1";
            this.Text = "Query Creation Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox SqlBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxSyntax;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonQueryStatistics;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBoxExamples;
	}
}

