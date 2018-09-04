﻿//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2018 Active Database Software              //
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

namespace BasicDemo
{
	internal enum SqlBuilderOptionsPages { MainQuery, DerievedQueries, ExpressionSubqueries };

	[ToolboxItem(false)]
	internal partial class SqlFormattingPage : UserControl
	{
		private SqlBuilderOptionsPages _page = SqlBuilderOptionsPages.MainQuery;
		private QueryBuilder _queryBuilder = null;
		private SQLBuilderSelectFormat _format;
		private bool _modified = false;


		public bool Modified { get { return _modified; } set { _modified = value; } }


		public SqlFormattingPage(SqlBuilderOptionsPages page, QueryBuilder queryBuilder)
		{
			_page = page;
			_queryBuilder = queryBuilder;
			_format = new SQLBuilderSelectFormat(null);

			if (_page == SqlBuilderOptionsPages.MainQuery)
				_format.Assign(_queryBuilder.SQLFormattingOptions.MainQueryFormat);
			else if (_page == SqlBuilderOptionsPages.DerievedQueries)
				_format.Assign(_queryBuilder.SQLFormattingOptions.DerivedQueryFormat);
			else if (_page == SqlBuilderOptionsPages.ExpressionSubqueries)
				_format.Assign(_queryBuilder.SQLFormattingOptions.ExpressionSubQueryFormat);

			InitializeComponent();

			cbPartsOnNewLines.Checked = _format.MainPartsFromNewLine;
			cbNewLineAfterKeywords.Checked = _format.NewLineAfterPartKeywords;
			updownGlobalIndent.Value = _format.IndentGlobal;
			updownPartIndent.Value = _format.IndentInPart;

			cbNewLineAfterSelectItem.Checked = _format.SelectListFormat.NewLineAfterItem;

			cbNewLineAfterDatasource.Checked = _format.FromClauseFormat.NewLineAfterDatasource;
			cbNewLineAfterJoin.Checked = _format.FromClauseFormat.NewLineAfterJoin;

			cbNewLineWhereTop.Checked = (_format.WhereFormat.NewLineAfter == SQLBuilderConditionFormatNewLine.AllLogical ||
				_format.WhereFormat.NewLineAfter == SQLBuilderConditionFormatNewLine.TopmostOr ||
				_format.WhereFormat.NewLineAfter == SQLBuilderConditionFormatNewLine.TopmostLogical);
			checkNewLineWhereTop_CheckedChanged(null, new EventArgs());
			cbNewLineWhereRest.Checked = (_format.WhereFormat.NewLineAfter == SQLBuilderConditionFormatNewLine.AllLogical);
			checkNewLineWhereRest_CheckedChanged(null, new EventArgs());
			updownWhereIndent.Value = _format.WhereFormat.IndentNestedConditions;

			cbNewLineAfterGroupItem.Checked = _format.GroupByFormat.NewLineAfterItem;

			cbNewLineHavingTop.Checked = (_format.HavingFormat.NewLineAfter == SQLBuilderConditionFormatNewLine.AllLogical ||
				_format.HavingFormat.NewLineAfter == SQLBuilderConditionFormatNewLine.TopmostOr ||
				_format.HavingFormat.NewLineAfter == SQLBuilderConditionFormatNewLine.TopmostLogical);
			checkNewLineHavingTop_CheckedChanged(null, new EventArgs());
			cbNewLineHavingRest.Checked = (_format.HavingFormat.NewLineAfter == SQLBuilderConditionFormatNewLine.AllLogical);
			checkNewLineHavingRest_CheckedChanged(null, new EventArgs());
			updownHavingIndent.Value = _format.HavingFormat.IndentNestedConditions;

			updownHavingIndent.ValueChanged += Changed;
			updownHavingIndent.TextChanged += Changed;
			cbNewLineHavingRest.CheckedChanged += checkNewLineHavingRest_CheckedChanged;
			cbNewLineHavingTop.CheckedChanged += checkNewLineHavingTop_CheckedChanged;
			cbNewLineAfterGroupItem.CheckedChanged += Changed;
			updownWhereIndent.ValueChanged += Changed;
			updownWhereIndent.TextChanged += Changed;
			cbNewLineWhereRest.CheckedChanged += checkNewLineWhereRest_CheckedChanged;
			cbNewLineWhereTop.CheckedChanged += checkNewLineWhereTop_CheckedChanged;
			cbNewLineAfterJoin.CheckedChanged += Changed;
			cbNewLineAfterDatasource.CheckedChanged += Changed;
			cbNewLineAfterSelectItem.CheckedChanged += Changed;
			updownPartIndent.ValueChanged += Changed;
			updownPartIndent.TextChanged += Changed;
			updownGlobalIndent.ValueChanged += Changed;
			updownGlobalIndent.TextChanged += Changed;
			cbNewLineAfterKeywords.CheckedChanged += Changed;
			cbPartsOnNewLines.CheckedChanged += Changed;
		}

