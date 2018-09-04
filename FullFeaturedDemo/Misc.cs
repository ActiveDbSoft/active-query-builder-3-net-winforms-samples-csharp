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
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View.WinForms;

namespace FullFeaturedDemo
{
    public class ParameterInfo
    {
        public string Name { get; set; }
        public DbType DataType { get; set; }
        public object Value { get; set; }
    }

    public static class Misc
    {
        private const string AtNameParamFormat = "@s";
        private const string ColonNameParamFormat = ":s";
        private const string QuestionParamFormat = "?";
        private const string QuestionNumberParamFormat = "?n";
        private const string QuestionNameParamFormat = "?s";

        public static readonly List<ParameterInfo> ParamsCache = new List<ParameterInfo>();

        public static DbCommand CreateSqlCommand(string sqlCommand, SQLQuery sqlQuery)
        {
            DbCommand command = (DbCommand)sqlQuery.SQLContext.MetadataProvider.Connection.CreateCommand();
            command.CommandText = sqlCommand;

            // handle the query parameters
            if (sqlQuery.QueryParameters.Count == 0)
            {
                ClearParamsCache();
                return command;
            }

            var allApllied = ApplyParamsFromCache(command, sqlQuery);
            if (allApllied)
                return command;
            else
            {
                var qpf = new QueryParametersForm(command);
                if (qpf.ShowDialog() == DialogResult.OK)
                {
                    SaveParamsToCache(command);
                }
                else
                {
                    return null;
                }
            }

            return command;
        }

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
                    ParamsCache.Add(new ParameterInfo
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

        public static DataTable ExecuteSql(string sqlCommand, SQLQuery sqlQuery)
        {
            if (string.IsNullOrEmpty(sqlCommand)) return null;

            if (sqlQuery.SQLContext.MetadataProvider == null)
            {
                return null;
            }

            if (!sqlQuery.SQLContext.MetadataProvider.Connected)
            {
                sqlQuery.SQLContext.MetadataProvider.Connect();
            }

            if (string.IsNullOrEmpty(sqlCommand)) return null;

            if (!sqlQuery.SQLContext.MetadataProvider.Connected)
                sqlQuery.SQLContext.MetadataProvider.Connect();

            var command = CreateSqlCommand(sqlCommand, sqlQuery);
            if (command == null)
                return null;

            DataTable table = new DataTable("result");

            using (var dbReader = command.ExecuteReader())
            {
                for (int i = 0; i < dbReader.FieldCount; i++)
                {
                    table.Columns.Add(dbReader.GetName(i));
                }

                while (dbReader.Read())
                {
                    object[] values = new object[dbReader.FieldCount];
                    dbReader.GetValues(values);
                    table.Rows.Add(values);
                }

                return table;
            }
        }

        public static List<string> GetAcceptableParametersFormats(BaseMetadataProvider metadataProvider,
            BaseSyntaxProvider syntaxProvider)
        {
            if (metadataProvider is MSSQLMetadataProvider)
            {
                return new List<string> { AtNameParamFormat };
            }

            if (metadataProvider is OracleNativeMetadataProvider)
            {
                return new List<string> { ColonNameParamFormat };
            }

            if (metadataProvider is PostgreSQLMetadataProvider)
            {
                return new List<string> { ColonNameParamFormat };
            }

            if (metadataProvider is MySQLMetadataProvider)
            {
                return new List<string> { AtNameParamFormat, QuestionParamFormat, QuestionNumberParamFormat, QuestionNameParamFormat };
            }

            if (metadataProvider is OLEDBMetadataProvider)
            {
                if (syntaxProvider is MSAccessSyntaxProvider)
                {
                    return new List<string> { AtNameParamFormat, ColonNameParamFormat, QuestionParamFormat };
                }

                if (syntaxProvider is MSSQLSyntaxProvider)
                {
                    return new List<string> { QuestionParamFormat };
                }

                if (syntaxProvider is OracleSyntaxProvider)
                {
                    return new List<string> { ColonNameParamFormat, QuestionParamFormat, QuestionNumberParamFormat };
                }

                if (syntaxProvider is DB2SyntaxProvider)
                {
                    return new List<string> { QuestionParamFormat };
                }
            }

            if (metadataProvider is ODBCMetadataProvider)
            {
                if (syntaxProvider is MSAccessSyntaxProvider)
                {
                    return new List<string> { QuestionParamFormat };
                }

                if (syntaxProvider is MSSQLSyntaxProvider)
                {
                    return new List<string> { QuestionParamFormat };
                }

                if (syntaxProvider is MySQLSyntaxProvider)
                {
                    return new List<string> { QuestionParamFormat };
                }

                if (syntaxProvider is PostgreSQLSyntaxProvider)
                {
                    return new List<string> { QuestionParamFormat };
                }

                if (syntaxProvider is OracleSyntaxProvider)
                {
                    return new List<string> { ColonNameParamFormat, QuestionParamFormat, QuestionNumberParamFormat };
                }

                if (syntaxProvider is DB2SyntaxProvider)
                {
                    return new List<string> { QuestionParamFormat };
                }
            }

            return new List<string>();
        }

        public static bool CheckParameters(QueryBuilder queryBuilder)
        {
            var acceptableFormats =
                GetAcceptableParametersFormats(queryBuilder.MetadataProvider, queryBuilder.SyntaxProvider);

            if (acceptableFormats.Count == 0)
                return true;

            foreach (var parameter in queryBuilder.Parameters)
            {
                if (!acceptableFormats.Any(x => IsSatisfiesFormat(parameter.FullName, x)))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsSatisfiesFormat(string name, string format)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(format))
                return false;

            if (format[0] != name[0])
                return false;

            var lastChar = format.Last();
            if (lastChar == '?')
                return name == format;

            if (lastChar == 's')
                return name.Length > 1 && Char.IsLetter(name[1]);

            if (lastChar == 'n')
            {
                if (name.Length == 1)
                    return false;

                foreach (var c in name)
                {
                    if (!Char.IsDigit(c))
                        return false;
                }

                return true;
            }

            return false;
        }
    }

