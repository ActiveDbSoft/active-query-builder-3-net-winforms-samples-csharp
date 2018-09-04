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
using System.Diagnostics;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;

using FullFeaturedDemo.ConnectionFrames;

namespace FullFeaturedDemo
{
	public partial class ConnectionEditForm : Form
	{
		private readonly ConnectionInfo _connectionInfo;
		private ConnectionFrameBase _currentConnectionFrame;

		public ConnectionEditForm(ConnectionInfo connectionInfo)
		{
			InitializeComponent();

			Debug.Assert(connectionInfo != null);

			_connectionInfo = connectionInfo;
			tbConnectionName.Text = connectionInfo.ConnectionName;

			if (!String.IsNullOrEmpty(connectionInfo.ConnectionString))
			{
				Text = "Edit Connection";

				if (!connectionInfo.IsXmlFile)
				{
					rbMSSQL.Enabled = (connectionInfo.ConnectionType == ConnectionTypes.MSSQL);
					rbMSAccess.Enabled = (connectionInfo.ConnectionType == ConnectionTypes.MSAccess);
					rbOracle.Enabled = (connectionInfo.ConnectionType == ConnectionTypes.Oracle);
					rbMySQL.Enabled = (connectionInfo.ConnectionType == ConnectionTypes.MySQL);
					rbPostrgeSQL.Enabled = (connectionInfo.ConnectionType == ConnectionTypes.PostgreSQL);
					rbOLEDB.Enabled = (connectionInfo.ConnectionType == ConnectionTypes.OLEDB);
					rbODBC.Enabled = (connectionInfo.ConnectionType == ConnectionTypes.ODBC);
				}
			}

			if (connectionInfo.IsXmlFile)
			{
				rbOLEDB.Enabled = false;
				rbODBC.Enabled = false;
			}

			rbMSSQL.Checked = (connectionInfo.ConnectionType == ConnectionTypes.MSSQL);
			rbMSAccess.Checked = (connectionInfo.ConnectionType == ConnectionTypes.MSAccess);
			rbOracle.Checked = (connectionInfo.ConnectionType == ConnectionTypes.Oracle);
			rbMySQL.Checked = (connectionInfo.ConnectionType == ConnectionTypes.MySQL);
			rbPostrgeSQL.Checked = (connectionInfo.ConnectionType == ConnectionTypes.PostgreSQL);
			rbOLEDB.Checked = (connectionInfo.ConnectionType == ConnectionTypes.OLEDB);
			rbODBC.Checked = (connectionInfo.ConnectionType == ConnectionTypes.ODBC);

			SetActiveConnectionTypeFrame();

			rbMSSQL.CheckedChanged += ConnectionTypeChanged;
			rbMSAccess.CheckedChanged += ConnectionTypeChanged;
			rbOracle.CheckedChanged += ConnectionTypeChanged;
			rbMySQL.CheckedChanged += ConnectionTypeChanged;
			rbPostrgeSQL.CheckedChanged += ConnectionTypeChanged;
			rbOLEDB.CheckedChanged += ConnectionTypeChanged;
			rbODBC.CheckedChanged += ConnectionTypeChanged;
            FillSyntax();
			Application.Idle += Application_Idle;
		}

		private void SetActiveConnectionTypeFrame()
		{
			if (_currentConnectionFrame != null)
			{
				_currentConnectionFrame.Dispose();
				_currentConnectionFrame = null;
			}

			if (!_connectionInfo.IsXmlFile)
			{
				switch (_connectionInfo.ConnectionType)
				{
					case ConnectionTypes.MSSQL:
						_currentConnectionFrame = new MSSQLConnectionFrame(_connectionInfo.ConnectionString);
						break;
					case ConnectionTypes.MSAccess:
						_currentConnectionFrame = new MSAccessConnectionFrame(_connectionInfo.ConnectionString);
						break;
					case ConnectionTypes.Oracle:
						_currentConnectionFrame = new OracleConnectionFrame(_connectionInfo.ConnectionString);
						break;
					case ConnectionTypes.MySQL:
						_currentConnectionFrame = new MySQLConnectionFrame(_connectionInfo.ConnectionString);
						break;
					case ConnectionTypes.PostgreSQL:
						_currentConnectionFrame = new PostgreSQLConnectionFrame(_connectionInfo.ConnectionString);
						break;
					case ConnectionTypes.OLEDB:
						_currentConnectionFrame = new OLEDBConnectionFrame(_connectionInfo.ConnectionString);
						break;
					case ConnectionTypes.ODBC:
						_currentConnectionFrame = new ODBCConnectionFrame(_connectionInfo.ConnectionString);
						break;
				}
			}
			else
			{
				_currentConnectionFrame = new XmlFileFrame(_connectionInfo.ConnectionString);
			}

			if (_currentConnectionFrame != null)
			{
				_currentConnectionFrame.Dock = DockStyle.Fill;
				_currentConnectionFrame.Parent = pnlFrames;
			}
		}

