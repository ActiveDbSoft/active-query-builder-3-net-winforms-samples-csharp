//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2024 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//


using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;

namespace PreserveInitialQueryFormattingDemo
{
    public partial class MainForm : Form
    {
        private bool _isCanUpdateSqlText = true;

        private StringBuilder _defaultSql = new StringBuilder();

        public MainForm()
        {
            _defaultSql.AppendLine("-- Any text for comment");
            _defaultSql.AppendLine("Select Categories.CategoryName,");
            _defaultSql.AppendLine("  Products.UnitPrice");
            _defaultSql.AppendLine("From Categories");
            _defaultSql.AppendLine("  Inner Join Products On Categories.CategoryID = Products.CategoryID");

            InitializeComponent();
            InitializeQueryBuilder();

            Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, System.EventArgs e) => textBoxSql.Text = _defaultSql.ToString();

        private void InitializeQueryBuilder()
        {
            queryBuilder1.MetadataContainer.LoadingOptions.OfflineMode = true;
            queryBuilder1.SyntaxProvider = new MSSQLSyntaxProvider();
            queryBuilder1.MetadataContainer.ImportFromXML("Northwind.xml");
            queryBuilder1.InitializeDatabaseSchemaTree();
            queryBuilder1.SQL = _defaultSql.ToString();
        }

        private void textBoxSql_Validating(object sender, System.ComponentModel.CancelEventArgs e) => SilentAssignSqlText(textBoxSql.Text);

        private void queryBuilder1_SQLUpdated(object sender, System.EventArgs e)
        {
            if (!_isCanUpdateSqlText) 
                return;

            textBoxSql.Text = queryBuilder1.FormattedSQL;
        }

        private void SilentAssignSqlText(string text)
        {
            _isCanUpdateSqlText = false;

            sqlErrorBox1.Show("", queryBuilder1.SyntaxProvider);

            try
            {
                queryBuilder1.SQL = text;
            }
            catch (Exception ex)
            {
                sqlErrorBox1.Show(ex.Message, queryBuilder1.SyntaxProvider);
            }

            _isCanUpdateSqlText = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog();
            
            if(openDialog.ShowDialog() != DialogResult.OK || !File.Exists(openDialog.FileName))
                return;

            var sqlText = string.Empty;

            using (var reader = new StreamReader(openDialog.FileName))
                sqlText = reader.ReadToEnd();

            textBoxSql.Text = sqlText;
            SilentAssignSqlText(sqlText);
        }
    }
}
