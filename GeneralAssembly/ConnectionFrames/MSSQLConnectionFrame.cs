//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2024 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GeneralAssembly.ConnectionFrames
{
    public sealed partial class MSSQLConnectionFrame : ConnectionFrameBase
    {
        private string _connectionString;

        public override string ConnectionString
        {
            get { return GetConnectionString(); }
            set { SetConnectionString(value); }
        }

        public MSSQLConnectionFrame(string connectionString)
        {
            InitializeComponent();

            if (String.IsNullOrEmpty(connectionString))
            {
                tbDataSource.Text = "(local)";
                cmbIntegratedSecurity.SelectedIndex = 0;
                tbUserID.Enabled = false;
                tbPassword.Enabled = false;
                cmbInitialCatalog.SelectedIndex = 0;
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
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.ConnectionString = _connectionString;

                builder.DataSource = tbDataSource.Text;
                builder.IntegratedSecurity = (cmbIntegratedSecurity.SelectedIndex == 0) ? true : false;
                builder.UserID = tbUserID.Text;
                builder.Password = tbPassword.Text;
                builder.InitialCatalog = cmbInitialCatalog.Text == "<default>" ? "" : cmbInitialCatalog.Text;

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
                    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                    builder.ConnectionString = _connectionString;

                    tbDataSource.Text = builder.DataSource;
                    cmbIntegratedSecurity.SelectedIndex = (builder.IntegratedSecurity) ? 0 : 1;
                    tbUserID.Text = builder.UserID;
                    tbUserID.Enabled = !builder.IntegratedSecurity;
                    tbPassword.Text = builder.Password;
                    tbPassword.Enabled = !builder.IntegratedSecurity;
                    cmbInitialCatalog.Text = builder.InitialCatalog;

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

        private void cmbInitialCatalog_DropDown(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                Cursor.Current = Cursors.WaitCursor;

                string currentDatabase = cmbInitialCatalog.Text;

                cmbInitialCatalog.Items.Clear();
                cmbInitialCatalog.Items.Add("<default>");
                cmbInitialCatalog.SelectedIndex = 0;

                try
                {
                    connection.Open();

                    DataTable schemaTable = connection.GetSchema("Databases");

                    foreach (DataRow r in schemaTable.Rows)
                    {
                        cmbInitialCatalog.Items.Add(r[0]);
                    }

                    cmbInitialCatalog.SelectedItem = null;
                    cmbInitialCatalog.SelectedItem = currentDatabase;

                    if (cmbInitialCatalog.SelectedItem == null)
                    {
                        cmbInitialCatalog.Text = currentDatabase;
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "Connection Failure.");
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
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
                SqlConnection connection = new SqlConnection(ConnectionString);
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
