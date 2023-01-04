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
using GeneralAssembly.DataViewerControl;
using XmlSerializer = ActiveQueryBuilder.Core.Serialization.XmlSerializer;

namespace GeneralAssembly
{
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
            typeof(FirebirdConnectionDescriptor),
            typeof(VistaDB5ConnectionDescriptor),
            typeof(DB2ConnectionDescriptor),
            typeof(AdvantageConnectionDescriptor),
            typeof(SybaseConnectionDescriptor),
            typeof(InformixConnectionDescriptor),
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
            "ODBC",
            "Generic OLEDB Connection",
            "SQLite",
            "Firebird",
            "VistaDB5",
            "DB2",
            "Advantage",
            "Sybase",
            "Informix"
        };
    }

    public enum ConnectionTypes
    {
        MSAccess,
        Excel,
        MSSQL,
        MSSQLAzure,
        MySQL,
        OracleNative,
        PostgreSQL,
        ODBC,
        OLEDB,
        SQLite,
        Firebird,
        VistaDB5,
        DB2,
        Advantage,
        Sybase,
        Informix
    }

    [Serializable]
    [XmlInclude(typeof(ConnectionInfo))]
    public class ConnectionList
    {
        [XmlElement(Type = typeof(ConnectionInfo))]
        private ArrayList _connections = new ArrayList();

        public void SaveData()
        {
            var xmlSerializer = new XmlSerializer();
            foreach (ConnectionInfo connection in _connections)
            {
                connection.SyntaxProviderName = connection.ConnectionDescriptor.SyntaxProvider.GetType().ToString();
                connection.ConnectionString = connection.ConnectionDescriptor.ConnectionString;
                connection.LoadingOptions =
                    xmlSerializer.Serialize(connection.ConnectionDescriptor.MetadataLoadingOptions);
                connection.SyntaxProviderState =
                    xmlSerializer.SerializeObject(connection.ConnectionDescriptor.SyntaxProvider);
                connection.StructureOptionsState = xmlSerializer.SerializeObject(connection.StructureOptions);
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
            var xmlSerializer = new XmlSerializer();
            
            foreach (ConnectionInfo connection in _connections)
            {
                if(connection.ConnectionDescriptor == null) continue;

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

                    xmlSerializer.DeserializeObject(connection.SyntaxProviderState,
                        connection.ConnectionDescriptor.SyntaxProvider);
                    connection.ConnectionDescriptor.RecreateSyntaxProperties();
                }

                if (!string.IsNullOrEmpty(connection.StructureOptionsState))
                {
                    if (connection.StructureOptions == null)
                        connection.StructureOptions = new MetadataStructureOptions();

                    xmlSerializer.DeserializeObject(connection.StructureOptionsState, connection.StructureOptions);
                }
            }
        }

        public ConnectionInfo this[int index] => (ConnectionInfo)_connections[index];

        public int Count => _connections.Count;

        public System.Collections.ArrayList Connections
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
        public string Name { get; set; }
        [XmlIgnore]
        public BaseConnectionDescriptor ConnectionDescriptor { get; set; }
        [XmlIgnore]
        public MetadataStructureOptions StructureOptions { get; set; }
        public string ConnectionString { get; set; }
        public bool IsXmlFile { get; set; }
        public string XMLPath { get; set; }
        public string CacheFile { get; set; }
        public string UserQueries { get; set; }
        public string MetadataStructure { get; set; }
        public string LoadingOptions { get; set; }
        public string StructureOptionsState { get; set; }
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

        private ConnectionTypes _type = ConnectionTypes.MSSQL;

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
            StructureOptions = new MetadataStructureOptions() { AllowFavourites = true };
        }

        public ConnectionInfo(string xmlPath, string name, ConnectionTypes type)
        {
            Name = name;
            XMLPath = xmlPath;
            Type = type;
            IsXmlFile = true;
            StructureOptions = new MetadataStructureOptions { AllowFavourites = true };
            CreateConnectionByType();
        }

        public ConnectionInfo()
        {
            StructureOptions = new MetadataStructureOptions { AllowFavourites = true };
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
                    case ConnectionTypes.OracleNative:
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
                    case ConnectionTypes.Advantage:
                        ConnectionDescriptor = new AdvantageConnectionDescriptor();
                        break;
                    case ConnectionTypes.Sybase:
                        ConnectionDescriptor = new SybaseConnectionDescriptor();
                        break;
                    case ConnectionTypes.VistaDB5:
                        ConnectionDescriptor = new VistaDB5ConnectionDescriptor();
                        break;
                    case ConnectionTypes.DB2:
                        ConnectionDescriptor = new DB2ConnectionDescriptor();
                        break;
                    case ConnectionTypes.Informix:
                        ConnectionDescriptor = new InformixConnectionDescriptor();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            catch
            {
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
                return ConnectionTypes.OracleNative;
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
            if (descriptorType == typeof(AdvantageConnectionDescriptor))
            {
                return ConnectionTypes.Advantage;
            }
            if (descriptorType == typeof(SybaseConnectionDescriptor))
            {
                return ConnectionTypes.Sybase;
            }
            if (descriptorType == typeof(VistaDB5ConnectionDescriptor))
            {
                return ConnectionTypes.VistaDB5;
            }
            if (descriptorType == typeof(DB2ConnectionDescriptor))
            {
                return ConnectionTypes.DB2;
            }
            if (descriptorType == typeof(InformixConnectionDescriptor))
            {
                return ConnectionTypes.Informix;
            }

            return ConnectionTypes.MSSQL;
        }

        public override bool Equals(Object obj)
        {
            if (obj != null && obj is ConnectionInfo)
            {
                if (((ConnectionInfo)obj).Type == this.Type &&
                    ((ConnectionInfo)obj).Name == this.Name &&
                    ((ConnectionInfo)obj).ConnectionString == this.ConnectionString &&
                    ((ConnectionInfo)obj).IsXmlFile == this.IsXmlFile)
                {
                    return true;
                }
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
