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
using System.ComponentModel;
using System.Windows.Forms;
using ActiveQueryBuilder.View.QueryView;
using ActiveQueryBuilder.View.WinForms;

namespace FullFeaturedDemo.PropertiesForm
{
	[ToolboxItem(false)]
	internal partial class MiscellaneousPage : UserControl
	{
		private QueryBuilder _queryBuilder = null;
		private bool _modified = false;


		public bool Modified { get { return _modified; } set { _modified = value; } }


		public MiscellaneousPage(QueryBuilder qb)
		{
			_queryBuilder = qb;

			InitializeComponent();

            comboLinksStyle.Items.Add("Simple style");
            comboLinksStyle.Items.Add("MS Access style");
            comboLinksStyle.Items.Add("SQL Server Enterprise Manager style");

            if (_queryBuilder.DesignPaneOptions.LinkStyle == LinkStyle.Simple)
			{
				comboLinksStyle.SelectedIndex = 0;
			}
			else if (_queryBuilder.DesignPaneOptions.LinkStyle == LinkStyle.MSAccess)
			{
				comboLinksStyle.SelectedIndex = 1;
			}
			else if (_queryBuilder.DesignPaneOptions.LinkStyle == LinkStyle.MSSQL)
			{
				comboLinksStyle.SelectedIndex = 2;
			}

			comboLinksStyle.SelectedIndexChanged += Changed;
		}

		protected override void Dispose(bool disposing)
		{
			comboLinksStyle.SelectedIndexChanged -= Changed;

			if (disposing && (components != null))
			{
				components.Dispose();
			}

			base.Dispose(disposing);
		}

		public void ApplyChanges()
		{
			if (Modified)
			{
				switch (comboLinksStyle.SelectedIndex)
				{
					case 0:
						_queryBuilder.DesignPaneOptions.LinkStyle = LinkStyle.Simple;
						break;
					case 2:
						_queryBuilder.DesignPaneOptions.LinkStyle = LinkStyle.MSSQL;
						break;
					default:
						_queryBuilder.DesignPaneOptions.LinkStyle = LinkStyle.MSAccess;
						break;
				}
			}
		}

		private void Changed(object sender, EventArgs e)
		{
			Modified = true;
		}
	}
}
