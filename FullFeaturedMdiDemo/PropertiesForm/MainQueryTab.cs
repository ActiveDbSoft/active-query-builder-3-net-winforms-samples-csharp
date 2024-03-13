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
using System.Windows.Forms;
using ActiveQueryBuilder.Core;

namespace FullFeaturedMdiDemo.PropertiesForm
{
    public partial class MainQueryTab : UserControl
    {
        public SQLFormattingOptions Options { get; set; }

        public MainQueryTab(SQLFormattingOptions options)
        {
            InitializeComponent();
            Options = options;

            LoadOptions();
        }

        // Load options to form
        public void LoadOptions()
        {
            chBxEnableDynamicIndents.Checked = Options.DynamicIndents;
            chBxEnableDynamicRightMargin.Checked = Options.DynamicRightMargin;

            if (Options.RightMargin > 0)
            {
                chBxEnableWordWrap.Checked = false;
                upDownMaxCharsInLine.Value = Options.RightMargin;
            }
            else
            {
                // no margin
                chBxEnableWordWrap.Checked = false;
                upDownMaxCharsInLine.Value = 80;
            }
            chBxParenthesizeConditionsWithinAndOperators.Checked = Options.ParenthesizeANDGroups;
            chBxParenthesizeEachSingleCondition.Checked = Options.ParenthesizeSingleCriterion;

            switch (Options.KeywordFormat)
            {
                case KeywordFormat.FirstUpper:
                    cmbBoxKeyWordsCase.Text = "FirstUpper";
                    break;
                case KeywordFormat.UpperCase:
                    cmbBoxKeyWordsCase.Text = "UpperCase";
                    break;
                case KeywordFormat.LowerCase:
                    cmbBoxKeyWordsCase.Text = "LowerCase";
                    break;
            }
        }

        private void chBxEnableWordWrap_CheckedChanged(object sender, EventArgs e)
        {
            if (!chBxEnableWordWrap.Checked)
                Options.RightMargin = 0;
            else
                Options.RightMargin = (int)upDownMaxCharsInLine.Value;
        }

        private void chBxEnableDynamicIndents_CheckedChanged(object sender, EventArgs e)
        {
            Options.DynamicIndents = chBxEnableDynamicIndents.Checked;            
        }

        private void chBxEnableDynamicRightMargin_CheckedChanged(object sender, EventArgs e)
        {
            Options.DynamicRightMargin = chBxEnableDynamicRightMargin.Checked;
        }

        private void chBxParenthesizeConditionsWithinAndOperators_CheckedChanged(object sender, EventArgs e)
        {
            Options.ParenthesizeANDGroups = chBxParenthesizeConditionsWithinAndOperators.Checked;
        }

        private void chBxParenthesizeEachSingleCondition_CheckedChanged(object sender, EventArgs e)
        {
            Options.ParenthesizeSingleCriterion = chBxParenthesizeEachSingleCondition.Checked;
        }

        private void upDownMaxCharsInLine_ValueChanged(object sender, EventArgs e)
        {
            if (chBxEnableWordWrap.Checked)
                Options.RightMargin = (int) upDownMaxCharsInLine.Value;
        }

        private void cmbBoxKeyWordsCase_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbBoxKeyWordsCase.SelectedIndex)
            {
                case 0:
                    Options.KeywordFormat = KeywordFormat.FirstUpper;
                    break;
                case 1:
                    Options.KeywordFormat = KeywordFormat.UpperCase;
                    break;
                case 2:
                    Options.KeywordFormat = KeywordFormat.LowerCase;
                    break;
            }
        }
    }
}
