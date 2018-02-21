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
using System.Windows.Forms;

namespace PanesVisibilityDemo
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void cbRightPane_CheckedChanged(object sender, EventArgs e)
		{
			queryBuilder.PanesConfigurationOptions.DatabaseSchemaViewVisible = cbRightPane.Checked;
		}

		private void cbDesignPane_CheckedChanged(object sender, EventArgs e)
		{
			queryBuilder.PanesConfigurationOptions.DesignPaneVisible = cbDesignPane.Checked;

			// Design Pane and Query Columns Pane can't be invisible both
			if (!cbDesignPane.Checked && !cbQueryColumnsPane.Checked)
				cbQueryColumnsPane.Checked = true;
		}

		private void cbQueryColumnsPane_CheckedChanged(object sender, EventArgs e)
		{
			queryBuilder.PanesConfigurationOptions.QueryColumnsPaneVisible = cbQueryColumnsPane.Checked;

			// Design Pane and Query Columns Pane can't be invisible both
			if (!cbDesignPane.Checked && !cbQueryColumnsPane.Checked)
				cbDesignPane.Checked = true;
		}
	}
}
