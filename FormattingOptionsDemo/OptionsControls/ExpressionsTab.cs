//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2025 Active Database Software              //
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
    public partial class ExpressionsTab : UserControl, IOptionsLoader
    {
        public  SQLBuilderSelectFormat SelectFormat { get; set; }
        public  SQLFormattingOptions FormattingOptions { get; set; }

        public ExpressionsTab(SQLFormattingOptions formattingOptions, SQLBuilderSelectFormat selectFormat)
        {
            InitializeComponent();

            SelectFormat = selectFormat;
            FormattingOptions = formattingOptions;

            LoadOptionsOnForm();
        }

        public void LoadOptionsOnForm()
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

        public void LoadOptionsFromForm()
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

            if (radButEndLines.Checked)
            {
                SelectFormat.WhereFormat.NewLineBefore = SQLBuilderConditionFormatNewLine.None;
                SelectFormat.HavingFormat.NewLineBefore = SQLBuilderConditionFormatNewLine.None;
            }

            SelectFormat.WhereFormat.IndentNestedConditions = (int)UpDownIndentForNestedConditions.Value;
            SelectFormat.HavingFormat.IndentNestedConditions = (int)UpDownIndentForNestedConditions.Value;

            SelectFormat.FromClauseFormat.JoinConditionFormat.IndentNestedConditions =
                (int)UpDownIndentForNestedConditions.Value;

            SelectFormat.ConditionalOperatorsFormat.NewLineBeforeWhen =
                chBxBranchConditionKeyWrdsFromNewLinesWhen.Checked;

            SelectFormat.ConditionalOperatorsFormat.NewLineAfterWhen =
                chBxBranchConditionExprFromNewLines.Checked;

            SelectFormat.ConditionalOperatorsFormat.NewLineBeforeThen = chBxResultKwrdsFromNewLinesThen.Checked;

            SelectFormat.ConditionalOperatorsFormat.NewLineAfterThen = chBxBranchResultExprsFromNewLines.Checked;

            SelectFormat.ConditionalOperatorsFormat.IndentBranch = (int)UpDownBranchKeyWrdsIndent.Value;

            SelectFormat.ConditionalOperatorsFormat.IndentExpressions = (int)UpDownExprsIndent.Value;
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

                FormattingOptions.NotifyUpdated();
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
                FormattingOptions.NotifyUpdated();
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
                FormattingOptions.NotifyUpdated();
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
                FormattingOptions.NotifyUpdated();
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

                FormattingOptions.NotifyUpdated();
            }
        }

        private void chBxBranchConditionKeyWrdsFromNewLinesWhen_CheckedChanged(object sender, EventArgs e)
        {
            using (new UpdateRegion(FormattingOptions))
            {
                SelectFormat.ConditionalOperatorsFormat.NewLineBeforeWhen =
                    chBxBranchConditionKeyWrdsFromNewLinesWhen.Checked;

                FormattingOptions.NotifyUpdated();
            }
        }

        private void chBxBranchConditionExprFromNewLines_CheckedChanged(object sender, EventArgs e)
        {
            using (new UpdateRegion(FormattingOptions))
            {
                SelectFormat.ConditionalOperatorsFormat.NewLineAfterWhen =
                    chBxBranchConditionExprFromNewLines.Checked;

                FormattingOptions.NotifyUpdated();
            }
        }

        private void chBxResultKwrdsFromNewLinesThen_CheckedChanged(object sender, EventArgs e)
        {
            using (new UpdateRegion(FormattingOptions))
            {
                SelectFormat.ConditionalOperatorsFormat.NewLineBeforeThen = chBxResultKwrdsFromNewLinesThen.Checked;

                FormattingOptions.NotifyUpdated();
            }
        }

        private void chBxBranchResultExprsFromNewLines_CheckedChanged(object sender, EventArgs e)
        {
            using (new UpdateRegion(FormattingOptions))
            {
                SelectFormat.ConditionalOperatorsFormat.NewLineAfterThen = chBxBranchResultExprsFromNewLines.Checked;

                FormattingOptions.NotifyUpdated();
            }
        }

        private void UpDownBranchKeyWrdsIndent_ValueChanged(object sender, EventArgs e)
        {
            using (new UpdateRegion(FormattingOptions))
            {
                SelectFormat.ConditionalOperatorsFormat.IndentBranch = (int) UpDownBranchKeyWrdsIndent.Value;

                FormattingOptions.NotifyUpdated();
            }
        }

        private void UpDownExprsIndent_ValueChanged(object sender, EventArgs e)
        {
            using (new UpdateRegion(FormattingOptions))
            {
                SelectFormat.ConditionalOperatorsFormat.IndentExpressions = (int)UpDownExprsIndent.Value;

                FormattingOptions.NotifyUpdated();
            }
        }
    }
}
