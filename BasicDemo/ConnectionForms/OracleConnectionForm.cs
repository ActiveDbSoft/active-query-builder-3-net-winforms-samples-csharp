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
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace BasicDemo
{
	public partial class OracleConnectionForm : Form
	{
		public string ConnectionString = "";

		public OracleConnectionForm()
		{
			InitializeComponent();
		}

		private void buttonConnect_Click(object sender, EventArgs e)
		{
			OracleConnectionStringBuilder builder = new OracleConnectionStringBuilder();

			builder.DataSource = textBoxServerName.Text;

			builder.UserID = textBoxLogin.Text;
			builder.Password = textBoxPassword.Text;

			// check the connection

			using (OracleConnection connection = new OracleConnection(builder.ConnectionString))
			{
				this.Cursor = Cursors.WaitCursor;

				try
				{
					connection.Open();
					ConnectionString = builder.ConnectionString;
				}
				catch (System.Exception ex)
				{
					MessageBox.Show(ex.Message, "Connection Failure.");
					this.DialogResult = DialogResult.None;
				}
				finally
				{
					this.Cursor = Cursors.Default;
				}
			}
		}
	}
}
