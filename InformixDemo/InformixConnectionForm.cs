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

using IBM.Data.Informix;

namespace InformixDemo
{
	public partial class InformixConnectionForm : Form
	{
		public string ConnectionString = "";


		public InformixConnectionForm()
		{
			InitializeComponent();
		}

		private void buttonConnect_Click(object sender, EventArgs e)
		{
			String connectionString = 
				String.Format("Server={0};Host={1};Protocol={2};Service={3};Database={4};Database Locale={5};User ID={6};Password={7};",
					tbServer.Text, tbHost.Text, tbProtocol.Text, tbService.Text, tbDatabase.Text, 
					tbDatabaseLocale.Text, tbUser.Text, tbPassword.Text);

			this.ConnectionString = connectionString;
		}
	}
}
