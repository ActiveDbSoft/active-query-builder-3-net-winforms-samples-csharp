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
using System.ComponentModel;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View.WinForms;

namespace GeneralAssembly.QueryBuilderProperties
{
	[ToolboxItem(false)]
	internal partial class GeneralPage : UserControl
	{
		private QueryBuilder _queryBuilder = null;
		bool _modified = false;


		public bool Modified { get { return _modified; } set { _modified = value; } }


		public GeneralPage(QueryBuilder queryBuilder)
		{
			_queryBuilder = queryBuilder;

			InitializeComponent();

			cbWordWrap.Checked = (_queryBuilder.SQLFormattingOptions.RightMargin != 0);
			updownRightMargin.Enabled = cbWordWrap.Checked;

			updownRightMargin.Value = _queryBuilder.SQLFormattingOptions.RightMargin == 0 ?
				80 : _queryBuilder.SQLFormattingOptions.RightMargin;

			comboKeywordsCasing.Items.Add("Capitalized");
			comboKeywordsCasing.Items.Add("Uppercase");
			comboKeywordsCasing.Items.Add("Lowercase");

			comboKeywordsCasing.SelectedIndex = (int)queryBuilder.SQLFormattingOptions.KeywordFormat;

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
					_queryBuilder.SQLFormattingOptions.RightMargin = (int)updownRightMargin.Value;
				}
				else
				{
					_queryBuilder.SQLFormattingOptions.RightMargin = 0;
				}

				_queryBuilder.SQLFormattingOptions.KeywordFormat = (KeywordFormat) comboKeywordsCasing.SelectedIndex;
			}
		}
	}
}
