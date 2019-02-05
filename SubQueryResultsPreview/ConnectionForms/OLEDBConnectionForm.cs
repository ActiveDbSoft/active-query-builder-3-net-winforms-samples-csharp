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
	public partial class OLEDBConnectionForm : Form
	{
		public string ConnectionString = "";

		public OLEDBConnectionForm()
		{
			InitializeComponent();
		}

		private void buttonConnect_Click(object sender, EventArgs e)
		{
			OleDbConnectionStringBuilder builder = new OleDbConnectionStringBuilder();

			try
			{
				builder.ConnectionString = textBoxConnectionString.Text;

				this.Cursor = Cursors.WaitCursor;

				using (OleDbConnection connection = new OleDbConnection(builder.ConnectionString))
				{
					try
					{
						connection.Open();
						ConnectionString = builder.ConnectionString;
					}
					catch (System.Exception ex)
					{
						MessageBox.Show(ex.Message, "Failed to connect.");
						this.DialogResult = DialogResult.None;
					}
					finally
					{
						this.Cursor = Cursors.Default;
					}
				}
			}
			catch (ArgumentException ae)
			{
				MessageBox.Show(ae.Message, "Invalid OLE DB connection string.");
				this.DialogResult = DialogResult.None;
			}
		}
	}
}
