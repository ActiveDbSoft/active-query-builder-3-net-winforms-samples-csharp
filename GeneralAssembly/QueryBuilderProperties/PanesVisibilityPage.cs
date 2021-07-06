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
using System.ComponentModel;
using System.Windows.Forms;
using ActiveQueryBuilder.View.WinForms;

namespace GeneralAssembly.QueryBuilderProperties
{
	[ToolboxItem(false)]
	internal partial class PanesVisibilityPage : UserControl
	{
		private QueryBuilder _queryBuilder = null;
		bool _modified = false;


		public bool Modified { get { return _modified; } set { _modified = value; } }


		public PanesVisibilityPage(QueryBuilder qb)
		{
			_queryBuilder = qb;

			InitializeComponent();

			cbShowDesignPane.Checked = _queryBuilder.PanesConfigurationOptions.DesignPaneVisible;
			cbShowQueryColumnsPane.Checked = _queryBuilder.PanesConfigurationOptions.QueryColumnsPaneVisible;
			cbShowDatabaseSchemaView.Checked = _queryBuilder.PanesConfigurationOptions.DatabaseSchemaViewVisible;
			cbShowQueryNavigationBar.Checked = _queryBuilder.PanesConfigurationOptions.QueryNavigationBarVisible;

			cbShowDesignPane.CheckedChanged += Changed;
			cbShowQueryColumnsPane.CheckedChanged += Changed;
			cbShowDatabaseSchemaView.CheckedChanged += Changed;
			cbShowQueryNavigationBar.CheckedChanged += Changed;
		}

		protected override void Dispose(bool disposing)
		{
			cbShowDesignPane.CheckedChanged -= Changed;
			cbShowQueryColumnsPane.CheckedChanged -= Changed;
			cbShowDatabaseSchemaView.CheckedChanged -= Changed;
			cbShowQueryNavigationBar.CheckedChanged -= Changed;

			if (disposing && (components != null))
			{
				components.Dispose();
			}

			base.Dispose(disposing);
		}

		private void Changed(object sender, EventArgs e)
		{
			if (sender == cbShowDesignPane)
			{
				if (!cbShowDesignPane.Checked && !cbShowQueryColumnsPane.Checked)
					cbShowQueryColumnsPane.Checked = true;
			}
			else if (sender == cbShowQueryColumnsPane)
			{
				if (!cbShowDesignPane.Checked && !cbShowQueryColumnsPane.Checked)
					cbShowDesignPane.Checked = true;
			}

			Modified = true;
		}

		public void ApplyChanges()
		{
			if (Modified)
			{
				_queryBuilder.PanesConfigurationOptions.BeginUpdate();

				try
				{
					_queryBuilder.PanesConfigurationOptions.DesignPaneVisible = cbShowDesignPane.Checked;
					_queryBuilder.PanesConfigurationOptions.QueryColumnsPaneVisible = cbShowQueryColumnsPane.Checked;
					_queryBuilder.PanesConfigurationOptions.DatabaseSchemaViewVisible = cbShowDatabaseSchemaView.Checked;
					_queryBuilder.PanesConfigurationOptions.QueryNavigationBarVisible = cbShowQueryNavigationBar.Checked;
				}
				finally
				{
					_queryBuilder.PanesConfigurationOptions.EndUpdate();
				}
			}
		}
	}
}