    public enum ConnectionTypes
    {
        MSSQL,
        MSAccess,
        Oracle,
        MySQL,
        PostgreSQL,
        OLEDB,
        ODBC
    }

    [Serializable]
    [XmlInclude(typeof(ConnectionInfo))]
    public class ConnectionList
    {
        [XmlElement(Type = typeof(ConnectionInfo))]
        private ArrayList _connections = new ArrayList();

        public ConnectionInfo this[int index]
        {
            get
            {
                return (ConnectionInfo)_connections[index];
            }
        }

        public int Count
        {
            get
            {
                return _connections.Count;
            }
        }

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
        private BaseSyntaxProvider _syntaxProvider;
        private string _syntaxProviderName;
        public ConnectionTypes ConnectionType { get; set; }
        public string ConnectionName { get; set; }
        public string ConnectionString { get; set; }
        public bool IsXmlFile { get; set; }
        public string UserQueries { get; set; }

        public string SyntaxProviderName
        {
            set
            {
                if (_syntaxProviderName == value) return;

                _syntaxProviderName = value;

                var foundSyntaxProviderType = typeof(GenericSyntaxProvider);

                // find by syntaxProvider.GetType().Name
                foreach (Type syntaxProviderType in Helpers.SyntaxProviderList)
                {
                    if (string.Equals(syntaxProviderType.Name, value, StringComparison.InvariantCultureIgnoreCase))
                    {
                        foundSyntaxProviderType = syntaxProviderType;
                        break;
                    }
                }

                // find by syntaxProvider.Description for backward compatibility
                foreach (Type syntaxProviderType in Helpers.SyntaxProviderList)
                {
                    using (var syntaxProvider = (BaseSyntaxProvider)Activator.CreateInstance(syntaxProviderType))
                    {
                        if (string.Equals(syntaxProvider.Description, value, StringComparison.InvariantCultureIgnoreCase))
                        {
                            foundSyntaxProviderType = syntaxProviderType;
                            break;
                        }
                    }
                }

                // same type?
                if (_syntaxProvider != null && _syntaxProvider.GetType() == foundSyntaxProviderType)
                    return;

                // replace syntax provider
                if (_syntaxProvider != null)
                    _syntaxProvider.Dispose();

                _syntaxProvider = (BaseSyntaxProvider)Activator.CreateInstance(foundSyntaxProviderType);
            }
            get { return _syntaxProviderName; }
        }

        [XmlIgnore]
        public BaseSyntaxProvider SyntaxProvider
        {
            set
            {
                _syntaxProvider = value;
                if (_syntaxProvider != null)
                    SyntaxProviderName = _syntaxProvider.GetType().Name;
            }
            get { return _syntaxProvider; }
        }

        public ConnectionInfo()
        {
            ConnectionType = ConnectionTypes.MSSQL;
            ConnectionName = null;
            ConnectionString = null;
            IsXmlFile = false;
        }

        public ConnectionInfo(ConnectionTypes connectionType, string connectionName, string connectionString, bool isFromXml, string cacheFile, string userQueriesXml)
        {
            ConnectionType = connectionType;
            ConnectionName = connectionName;
            ConnectionString = connectionString;
            IsXmlFile = isFromXml;
            UserQueries = userQueriesXml;
        }

        public void CreateSyntaxByType()
        {
            switch (ConnectionType)
            {
                case ConnectionTypes.MSSQL:
                    SyntaxProvider = new MSSQLSyntaxProvider();
                    break;
                case ConnectionTypes.MSAccess:
                    SyntaxProvider = new MSAccessSyntaxProvider();
                    break;
                case ConnectionTypes.Oracle:
                    SyntaxProvider = new OracleSyntaxProvider();
                    break;
                case ConnectionTypes.MySQL:
                    SyntaxProvider = new MySQLSyntaxProvider();
                    break;
                case ConnectionTypes.PostgreSQL:
                    SyntaxProvider = new PostgreSQLSyntaxProvider();
                    break;
                case ConnectionTypes.OLEDB:
                    SyntaxProvider = new SQL92SyntaxProvider();
                    break;
                case ConnectionTypes.ODBC:
                    SyntaxProvider = new SQL92SyntaxProvider();
                    break;
            }
        }

        public override bool Equals(System.Object obj)
        {
            if (obj != null && obj is ConnectionInfo)
            {
                if (((ConnectionInfo)obj).ConnectionType == this.ConnectionType &&
                    ((ConnectionInfo)obj).ConnectionName == this.ConnectionName &&
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
