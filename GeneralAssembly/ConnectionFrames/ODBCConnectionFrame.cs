//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2025 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.Data.Odbc;
using System.Windows.Forms;

namespace GeneralAssembly.ConnectionFrames
{
    public sealed partial class ODBCConnectionFrame : ConnectionFrameBase
    {
        private string _connectionString;

        public override string ConnectionString
        {
            get { return GetConnectionString(); }
            set { SetConnectionString(value); }
        }

        public ODBCConnectionFrame(string connectionString)
        {
            InitializeComponent();

            ConnectionString = connectionString;
        }

        public string GetConnectionString()
        {
            try
            {
                OdbcConnectionStringBuilder builder = new OdbcConnectionStringBuilder();
                builder.ConnectionString = tbConnectionString.Text;
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
                    OdbcConnectionStringBuilder builder = new OdbcConnectionStringBuilder();
                    builder.ConnectionString = _connectionString;
                    _connectionString = builder.ConnectionString;
                    tbConnectionString.Text = _connectionString;
                }
                catch
                {
                }
            }
        }

        public override bool TestConnection()
        {
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                OdbcConnection connection = new OdbcConnection(ConnectionString);
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
