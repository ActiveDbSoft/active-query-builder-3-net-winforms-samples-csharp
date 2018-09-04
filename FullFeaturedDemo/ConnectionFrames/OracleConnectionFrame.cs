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
				cmbIntegratedSecurity.SelectedIndex = 0;
				tbUserID.Enabled = false;
				tbPassword.Enabled = false;
			}
			else
			{
				ConnectionString = connectionString;
			}

			cmbIntegratedSecurity.SelectedIndexChanged += cmbIntegratedSecurity_SelectedIndexChanged;
		}

		public string GetConnectionString()
		{
			try
			{
				OracleConnectionStringBuilder builder = new OracleConnectionStringBuilder();
				builder.ConnectionString = _connectionString;

				builder.DataSource = tbDataSource.Text;
                builder.UserID = (cmbIntegratedSecurity.SelectedIndex == 0) ? "/" : tbUserID.Text;

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
					cmbIntegratedSecurity.SelectedIndex = (builder.UserID == "/") ? 0 : 1;
					tbUserID.Text = builder.UserID;
					tbUserID.Enabled = (builder.UserID != "/");
					tbPassword.Text = builder.Password;
					tbPassword.Enabled = (builder.UserID != "/");

					_connectionString = builder.ConnectionString;
				}
				catch
				{
				}
			}
		}

		private void cmbIntegratedSecurity_SelectedIndexChanged(object sender, EventArgs e)
		{
			tbUserID.Enabled = (cmbIntegratedSecurity.SelectedIndex == 1);
			tbPassword.Enabled = (cmbIntegratedSecurity.SelectedIndex == 1);
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
