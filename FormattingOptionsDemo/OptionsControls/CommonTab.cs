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
    public partial class CommonTab : UserControl, IOptionsLoader
    {
        public SQLBuilderSelectFormat SelectFormat { get; set; }
        public SQLFormattingOptions FormattingOptions { get; set; }

        public CommonTab(SQLFormattingOptions formattingOptions, SQLBuilderSelectFormat selectFormat)
        {
            InitializeComponent();
            SelectFormat = selectFormat;
            FormattingOptions = formattingOptions;

            LoadOptionsOnForm();
        }

        public void LoadOptionsOnForm()
        {
            chBxStartPartsFromNewLines.Checked = SelectFormat.MainPartsFromNewLine;
            chBxInsertNewLineAfterPartKeywords.Checked = SelectFormat.NewLineAfterPartKeywords;
            upDownPartIndent.Value = SelectFormat.IndentInPart;
            chBxStartSelectListItemsOnNewLines.Checked = SelectFormat.SelectListFormat.NewLineAfterItem;

            radButNewLineBeforeComma.Checked = SelectFormat.SelectListFormat.NewLineBeforeComma;
            radButNewLineBeforeComma.Checked = SelectFormat.OrderByFormat.NewLineBeforeComma;
            radButNewLineBeforeComma.Checked = SelectFormat.GroupByFormat.NewLineBeforeComma;

            radButNewLineAfterComma.Checked = SelectFormat.SelectListFormat.NewLineAfterItem;
            radButNewLineAfterComma.Checked = SelectFormat.OrderByFormat.NewLineAfterItem;
            radButNewLineAfterComma.Checked = SelectFormat.GroupByFormat.NewLineAfterItem;

            radButStartJoinKeywordsFromNewLines.Checked = SelectFormat.FromClauseFormat.NewLineAfterDatasource;
            chBxStartJoinConditionsOnNewLines.Checked = SelectFormat.FromClauseFormat.NewLineBeforeJoinExpression;
        }

        public void LoadOptionsFromForm()
        {
            SelectFormat.MainPartsFromNewLine = chBxStartPartsFromNewLines.Checked;
            SelectFormat.NewLineAfterPartKeywords = chBxInsertNewLineAfterPartKeywords.Checked;
            SelectFormat.IndentInPart = (int)upDownPartIndent.Value;
            SelectFormat.SelectListFormat.NewLineAfterItem = chBxStartSelectListItemsOnNewLines.Checked;

            SelectFormat.SelectListFormat.NewLineBeforeComma = radButNewLineBeforeComma.Checked;
            SelectFormat.OrderByFormat.NewLineBeforeComma = radButNewLineBeforeComma.Checked;
            SelectFormat.GroupByFormat.NewLineBeforeComma = radButNewLineBeforeComma.Checked;

            SelectFormat.SelectListFormat.NewLineAfterItem = radButNewLineAfterComma.Checked;
            SelectFormat.OrderByFormat.NewLineAfterItem = radButNewLineAfterComma.Checked;
            SelectFormat.GroupByFormat.NewLineAfterItem = radButNewLineAfterComma.Checked;

            SelectFormat.FromClauseFormat.NewLineAfterDatasource = radButStartJoinKeywordsFromNewLines.Checked;
            SelectFormat.FromClauseFormat.NewLineBeforeJoinExpression = chBxStartJoinConditionsOnNewLines.Checked;
        }

        private void chBxStartPartsFromNewLines_CheckedChanged(object sender, EventArgs e)
        {
            using (new UpdateRegion(FormattingOptions))
            {
                SelectFormat.MainPartsFromNewLine = chBxStartPartsFromNewLines.Checked;

                FormattingOptions.NotifyUpdated();
            }
        }

        private void chBxInsertNewLineAfterPartKeywords_CheckedChanged(object sender, EventArgs e)
        {
            using (new UpdateRegion(FormattingOptions))
            {
                SelectFormat.NewLineAfterPartKeywords = chBxInsertNewLineAfterPartKeywords.Checked;

                FormattingOptions.NotifyUpdated();
            }
        }

        private void upDownPartIndent_ValueChanged(object sender, EventArgs e)
        {
            using (new UpdateRegion(FormattingOptions))
            {
                SelectFormat.IndentInPart = (int) upDownPartIndent.Value;

                FormattingOptions.NotifyUpdated();
            }
        }

        private void chBxStartSelectListItemsOnNewLines_CheckedChanged(object sender, EventArgs e)
        {
            using (new UpdateRegion(FormattingOptions))
            {
                SelectFormat.SelectListFormat.NewLineAfterItem = chBxStartSelectListItemsOnNewLines.Checked;

                FormattingOptions.NotifyUpdated();
            }
        }

        private void radButNewLineBeforeComma_CheckedChanged(object sender, EventArgs e)
        {
            using (new UpdateRegion(FormattingOptions))
            {
                SelectFormat.SelectListFormat.NewLineBeforeComma = radButNewLineBeforeComma.Checked;
                SelectFormat.OrderByFormat.NewLineBeforeComma = radButNewLineBeforeComma.Checked;
                SelectFormat.GroupByFormat.NewLineBeforeComma = radButNewLineBeforeComma.Checked;

                FormattingOptions.NotifyUpdated();
            }
        }

        private void radButNewLineAfterComma_CheckedChanged(object sender, EventArgs e)
        {
            using (new UpdateRegion(FormattingOptions))
            {
                SelectFormat.SelectListFormat.NewLineAfterItem = radButNewLineAfterComma.Checked;
                SelectFormat.OrderByFormat.NewLineAfterItem = radButNewLineAfterComma.Checked;
                SelectFormat.GroupByFormat.NewLineAfterItem = radButNewLineAfterComma.Checked;

                FormattingOptions.NotifyUpdated();
            }
        }

        private void radButStartDataSourcesFromNewLines_CheckedChanged(object sender, EventArgs e)
        {
            using (new UpdateRegion(FormattingOptions))
            {
                SelectFormat.FromClauseFormat.NewLineAfterDatasource = radButStartDataSourcesFromNewLines.Checked;

                FormattingOptions.NotifyUpdated();
            }
        }

        private void radButStartJoinKeywordsFromNewLines_CheckedChanged(object sender, EventArgs e)
        {
            using (new UpdateRegion(FormattingOptions))
            {
                SelectFormat.FromClauseFormat.NewLineAfterJoin = radButStartJoinKeywordsFromNewLines.Checked;

                FormattingOptions.NotifyUpdated();
            }
        }

        private void chBxStartJoinConditionsOnNewLines_CheckedChanged(object sender, EventArgs e)
        {
            using (new UpdateRegion(FormattingOptions))
            {
                SelectFormat.FromClauseFormat.NewLineBeforeJoinExpression = chBxStartJoinConditionsOnNewLines.Checked;

                FormattingOptions.NotifyUpdated();
            }
        }
    }
}
