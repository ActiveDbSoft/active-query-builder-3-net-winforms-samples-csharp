//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2018 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;

namespace FullFeaturedMdiDemo.PropertiesForm
{
    public enum SubQueryType { Derived, Cte, Expression}

    public partial class SubQueryTab : UserControl
    {
        public  SQLFormattingOptions FormattingOptions { get; set; }
        public  SQLBuilderSelectFormat SelectFormat { get; set; }

        public SubQueryTab(SQLFormattingOptions formattingOptions, SubQueryType type = SubQueryType.Expression)
        {
            InitializeComponent();

            FormattingOptions = formattingOptions;

            if (type == SubQueryType.Expression)
            {
                SelectFormat = formattingOptions.ExpressionSubQueryFormat;
            }

            else if (type == SubQueryType.Derived)
            {
                groupBox1.Text = "Derived tables format options";
                label1.Text = "Derived tables indent:";
                chBxSubQueriesFromNewLines.Text = "Start derived tables from new lines";
                label2.Text = "Derived Tables format options\n"+
                              "determine the layout of sub-queries\n"+ 
                              "used as data sources in the query.";

                SelectFormat = formattingOptions.DerivedQueryFormat;
            }

            else if (type == SubQueryType.Cte)
            {
                groupBox1.Text = "Common table expressions format options";
                label1.Text = "CTE indent:";
                chBxSubQueriesFromNewLines.Text = "Start CTE from new lines";
                label2.Text = "CTE format options\n" +
                              "determine the layout of sub-queries\n" +
                              "used above the main query in the with clause.";

                SelectFormat = formattingOptions.CTESubQueryFormat;
            }

            LoadOptions();
        }

        public void LoadOptions()
        {
            UpDownSubQueryIndent.Value = SelectFormat.IndentInPart;
            chBxSubQueriesFromNewLines.Checked = SelectFormat.SubQueryTextFromNewLine;
        }

        private void UpDownSubQueryIndent_ValueChanged(object sender, EventArgs e)
        {
            SelectFormat.IndentInPart = (int)UpDownSubQueryIndent.Value;
        }

        private void chBxSubQueriesFromNewLines_CheckedChanged(object sender, EventArgs e)
        {
            SelectFormat.SubQueryTextFromNewLine = chBxSubQueriesFromNewLines.Checked;
        }

        private void chBxSameFormatAsMainQuery_CheckedChanged(object sender, EventArgs e)
        {
            SelectFormat.Assign(FormattingOptions.MainQueryFormat);
        }
    }
}
