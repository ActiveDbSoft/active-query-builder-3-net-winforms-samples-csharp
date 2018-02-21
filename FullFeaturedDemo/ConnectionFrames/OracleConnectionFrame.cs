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
using Oracle.ManagedDataAccess.Client;

namespace FullFeaturedDemo.ConnectionFrames
{
	public sealed partial class OracleConnectionFrame : ConnectionFrameBase
	{
		private string _connectionString;

		public override string ConnectionString
		{
			get { return GetConnectionString(); }
			set { SetConnectionString(value); }
		}

		public OracleConnectionFrame(string connectionString)
		{
			InitializeComponent();

			if (String.IsNullOrEmpty(connectionString))
			{
				tbUserID.Enabled = true;
				tbPassword.Enabled = true;
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
				OracleConnectionStringBuilder builder = new OracleConnectionStringBuilder();
				builder.ConnectionString = _connectionString;

				builder.DataSource = tbDataSource.Text;
				builder.UserID = tbUserID.Text;
				builder.Password = tbPassword.Text;

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
					OracleConnectionStringBuilder builder = new OracleConnectionStringBuilder();
					builder.ConnectionString = _connectionString;

					tbDataSource.Text = builder.DataSource;
					tbUserID.Text = builder.UserID;
					tbPassword.Text = builder.Password;

					_connectionString = builder.ConnectionString;
				}
				catch
				{
				}
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
				OracleConnection connection = new OracleConnection(ConnectionString);
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
