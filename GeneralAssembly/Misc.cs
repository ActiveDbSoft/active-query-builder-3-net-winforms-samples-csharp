//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2023 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Xml.Serialization;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View;
using GeneralAssembly.DataViewerControl;
using Helpers = ActiveQueryBuilder.Core.Helpers;

namespace GeneralAssembly
{
    public static class Converters
    {
        public static CPoint FromNativePoint(this Point stdPoint)
        {
            return new CPoint(stdPoint.X, stdPoint.Y);
        }

        public static Point ToNativePoint(this CPoint customPoint)
        {
            return new Point((int)customPoint.X, (int)customPoint.Y);
        }

        public static CFont ToCFont(object font)
        {
            var castedFont = font as Font;
            if (castedFont == null)
                return null;

            return new CFont(castedFont.FontFamily.Name, castedFont.Size, castedFont.Bold, castedFont.Italic);
        }

        public static Font ToFont(this CFont font)
        {
            FontStyle style = FontStyle.Regular;
            if (font.Bold)
            {
                style |= FontStyle.Bold;
            }
            if (font.Italic)
            {
                style |= FontStyle.Italic;
            }

            return new Font(font.Family, (float)font.Size, style, (GraphicsUnit)font.Unit);
        }

        public static CFont ToCFont(this Font font)
        {

            return new CFont(font.FontFamily.Name, font.Size, font.Bold, font.Italic) { Unit = (CFont.FontUnit)font.Unit };
        }
    }
    public class Misc
    {
        public static readonly List<DataViewer.ParameterInfo> ParamsCache = new List<DataViewer.ParameterInfo>();

        public static void ClearParamsCache()
        {
            ParamsCache.Clear();
        }

        private static void SaveParamsToCache(DbCommand command)
        {
            ClearParamsCache();
            foreach (DbParameter parameter in command.Parameters)
            {
                if (parameter.Value != null)
                    ParamsCache.Add(new DataViewer.ParameterInfo
                    {
                        Name = parameter.ParameterName,
                        DataType = parameter.DbType,
                        Value = parameter.Value
                    });
            }
        }

        private static bool ApplyParamsFromCache(DbCommand command, SQLQuery query)
        {
            var result = true;
            foreach (var parameter in query.QueryParameters)
            {
                var cached =
                    ParamsCache.FirstOrDefault(x => x.Name == parameter.FullName && x.DataType == parameter.DataType);

                var param = command.CreateParameter();
                param.ParameterName = parameter.FullName;
                param.DbType = parameter.DataType;
                if (cached != null)
                    param.Value = cached.Value;
                else
                    result = false;

                command.Parameters.Add(param);
            }

            return result;
        }

        public static readonly List<Type> ConnectionDescriptorList = new List<Type>
        {
            typeof(MSAccessConnectionDescriptor),
            typeof(ExcelConnectionDescriptor),
            typeof(MSSQLConnectionDescriptor),
            typeof(MSSQLAzureConnectionDescriptor),
            typeof(MySQLConnectionDescriptor),
            typeof(OracleNativeConnectionDescriptor),
            typeof(PostgreSQLConnectionDescriptor),
            typeof(ODBCConnectionDescriptor),
            typeof(OLEDBConnectionDescriptor),
            typeof(SQLiteConnectionDescriptor),
            typeof(FirebirdConnectionDescriptor)
        };

        public static readonly List<string> ConnectionDescriptorNames = new List<string>
        {
            "MS Access",
            "Excel",
            "MS SQL Server",
            "MS SQL Server Azure",
            "MySQL",
            "Oracle Native",
            "PostgreSQL",
            "Generic ODBC Connection",
            "Generic OLEDB Connection",
            "SQLite",
            "Firebird"
        };
    }

    public enum ConnectionTypes
    {
        MSSQL,
        MSSQLAzure,
        MSAccess,
        Oracle,
        MySQL,
        PostgreSQL,
        OLEDB,
        ODBC,
        SQLite,
        Firebird,
        Excel
    }

    [Serializable]
    [XmlInclude(typeof(ConnectionInfo))]
    public class ConnectionList
    {
        [XmlElement(Type = typeof(ConnectionInfo))]
        private ArrayList _connections = new ArrayList();

        public void SaveData()
        {
            var xmlSerializer = new ActiveQueryBuilder.Core.Serialization.XmlSerializer();
            foreach (ConnectionInfo connection in _connections)
            {
                connection.SyntaxProviderName = connection.ConnectionDescriptor.SyntaxProvider.GetType().ToString();
                if (string.IsNullOrEmpty(connection.ConnectionString))
                    connection.ConnectionString = connection.ConnectionDescriptor.ConnectionString;
                connection.LoadingOptions =
                    xmlSerializer.Serialize(connection.ConnectionDescriptor.MetadataLoadingOptions);
                connection.SyntaxProviderState =
                    xmlSerializer.SerializeObject(connection.ConnectionDescriptor.SyntaxProvider);
            }
        }

