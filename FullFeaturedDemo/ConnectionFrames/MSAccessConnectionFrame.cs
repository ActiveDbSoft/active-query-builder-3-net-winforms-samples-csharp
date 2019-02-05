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


namespace FullFeaturedDemo.ConnectionFrames
{
	public sealed partial class MSAccessConnectionFrame : ConnectionFrameBase
	{
		private string _connectionString;

		public override string ConnectionString
		{
			get { return GetConnectionString(); }
			set { SetConnectionString(value); }
		}

		public MSAccessConnectionFrame(string connectionString)
		{
			InitializeComponent();

			if (String.IsNullOrEmpty(connectionString))
			{
				tbUserID.Text = "Admin";
			}
			else
			{
				ConnectionString = connectionString;
			}
		}

		public string GetConnectionString()
		{
			try
			{
				OleDbConnectionStringBuilder builder = new OleDbConnectionStringBuilder();
				builder.ConnectionString = _connectionString;

				builder.Provider = "Microsoft.ACE.OLEDB.12.0";
				builder.DataSource = tbDataSource.Text;
				builder["User ID"] = tbUserID.Text;
				builder["Password"] = tbPassword.Text;

				_connectionString = builder.ConnectionString;
			}
			catch
			{
			}

			return _connectionString;
		}

		public void SetConnectionString(string value)
		{
			_connectionString = value;

			if (!String.IsNullOrEmpty(_connectionString))
			{
				try
				{
					OleDbConnectionStringBuilder builder = new OleDbConnectionStringBuilder();
					builder.ConnectionString = _connectionString;

					tbDataSource.Text = builder.DataSource;
					tbUserID.Text = builder["User ID"].ToString();
					tbPassword.Text = builder["Password"].ToString();

					_connectionString = builder.ConnectionString;
				}
				catch
				{
				}
			}
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				tbDataSource.Text = openFileDialog1.FileName;
			}
		}

		private void btnEditConnectionString_Click(object sender, EventArgs e)
		{
			using (ConnectionStringEditForm csef = new ConnectionStringEditForm())
			{
				csef.ConnectionString = this.ConnectionString;

				if (csef.ShowDialog() == DialogResult.OK)
				{
					if (csef.Modified)
					{
						this.ConnectionString = csef.ConnectionString;
					}
				}
			}
		}

		public override bool TestConnection()
		{
			Cursor.Current = Cursors.WaitCursor;

			try
			{
				OleDbConnection connection = new OleDbConnection(ConnectionString);
				connection.Open();
				connection.Close();
			}
			catch (System.Exception e)
			{
				MessageBox.Show(e.Message, Program.Name);
				return false;
			}
			finally
			{
				Cursor.Current = Cursors.Default;
			}

			return true;
		}
	}
}
