//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2023 Active Database Software              //
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
    public partial class CommonTab : UserControl
    {
        public SQLBuilderSelectFormat SelectFormat { get; set; }
        public SQLFormattingOptions FormattingOptions { get; set; }

        public CommonTab(SQLFormattingOptions formattingOptions, SQLBuilderSelectFormat selectFormat)
        {
            InitializeComponent();
            SelectFormat = selectFormat;
            FormattingOptions = formattingOptions;

            LoadOptions();
        }

        public void LoadOptions()
        {
            chBxStartPartsFromNewLines.Checked = SelectFormat.MainPartsFromNewLine;
            chBxInsertNewLineAfterPartKeywords.Checked = SelectFormat.NewLineAfterPartKeywords;
            upDownPartIndent.Value = SelectFormat.IndentInPart;
            chBxStartSelectListItemsOnNewLines.Checked = SelectFormat.SelectListFormat.NewLineAfterItem;

            radButNewLineBeforeComma.Checked = SelectFormat.SelectListFormat.NewLineBeforeComma;
            radButNewLineAfterComma.Checked = SelectFormat.SelectListFormat.NewLineAfterItem;

            radButStartDataSourcesFromNewLines.Checked = SelectFormat.FromClauseFormat.NewLineAfterDatasource;
            chBxStartJoinConditionsOnNewLines.Checked = SelectFormat.FromClauseFormat.NewLineBeforeJoinExpression;
        }

        private void chBxStartPartsFromNewLines_CheckedChanged(object sender, EventArgs e)
        {
            SelectFormat.MainPartsFromNewLine = chBxStartPartsFromNewLines.Checked;
        }

        private void chBxInsertNewLineAfterPartKeywords_CheckedChanged(object sender, EventArgs e)
        {
            SelectFormat.NewLineAfterPartKeywords = chBxInsertNewLineAfterPartKeywords.Checked;
        }

        private void upDownPartIndent_ValueChanged(object sender, EventArgs e)
        {
            SelectFormat.IndentInPart = (int) upDownPartIndent.Value;
        }

        private void chBxStartSelectListItemsOnNewLines_CheckedChanged(object sender, EventArgs e)
        {
            SelectFormat.SelectListFormat.NewLineAfterItem = chBxStartSelectListItemsOnNewLines.Checked;
        }

        private void radButNewLineBeforeComma_CheckedChanged(object sender, EventArgs e)
        {
            using (new UpdateRegion(FormattingOptions))
            {
                SelectFormat.SelectListFormat.NewLineBeforeComma = radButNewLineBeforeComma.Checked;
                SelectFormat.OrderByFormat.NewLineBeforeComma = radButNewLineBeforeComma.Checked;
                SelectFormat.GroupByFormat.NewLineBeforeComma = radButNewLineBeforeComma.Checked;
            }
        }

        private void radButNewLineAfterComma_CheckedChanged(object sender, EventArgs e)
        {
            using (new UpdateRegion(FormattingOptions))
            {
                SelectFormat.SelectListFormat.NewLineAfterItem = radButNewLineAfterComma.Checked;
                SelectFormat.OrderByFormat.NewLineAfterItem = radButNewLineAfterComma.Checked;
                SelectFormat.GroupByFormat.NewLineAfterItem = radButNewLineAfterComma.Checked;
            }
        }

        private void radButStartDataSourcesFromNewLines_CheckedChanged(object sender, EventArgs e)
        {
            SelectFormat.FromClauseFormat.NewLineAfterDatasource = radButStartDataSourcesFromNewLines.Checked;
        }

        private void radButStartJoinKeywordsFromNewLines_CheckedChanged(object sender, EventArgs e)
        {
            SelectFormat.FromClauseFormat.NewLineAfterJoin = radButStartJoinKeywordsFromNewLines.Checked;
        }

        private void chBxStartJoinConditionsOnNewLines_CheckedChanged(object sender, EventArgs e)
        {
            SelectFormat.FromClauseFormat.NewLineBeforeJoinExpression = chBxStartJoinConditionsOnNewLines.Checked;
        }
    }
}