        public void RemoveObsoleteConnectionInfos()
        {
            var connectionsToRemove = new List<ConnectionInfo>();

            foreach (ConnectionInfo connection in _connections)
            {
                if (connection.ConnectionDescriptor == null)
                {
                    connectionsToRemove.Add(connection);
                }
            }

            foreach (ConnectionInfo connection in connectionsToRemove)
            {
                _connections.Remove(connection);
            }
        }

        public void RestoreData()
        {
            var xmlSerializer = new ActiveQueryBuilder.Core.Serialization.XmlSerializer();

            foreach (ConnectionInfo connection in _connections)
            {
                if (connection.ConnectionDescriptor == null) continue;

                if (!connection.IsXmlFile)
                    connection.ConnectionDescriptor.ConnectionString = connection.ConnectionString;

                if (!string.IsNullOrEmpty(connection.LoadingOptions))
                {
                    xmlSerializer.Deserialize(connection.LoadingOptions,
                        connection.ConnectionDescriptor.MetadataLoadingOptions);
                }

                if (!string.IsNullOrEmpty(connection.SyntaxProviderName) && connection.IsGenericConnection())
                {
                    connection.ConnectionDescriptor.SyntaxProvider =
                        ConnectionInfo.GetSyntaxByName(connection.SyntaxProviderName);
                }

                if (!string.IsNullOrEmpty(connection.SyntaxProviderState))
                {
                    if (!string.IsNullOrEmpty(connection.SyntaxProviderName))
                    {
                        connection.ConnectionDescriptor.SyntaxProvider =
                            ConnectionInfo.GetSyntaxByName(connection.SyntaxProviderName);
                    }

                    xmlSerializer.DeserializeObject(connection.SyntaxProviderState, connection.ConnectionDescriptor.SyntaxProvider);
                    connection.ConnectionDescriptor.RecreateSyntaxProperties();
                }
            }
        }

        public ConnectionInfo this[int index] => (ConnectionInfo)_connections[index];

        public int Count => _connections.Count;

        public ArrayList Connections
        {
            get
            {
                return _connections;
            }
            set
            {
                _connections = value;
            }
        }

        public void Add(ConnectionInfo ci)
        {
            _connections.Add(ci);
        }

        public void Insert(int index, ConnectionInfo ci)
        {
            _connections.Insert(index, ci);
        }

        public void Remove(ConnectionInfo ci)
        {
            _connections.Remove(ci);
        }
    }

    [Serializable]
    public class ConnectionInfo
    {
        private ConnectionTypes _type = ConnectionTypes.MSSQL;
        public string Name { get; set; }

        private BaseConnectionDescriptor _connectionDescriptor;
        [XmlIgnore]
        public BaseConnectionDescriptor ConnectionDescriptor
        {
            get { return _connectionDescriptor; }
            set
            {
                _connectionDescriptor = value;
                if (_connectionDescriptor?.MetadataProvider?.Connection != null && string.IsNullOrEmpty(_connectionDescriptor.MetadataProvider.Connection.ConnectionString) && !string.IsNullOrEmpty(ConnectionString) && !IsXmlFile)
                {
                    _connectionDescriptor.MetadataProvider.Connection.ConnectionString = ConnectionString;
                }
            }
        }

        [XmlIgnore]
        public BaseSyntaxProvider SyntaxProvider
        {
            get { return ConnectionDescriptor.SyntaxProvider; }
            set { ConnectionDescriptor.SyntaxProvider = value; }
        }

        public string ConnectionString { get; set; }
        public bool IsXmlFile { get; set; }
        public string XMLPath { get; set; }
        public string UserQueries { get; set; }
        public string LoadingOptions { get; set; }
        public string SyntaxProviderState { get; set; }
        public string SyntaxProviderName { get; set; }

        public bool IsGenericConnection()
        {
            return ConnectionDescriptor is OLEDBConnectionDescriptor ||
                   ConnectionDescriptor is ODBCConnectionDescriptor;
        }

        public static BaseSyntaxProvider GetSyntaxByName(string name)
        {
            foreach (Type syntax in Helpers.SyntaxProviderList)
            {
                if (syntax.ToString() == name)
                {
                    return Activator.CreateInstance(syntax) as BaseSyntaxProvider;
                }
            }

            return null;
        }

        public ConnectionTypes Type
        {
            get { return _type; }
            set
            {
                _type = value;
                CreateConnectionByType();

                if (!string.IsNullOrEmpty(SyntaxProviderName) && IsGenericConnection())
                {
                    ConnectionDescriptor.SyntaxProvider = GetSyntaxByName(SyntaxProviderName);
                }
            }
        }