		private void ConnectionTypeChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked != true) return;

            var connectionType = ConnectionTypes.MSSQL;

            if (Equals(sender, rbMSSQL))
            {
                connectionType = ConnectionTypes.MSSQL;
            }
            else if (Equals(sender, rbMSAccess))
            {
                connectionType = ConnectionTypes.MSAccess;
            }
            else if (Equals(sender, rbOracle))
            {
                connectionType = ConnectionTypes.Oracle;
            }
            else if (Equals(sender, rbMySQL))
            {
                connectionType = ConnectionTypes.MySQL;
            }
            else if (Equals(sender, rbPostrgeSQL))
            {
                connectionType = ConnectionTypes.PostgreSQL;
            }
            else if (Equals(sender, rbOLEDB))
            {
                connectionType = ConnectionTypes.OLEDB;
            }
            else if (Equals(sender, rbODBC))
            {
                connectionType = ConnectionTypes.ODBC;
            }

            if (connectionType != _connectionInfo.ConnectionType)
            {
                _connectionInfo.ConnectionType = connectionType;

                if (!_connectionInfo.IsXmlFile)
                {
                    SetActiveConnectionTypeFrame();
                }
            }

            switch (_connectionInfo.ConnectionType)
            {
                case ConnectionTypes.MSSQL:
                    _connectionInfo.SyntaxProvider = new MSSQLSyntaxProvider();
                    break;
                case ConnectionTypes.MSAccess:
                    _connectionInfo.SyntaxProvider = new MSAccessSyntaxProvider();
                    break;
                case ConnectionTypes.Oracle:
                    _connectionInfo.SyntaxProvider = new OracleSyntaxProvider();
                    break;
                case ConnectionTypes.MySQL:
                    _connectionInfo.SyntaxProvider = new MySQLSyntaxProvider();
                    break;
                case ConnectionTypes.PostgreSQL:
                    _connectionInfo.SyntaxProvider = new PostgreSQLSyntaxProvider();
                    break;
                case ConnectionTypes.OLEDB:
                    _connectionInfo.SyntaxProvider = new SQL92SyntaxProvider();
                    break;
                case ConnectionTypes.ODBC:
                    _connectionInfo.SyntaxProvider = new SQL92SyntaxProvider();
                    break;
            }

