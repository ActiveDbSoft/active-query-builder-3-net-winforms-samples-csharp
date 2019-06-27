//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2019 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View.WinForms;


namespace AlternateNames
{
    public partial class Form1 : Form
    {
        private string _lastValidText;
        private string _lastValidTextReal;
        private int _errorPosition = -1;
        private int _errorPositionReal = -1;
        public Form1()
		{
			InitializeComponent();
		}

        protected override void OnLoad(EventArgs e)
        {
            // set required syntax provider
            queryBuilder1.SyntaxProvider = new DB2SyntaxProvider();

            try
            {
				// Load demo metadata from XML file
                queryBuilder1.MetadataLoadingOptions.OfflineMode = true;
                queryBuilder1.MetadataContainer.ImportFromXML("db2_sample_with_alt_names.xml");
                queryBuilder1.InitializeDatabaseSchemaTree();

				// set example query text
	            queryBuilder1.SQL = "Select DEPARTMENT.DEPTNO, DEPARTMENT.DEPTNAME, DEPARTMENT.MGRNO From DEPARTMENT";
            }
            catch (QueryBuilderException ex)
            {
                MessageBox.Show(ex.Message);
            }

            base.OnLoad(e);
        }

		private void queryBuilder_SQLUpdated(object sender, EventArgs e)
		{
			// Text of SQL query has been updated.

			// To get the formatted query text with alternate object names just use FormattedSQL property
			_lastValidText = textBox1.Text = queryBuilder1.FormattedSQL;

			// To get the query text, ready for execution on SQL server with real object names just use SQL property.
            _lastValidTextReal = textBox2.Text = queryBuilder1.SQL;

            // The query text containing in SQL property is unformatted. If you need the formatted text, but with real object names, 
            // do the following:
            //			SQLFormattingOptions formattingOptions = new SQLFormattingOptions();
            //			formattingOptions.Assign(queryBuilder1.SQLFormattingOptions); // copy actual formatting options from the QueryBuilder
            //			formattingOptions.UseAltNames = false; // disable alt names
            //			textBox2.Text = FormattedSQLBuilder.GetSQL(queryBuilder1.SQLQuery.QueryRoot, formattingOptions);
        }
		
		private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			try
			{
				// Update the query builder with manually edited query text:
				queryBuilder1.SQL = textBox1.Text;

				// Hide error banner if any
                errorBox1.Show(null, queryBuilder1.SyntaxProvider);
            }
			catch (SQLParsingException ex)
			{
				// Set caret to error position
				textBox1.SelectionStart = ex.ErrorPos.pos;

                // Show banner with error text
                errorBox1.Show(ex.Message, queryBuilder1.SyntaxProvider);
                _errorPosition = ex.ErrorPos.pos;
            }
		}

		private void textBox2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			try
			{
				// Update the query builder with manually edited query text:
				queryBuilder1.SQL = textBox2.Text;

                // Hide error banner if any
                errorBox2.Show(null, queryBuilder1.SyntaxProvider);
            }
			catch (SQLParsingException ex)
			{
				// Set caret to error position
				textBox2.SelectionStart = ex.ErrorPos.pos;

                // Show banner with error text
                errorBox2.Show(ex.Message, queryBuilder1.SyntaxProvider);
                _errorPositionReal = ex.ErrorPos.pos;
            }
		}

		private void editMetadataToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Open the metadata container editor
			QueryBuilder.EditMetadataContainer(queryBuilder1.SQLContext);
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			QueryBuilder.ShowAboutDialog();
		}

        private void ErrorBox2_GoToErrorPosition(object sender, EventArgs e)
        {
            if (_errorPosition != -1)
            {
                textBox2.SelectionStart = _errorPositionReal;
                textBox2.SelectionLength = 0;
                textBox2.ScrollToCaret();
            }

            textBox2.Focus();
        }

        private void ErrorBox2_RevertValidText(object sender, EventArgs e)
        {
            textBox2.Text = _lastValidTextReal;
            textBox2.Focus();
        }

        private void ErrorBox1_GoToErrorPosition(object sender, EventArgs e)
        {
            if (_errorPosition != -1)
            {
                textBox1.SelectionStart = _errorPosition;
                textBox1.SelectionLength = 0;
                textBox1.ScrollToCaret();
            }

            errorBox1.Visible = false;
            textBox1.Focus();
        }

        private void ErrorBox1_RevertValidText(object sender, EventArgs e)
        {
            textBox1.Text = _lastValidText;
            textBox1.Focus();
            errorBox1.Visible = false;
        }
    }
}
