//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2021 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.Windows.Forms;
using Npgsql;

namespace GeneralAssembly.ConnectionFrames
{
	public sealed partial class PostgreSQLConnectionFrame : ConnectionFrameBase
	{
		private string _connectionString;

		public override string ConnectionString
		{
			get { return GetConnectionString(); }
			set { SetConnectionString(value); }
		}

		public PostgreSQLConnectionFrame(string connectionString)
		{
			InitializeComponent();

			if (String.IsNullOrEmpty(connectionString))
			{
				tbHost.Text = "localhost";
				tbPort.Text = "5432";
				tbUserName.Text = "postgres";
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
				NpgsqlConnectionStringBuilder builder = new NpgsqlConnectionStringBuilder();
				builder.ConnectionString = _connectionString;

				builder.Host = tbHost.Text;
				builder.Port = Convert.ToInt32(tbPort.Text);
				builder.Database = tbDatabase.Text;
				builder.Username = tbUserName.Text;
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
					NpgsqlConnectionStringBuilder builder = new NpgsqlConnectionStringBuilder();
					builder.ConnectionString = _connectionString;

					tbHost.Text = builder.Host;
					tbPort.Text = builder.Port.ToString();
					tbDatabase.Text = builder.Database;
					tbUserName.Text = builder.Username;
					//tbPassword.Text = builder.Password;

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
				NpgsqlConnection connection = new NpgsqlConnection(ConnectionString);
				connection.Open();
				connection.Close();
			}
			catch (System.Exception e)
			{
				MessageBox.Show(e.Message, "Demo project");
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
