//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2022 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GeneralAssembly.ConnectionFrames
{
    public sealed partial class MySQLConnectionFrame : ConnectionFrameBase
    {
        private string _connectionString;

        public override string ConnectionString
        {
            get { return GetConnectionString(); }
            set { SetConnectionString(value); }
        }

        public MySQLConnectionFrame(string connectionString)
        {
            InitializeComponent();

            if (!String.IsNullOrEmpty(connectionString))
            {
                ConnectionString = connectionString;
            }
        }

        public string GetConnectionString()
        {
            try
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.ConnectionString = _connectionString;

                builder.Server = tbServer.Text;
                builder.Database = tbDatabase.Text;
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
                    MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                    builder.ConnectionString = _connectionString;

                    tbServer.Text = builder.Server;
                    tbDatabase.Text = builder.Database;
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
                MySqlConnection connection = new MySqlConnection(ConnectionString);
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
