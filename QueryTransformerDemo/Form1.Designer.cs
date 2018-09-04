namespace QueryTransformerCoreDemo
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BoxSourceSql = new System.Windows.Forms.RichTextBox();
            this.ButtonLoad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CounterVisibleColumns = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ComboBoxWhereColumns = new System.Windows.Forms.ComboBox();
            this.ComboBoxConditions = new System.Windows.Forms.ComboBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.CounterFilters = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.ButtonClearWhere = new System.Windows.Forms.Button();
            this.ButtonAddWhere = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.TextBoxWhereValue = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ComboBoxAggregateColumns = new System.Windows.Forms.ComboBox();
            this.ComboBoxAggregations = new System.Windows.Forms.ComboBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.CounterAggregations = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.ButtonClearAggregates = new System.Windows.Forms.Button();
            this.ButtonAddAggregate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ComboBoxSortingColumns = new System.Windows.Forms.ComboBox();
            this.ComboBoxSortings = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.CounterSortings = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.ButtonClearSortings = new System.Windows.Forms.Button();
            this.ButtonAddSorting = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListBoxVisibleFields = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BoxResultSql = new System.Windows.Forms.RichTextBox();
            this.ButtonCodeBehindShow = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source SQL:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.BoxSourceSql, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonLoad, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1081, 100);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // BoxSourceSql
            // 
            this.BoxSourceSql.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BoxSourceSql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoxSourceSql.Location = new System.Drawing.Point(3, 3);
            this.BoxSourceSql.Name = "BoxSourceSql";
            this.BoxSourceSql.Size = new System.Drawing.Size(994, 94);
            this.BoxSourceSql.TabIndex = 0;
            this.BoxSourceSql.Text = "";
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.Location = new System.Drawing.Point(1003, 3);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Size = new System.Drawing.Size(75, 23);
            this.ButtonLoad.TabIndex = 1;
            this.ButtonLoad.Text = "Load";
            this.ButtonLoad.UseVisualStyleBackColor = true;
            this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Visible Columns:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 252);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Visible count :";
            // 
            // CounterVisibleColumns
            // 
            this.CounterVisibleColumns.AutoSize = true;
            this.CounterVisibleColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CounterVisibleColumns.Location = new System.Drawing.Point(79, 252);
            this.CounterVisibleColumns.Name = "CounterVisibleColumns";
            this.CounterVisibleColumns.Size = new System.Drawing.Size(14, 13);
            this.CounterVisibleColumns.TabIndex = 0;
            this.CounterVisibleColumns.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(119, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 20);
            this.button2.TabIndex = 1;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(10, 123);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1081, 285);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(209, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.panel2.Size = new System.Drawing.Size(869, 279);
            this.panel2.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel5);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(869, 61);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Where";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tableLayoutPanel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 16);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(863, 42);
            this.panel5.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanel6.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label15, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.ComboBoxWhereColumns, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.ComboBoxConditions, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.panel10, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.panel11, 3, 1);
            this.tableLayoutPanel6.Controls.Add(this.label18, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.TextBoxWhereValue, 2, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(863, 42);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(226, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Columns:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label15.Location = new System.Drawing.Point(235, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(226, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Conditions:";
            // 
            // ComboBoxWhereColumns
            // 
            this.ComboBoxWhereColumns.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComboBoxWhereColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxWhereColumns.FormattingEnabled = true;
            this.ComboBoxWhereColumns.Location = new System.Drawing.Point(3, 16);
            this.ComboBoxWhereColumns.Name = "ComboBoxWhereColumns";
            this.ComboBoxWhereColumns.Size = new System.Drawing.Size(226, 21);
            this.ComboBoxWhereColumns.TabIndex = 2;
            // 
            // ComboBoxConditions
            // 
            this.ComboBoxConditions.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComboBoxConditions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxConditions.FormattingEnabled = true;
            this.ComboBoxConditions.Items.AddRange(new object[] {
            "Equal",
            "Not Equal",
            "Greater",
            "GreaterEqual",
            "Not Grater",
            "Not GreaterEqual",
            "IsNull",
            "Not IsNull",
            "IsNotNull",
            "Less",
            "LessEqual",
            "Not Less",
            "Not LessEqual",
            "In",
            "Not In",
            "Like",
            "Not Like"});
            this.ComboBoxConditions.Location = new System.Drawing.Point(235, 16);
            this.ComboBoxConditions.Name = "ComboBoxConditions";
            this.ComboBoxConditions.Size = new System.Drawing.Size(226, 21);
            this.ComboBoxConditions.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.CounterFilters);
            this.panel10.Controls.Add(this.label17);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(696, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(167, 13);
            this.panel10.TabIndex = 3;
            // 
            // CounterFilters
            // 
            this.CounterFilters.AutoSize = true;
            this.CounterFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CounterFilters.Location = new System.Drawing.Point(106, 0);
            this.CounterFilters.Name = "CounterFilters";
            this.CounterFilters.Size = new System.Drawing.Size(14, 13);
            this.CounterFilters.TabIndex = 1;
            this.CounterFilters.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Active filters:";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.ButtonClearWhere);
            this.panel11.Controls.Add(this.ButtonAddWhere);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(699, 16);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(161, 29);
            this.panel11.TabIndex = 4;
            // 
            // ButtonClearWhere
            // 
            this.ButtonClearWhere.Location = new System.Drawing.Point(84, 1);
            this.ButtonClearWhere.Name = "ButtonClearWhere";
            this.ButtonClearWhere.Size = new System.Drawing.Size(75, 21);
            this.ButtonClearWhere.TabIndex = 0;
            this.ButtonClearWhere.Text = "Clear";
            this.ButtonClearWhere.UseVisualStyleBackColor = true;
            this.ButtonClearWhere.Click += new System.EventHandler(this.ButtonClearWhere_Click);
            // 
            // ButtonAddWhere
            // 
            this.ButtonAddWhere.Location = new System.Drawing.Point(3, 1);
            this.ButtonAddWhere.Name = "ButtonAddWhere";
            this.ButtonAddWhere.Size = new System.Drawing.Size(75, 21);
            this.ButtonAddWhere.TabIndex = 0;
            this.ButtonAddWhere.Text = "Add";
            this.ButtonAddWhere.UseVisualStyleBackColor = true;
            this.ButtonAddWhere.Click += new System.EventHandler(this.ButtonAddWhere_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label18.Location = new System.Drawing.Point(467, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(226, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "Value:";
            // 
            // TextBoxWhereValue
            // 
            this.TextBoxWhereValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBoxWhereValue.Location = new System.Drawing.Point(467, 16);
            this.TextBoxWhereValue.Name = "TextBoxWhereValue";
            this.TextBoxWhereValue.Size = new System.Drawing.Size(226, 20);
            this.TextBoxWhereValue.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(869, 61);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aggregate";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(863, 42);
            this.panel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel5.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label11, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.ComboBoxAggregateColumns, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.ComboBoxAggregations, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.panel8, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel9, 2, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(863, 42);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(343, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Columns:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label11.Location = new System.Drawing.Point(352, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(343, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Functions:";
            // 
            // ComboBoxAggregateColumns
            // 
            this.ComboBoxAggregateColumns.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComboBoxAggregateColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxAggregateColumns.FormattingEnabled = true;
            this.ComboBoxAggregateColumns.Location = new System.Drawing.Point(3, 16);
            this.ComboBoxAggregateColumns.Name = "ComboBoxAggregateColumns";
            this.ComboBoxAggregateColumns.Size = new System.Drawing.Size(343, 21);
            this.ComboBoxAggregateColumns.TabIndex = 2;
            // 
            // ComboBoxAggregations
            // 
            this.ComboBoxAggregations.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComboBoxAggregations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxAggregations.FormattingEnabled = true;
            this.ComboBoxAggregations.Items.AddRange(new object[] {
            "Count",
            "Avg",
            "Sum",
            "Min",
            "Max"});
            this.ComboBoxAggregations.Location = new System.Drawing.Point(352, 16);
            this.ComboBoxAggregations.Name = "ComboBoxAggregations";
            this.ComboBoxAggregations.Size = new System.Drawing.Size(343, 21);
            this.ComboBoxAggregations.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.CounterAggregations);
            this.panel8.Controls.Add(this.label13);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(698, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(165, 13);
            this.panel8.TabIndex = 3;
            // 
            // CounterAggregations
            // 
            this.CounterAggregations.AutoSize = true;
            this.CounterAggregations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CounterAggregations.Location = new System.Drawing.Point(106, 0);
            this.CounterAggregations.Name = "CounterAggregations";
            this.CounterAggregations.Size = new System.Drawing.Size(14, 13);
            this.CounterAggregations.TabIndex = 1;
            this.CounterAggregations.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Active aggregations:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.ButtonClearAggregates);
            this.panel9.Controls.Add(this.ButtonAddAggregate);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(701, 16);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(159, 29);
            this.panel9.TabIndex = 4;
            // 
            // ButtonClearAggregates
            // 
            this.ButtonClearAggregates.Location = new System.Drawing.Point(84, 1);
            this.ButtonClearAggregates.Name = "ButtonClearAggregates";
            this.ButtonClearAggregates.Size = new System.Drawing.Size(75, 21);
            this.ButtonClearAggregates.TabIndex = 0;
            this.ButtonClearAggregates.Text = "Clear";
            this.ButtonClearAggregates.UseVisualStyleBackColor = true;
            this.ButtonClearAggregates.Click += new System.EventHandler(this.ButtonClearAggregates_Click);
            // 
            // ButtonAddAggregate
            // 
            this.ButtonAddAggregate.Location = new System.Drawing.Point(3, 1);
            this.ButtonAddAggregate.Name = "ButtonAddAggregate";
            this.ButtonAddAggregate.Size = new System.Drawing.Size(75, 21);
            this.ButtonAddAggregate.TabIndex = 0;
            this.ButtonAddAggregate.Text = "Add";
            this.ButtonAddAggregate.UseVisualStyleBackColor = true;
            this.ButtonAddAggregate.Click += new System.EventHandler(this.ButtonAddAggregate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(869, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sorting";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(863, 42);
            this.panel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.ComboBoxSortingColumns, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.ComboBoxSortings, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.panel6, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel7, 2, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(863, 42);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(343, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Columns:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label7.Location = new System.Drawing.Point(352, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(343, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sorting:";
            // 
            // ComboBoxSortingColumns
            // 
            this.ComboBoxSortingColumns.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComboBoxSortingColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSortingColumns.FormattingEnabled = true;
            this.ComboBoxSortingColumns.Location = new System.Drawing.Point(3, 16);
            this.ComboBoxSortingColumns.Name = "ComboBoxSortingColumns";
            this.ComboBoxSortingColumns.Size = new System.Drawing.Size(343, 21);
            this.ComboBoxSortingColumns.TabIndex = 2;
            // 
            // ComboBoxSortings
            // 
            this.ComboBoxSortings.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComboBoxSortings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSortings.FormattingEnabled = true;
            this.ComboBoxSortings.Items.AddRange(new object[] {
            "Asc",
            "Desc"});
            this.ComboBoxSortings.Location = new System.Drawing.Point(352, 16);
            this.ComboBoxSortings.Name = "ComboBoxSortings";
            this.ComboBoxSortings.Size = new System.Drawing.Size(343, 21);
            this.ComboBoxSortings.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.CounterSortings);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(698, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(165, 13);
            this.panel6.TabIndex = 3;
            // 
            // CounterSortings
            // 
            this.CounterSortings.AutoSize = true;
            this.CounterSortings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CounterSortings.Location = new System.Drawing.Point(106, 0);
            this.CounterSortings.Name = "CounterSortings";
            this.CounterSortings.Size = new System.Drawing.Size(14, 13);
            this.CounterSortings.TabIndex = 1;
            this.CounterSortings.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Active sortings:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.ButtonClearSortings);
            this.panel7.Controls.Add(this.ButtonAddSorting);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(701, 16);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(159, 29);
            this.panel7.TabIndex = 4;
            // 
            // ButtonClearSortings
            // 
            this.ButtonClearSortings.Location = new System.Drawing.Point(84, 1);
            this.ButtonClearSortings.Name = "ButtonClearSortings";
            this.ButtonClearSortings.Size = new System.Drawing.Size(75, 21);
            this.ButtonClearSortings.TabIndex = 0;
            this.ButtonClearSortings.Text = "Clear";
            this.ButtonClearSortings.UseVisualStyleBackColor = true;
            this.ButtonClearSortings.Click += new System.EventHandler(this.ButtonClearSortings_Click);
            // 
            // ButtonAddSorting
            // 
            this.ButtonAddSorting.Location = new System.Drawing.Point(3, 1);
            this.ButtonAddSorting.Name = "ButtonAddSorting";
            this.ButtonAddSorting.Size = new System.Drawing.Size(75, 21);
            this.ButtonAddSorting.TabIndex = 0;
            this.ButtonAddSorting.Text = "Add";
            this.ButtonAddSorting.UseVisualStyleBackColor = true;
            this.ButtonAddSorting.Click += new System.EventHandler(this.ButtonAddSorting_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.CounterVisibleColumns);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ListBoxVisibleFields);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 279);
            this.panel1.TabIndex = 5;
            // 
            // ListBoxVisibleFields
            // 
            this.ListBoxVisibleFields.CheckOnClick = true;
            this.ListBoxVisibleFields.FormattingEnabled = true;
            this.ListBoxVisibleFields.Location = new System.Drawing.Point(0, 20);
            this.ListBoxVisibleFields.Margin = new System.Windows.Forms.Padding(0);
            this.ListBoxVisibleFields.Name = "ListBoxVisibleFields";
            this.ListBoxVisibleFields.Size = new System.Drawing.Size(194, 214);
            this.ListBoxVisibleFields.TabIndex = 1;
            this.ListBoxVisibleFields.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ListBoxVisibleFields_ItemCheck);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Result SQL:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.BoxResultSql, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ButtonCodeBehindShow, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 421);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1081, 122);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // BoxResultSql
            // 
            this.BoxResultSql.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BoxResultSql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoxResultSql.Location = new System.Drawing.Point(3, 3);
            this.BoxResultSql.Name = "BoxResultSql";
            this.BoxResultSql.Size = new System.Drawing.Size(994, 116);
            this.BoxResultSql.TabIndex = 0;
            this.BoxResultSql.Text = "";
            // 
            // ButtonCodeBehindShow
            // 
            this.ButtonCodeBehindShow.Location = new System.Drawing.Point(1003, 3);
            this.ButtonCodeBehindShow.Name = "ButtonCodeBehindShow";
            this.ButtonCodeBehindShow.Size = new System.Drawing.Size(75, 23);
            this.ButtonCodeBehindShow.TabIndex = 1;
            this.ButtonCodeBehindShow.Text = "CodeBehind";
            this.ButtonCodeBehindShow.UseVisualStyleBackColor = true;
            this.ButtonCodeBehindShow.Click += new System.EventHandler(this.ButtonCodeBehindShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1101, 549);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "QueryTransformerCoreDemo";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox BoxSourceSql;
        private System.Windows.Forms.Button ButtonLoad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CounterVisibleColumns;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RichTextBox BoxResultSql;
        private System.Windows.Forms.Button ButtonCodeBehindShow;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ComboBoxSortingColumns;
        private System.Windows.Forms.ComboBox ComboBoxSortings;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label CounterSortings;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button ButtonClearSortings;
        private System.Windows.Forms.Button ButtonAddSorting;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox ComboBoxWhereColumns;
        private System.Windows.Forms.ComboBox ComboBoxConditions;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label CounterFilters;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button ButtonClearWhere;
        private System.Windows.Forms.Button ButtonAddWhere;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox ComboBoxAggregateColumns;
        private System.Windows.Forms.ComboBox ComboBoxAggregations;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label CounterAggregations;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button ButtonClearAggregates;
        private System.Windows.Forms.Button ButtonAddAggregate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TextBoxWhereValue;
        private System.Windows.Forms.CheckedListBox ListBoxVisibleFields;
    }
}

