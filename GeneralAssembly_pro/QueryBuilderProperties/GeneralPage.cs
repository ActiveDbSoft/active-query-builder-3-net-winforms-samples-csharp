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
using System.ComponentModel;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;

namespace GeneralAssembly.QueryBuilderProperties
{
    [ToolboxItem(false)]
    internal partial class GeneralPage : UserControl
    {
        private readonly SQLFormattingOptions _sqlFormattingOptions;

        public bool Modified { get; set; }


        public GeneralPage(SQLFormattingOptions sqlFormattingOptions)
        {
            Modified = false;
            _sqlFormattingOptions = sqlFormattingOptions;

            InitializeComponent();

            cbWordWrap.Checked = (_sqlFormattingOptions.RightMargin != 0);
            updownRightMargin.Enabled = cbWordWrap.Checked;

            updownRightMargin.Value = _sqlFormattingOptions.RightMargin == 0 ? 
                80 : _sqlFormattingOptions.RightMargin;

            comboKeywordsCasing.Items.Add("Capitalized");
            comboKeywordsCasing.Items.Add("Uppercase");
            comboKeywordsCasing.Items.Add("Lowercase");

            comboKeywordsCasing.SelectedIndex = (int) _sqlFormattingOptions.KeywordFormat;

            cbWordWrap.CheckedChanged += checkWordWrap_CheckedChanged;
            updownRightMargin.ValueChanged += updownRightMargin_ValueChanged;
            comboKeywordsCasing.SelectedIndexChanged += comboKeywordsCasing_SelectedIndexChanged;
        }

        protected override void Dispose(bool disposing)
        {
            cbWordWrap.CheckedChanged -= checkWordWrap_CheckedChanged;
            updownRightMargin.ValueChanged -= updownRightMargin_ValueChanged;
            comboKeywordsCasing.SelectedIndexChanged -= comboKeywordsCasing_SelectedIndexChanged;

            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        void comboKeywordsCasing_SelectedIndexChanged(object sender, EventArgs e)
        {
            Modified = true;
        }

        private void checkWordWrap_CheckedChanged(object sender, EventArgs e)
        {
            updownRightMargin.Enabled = cbWordWrap.Checked;
            Modified = true;
        }

        private void updownRightMargin_ValueChanged(object sender, EventArgs e)
        {
            Modified = true;            
        }

        public void ApplyChanges()
        {
            if (this.Modified)
            {
                if (cbWordWrap.Checked)
                {
                    _sqlFormattingOptions.RightMargin = (int)updownRightMargin.Value;
                }
                else
                {
                    _sqlFormattingOptions.RightMargin = 0; 
                }

                _sqlFormattingOptions.KeywordFormat = (KeywordFormat) comboKeywordsCasing.SelectedIndex;
            }
        }        
    }
}
