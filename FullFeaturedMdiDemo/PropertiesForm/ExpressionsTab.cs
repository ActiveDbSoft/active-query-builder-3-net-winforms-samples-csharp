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
using System.Windows.Forms;
using ActiveQueryBuilder.Core;

namespace FullFeaturedMdiDemo.PropertiesForm
{
    public partial class ExpressionsTab : UserControl
    {
        public  SQLBuilderSelectFormat SelectFormat { get; set; }
        public  SQLFormattingOptions FormattingOptions { get; set; }

        public ExpressionsTab(SQLFormattingOptions formattingOptions, SQLBuilderSelectFormat selectFormat)
        {
            InitializeComponent();

            SelectFormat = selectFormat;
            FormattingOptions = formattingOptions;

            LoadOptions();
        }

        public void LoadOptions()
        {
            if (SelectFormat.WhereFormat.NewLineAfter == SQLBuilderConditionFormatNewLine.TopmostLogical &&
                SelectFormat.HavingFormat.NewLineAfter == SQLBuilderConditionFormatNewLine.TopmostLogical)
            {
                chBxUpperLvlLogicExprFromNewLines.Checked = true;

                chBxStartAllLogicExprFromNewLines.Enabled = true;
            }
            if (SelectFormat.WhereFormat.NewLineAfter == SQLBuilderConditionFormatNewLine.None &&
                SelectFormat.HavingFormat.NewLineAfter == SQLBuilderConditionFormatNewLine.None)
            {
                chBxStartAllLogicExprFromNewLines.Checked = false;
                chBxStartAllLogicExprFromNewLines.Enabled = false;
            }

            if (SelectFormat.WhereFormat.NewLineAfter == SQLBuilderConditionFormatNewLine.AllLogical &&
                SelectFormat.HavingFormat.NewLineAfter == SQLBuilderConditionFormatNewLine.AllLogical)
            {
                chBxStartAllLogicExprFromNewLines.Checked = true;
                UpDownIndentForNestedConditions.Enabled = true;
            }
            else
            {
                if (SelectFormat.WhereFormat.NewLineAfter == SQLBuilderConditionFormatNewLine.TopmostLogical &&
                    SelectFormat.HavingFormat.NewLineAfter == SQLBuilderConditionFormatNewLine.TopmostLogical)
                {
                    chBxUpperLvlLogicExprFromNewLines.Checked = true;
                }
                if (SelectFormat.WhereFormat.NewLineAfter == SQLBuilderConditionFormatNewLine.None &&
                    SelectFormat.HavingFormat.NewLineAfter == SQLBuilderConditionFormatNewLine.None)
                {
                    UpDownIndentForNestedConditions.Enabled = false;
                } 
            }

            if (SelectFormat.WhereFormat.NewLineBefore == SQLBuilderConditionFormatNewLine.TopmostLogical &&
                SelectFormat.HavingFormat.NewLineBefore == SQLBuilderConditionFormatNewLine.TopmostLogical)
            {

            }
            if (SelectFormat.WhereFormat.NewLineBefore == SQLBuilderConditionFormatNewLine.AllLogical &&
                SelectFormat.HavingFormat.NewLineBefore == SQLBuilderConditionFormatNewLine.AllLogical)
            {
                radButStartLines.Checked = true;
                chBxUpperLvlLogicExprFromNewLines.Checked = true;
                chBxStartAllLogicExprFromNewLines.Checked = true;
            }

            if (SelectFormat.WhereFormat.NewLineBefore == SQLBuilderConditionFormatNewLine.None &&
                SelectFormat.HavingFormat.NewLineBefore == SQLBuilderConditionFormatNewLine.None)
            {
                radButEndLines.Checked = true;
            }

            UpDownIndentForNestedConditions.Value = SelectFormat.WhereFormat.IndentNestedConditions;
            UpDownIndentForNestedConditions.Value = SelectFormat.HavingFormat.IndentNestedConditions;

            UpDownIndentForNestedConditions.Value = SelectFormat.FromClauseFormat.JoinConditionFormat.IndentNestedConditions;
            chBxBranchConditionKeyWrdsFromNewLinesWhen.Checked = SelectFormat.ConditionalOperatorsFormat.NewLineBeforeWhen;
     
            chBxBranchConditionExprFromNewLines.Checked = SelectFormat.ConditionalOperatorsFormat.NewLineAfterWhen;

            chBxResultKwrdsFromNewLinesThen.Checked = SelectFormat.ConditionalOperatorsFormat.NewLineBeforeThen;

            chBxBranchResultExprsFromNewLines.Checked = SelectFormat.ConditionalOperatorsFormat.NewLineAfterThen;

            UpDownBranchKeyWrdsIndent.Value = SelectFormat.ConditionalOperatorsFormat.IndentBranch;

            UpDownExprsIndent.Value = SelectFormat.ConditionalOperatorsFormat.IndentExpressions;
        }