            FillSyntax();
		}

		private void Application_Idle(object sender, EventArgs e)
		{
			btnOk.Enabled = (tbConnectionName.Text.Length > 0);
		}

		private void ConnectionEditForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (DialogResult == DialogResult.OK)
			{
				if (_currentConnectionFrame != null &&
				    _currentConnectionFrame.TestConnection())
				{
					_connectionInfo.ConnectionName = tbConnectionName.Text;
					_connectionInfo.ConnectionString = _currentConnectionFrame.ConnectionString;
					e.Cancel = false;
				}
				else
				{
					e.Cancel = true;
				}
			}
		}

        private void FillSyntax()
        {
            BoxSyntaxProvider.Items.Clear();
            BoxServerVersion.Items.Clear();

            if (!string.IsNullOrEmpty(_connectionInfo.SyntaxProviderName) && _connectionInfo.SyntaxProvider == null)
            {
                BoxSyntaxProvider.Items.Add(_connectionInfo.SyntaxProviderName);
                BoxSyntaxProvider.SelectedItem = _connectionInfo.SyntaxProviderName;
                return;
            }

            if (_connectionInfo.SyntaxProvider == null)
            {
                switch (_connectionInfo.ConnectionType)
                {
                    case ConnectionTypes.MSSQL:
                        _connectionInfo.SyntaxProvider = new MSSQLSyntaxProvider();
                        break;
                    case ConnectionTypes.MSAccess:
                        _connectionInfo.SyntaxProvider = new MSAccessSyntaxProvider();
                        break;
                    case ConnectionTypes.Oracle:
                        _connectionInfo.SyntaxProvider = new OracleSyntaxProvider();
                        break;
                    case ConnectionTypes.MySQL:
                        _connectionInfo.SyntaxProvider = new MySQLSyntaxProvider();
                        break;
                    case ConnectionTypes.PostgreSQL:
                        _connectionInfo.SyntaxProvider = new PostgreSQLSyntaxProvider();
                        break;
                    case ConnectionTypes.OLEDB:
                        _connectionInfo.SyntaxProvider = new SQL92SyntaxProvider();
                        break;
                    case ConnectionTypes.ODBC:
                        _connectionInfo.SyntaxProvider = new SQL92SyntaxProvider();
                        break;
                }
            }

            if (_connectionInfo.SyntaxProvider is SQL2003SyntaxProvider)
            {
                BoxSyntaxProvider.Items.Add("ANSI SQL-2003");
                BoxSyntaxProvider.SelectedItem = "ANSI SQL-2003";

                BoxSyntaxProvider.Items.Add("ANSI SQL-92");
                BoxSyntaxProvider.Items.Add("ANSI SQL-89");
                BoxSyntaxProvider.Items.Add("Firebird");
                BoxSyntaxProvider.Items.Add("IBM DB2");
                BoxSyntaxProvider.Items.Add("IBM Informix");
                BoxSyntaxProvider.Items.Add("Microsoft Access");
                BoxSyntaxProvider.Items.Add("Microsoft SQL Server");
                BoxSyntaxProvider.Items.Add("MySQL");
                BoxSyntaxProvider.Items.Add("Oracle");
                BoxSyntaxProvider.Items.Add("PostgreSQL");
                BoxSyntaxProvider.Items.Add("SQLite");
                BoxSyntaxProvider.Items.Add("Sybase");
                BoxSyntaxProvider.Items.Add("VistaDB");
                BoxSyntaxProvider.Items.Add("Universal");
            }
            else if (_connectionInfo.SyntaxProvider is SQL92SyntaxProvider)
            {
                BoxSyntaxProvider.Items.Add("ANSI SQL-92");
                BoxSyntaxProvider.SelectedItem = "ANSI SQL-92";

                BoxSyntaxProvider.Items.Add("ANSI SQL-2003");

                BoxSyntaxProvider.Items.Add("ANSI SQL-89");
                BoxSyntaxProvider.Items.Add("Firebird");
                BoxSyntaxProvider.Items.Add("IBM DB2");
                BoxSyntaxProvider.Items.Add("IBM Informix");
                BoxSyntaxProvider.Items.Add("Microsoft Access");
                BoxSyntaxProvider.Items.Add("Microsoft SQL Server");
                BoxSyntaxProvider.Items.Add("MySQL");
                BoxSyntaxProvider.Items.Add("Oracle");
                BoxSyntaxProvider.Items.Add("PostgreSQL");
                BoxSyntaxProvider.Items.Add("SQLite");
                BoxSyntaxProvider.Items.Add("Sybase");
                BoxSyntaxProvider.Items.Add("VistaDB");
                BoxSyntaxProvider.Items.Add("Universal");
            }
            else if (_connectionInfo.SyntaxProvider is SQL89SyntaxProvider)
            {
                BoxSyntaxProvider.Items.Add("ANSI SQL-89");
                BoxSyntaxProvider.SelectedItem = "ANSI SQL-89";

                BoxSyntaxProvider.Items.Add("ANSI SQL-2003");
                BoxSyntaxProvider.Items.Add("ANSI SQL-92");
                BoxSyntaxProvider.Items.Add("Firebird");
                BoxSyntaxProvider.Items.Add("IBM DB2");
                BoxSyntaxProvider.Items.Add("IBM Informix");
                BoxSyntaxProvider.Items.Add("Microsoft Access");
                BoxSyntaxProvider.Items.Add("Microsoft SQL Server");
                BoxSyntaxProvider.Items.Add("MySQL");
                BoxSyntaxProvider.Items.Add("Oracle");
                BoxSyntaxProvider.Items.Add("PostgreSQL");
                BoxSyntaxProvider.Items.Add("SQLite");
                BoxSyntaxProvider.Items.Add("Sybase");
                BoxSyntaxProvider.Items.Add("VistaDB");
                BoxSyntaxProvider.Items.Add("Universal");
            }
            else if (_connectionInfo.SyntaxProvider is FirebirdSyntaxProvider)
            {
                BoxSyntaxProvider.Items.Add("Firebird");
                BoxSyntaxProvider.SelectedItem = "Firebird";
            }
            else if (_connectionInfo.SyntaxProvider is DB2SyntaxProvider)
            {
                BoxSyntaxProvider.Items.Add("IBM DB2");
                BoxSyntaxProvider.SelectedItem = "IBM DB2";
            }
            else if (_connectionInfo.SyntaxProvider is InformixSyntaxProvider)
            {
                BoxSyntaxProvider.Items.Add("IBM Informix");
                BoxSyntaxProvider.SelectedItem = "IBM Informix";
            }
            else if (_connectionInfo.SyntaxProvider is MSAccessSyntaxProvider)
            {
                BoxSyntaxProvider.Items.Add("Microsoft Access");
                BoxSyntaxProvider.SelectedItem = "Microsoft Access";
            }
            else if (_connectionInfo.SyntaxProvider is MSSQLSyntaxProvider)
            {
                BoxSyntaxProvider.Items.Add("Microsoft SQL Server");
                BoxSyntaxProvider.SelectedItem = "Microsoft SQL Server";
            }
            else if (_connectionInfo.SyntaxProvider is MySQLSyntaxProvider)
            {
                BoxSyntaxProvider.Items.Add("MySQL");
                BoxSyntaxProvider.SelectedItem = "MySQL";
            }
            else if (_connectionInfo.SyntaxProvider is OracleSyntaxProvider)
            {
                BoxSyntaxProvider.Items.Add("Oracle");
                BoxSyntaxProvider.SelectedItem = "Oracle";
            }
            else if (_connectionInfo.SyntaxProvider is PostgreSQLSyntaxProvider)
            {
                BoxSyntaxProvider.Items.Add("PostgreSQL");
                BoxSyntaxProvider.SelectedItem = "PostgreSQL";
            }
            else if (_connectionInfo.SyntaxProvider is SQLiteSyntaxProvider)
            {
                BoxSyntaxProvider.Items.Add("SQLite");
                BoxSyntaxProvider.SelectedItem = "SQLite";
            }
            else if (_connectionInfo.SyntaxProvider is SybaseSyntaxProvider)
            {
                BoxSyntaxProvider.Items.Add("Sybase");
                BoxSyntaxProvider.SelectedItem = "Sybase";
            }
            else if (_connectionInfo.SyntaxProvider is VistaDBSyntaxProvider)
            {
                BoxSyntaxProvider.Items.Add("VistaDB");
                BoxSyntaxProvider.SelectedItem = "VistaDB";
            }
            else if (_connectionInfo.SyntaxProvider is GenericSyntaxProvider)
            {
                BoxSyntaxProvider.Items.Add("Universal");
                BoxSyntaxProvider.SelectedItem = "Universal";


                BoxSyntaxProvider.Items.Add("ANSI SQL-2003");
                BoxSyntaxProvider.Items.Add("ANSI SQL-92");
                BoxSyntaxProvider.Items.Add("ANSI SQL-89");
                BoxSyntaxProvider.Items.Add("Firebird");
                BoxSyntaxProvider.Items.Add("IBM DB2");
                BoxSyntaxProvider.Items.Add("IBM Informix");
                BoxSyntaxProvider.Items.Add("Microsoft Access");
                BoxSyntaxProvider.Items.Add("Microsoft SQL Server");
                BoxSyntaxProvider.Items.Add("MySQL");
                BoxSyntaxProvider.Items.Add("Oracle");
                BoxSyntaxProvider.Items.Add("PostgreSQL");
                BoxSyntaxProvider.Items.Add("SQLite");
                BoxSyntaxProvider.Items.Add("Sybase");
                BoxSyntaxProvider.Items.Add("VistaDB");
                BoxSyntaxProvider.Items.Add("Universal");
            }


            FillVersions();
        }

        private void FillVersions()
        {
            BoxServerVersion.Items.Clear();

            if (_connectionInfo.SyntaxProvider is SQL2003SyntaxProvider)
            {
                BoxServerVersion.Enabled = false;
            }
            else if (_connectionInfo.SyntaxProvider is SQL92SyntaxProvider)
            {
                BoxServerVersion.Enabled = false;
            }
            else if (_connectionInfo.SyntaxProvider is SQL89SyntaxProvider)
            {
                BoxServerVersion.Enabled = false;
            }
            else if (_connectionInfo.SyntaxProvider is FirebirdSyntaxProvider)
            {
                BoxServerVersion.Enabled = true;
                BoxServerVersion.Items.Add("Firebird 1.0");
                BoxServerVersion.Items.Add("Firebird 1.5");
                BoxServerVersion.Items.Add("Firebird 2.0");
                BoxServerVersion.Items.Add("Firebird 2.5");

                if (((FirebirdSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion == FirebirdVersion.Firebird10)
                {
                    BoxServerVersion.SelectedItem = "Firebird 1.0";
                }
                else if (((FirebirdSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion == FirebirdVersion.Firebird15)
                {
                    BoxServerVersion.SelectedItem = "Firebird 1.5";
                }
                if (((FirebirdSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion == FirebirdVersion.Firebird20)
                {
                    BoxServerVersion.SelectedItem = "Firebird 2.0";
                }
                if (((FirebirdSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion == FirebirdVersion.Firebird25)
                {
                    BoxServerVersion.SelectedItem = "Firebird 2.5";
                }
            }
            else if (_connectionInfo.SyntaxProvider is DB2SyntaxProvider)
            {
                BoxServerVersion.Enabled = false;
            }
            else if (_connectionInfo.SyntaxProvider is InformixSyntaxProvider)
            {
                BoxServerVersion.Enabled = true;
                BoxServerVersion.Items.Add("Informix 8");
                BoxServerVersion.Items.Add("Informix 9");
                BoxServerVersion.Items.Add("Informix 10");

                if (((InformixSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion == InformixVersion.DS8)
                {
                    BoxServerVersion.SelectedItem = "Informix 8";
                }
                else if (((InformixSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion == InformixVersion.DS9)
                {
                    BoxServerVersion.SelectedItem = "Informix 9";
                }
                if (((InformixSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion == InformixVersion.DS10)
                {
                    BoxServerVersion.SelectedItem = "Informix 10";
                }
            }
            else if (_connectionInfo.SyntaxProvider is MSAccessSyntaxProvider)
            {
                BoxServerVersion.Enabled = true;
                BoxServerVersion.Items.Add("MS Jet 3");
                BoxServerVersion.Items.Add("MS Jet 4");

                if (((MSAccessSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion == MSAccessServerVersion.MSJET3)
                {
                    BoxServerVersion.SelectedItem = "MS Jet 3";
                }
                else if (((MSAccessSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion == MSAccessServerVersion.MSJET4)
                {
                    BoxServerVersion.SelectedItem = "MS Jet 4";
                }
            }
            else if (_connectionInfo.SyntaxProvider is MSSQLSyntaxProvider)
            {
                BoxServerVersion.Enabled = true;
                BoxServerVersion.Items.Add("Auto");
                BoxServerVersion.Items.Add("SQL Server 7");
                BoxServerVersion.Items.Add("SQL Server 2000");
                BoxServerVersion.Items.Add("SQL Server 2005");

                if (((MSSQLSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion == MSSQLServerVersion.MSSQL7)
                {
                    BoxServerVersion.SelectedItem = "SQL Server 7";
                }
                else if (((MSSQLSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion == MSSQLServerVersion.MSSQL2000)
                {
                    BoxServerVersion.SelectedItem = "SQL Server 2000";
                }
                else if (((MSSQLSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion == MSSQLServerVersion.MSSQL2005)
                {
                    BoxServerVersion.SelectedItem = "SQL Server 2005";
                }
                else
                {
                    BoxServerVersion.SelectedItem = "Auto";
                }
            }
            else if (_connectionInfo.SyntaxProvider is MySQLSyntaxProvider)
            {
                BoxServerVersion.Enabled = true;
                BoxServerVersion.Items.Add("3.0");
                BoxServerVersion.Items.Add("4.0");
                BoxServerVersion.Items.Add("5.0");

                if (((MySQLSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersionInt < 40000)
                {
                    BoxServerVersion.SelectedItem = "3.0";
                }
                else if (((MySQLSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersionInt < 50000)
                {
                    BoxServerVersion.SelectedItem = "4.0";
                }
                else
                {
                    BoxServerVersion.SelectedItem = "5.0";
                }
            }
            else if (_connectionInfo.SyntaxProvider is OracleSyntaxProvider)
            {
                BoxServerVersion.Enabled = true;
                BoxServerVersion.Items.Add("Oracle 7");
                BoxServerVersion.Items.Add("Oracle 8");
                BoxServerVersion.Items.Add("Oracle 9");
                BoxServerVersion.Items.Add("Oracle 10");
                BoxServerVersion.Items.Add("Oracle 11");

                if (((OracleSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion == OracleServerVersion.Oracle7)
                {
                    BoxServerVersion.SelectedItem = "Oracle 7";
                }
                else if (((OracleSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion == OracleServerVersion.Oracle8)
                {
                    BoxServerVersion.SelectedItem = "Oracle 8";
                }
                else if (((OracleSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion == OracleServerVersion.Oracle9)
                {
                    BoxServerVersion.SelectedItem = "Oracle 9";
                }
                else if (((OracleSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion == OracleServerVersion.Oracle10)
                {
                    BoxServerVersion.SelectedItem = "Oracle 10";
                }
                else if (((OracleSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion == OracleServerVersion.Oracle11)
                {
                    BoxServerVersion.SelectedItem = "Oracle 11";
                }
            }
            else if (_connectionInfo.SyntaxProvider is PostgreSQLSyntaxProvider)
            {
                BoxServerVersion.Enabled = false;
            }
            else if (_connectionInfo.SyntaxProvider is SQLiteSyntaxProvider)
            {
                BoxServerVersion.Enabled = false;
            }
            else if (_connectionInfo.SyntaxProvider is SybaseSyntaxProvider)
            {
                BoxServerVersion.Enabled = true;
                BoxServerVersion.Items.Add("ASE");
                BoxServerVersion.Items.Add("SQL Anywhere");

                if (((SybaseSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion == SybaseServerVersion.SybaseASE)
                {
                    BoxServerVersion.SelectedItem = "ASE";
                }
                else if (((SybaseSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion == SybaseServerVersion.SybaseASA)
                {
                    BoxServerVersion.SelectedItem = "SQL Anywhere";
                }
            }
            else if (_connectionInfo.SyntaxProvider is VistaDBSyntaxProvider)
            {
                BoxServerVersion.Enabled = false;
            }
            else if (_connectionInfo.SyntaxProvider is GenericSyntaxProvider)
            {
                BoxServerVersion.Enabled = false;
            }
        }

        private void BoxSyntaxProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((string)BoxSyntaxProvider.SelectedItem))
            {
                case "ANSI SQL-2003":
                    _connectionInfo.SyntaxProvider = new SQL2003SyntaxProvider();
                    break;
                case "ANSI SQL-92":
                    _connectionInfo.SyntaxProvider = new SQL92SyntaxProvider();
                    break;
                case "ANSI SQL-89":
                    _connectionInfo.SyntaxProvider = new SQL89SyntaxProvider();
                    break;
                case "Firebird":
                    _connectionInfo.SyntaxProvider = new FirebirdSyntaxProvider();
                    break;
                case "IBM DB2":
                    _connectionInfo.SyntaxProvider = new DB2SyntaxProvider();
                    break;
                case "IBM Informix":
                    _connectionInfo.SyntaxProvider = new InformixSyntaxProvider();
                    break;
                case "Microsoft Access":
                    _connectionInfo.SyntaxProvider = new MSAccessSyntaxProvider();
                    break;
                case "Microsoft SQL Server":
                    _connectionInfo.SyntaxProvider = new MSSQLSyntaxProvider();
                    break;
                case "MySQL":
                    _connectionInfo.SyntaxProvider = new MySQLSyntaxProvider();
                    break;
                case "Oracle":
                    _connectionInfo.SyntaxProvider = new OracleSyntaxProvider();
                    break;
                case "PostgreSQL":
                    _connectionInfo.SyntaxProvider = new PostgreSQLSyntaxProvider();
                    break;
                case "SQLite":
                    _connectionInfo.SyntaxProvider = new SQLiteSyntaxProvider();
                    break;
                case "Sybase":
                    _connectionInfo.SyntaxProvider = new SybaseSyntaxProvider();
                    break;
                case "VistaDB":
                    _connectionInfo.SyntaxProvider = new VistaDBSyntaxProvider();
                    break;
                case "Universal":
                    _connectionInfo.SyntaxProvider = new GenericSyntaxProvider();
                    break;
            }

            FillVersions();
        }

        private void BoxServerVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_connectionInfo.SyntaxProvider is FirebirdSyntaxProvider)
            {
                if ((string)BoxServerVersion.SelectedItem == "Firebird 1.0")
                {
                    ((FirebirdSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion = FirebirdVersion.Firebird10;
                }
                else if ((string)BoxServerVersion.SelectedItem == "Firebird 1.5")
                {
                    ((FirebirdSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion = FirebirdVersion.Firebird15;
                }
                if ((string)BoxServerVersion.SelectedItem == "Firebird 2.0")
                {
                    ((FirebirdSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion = FirebirdVersion.Firebird20;
                }
                if ((string)BoxServerVersion.SelectedItem == "Firebird 2.5")
                {
                    ((FirebirdSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion = FirebirdVersion.Firebird25;
                }
            }
            else if (_connectionInfo.SyntaxProvider is InformixSyntaxProvider)
            {
                if ((string)BoxServerVersion.SelectedItem == "Informix 8")
                {
                    ((InformixSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion = InformixVersion.DS8;
                }
                else if ((string)BoxServerVersion.SelectedItem == "Informix 9")
                {
                    ((InformixSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion = InformixVersion.DS9;
                }
                if ((string)BoxServerVersion.SelectedItem == "Informix 10")
                {
                    ((InformixSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion = InformixVersion.DS10;
                }
            }
            else if (_connectionInfo.SyntaxProvider is MSAccessSyntaxProvider)
            {
                if ((string)BoxServerVersion.SelectedItem == "MS Jet 3")
                {
                    ((MSAccessSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion = MSAccessServerVersion.MSJET3;
                }
                else if ((string)BoxServerVersion.SelectedItem == "MS Jet 4")
                {
                    ((MSAccessSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion = MSAccessServerVersion.MSJET4;
                }
            }
            else if (_connectionInfo.SyntaxProvider is MSSQLSyntaxProvider)
            {
                if ((string)BoxServerVersion.SelectedItem == "Auto")
                {
                    ((MSSQLSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion = MSSQLServerVersion.Auto;
                }
                else if ((string)BoxServerVersion.SelectedItem == "SQL Server 7")
                {
                    ((MSSQLSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion = MSSQLServerVersion.MSSQL7;
                }
                else if ((string)BoxServerVersion.SelectedItem == "SQL Server 2000")
                {
                    ((MSSQLSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion = MSSQLServerVersion.MSSQL2000;
                }
                else if ((string)BoxServerVersion.SelectedItem == "SQL Server 2005")
                {
                    ((MSSQLSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion = MSSQLServerVersion.MSSQL2005;
                }
            }
            else if (_connectionInfo.SyntaxProvider is MySQLSyntaxProvider)
            {
                if ((string)BoxServerVersion.SelectedItem == "3.0")
                {
                    ((MySQLSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersionInt = 39999;
                }
                else if ((string)BoxServerVersion.SelectedItem == "4.0")
                {
                    ((MySQLSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersionInt = 49999;
                }
                else if ((string)BoxServerVersion.SelectedItem == "5.0")
                {
                    ((MySQLSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersionInt = 50000;
                }
            }
            else if (_connectionInfo.SyntaxProvider is OracleSyntaxProvider)
            {
                if ((string)BoxServerVersion.SelectedItem == "Oracle 7")
                {
                    ((OracleSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion = OracleServerVersion.Oracle7;
                }
                else if ((string)BoxServerVersion.SelectedItem == "Oracle 8")
                {
                    ((OracleSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion = OracleServerVersion.Oracle8;
                }
                else if ((string)BoxServerVersion.SelectedItem == "Oracle 9")
                {
                    ((OracleSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion = OracleServerVersion.Oracle9;
                }
                else if ((string)BoxServerVersion.SelectedItem == "Oracle 10")
                {
                    ((OracleSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion = OracleServerVersion.Oracle10;
                }
            }
            else if (_connectionInfo.SyntaxProvider is SybaseSyntaxProvider)
            {
                if ((string)BoxServerVersion.SelectedItem == "ASE")
                {
                    ((SybaseSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion = SybaseServerVersion.SybaseASE;
                }
                else if ((string)BoxServerVersion.SelectedItem == "SQL Anywhere")
                {
                    ((SybaseSyntaxProvider)_connectionInfo.SyntaxProvider).ServerVersion = SybaseServerVersion.SybaseASA;
                }
            }
        }

	}
}
