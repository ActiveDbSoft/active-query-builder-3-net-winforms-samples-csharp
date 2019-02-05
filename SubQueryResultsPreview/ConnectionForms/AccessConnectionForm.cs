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
using System.Data.OleDb;
using System.Windows.Forms;

namespace SubQueryResultsPreview
{
	public partial class AccessConnectionForm : Form
	{
		public string ConnectionString = "";

		public AccessConnectionForm()
		{
			InitializeComponent();
		}

		private void buttonConnect_Click(object sender, EventArgs e)
		{
			ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0";
			ConnectionString += ";Data Source=" + textboxDatabase.Text;
			ConnectionString += ";User Id=" + textboxUserName.Text;
			ConnectionString += ";Password=";

			if (textboxPassword.Text.Length > 0)
			{
				ConnectionString += textboxPassword.Text + ";";
			}

			// check the connection

			using (OleDbConnection connection = new OleDbConnection(ConnectionString))
			{
				this.Cursor = Cursors.WaitCursor;

				try
				{
					connection.Open();
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

		private void buttonBrowse_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				textboxDatabase.Text = openFileDialog1.FileName;
			}
		}
	}
}