        public ConnectionInfo(BaseConnectionDescriptor descriptor, string name, ConnectionTypes type, string connectionString)
        {
            Name = name;
            ConnectionDescriptor = descriptor;
            Type = type;
            ConnectionString = connectionString;
            IsXmlFile = false;
            ConnectionDescriptor.ConnectionString = connectionString;
        }

        public ConnectionInfo(string xmlPath, string name, ConnectionTypes type)
        {
            Name = name;
            XMLPath = xmlPath;
            Type = type;
            IsXmlFile = true;
            ConnectionString = string.Empty;
            CreateConnectionByType();
        }

        public ConnectionInfo(ConnectionTypes connectionType, string connectionName, string connectionString, bool isFromXml, string userQueriesXml)
        {
            Type = connectionType;
            Name = connectionName;
            ConnectionString = connectionString;
            IsXmlFile = isFromXml;
            UserQueries = userQueriesXml;
            CreateConnectionByType();
        }

        public ConnectionInfo()
        {
        }

        private void CreateConnectionByType()
        {
            try
            {
                switch (Type)
                {
                    case ConnectionTypes.MSAccess:
                        ConnectionDescriptor = new MSAccessConnectionDescriptor();
                        return;
                    case ConnectionTypes.MSSQL:
                        ConnectionDescriptor = new MSSQLConnectionDescriptor();
                        return;
                    case ConnectionTypes.MSSQLAzure:
                        ConnectionDescriptor = new MSSQLAzureConnectionDescriptor();
                        return;
                    case ConnectionTypes.MySQL:
                        ConnectionDescriptor = new MySQLConnectionDescriptor();
                        return;
                    case ConnectionTypes.Oracle:
                        ConnectionDescriptor = new OracleNativeConnectionDescriptor();
                        return;
                    case ConnectionTypes.PostgreSQL:
                        ConnectionDescriptor = new PostgreSQLConnectionDescriptor();
                        return;
                    case ConnectionTypes.ODBC:
                        ConnectionDescriptor = new ODBCConnectionDescriptor();
                        return;
                    case ConnectionTypes.OLEDB:
                        ConnectionDescriptor = new OLEDBConnectionDescriptor();
                        return;
                    case ConnectionTypes.Firebird:
                        ConnectionDescriptor = new FirebirdConnectionDescriptor();
                        return;
                    case ConnectionTypes.SQLite:
                        ConnectionDescriptor = new SQLiteConnectionDescriptor();
                        return;
                    case ConnectionTypes.Excel:
                        ConnectionDescriptor = new ExcelConnectionDescriptor();
                        return;
                }
            }
            finally
            {
                //ignore
            }
        }

        public ConnectionTypes GetConnectionType(Type descriptorType)
        {
            if (descriptorType == typeof(MSAccessConnectionDescriptor))
            {
                return ConnectionTypes.MSAccess;
            }
            if (descriptorType == typeof(ExcelConnectionDescriptor))
            {
                return ConnectionTypes.Excel;
            }
            if (descriptorType == typeof(PostgreSQLConnectionDescriptor))
            {
                return ConnectionTypes.PostgreSQL;
            }
            if (descriptorType == typeof(MSSQLConnectionDescriptor))
            {
                return ConnectionTypes.MSSQL;
            }
            if (descriptorType == typeof(MSSQLAzureConnectionDescriptor))
            {
                return ConnectionTypes.MSSQLAzure;
            }
            if (descriptorType == typeof(MySQLConnectionDescriptor))
            {
                return ConnectionTypes.MySQL;
            }
            if (descriptorType == typeof(OracleNativeConnectionDescriptor))
            {
                return ConnectionTypes.Oracle;
            }
            if (descriptorType == typeof(ODBCConnectionDescriptor))
            {
                return ConnectionTypes.ODBC;
            }
            if (descriptorType == typeof(OLEDBConnectionDescriptor))
            {
                return ConnectionTypes.OLEDB;
            }
            if (descriptorType == typeof(FirebirdConnectionDescriptor))
            {
                return ConnectionTypes.Firebird;
            }
            if (descriptorType == typeof(SQLiteConnectionDescriptor))
            {
                return ConnectionTypes.SQLite;
            }

            return ConnectionTypes.MSSQL;
        }

        public void CreateConnectionDescriptor()
        {
            CreateConnectionByType();

            if (!string.IsNullOrEmpty(SyntaxProviderName) && IsGenericConnection())
                ConnectionDescriptor.SyntaxProvider = GetSyntaxByName(SyntaxProviderName);

            if (IsXmlFile) return;

            ConnectionDescriptor.MetadataProvider.Connection.ConnectionString = ConnectionString;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is ConnectionInfo)) return false;

            return ((ConnectionInfo)obj).Type == Type &&
                   ((ConnectionInfo)obj).Name == Name &&
                   ((ConnectionInfo)obj).ConnectionString == ConnectionString &&
                   ((ConnectionInfo)obj).IsXmlFile == IsXmlFile;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
