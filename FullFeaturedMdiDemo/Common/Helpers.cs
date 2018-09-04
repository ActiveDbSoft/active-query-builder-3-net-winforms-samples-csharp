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
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.Core.Serialization;
using ActiveQueryBuilder.View.WinForms;
using ActiveQueryBuilder.View.WinForms.DatabaseSchemaView;
using ActiveQueryBuilder.View.WinForms.Serialization;

namespace FullFeaturedMdiDemo.Common
{
    public static class Helpers
    {
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

        private const string AtNameParamFormat = "@s";
        private const string ColonNameParamFormat = ":s";
        private const string QuestionParamFormat = "?";
        private const string QuestionNumberParamFormat = "?n";
        private const string QuestionNameParamFormat = "?s";

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

        public static bool CheckParameters(BaseMetadataProvider metadataProvider, BaseSyntaxProvider syntaxProvider, ParameterList parameters)
        {
            var acceptableFormats =
                GetAcceptableParametersFormats(metadataProvider, syntaxProvider);

            if (acceptableFormats.Count == 0)
                return true;

            foreach (var parameter in parameters)
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

        public static DbCommand CreateSqlCommand(string sqlCommand, SQLQuery sqlQuery)
        {
            DbCommand command = (DbCommand)sqlQuery.SQLContext.MetadataProvider.Connection.CreateCommand();
            command.CommandText = sqlCommand;

            // handle the query parameters
            if (sqlQuery.QueryParameters.Count <= 0) return command;

            foreach (Parameter p in sqlQuery.QueryParameters.Where(item => !command.Parameters.Contains(item.FullName)))
            {
                var parameter = command.CreateParameter();
                parameter.ParameterName = p.FullName;
                parameter.DbType = p.DataType;
                command.Parameters.Add(parameter);
            }
            var qpf = new QueryParametersForm(command);
            qpf.ShowDialog();
            return command;
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

        public static void SerializeOptions(string path, DatabaseSchemaView dbView, ChildForm childForm)
        {
            using (var fileStream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite))
            using (var xmlBuilder = new XmlDescriptionBuilder(fileStream))
            {
                var service = new OptionsSerializationService(xmlBuilder){SerializeDefaultValues = true};
                var metadataService = new MetadataSerializationService(xmlBuilder);
                XmlSerializerExtensions.Builder = xmlBuilder;
                var root = xmlBuilder.BeginObject("Options");
                {
                    // Behavior options
                    var behaviorHandle = xmlBuilder.BeginObjectProperty(root, Constants.BehaviorOptionsTag);
                    {
                        service.EncodeObject(behaviorHandle, childForm.BehaviorOptions);
                    }
                    xmlBuilder.EndObjectProperty(behaviorHandle);
                    // Database view options
                    var dbViewOptionsHandle = xmlBuilder.BeginObjectProperty(root, Constants.DatabaseSchemaViewOptionsTag);
                    {
                        service.EncodeObject(dbViewOptionsHandle, dbView.Options);
                    }
                    xmlBuilder.EndObjectProperty(dbViewOptionsHandle);
                    // DesignPaneOptions
                    var designPaneOptionsHandle = xmlBuilder.BeginObjectProperty(root, Constants.DesignPaneOptionsTag);
                    {
                        service.EncodeObject(designPaneOptionsHandle, childForm.DesignPaneOptions);
                    }
                    xmlBuilder.EndObjectProperty(designPaneOptionsHandle);
                    // VisualOptions
                    var visualOptionsHandle = xmlBuilder.BeginObjectProperty(root, Constants.VisualOptionsTag);
                    {
                        service.EncodeObject(visualOptionsHandle, childForm.VisualOptions);
                    }
                    xmlBuilder.EndObjectProperty(visualOptionsHandle);
                    // AddObjectDialogOptions
                    var addObjectDialogHandle = xmlBuilder.BeginObjectProperty(root, Constants.AddObjectDialogOptionsTag);
                    {
                        service.EncodeObject(addObjectDialogHandle, childForm.AddObjectDialogOptions);
                    }
                    xmlBuilder.EndObjectProperty(addObjectDialogHandle);
                    // DataSourceOptions
                    var dataSourceOptionsHandle = xmlBuilder.BeginObjectProperty(root, "DataSourceOptions");
                    {
                        service.EncodeObject(dataSourceOptionsHandle, childForm.DataSourceOptions);
                    }
                    xmlBuilder.EndObjectProperty(dataSourceOptionsHandle);
                    // MetadataLoadingOptions
                    var metadataLoadingOptionsHandle = xmlBuilder.BeginObjectProperty(root, "MetadataLoadingOptions");
                    {
                        metadataService.Encode(metadataLoadingOptionsHandle, childForm.MetadataLoadingOptions);
                    }
                    xmlBuilder.EndObjectProperty(metadataLoadingOptionsHandle);
                    // MetadataStructureOptions
                    var metadataStructureOptionsHandle = xmlBuilder.BeginObjectProperty(root, "MetadataStructureOptions");
                    {
                        service.EncodeObject(metadataStructureOptionsHandle, childForm.MetadataStructureOptions);
                    }
                    xmlBuilder.EndObjectProperty(metadataStructureOptionsHandle);
                    // QueryColumnListOptions
                    var queryColumnListOptionsHandle = xmlBuilder.BeginObjectProperty(root, "QueryColumnListOptions");
                    {
                        service.EncodeObject(queryColumnListOptionsHandle, childForm.QueryColumnListOptions);
                    }
                    xmlBuilder.EndObjectProperty(queryColumnListOptionsHandle);
                    // QueryNavBarOptions
                    var queryNavBarOptionsHandle = xmlBuilder.BeginObjectProperty(root, "QueryNavBarOptions");
                    {
                        service.EncodeObject(queryNavBarOptionsHandle, childForm.QueryNavBarOptions);
                    }
                    xmlBuilder.EndObjectProperty(queryNavBarOptionsHandle);
                    // UserInterfaceOptions
                    var userInterfaceOptionsHandle = xmlBuilder.BeginObjectProperty(root, "UserInterfaceOptions");
                    {
                        service.EncodeObject(userInterfaceOptionsHandle, childForm.UserInterfaceOptions);
                    }
                    xmlBuilder.EndObjectProperty(userInterfaceOptionsHandle);
                    // SqlFormattingOptions
                    var sqlFormattingOptionsHandle = xmlBuilder.BeginObjectProperty(root, "SqlFormattingOptions");
                    {
                        service.EncodeObject(sqlFormattingOptionsHandle, childForm.SqlFormattingOptions);
                    }
                    xmlBuilder.EndObjectProperty(sqlFormattingOptionsHandle);
                    // SqlGenerationOptions
                    var sqlGenerationOptionsHandle = xmlBuilder.BeginObjectProperty(root, "SqlGenerationOptions");
                    {
                        service.EncodeObject(sqlGenerationOptionsHandle, childForm.SqlGenerationOptions);
                    }
                    xmlBuilder.EndObjectProperty(sqlGenerationOptionsHandle);
                }
                xmlBuilder.EndObject(root);
            }
        }

        public static void DeserializeOptions(string xml, DatabaseSchemaView dbView, ChildForm childForm)
        {
            var buffer = Encoding.UTF8.GetBytes(xml);
            using (var memoryStream = new MemoryStream(buffer))
            {
                var adapter = new XmlAdapter(memoryStream);
                var service = new OptionsDeserializationService(adapter);
                XmlSerializerExtensions.Adapter = adapter;

                var metadataService = new MetadataDeserializationService(adapter);

                adapter.Reader.ReadToFollowing(Constants.BehaviorOptionsTag);
                var behaviorOptionsTree = adapter.Reader.ReadSubtree();
                behaviorOptionsTree.Read();
                service.DecodeObject(behaviorOptionsTree, childForm.BehaviorOptions);
                behaviorOptionsTree.Close();
                adapter.Reader.Read();

                var dbViewOptionsTree = adapter.Reader.ReadSubtree();
                dbViewOptionsTree.Read();
                service.DecodeObject(dbViewOptionsTree, dbView.Options);
                dbViewOptionsTree.Close();
                adapter.Reader.Read();

                var designPaneOptionsTree = adapter.Reader.ReadSubtree();
                designPaneOptionsTree.Read();
                service.DecodeObject(designPaneOptionsTree, childForm.DesignPaneOptions);
                designPaneOptionsTree.Close();
                adapter.Reader.Read();

                var visualOptionsTree = adapter.Reader.ReadSubtree();
                visualOptionsTree.Read();
                service.DecodeObject(visualOptionsTree, childForm.VisualOptions);
                visualOptionsTree.Close();
                adapter.Reader.Read();

                var addObjectDialogOptionsTree = adapter.Reader.ReadSubtree();
                addObjectDialogOptionsTree.Read();
                service.DecodeObject(addObjectDialogOptionsTree, childForm.AddObjectDialogOptions);
                addObjectDialogOptionsTree.Close();
                adapter.Reader.Read();

                var dataSourceOptionsTree = adapter.Reader.ReadSubtree();
                dataSourceOptionsTree.Read();
                service.DecodeObject(dataSourceOptionsTree, childForm.DataSourceOptions);
                dataSourceOptionsTree.Close();
                adapter.Reader.Read();

                var metadataLoadingOptionsTree = adapter.Reader.ReadSubtree();
                metadataLoadingOptionsTree.Read();
                metadataService.DecodeMetadataLoadingOptions(metadataLoadingOptionsTree, childForm.MetadataLoadingOptions);
                metadataLoadingOptionsTree.Close();
                adapter.Reader.Read();

                var metadataStructureOptionsTree = adapter.Reader.ReadSubtree();
                metadataStructureOptionsTree.Read();
                service.DecodeObject(metadataStructureOptionsTree, childForm.MetadataStructureOptions);
                metadataStructureOptionsTree.Close();
                adapter.Reader.Read();

                var queryColumnListTree = adapter.Reader.ReadSubtree();
                queryColumnListTree.Read();
                service.DecodeObject(queryColumnListTree, childForm.QueryColumnListOptions);
                queryColumnListTree.Close();
                adapter.Reader.Read();

                var queryNavBarTree = adapter.Reader.ReadSubtree();
                queryNavBarTree.Read();
                service.DecodeObject(queryNavBarTree, childForm.QueryNavBarOptions);
                queryNavBarTree.Close();
                adapter.Reader.Read();

                var userInterfaceOptionsTree = adapter.Reader.ReadSubtree();
                userInterfaceOptionsTree.Read();
                service.DecodeObject(userInterfaceOptionsTree, childForm.UserInterfaceOptions);
                userInterfaceOptionsTree.Close();
                adapter.Reader.Read();

                var sqlFormattingOptionsTree = adapter.Reader.ReadSubtree();
                sqlFormattingOptionsTree.Read();
                service.DecodeObject(sqlFormattingOptionsTree, childForm.SqlFormattingOptions);
                sqlFormattingOptionsTree.Close();
                adapter.Reader.Read();

                var sqlGenerationOptionsTree = adapter.Reader.ReadSubtree();
                sqlGenerationOptionsTree.Read();
                service.DecodeObject(sqlGenerationOptionsTree, childForm.SqlGenerationOptions);
                sqlGenerationOptionsTree.Close();
                adapter.Reader.Read();
            }
        }
    }
}
