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
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SubQueryResultsPreview
{
	public partial class MSSQLConnectionForm : Form
	{
		public string ConnectionString = "";

		public MSSQLConnectionForm()
		{
			InitializeComponent();

			comboBoxAuthentication.SelectedIndex = 0; //0 - Windows Authentication
			comboBoxDatabase.SelectedIndex = 0;

			textBoxLogin.Enabled = false;
			textBoxPassword.Enabled = false;
		}

		private void comboBoxAuthentication_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBoxAuthentication.SelectedIndex == 0)
			{
				//Windows Authentication
				textBoxLogin.Enabled = false;
				textBoxPassword.Enabled = false;
			}
			else
			{
				//SQL Server Authentication
				textBoxLogin.Enabled = true;
				textBoxPassword.Enabled = true;
			}
		}

		private void comboBoxDatabase_DropDown(object sender, EventArgs e)
		{
			// Fill the drop down list with available database names

			SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

			builder.DataSource = textBoxServerName.Text;

			if (comboBoxAuthentication.SelectedIndex == 0)
			{
				builder.IntegratedSecurity = true;
			}
			else
			{
				builder.IntegratedSecurity = false;
				builder.UserID = textBoxLogin.Text;
				builder.Password = textBoxPassword.Text;
			}

			// try to connect
			using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
			{
				this.Cursor = Cursors.WaitCursor;

				string currentDatabase = comboBoxDatabase.SelectedItem.ToString();

				comboBoxDatabase.Items.Clear();
				comboBoxDatabase.Items.Add("<default>");
				comboBoxDatabase.SelectedIndex = 0;

				try
				{
					connection.Open();

					// connected successfully
					// retrieve available databases

					DataTable schemaTable = connection.GetSchema("Databases");

					foreach (DataRow r in schemaTable.Rows)
					{
						comboBoxDatabase.Items.Add(r[0]);
					}

					comboBoxDatabase.SelectedItem = currentDatabase;
				}
				catch (System.Exception ex)
				{
					MessageBox.Show(ex.Message, "Connection Failure.");
				}
				finally
				{
					this.Cursor = Cursors.Default;
				}
			}
		}

		private void buttonConnect_Click(object sender, EventArgs e)
		{
			SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

			builder.DataSource = textBoxServerName.Text;

			if (comboBoxAuthentication.SelectedIndex == 0)
			{
				builder.IntegratedSecurity = true;
			}
			else
			{
				builder.IntegratedSecurity = false;
				builder.UserID = textBoxLogin.Text;
				builder.Password = textBoxPassword.Text;
			}

			if (comboBoxDatabase.SelectedIndex > 0)
			{
				builder.InitialCatalog = comboBoxDatabase.SelectedItem.ToString();
			}

			// check the connection

			using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
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
