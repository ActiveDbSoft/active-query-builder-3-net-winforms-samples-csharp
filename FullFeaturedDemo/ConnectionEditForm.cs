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
				    if (connectionInfo.ConnectionType == ConnectionTypes.ODBC ||
				        connectionInfo.ConnectionType == ConnectionTypes.OLEDB)
				    {
				        BoxSyntaxProvider.Enabled = true;
				    }
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
			    _currentConnectionFrame.OnSyntaxProviderDetected -= CurrentConnectionFrame_SyntaxProviderDetected;
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
                _currentConnectionFrame.OnSyntaxProviderDetected += CurrentConnectionFrame_SyntaxProviderDetected;
			}
		}

	    private void CurrentConnectionFrame_SyntaxProviderDetected(Type syntaxType)
	    {
	        var syntaxProvider = Activator.CreateInstance(syntaxType) as BaseSyntaxProvider;
	        BoxSyntaxProvider.SelectedItem = SyntaxToString(syntaxProvider);
	        FillVersions();
        }	    

		private void ConnectionTypeChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked != true) return;

            var connectionType = ConnectionTypes.MSSQL;
            BoxSyntaxProvider.Enabled = false;

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
                BoxSyntaxProvider.Enabled = true;
            }
            else if (Equals(sender, rbODBC))
            {
                connectionType = ConnectionTypes.ODBC;
                BoxSyntaxProvider.Enabled = true;
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

	    private string SyntaxToString(BaseSyntaxProvider syntax)
	    {            
            if (syntax is SQL2003SyntaxProvider)
            {                
                return "ANSI SQL-2003";                
            }
            else if (syntax is SQL92SyntaxProvider)
            {                
                return "ANSI SQL-92";
            }
            else if (syntax is SQL89SyntaxProvider)
            {                
                return "ANSI SQL-89";
            }
            else if (syntax is FirebirdSyntaxProvider)
            {
                return "Firebird";
            }
            else if (syntax is DB2SyntaxProvider)
            {
                return "IBM DB2";
            }
            else if (syntax is InformixSyntaxProvider)
            {
                return "IBM Informix";
            }
            else if (syntax is MSAccessSyntaxProvider)
            {
                return "Microsoft Access";
            }
            else if (syntax is MSSQLSyntaxProvider)
            {
                return "Microsoft SQL Server";
            }
            else if (syntax is MySQLSyntaxProvider)
            {
                return "MySQL";
            }
            else if (syntax is OracleSyntaxProvider)
            {
                return "Oracle";
            }
            else if (syntax is PostgreSQLSyntaxProvider)
            {
                return "PostgreSQL";
            }
            else if (syntax is SQLiteSyntaxProvider)
            {
                return "SQLite";
            }
            else if (syntax is SybaseSyntaxProvider)
            {
                return "Sybase";
            }
            else if (syntax is VistaDBSyntaxProvider)
            {
                return "VistaDB";
            }
            else if (syntax is GenericSyntaxProvider)
            {
                return "Universal";
            }

	        return string.Empty;
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

            if (_connectionInfo.ConnectionType == ConnectionTypes.ODBC ||
                _connectionInfo.ConnectionType == ConnectionTypes.OLEDB)
            {
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
                BoxSyntaxProvider.SelectedItem = SyntaxToString(_connectionInfo.SyntaxProvider);
            }
            else if (_connectionInfo.SyntaxProvider is SQL2003SyntaxProvider)
            {
                BoxSyntaxProvider.Items.Add(SyntaxToString(_connectionInfo.SyntaxProvider));
                BoxSyntaxProvider.SelectedItem = SyntaxToString(_connectionInfo.SyntaxProvider);

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
                BoxSyntaxProvider.Items.Add(SyntaxToString(_connectionInfo.SyntaxProvider));
                BoxSyntaxProvider.SelectedItem = SyntaxToString(_connectionInfo.SyntaxProvider);

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
                BoxSyntaxProvider.Items.Add(SyntaxToString(_connectionInfo.SyntaxProvider));
                BoxSyntaxProvider.SelectedItem = SyntaxToString(_connectionInfo.SyntaxProvider);

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
            else if (_connectionInfo.SyntaxProvider is GenericSyntaxProvider)
            {
                BoxSyntaxProvider.Items.Add(SyntaxToString(_connectionInfo.SyntaxProvider));
                BoxSyntaxProvider.SelectedItem = SyntaxToString(_connectionInfo.SyntaxProvider);

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
            else
            {
                BoxSyntaxProvider.Items.Add(SyntaxToString(_connectionInfo.SyntaxProvider));
                BoxSyntaxProvider.SelectedItem = SyntaxToString(_connectionInfo.SyntaxProvider);
            }

            FillVersions();
        }

        private void FillVersions()
        {
            BoxServerVersion.Items.Clear();
            BoxServerVersion.Text = string.Empty;

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

                var firebirdSyntaxProvider = (FirebirdSyntaxProvider)_connectionInfo.SyntaxProvider;

                switch (firebirdSyntaxProvider.ServerVersion)
                {
                    case FirebirdVersion.Firebird10:
                        BoxServerVersion.SelectedItem = "Firebird 1.0";
                        break;
                    case FirebirdVersion.Firebird15:
                        BoxServerVersion.SelectedItem = "Firebird 1.5";
                        break;
                    case FirebirdVersion.Firebird20:
                        BoxServerVersion.SelectedItem = "Firebird 2.0";
                        break;
                    case FirebirdVersion.Firebird25:
                        BoxServerVersion.SelectedItem = "Firebird 2.5";
                        break;
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
                BoxServerVersion.Items.Add("Informix 11");

                var informixSyntaxProvider = (InformixSyntaxProvider)_connectionInfo.SyntaxProvider;

                switch (informixSyntaxProvider.ServerVersion)
                {
                    case InformixVersion.DS8:
                        BoxServerVersion.SelectedItem = "Informix 8";
                        break;
                    case InformixVersion.DS9:
                        BoxServerVersion.SelectedItem = "Informix 9";
                        break;
                    case InformixVersion.DS10:
                        BoxServerVersion.SelectedItem = "Informix 10";
                        break;
                    default:
                        BoxServerVersion.SelectedItem = "Informix 11";
                        break;
                }
            }
            else if (_connectionInfo.SyntaxProvider is MSAccessSyntaxProvider)
            {
                BoxServerVersion.Enabled = true;
                BoxServerVersion.Items.Add("Access 97");
                BoxServerVersion.Items.Add("Access 2000 and newer");

                var accessSyntaxProvider = (MSAccessSyntaxProvider)_connectionInfo.SyntaxProvider;

                BoxServerVersion.SelectedItem = accessSyntaxProvider.ServerVersion == MSAccessServerVersion.MSJET3 ? "Access 97" : "Access 2000 and newer";
            }
            else if (_connectionInfo.SyntaxProvider is MSSQLSyntaxProvider)
            {
                BoxServerVersion.Enabled = true;
                BoxServerVersion.Items.Add("Auto");
                BoxServerVersion.Items.Add("SQL Server 7");
                BoxServerVersion.Items.Add("SQL Server 2000");
                BoxServerVersion.Items.Add("SQL Server 2005");
                BoxServerVersion.Items.Add("SQL Server 2012");
                BoxServerVersion.Items.Add("SQL Server 2014");

                var mssqlSyntaxProvider = (MSSQLSyntaxProvider)_connectionInfo.SyntaxProvider;

                switch (mssqlSyntaxProvider.ServerVersion)
                {
                    case MSSQLServerVersion.MSSQL7:
                        BoxServerVersion.SelectedItem = "SQL Server 7";
                        break;
                    case MSSQLServerVersion.MSSQL2000:
                        BoxServerVersion.SelectedItem = "SQL Server 2000";
                        break;
                    case MSSQLServerVersion.MSSQL2005:
                        BoxServerVersion.SelectedItem = "SQL Server 2005";
                        break;
                    case MSSQLServerVersion.MSSQL2012:
                        BoxServerVersion.SelectedItem = "SQL Server 2012";
                        break;
                    case MSSQLServerVersion.MSSQL2014:
                        BoxServerVersion.SelectedItem = "SQL Server 2014";
                        break;
                    default:
                        BoxServerVersion.SelectedItem = "Auto";
                        break;
                }
            }
            else if (_connectionInfo.SyntaxProvider is MySQLSyntaxProvider)
            {
                BoxServerVersion.Enabled = true;
                BoxServerVersion.Items.Add("3.0");
                BoxServerVersion.Items.Add("4.0");
                BoxServerVersion.Items.Add("5.0+");

                var mySqlSyntaxProvider = (MySQLSyntaxProvider)_connectionInfo.SyntaxProvider;

                if (mySqlSyntaxProvider.ServerVersionInt < 40000)
                {
                    BoxServerVersion.SelectedItem = "3.0";
                }
                else if (mySqlSyntaxProvider.ServerVersionInt < 50000)
                {
                    BoxServerVersion.SelectedItem = "4.0";
                }
                else
                {
                    BoxServerVersion.SelectedItem = "5.0+";
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
                BoxServerVersion.Items.Add("Oracle 12");

                var oracleSyntaxProvider = (OracleSyntaxProvider)_connectionInfo.SyntaxProvider;

                switch (oracleSyntaxProvider.ServerVersion)
                {
                    case OracleServerVersion.Oracle7:
                        BoxServerVersion.SelectedItem = "Oracle 7";
                        break;
                    case OracleServerVersion.Oracle8:
                        BoxServerVersion.SelectedItem = "Oracle 8";
                        break;
                    case OracleServerVersion.Oracle9:
                        BoxServerVersion.SelectedItem = "Oracle 9";
                        break;
                    case OracleServerVersion.Oracle10:
                        BoxServerVersion.SelectedItem = "Oracle 10";
                        break;
                    case OracleServerVersion.Oracle11:
                        BoxServerVersion.SelectedItem = "Oracle 11";
                        break;
                    default:
                        BoxServerVersion.SelectedItem = "Oracle 12";
                        break;
                }
            }
            else if (_connectionInfo.SyntaxProvider is PostgreSQLSyntaxProvider)
            {
                BoxServerVersion.Enabled = false;
                BoxServerVersion.Text = "Auto";
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
                BoxServerVersion.Items.Add("SAP IQ");

                var sybaseSyntaxProvider = (SybaseSyntaxProvider)_connectionInfo.SyntaxProvider;

                switch (sybaseSyntaxProvider.ServerVersion)
                {
                    case SybaseServerVersion.SybaseASE:
                        BoxServerVersion.SelectedItem = "ASE";
                        break;
                    case SybaseServerVersion.SybaseASA:
                        BoxServerVersion.SelectedItem = "SQL Anywhere";
                        break;
                    case SybaseServerVersion.SybaseIQ:
                        BoxServerVersion.SelectedItem = "SAP IQ";
                        break;
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
            switch ((string)BoxSyntaxProvider.SelectedItem)
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
            var selectedItem = (string)BoxServerVersion.SelectedItem;

            if (_connectionInfo.SyntaxProvider is FirebirdSyntaxProvider)
            {
                var firebirdSyntaxProvider = (FirebirdSyntaxProvider)_connectionInfo.SyntaxProvider;

                switch (selectedItem)
                {
                    case "Firebird 1.0":
                        firebirdSyntaxProvider.ServerVersion = FirebirdVersion.Firebird10;
                        break;
                    case "Firebird 1.5":
                        firebirdSyntaxProvider.ServerVersion = FirebirdVersion.Firebird15;
                        break;
                    case "Firebird 2.0":
                        firebirdSyntaxProvider.ServerVersion = FirebirdVersion.Firebird20;
                        break;
                    default:
                        firebirdSyntaxProvider.ServerVersion = FirebirdVersion.Firebird25;
                        break;
                }
            }
            else if (_connectionInfo.SyntaxProvider is InformixSyntaxProvider)
            {
                var informixSyntaxProvider = (InformixSyntaxProvider)_connectionInfo.SyntaxProvider;

                switch (selectedItem)
                {
                    case "Informix 8":
                        informixSyntaxProvider.ServerVersion = InformixVersion.DS8;
                        break;
                    case "Informix 9":
                        informixSyntaxProvider.ServerVersion = InformixVersion.DS9;
                        break;
                    case "Informix 10":
                        informixSyntaxProvider.ServerVersion = InformixVersion.DS10;
                        break;
                    default:
                        informixSyntaxProvider.ServerVersion = InformixVersion.DS11;
                        break;
                }
            }
            else if (_connectionInfo.SyntaxProvider is MSAccessSyntaxProvider)
            {
                var accessSyntaxProvider = (MSAccessSyntaxProvider)_connectionInfo.SyntaxProvider;

                accessSyntaxProvider.ServerVersion = selectedItem == "Access 97"
                    ? MSAccessServerVersion.MSJET3
                    : MSAccessServerVersion.MSJET4;
            }
            else if (_connectionInfo.SyntaxProvider is MSSQLSyntaxProvider)
            {
                var mssqlSyntaxProvider = (MSSQLSyntaxProvider)_connectionInfo.SyntaxProvider;

                switch (selectedItem)
                {
                    case "SQL Server 7":
                        mssqlSyntaxProvider.ServerVersion = MSSQLServerVersion.MSSQL7;
                        break;
                    case "SQL Server 2000":
                        mssqlSyntaxProvider.ServerVersion = MSSQLServerVersion.MSSQL2000;
                        break;
                    case "SQL Server 2005":
                        mssqlSyntaxProvider.ServerVersion = MSSQLServerVersion.MSSQL2005;
                        break;
                    case "SQL Server 2012":
                        mssqlSyntaxProvider.ServerVersion = MSSQLServerVersion.MSSQL2012;
                        break;
                    case "SQL Server 2014":
                        mssqlSyntaxProvider.ServerVersion = MSSQLServerVersion.MSSQL2014;
                        break;
                    default:
                        mssqlSyntaxProvider.ServerVersion = MSSQLServerVersion.Auto;
                        break;
                }
            }
            else if (_connectionInfo.SyntaxProvider is MySQLSyntaxProvider)
            {
                var mySqlSyntaxProvider = (MySQLSyntaxProvider)_connectionInfo.SyntaxProvider;

                switch (selectedItem)
                {
                    case "3.0":
                        mySqlSyntaxProvider.ServerVersionInt = 39999;
                        break;
                    case "4.0":
                        mySqlSyntaxProvider.ServerVersionInt = 49999;
                        break;
                    default:
                        mySqlSyntaxProvider.ServerVersionInt = 50000;
                        break;
                }
            }
            else if (_connectionInfo.SyntaxProvider is OracleSyntaxProvider)
            {
                var oracleSyntaxProvider = (OracleSyntaxProvider)_connectionInfo.SyntaxProvider;

                switch (selectedItem)
                {
                    case "Oracle 7":
                        oracleSyntaxProvider.ServerVersion = OracleServerVersion.Oracle7;
                        break;
                    case "Oracle 8":
                        oracleSyntaxProvider.ServerVersion = OracleServerVersion.Oracle8;
                        break;
                    case "Oracle 9":
                        oracleSyntaxProvider.ServerVersion = OracleServerVersion.Oracle9;
                        break;
                    case "Oracle 10":
                        oracleSyntaxProvider.ServerVersion = OracleServerVersion.Oracle10;
                        break;
                    case "Oracle 11":
                        oracleSyntaxProvider.ServerVersion = OracleServerVersion.Oracle11;
                        break;
                    default:
                        oracleSyntaxProvider.ServerVersion = OracleServerVersion.Oracle12;
                        break;
                }
            }
            else if (_connectionInfo.SyntaxProvider is SybaseSyntaxProvider)
            {
                var sybaseSyntaxProvider = (SybaseSyntaxProvider)_connectionInfo.SyntaxProvider;

                switch (selectedItem)
                {
                    case "ASE":
                        sybaseSyntaxProvider.ServerVersion = SybaseServerVersion.SybaseASE;
                        break;
                    case "SAP IQ":
                        sybaseSyntaxProvider.ServerVersion = SybaseServerVersion.SybaseIQ;
                        break;
                    default:
                        sybaseSyntaxProvider.ServerVersion = SybaseServerVersion.SybaseASA;
                        break;
                }
            }

            _currentConnectionFrame.SetServerType(selectedItem);
        }

	}
}