        private void chBxUpperLvlLogicExprFromNewLines_CheckedChanged(object sender, EventArgs e)
        {
            using (new UpdateRegion(FormattingOptions))
            {
                if (chBxUpperLvlLogicExprFromNewLines.Checked)
                {
                    SelectFormat.WhereFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.TopmostLogical;
                    SelectFormat.HavingFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.TopmostLogical;

                    chBxStartAllLogicExprFromNewLines.Enabled = true;
                }
                else
                {
                    SelectFormat.WhereFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.None;
                    SelectFormat.HavingFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.None;

                    chBxStartAllLogicExprFromNewLines.Checked = false;
                    chBxStartAllLogicExprFromNewLines.Enabled = false;
                }
            }
        }

        private void chBxStartAllLogicExprFromNewLines_CheckedChanged(object sender, EventArgs e)
        {
            using (new UpdateRegion(FormattingOptions))
            {
                if (chBxStartAllLogicExprFromNewLines.Checked)
                {
                    SelectFormat.WhereFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.AllLogical;
                    SelectFormat.HavingFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.AllLogical;

                    UpDownIndentForNestedConditions.Enabled = true;
                }
                else
                {
                    if (chBxUpperLvlLogicExprFromNewLines.Checked)
                    {
                        SelectFormat.WhereFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.TopmostLogical;
                        SelectFormat.HavingFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.TopmostLogical;
                    }
                    else
                    {
                        SelectFormat.WhereFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.None;
                        SelectFormat.HavingFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.None;
                    }

                    UpDownIndentForNestedConditions.Enabled = false;
                }
            }
        }

        private void radButStartLines_CheckedChanged(object sender, EventArgs e)
        {
            using (new UpdateRegion(FormattingOptions))
            {
                if (radButStartLines.Checked)
                {
                    if (chBxUpperLvlLogicExprFromNewLines.Checked && !chBxStartAllLogicExprFromNewLines.Checked)
                    {
                        SelectFormat.WhereFormat.NewLineBefore = SQLBuilderConditionFormatNewLine.TopmostLogical;
                        SelectFormat.HavingFormat.NewLineBefore = SQLBuilderConditionFormatNewLine.TopmostLogical;
                    }
                    if (chBxUpperLvlLogicExprFromNewLines.Checked && chBxStartAllLogicExprFromNewLines.Checked)
                    {
                        SelectFormat.WhereFormat.NewLineBefore = SQLBuilderConditionFormatNewLine.AllLogical;
                        SelectFormat.HavingFormat.NewLineBefore = SQLBuilderConditionFormatNewLine.AllLogical;
                    }
                }
            }
        }

        private void radButEndLines_CheckedChanged(object sender, EventArgs e)
        {
            using (new UpdateRegion(FormattingOptions))
            {
                if (radButEndLines.Checked)
                {
                    SelectFormat.WhereFormat.NewLineBefore = SQLBuilderConditionFormatNewLine.None;
                    SelectFormat.HavingFormat.NewLineBefore = SQLBuilderConditionFormatNewLine.None;
                }
            }
        }

        private void UpDownIndentForNestedConditions_ValueChanged(object sender, EventArgs e)
        {
            using (new UpdateRegion(FormattingOptions))
            {
                SelectFormat.WhereFormat.IndentNestedConditions = (int)UpDownIndentForNestedConditions.Value;
                SelectFormat.HavingFormat.IndentNestedConditions = (int)UpDownIndentForNestedConditions.Value;

                SelectFormat.FromClauseFormat.JoinConditionFormat.IndentNestedConditions =
                    (int) UpDownIndentForNestedConditions.Value;
            }
        }

        private void chBxBranchConditionKeyWrdsFromNewLinesWhen_CheckedChanged(object sender, EventArgs e)
        {
            SelectFormat.ConditionalOperatorsFormat.NewLineBeforeWhen = chBxBranchConditionKeyWrdsFromNewLinesWhen.Checked;
        }

        private void chBxBranchConditionExprFromNewLines_CheckedChanged(object sender, EventArgs e)
        {
            SelectFormat.ConditionalOperatorsFormat.NewLineAfterWhen = chBxBranchConditionExprFromNewLines.Checked;
        }

        private void chBxResultKwrdsFromNewLinesThen_CheckedChanged(object sender, EventArgs e)
        {
            SelectFormat.ConditionalOperatorsFormat.NewLineBeforeThen = chBxResultKwrdsFromNewLinesThen.Checked;
        }

        private void chBxBranchResultExprsFromNewLines_CheckedChanged(object sender, EventArgs e)
        {
            SelectFormat.ConditionalOperatorsFormat.NewLineAfterThen = chBxBranchResultExprsFromNewLines.Checked;
        }

        private void UpDownBranchKeyWrdsIndent_ValueChanged(object sender, EventArgs e)
        {
            SelectFormat.ConditionalOperatorsFormat.IndentBranch = (int) UpDownBranchKeyWrdsIndent.Value;
        }

        private void UpDownExprsIndent_ValueChanged(object sender, EventArgs e)
        {
            SelectFormat.ConditionalOperatorsFormat.IndentExpressions = (int)UpDownExprsIndent.Value;
        }
    }
}