		protected override void Dispose(bool disposing)
		{
			updownHavingIndent.ValueChanged -= Changed;
			updownHavingIndent.TextChanged -= Changed;
			cbNewLineHavingRest.CheckedChanged -= checkNewLineHavingRest_CheckedChanged;
			cbNewLineHavingTop.CheckedChanged -= checkNewLineHavingTop_CheckedChanged;
			cbNewLineAfterGroupItem.CheckedChanged -= Changed;
			updownWhereIndent.ValueChanged -= Changed;
			updownWhereIndent.TextChanged -= Changed;
			cbNewLineWhereRest.CheckedChanged -= checkNewLineWhereRest_CheckedChanged;
			cbNewLineWhereTop.CheckedChanged -= checkNewLineWhereTop_CheckedChanged;
			cbNewLineAfterJoin.CheckedChanged -= Changed;
			cbNewLineAfterDatasource.CheckedChanged -= Changed;
			cbNewLineAfterSelectItem.CheckedChanged -= Changed;
			updownPartIndent.ValueChanged -= Changed;
			updownPartIndent.TextChanged -= Changed;
			updownGlobalIndent.ValueChanged -= Changed;
			updownGlobalIndent.TextChanged -= Changed;
			cbNewLineAfterKeywords.CheckedChanged -= Changed;
			cbPartsOnNewLines.CheckedChanged -= Changed;

			if (disposing && (components != null))
			{
				components.Dispose();
			}

			base.Dispose(disposing);
		}

		private void Changed(object sender, EventArgs e)
		{
			Modified = true;
		}

		private void checkNewLineWhereTop_CheckedChanged(object sender, EventArgs e)
		{
			cbNewLineWhereRest.Enabled = cbNewLineWhereTop.Checked;

			if (!cbNewLineWhereTop.Checked)
			{
				cbNewLineWhereRest.Checked = false;
				checkNewLineWhereRest_CheckedChanged(cbNewLineWhereRest, new EventArgs());
			}

			if (sender != null)
			{
				Modified = true;
			}
		}

		private void checkNewLineWhereRest_CheckedChanged(object sender, EventArgs e)
		{
			updownWhereIndent.Enabled = cbNewLineWhereRest.Checked;

			if (sender != null)
			{
				Modified = true;
			}
		}

		private void checkNewLineHavingTop_CheckedChanged(object sender, EventArgs e)
		{
			cbNewLineHavingRest.Enabled = cbNewLineHavingTop.Checked;

			if (!cbNewLineHavingTop.Checked)
			{
				cbNewLineHavingRest.Checked = false;
				checkNewLineHavingRest_CheckedChanged(cbNewLineHavingRest, new EventArgs());
			}

			if (sender != null)
			{
				Modified = true;
			}
		}

		private void checkNewLineHavingRest_CheckedChanged(object sender, EventArgs e)
		{
			updownHavingIndent.Enabled = cbNewLineHavingRest.Checked;

			if (sender != null)
			{
				Modified = true;
			}
		}

		public void ApplyChanges()
		{
			if (Modified)
			{
				_format.MainPartsFromNewLine = cbPartsOnNewLines.Checked;
				_format.NewLineAfterPartKeywords = cbNewLineAfterKeywords.Checked;
				_format.IndentInPart = (int) updownPartIndent.Value;
				_format.IndentGlobal = (int) updownGlobalIndent.Value;

				_format.SelectListFormat.NewLineAfterItem = cbNewLineAfterSelectItem.Checked;

				_format.FromClauseFormat.NewLineAfterDatasource = cbNewLineAfterDatasource.Checked;
				_format.FromClauseFormat.NewLineAfterJoin = cbNewLineAfterJoin.Checked;

				if (cbNewLineWhereRest.Checked)
				{
					_format.WhereFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.AllLogical;
				}
				else if (cbNewLineWhereTop.Checked)
				{
					_format.WhereFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.TopmostLogical;
				}
				else
				{
					_format.WhereFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.None;
				}

				_format.WhereFormat.IndentNestedConditions = (int) updownWhereIndent.Value;

				_format.GroupByFormat.NewLineAfterItem = cbNewLineAfterGroupItem.Checked;

				if (cbNewLineHavingRest.Checked)
				{
					_format.HavingFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.AllLogical;
				}
				else if (cbNewLineHavingTop.Checked)
				{
					_format.HavingFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.TopmostLogical;
				}
				else
				{
					_format.HavingFormat.NewLineAfter = SQLBuilderConditionFormatNewLine.None;
				}

				_format.HavingFormat.IndentNestedConditions = (int) updownHavingIndent.Value;


				if (_page == SqlBuilderOptionsPages.MainQuery)
				{
					_queryBuilder.SQLFormattingOptions.MainQueryFormat.Assign(_format);
				}
				else if (_page == SqlBuilderOptionsPages.DerievedQueries)
				{
					_queryBuilder.SQLFormattingOptions.DerivedQueryFormat.Assign(_format);
				}
				else if (_page == SqlBuilderOptionsPages.ExpressionSubqueries)
				{
					_queryBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.Assign(_format);
				}
			}
		}
	}
}
