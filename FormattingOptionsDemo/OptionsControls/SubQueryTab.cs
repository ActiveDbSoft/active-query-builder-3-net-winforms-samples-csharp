//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2021 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;

namespace FormattingOptionsDemo
{
    public partial class SubQueryTab : UserControl, IOptionsLoader
    {
        public  SQLFormattingOptions FormattingOptions { get; set; }
        public  SQLBuilderSelectFormat SelectFormat { get; set; }

        public SubQueryTab(SQLFormattingOptions formattingOptions, string prefix = "Sub-Query")
        {
            InitializeComponent();

            FormattingOptions = formattingOptions;

            if (prefix == "Sub-Query")
            {
                SelectFormat = formattingOptions.ExpressionSubQueryFormat;
            }

            if (prefix == "Derived Tables")
            {
                groupBox1.Text = "Derived tables format options";
                label1.Text = "Derived tables indent:";
                chBxSubQueriesFromNewLines.Text = "Start derived tables from new lines";
                label2.Text = "Derived Tables format options\n"+
                              "determine the layout of sub-queries\n"+ 
                              "used as data sources in the query.";

                SelectFormat = formattingOptions.DerivedQueryFormat;
            }
            if (prefix == "CTE")
            {
                groupBox1.Text = "Common table expressions format options";
                label1.Text = "CTE indent:";
                chBxSubQueriesFromNewLines.Text = "Start CTE from new lines";
                label2.Text = "CTE format options\n" +
                              "determine the layout of sub-queries\n" +
                              "used above the main query in the with clause.";

                SelectFormat = formattingOptions.CTESubQueryFormat;
            }
            LoadOptionsOnForm();
        }

        public void LoadOptionsOnForm()
        {
            UpDownSubQueryIndent.Value = SelectFormat.IndentInPart;
            chBxSubQueriesFromNewLines.Checked = SelectFormat.SubQueryTextFromNewLine;
        }

        public void LoadOptionsFromForm()
        {
            SelectFormat.IndentInPart = (int) UpDownSubQueryIndent.Value;
            SelectFormat.SubQueryTextFromNewLine = chBxSubQueriesFromNewLines.Checked;
        }

        private void UpDownSubQueryIndent_ValueChanged(object sender, EventArgs e)
        {
            using (new UpdateRegion(FormattingOptions))
            {
                SelectFormat.IndentInPart = (int)UpDownSubQueryIndent.Value;

                FormattingOptions.NotifyUpdated();
            }
        }

        private void chBxSubQueriesFromNewLines_CheckedChanged(object sender, EventArgs e)
        {
            using (new UpdateRegion(FormattingOptions))
            {
                SelectFormat.SubQueryTextFromNewLine = chBxSubQueriesFromNewLines.Checked;

                FormattingOptions.NotifyUpdated();
            }
        }

        private void chBxSameFormatAsMainQuery_CheckedChanged(object sender, EventArgs e)
        {
            using (new UpdateRegion(FormattingOptions))
            {
                SelectFormat.Assign(FormattingOptions.MainQueryFormat);

                FormattingOptions.NotifyUpdated();
            }
        }
    }
}
