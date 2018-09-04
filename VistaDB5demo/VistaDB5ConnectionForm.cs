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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using VistaDB.Diagnostic;
using VistaDB.Provider;

namespace VistaDB5demo
{
	public partial class VistaDB5ConnectionForm : Form
	{
		public string ConnectionString = "";


		public VistaDB5ConnectionForm()
		{
			InitializeComponent();
		}

		private void buttonBrowse_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				textboxDatabase.Text = openFileDialog1.FileName;
			}
		}

		private void buttonConnect_Click(object sender, EventArgs e)
		{
			
			VistaDBConnectionStringBuilder builder = new VistaDBConnectionStringBuilder();

			builder.DataSource = textboxDatabase.Text;
			builder.OpenMode = VistaDB.VistaDBDatabaseOpenMode.NonexclusiveReadOnly;

			if (textboxPassword.Text.Length > 0)
			{
				builder.Password = textboxPassword.Text;
			}

			this.ConnectionString = builder.ConnectionString;
		}
	}
}
