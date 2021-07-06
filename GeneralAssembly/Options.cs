//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2021 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.Core.Serialization;
using ActiveQueryBuilder.View;
using ActiveQueryBuilder.View.DatabaseSchemaView;
using ActiveQueryBuilder.View.WinForms;
using ActiveQueryBuilder.View.WinForms.QueryView;
using ActiveQueryBuilder.View.WinForms.Serialization;

namespace GeneralAssembly
{
    public class Options
    {
        private readonly Padding DefaultTextEditorPadding = new Padding(5, 5, 0, 0);

        public BehaviorOptions BehaviorOptions { get; set; }
        public DatabaseSchemaViewOptions DatabaseSchemaViewOptions { get; set; }
        public DesignPaneOptions DesignPaneOptions { get; set; }
        public VisualOptions VisualOptions { get; set; }
        public AddObjectDialogOptions AddObjectDialogOptions { get; set; }
        public DataSourceOptions DataSourceOptions { get; set; }
        public QueryNavBarOptions QueryNavBarOptions { get; set; }
        public UserInterfaceOptions UserInterfaceOptions { get; set; }
        public SQLFormattingOptions SqlFormattingOptions { get; set; }
        public SQLGenerationOptions SqlGenerationOptions { get; set; }

        private readonly List<OptionsBase> _options = new List<OptionsBase>();

        public void CreateDefaultOptions()
        {
            BehaviorOptions = new BehaviorOptions();
            DatabaseSchemaViewOptions = new DatabaseSchemaViewOptions();
            DesignPaneOptions = new DesignPaneOptions();
            VisualOptions = new VisualOptions();
            AddObjectDialogOptions = new AddObjectDialogOptions();
            DataSourceOptions = new DataSourceOptions();
            QueryNavBarOptions = new QueryNavBarOptions();
            UserInterfaceOptions = new UserInterfaceOptions();
            SqlFormattingOptions = new SQLFormattingOptions();
            SqlGenerationOptions = new SQLGenerationOptions();
        }

        private void InitializeOptionsList()
        {
            _options.Clear();
            _options.Add(BehaviorOptions);
            _options.Add(DatabaseSchemaViewOptions);
            _options.Add(DesignPaneOptions);
            _options.Add(VisualOptions);
            _options.Add(AddObjectDialogOptions);
            _options.Add(DataSourceOptions);
            _options.Add(QueryNavBarOptions);
            _options.Add(UserInterfaceOptions);
            _options.Add(SqlFormattingOptions);
            _options.Add(SqlGenerationOptions);
        }

        public string SerializeToString()
        {
            InitializeOptionsList();

            var result = string.Empty;
            using (var stream = new MemoryStream())
            {
                using (var xmlBuilder = new XmlDescriptionBuilder(stream))
                {
                    var service = new OptionsSerializationService(xmlBuilder) {SerializeDefaultValues = true};
                    XmlSerializerExtensions.Builder = xmlBuilder;
                    using (var root = xmlBuilder.BeginObject("Options"))
                    {
                        foreach (var option in _options)
                        {
                            using (var optionHandle = xmlBuilder.BeginObjectProperty(root, option.GetType().Name))
                            {
                                service.EncodeObject(optionHandle, option);
                            }
                        }
                    }
                }

                stream.Position = 0;
                using (var reader = new StreamReader(stream))
                {
                    result = reader.ReadToEnd();
                }
            }

            return result;
        }

        public void SerializeToFile(string path)
        {
            InitializeOptionsList();
            
            File.WriteAllText(path, SerializeToString());
        }

        public void DeserializeFromFile(string path)
        {
            InitializeOptionsList();
            
            DeserializeFromString(File.ReadAllText(path));
        }

        public void DeserializeFromString(string xml)
        {
            InitializeOptionsList();

            var buffer = Encoding.UTF8.GetBytes(xml);
            using (var memoryStream = new MemoryStream(buffer))
            {
                var adapter = new XmlAdapter(memoryStream);
                var service = new OptionsDeserializationService(adapter);
                XmlSerializerExtensions.Adapter = adapter;

                adapter.Reader.ReadToFollowing(_options[0].GetType().Name);

                foreach (var option in _options)
                {
                    var optionTree = adapter.Reader.ReadSubtree();
                    optionTree.Read();
                    service.DecodeObject(optionTree, option);
                    optionTree.Close();
                    adapter.Reader.Read();
                }
            }
        }

        public static void SerializeOptions(string path, IDatabaseSchemaView dbView, ISupportOptions withOptions)
        {
            using (var fileStream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite))
            using (var xmlBuilder = new XmlDescriptionBuilder(fileStream))
            {
                var service = new OptionsSerializationService(xmlBuilder) { SerializeDefaultValues = true };
                var metadataService = new MetadataSerializationService(xmlBuilder);
                XmlSerializerExtensions.Builder = xmlBuilder;
                using (var root = xmlBuilder.BeginObject("Options"))
                {
                    // Behavior options
                    using (var behaviorHandle = xmlBuilder.BeginObjectProperty(root, Constants.BehaviorOptionsTag))
                    {
                        service.EncodeObject(behaviorHandle, withOptions.BehaviorOptions);
                    }
                    // Database view options
                    using (var dbViewOptionsHandle = xmlBuilder.BeginObjectProperty(root, Constants.DatabaseSchemaViewOptionsTag))
                    {
                        service.EncodeObject(dbViewOptionsHandle, dbView.Options);
                    }
                    // DesignPaneOptions
                    using (var designPaneOptionsHandle = xmlBuilder.BeginObjectProperty(root, Constants.DesignPaneOptionsTag))
                    {
                        service.EncodeObject(designPaneOptionsHandle, withOptions.DesignPaneOptions);
                    }
                    // VisualOptions
                    using (var visualOptionsHandle = xmlBuilder.BeginObjectProperty(root, Constants.VisualOptionsTag))
                    {
                        service.EncodeObject(visualOptionsHandle, withOptions.VisualOptions);
                    }
                    // AddObjectDialogOptions
                    using (var addObjectDialogHandle = xmlBuilder.BeginObjectProperty(root, Constants.AddObjectDialogOptionsTag))
                    {
                        service.EncodeObject(addObjectDialogHandle, withOptions.AddObjectDialogOptions);
                    }
                    // DataSourceOptions
                    using (var dataSourceOptionsHandle = xmlBuilder.BeginObjectProperty(root, "DataSourceOptions"))
                    {
                        service.EncodeObject(dataSourceOptionsHandle, withOptions.DataSourceOptions);
                    }
                    // MetadataLoadingOptions
                    using (var metadataLoadingOptionsHandle = xmlBuilder.BeginObjectProperty(root, "MetadataLoadingOptions"))
                    {
                        metadataService.Encode(metadataLoadingOptionsHandle, withOptions.MetadataLoadingOptions);
                    }
                    // MetadataStructureOptions
                    using (var metadataStructureOptionsHandle = xmlBuilder.BeginObjectProperty(root, "MetadataStructureOptions"))
                    {
                        service.EncodeObject(metadataStructureOptionsHandle, withOptions.MetadataStructureOptions);
                    }
                    // QueryColumnListOptions
                    using (var queryColumnListOptionsHandle = xmlBuilder.BeginObjectProperty(root, "QueryColumnListOptions"))
                    {
                        service.EncodeObject(queryColumnListOptionsHandle, withOptions.QueryColumnListOptions);
                    }
                    // QueryNavBarOptions
                    using (var queryNavBarOptionsHandle = xmlBuilder.BeginObjectProperty(root, "QueryNavBarOptions"))
                    {
                        service.EncodeObject(queryNavBarOptionsHandle, withOptions.QueryNavBarOptions);
                    }
                    // UserInterfaceOptions
                    using (var userInterfaceOptionsHandle = xmlBuilder.BeginObjectProperty(root, "UserInterfaceOptions"))
                    {
                        service.EncodeObject(userInterfaceOptionsHandle, withOptions.UserInterfaceOptions);
                    }
                    // SqlFormattingOptions
                    using (var sqlFormattingOptionsHandle = xmlBuilder.BeginObjectProperty(root, "SqlFormattingOptions"))
                    {
                        service.EncodeObject(sqlFormattingOptionsHandle, withOptions.SqlFormattingOptions);
                    }
                    // SqlGenerationOptions
                    using (var sqlGenerationOptionsHandle = xmlBuilder.BeginObjectProperty(root, "SqlGenerationOptions"))
                    {
                        service.EncodeObject(sqlGenerationOptionsHandle, withOptions.SqlGenerationOptions);
                    }
                }
            }
        }

        public static void DeserializeOptions(string xml, IDatabaseSchemaView dbView, ISupportOptions withOptions)
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
                service.DecodeObject(behaviorOptionsTree, withOptions.BehaviorOptions);
                behaviorOptionsTree.Close();
                adapter.Reader.Read();

                var dbViewOptionsTree = adapter.Reader.ReadSubtree();
                dbViewOptionsTree.Read();
                service.DecodeObject(dbViewOptionsTree, dbView.Options);
                dbViewOptionsTree.Close();
                adapter.Reader.Read();

                var designPaneOptionsTree = adapter.Reader.ReadSubtree();
                designPaneOptionsTree.Read();
                service.DecodeObject(designPaneOptionsTree, withOptions.DesignPaneOptions);
                designPaneOptionsTree.Close();
                adapter.Reader.Read();

                var visualOptionsTree = adapter.Reader.ReadSubtree();
                visualOptionsTree.Read();
                service.DecodeObject(visualOptionsTree, withOptions.VisualOptions);
                visualOptionsTree.Close();
                adapter.Reader.Read();

                var addObjectDialogOptionsTree = adapter.Reader.ReadSubtree();
                addObjectDialogOptionsTree.Read();
                service.DecodeObject(addObjectDialogOptionsTree, withOptions.AddObjectDialogOptions);
                addObjectDialogOptionsTree.Close();
                adapter.Reader.Read();

                var dataSourceOptionsTree = adapter.Reader.ReadSubtree();
                dataSourceOptionsTree.Read();
                service.DecodeObject(dataSourceOptionsTree, withOptions.DataSourceOptions);
                dataSourceOptionsTree.Close();
                adapter.Reader.Read();

                var metadataLoadingOptionsTree = adapter.Reader.ReadSubtree();
                metadataLoadingOptionsTree.Read();
                metadataService.DecodeMetadataLoadingOptions(metadataLoadingOptionsTree, withOptions.MetadataLoadingOptions);
                metadataLoadingOptionsTree.Close();
                adapter.Reader.Read();

                var metadataStructureOptionsTree = adapter.Reader.ReadSubtree();
                metadataStructureOptionsTree.Read();
                service.DecodeObject(metadataStructureOptionsTree, withOptions.MetadataStructureOptions);
                metadataStructureOptionsTree.Close();
                adapter.Reader.Read();

                var queryColumnListTree = adapter.Reader.ReadSubtree();
                queryColumnListTree.Read();
                service.DecodeObject(queryColumnListTree, withOptions.QueryColumnListOptions);
                queryColumnListTree.Close();
                adapter.Reader.Read();

                var queryNavBarTree = adapter.Reader.ReadSubtree();
                queryNavBarTree.Read();
                service.DecodeObject(queryNavBarTree, withOptions.QueryNavBarOptions);
                queryNavBarTree.Close();
                adapter.Reader.Read();

                var userInterfaceOptionsTree = adapter.Reader.ReadSubtree();
                userInterfaceOptionsTree.Read();
                service.DecodeObject(userInterfaceOptionsTree, withOptions.UserInterfaceOptions);
                userInterfaceOptionsTree.Close();
                adapter.Reader.Read();

                var sqlFormattingOptionsTree = adapter.Reader.ReadSubtree();
                sqlFormattingOptionsTree.Read();
                service.DecodeObject(sqlFormattingOptionsTree, withOptions.SqlFormattingOptions);
                sqlFormattingOptionsTree.Close();
                adapter.Reader.Read();

                var sqlGenerationOptionsTree = adapter.Reader.ReadSubtree();
                sqlGenerationOptionsTree.Read();
                service.DecodeObject(sqlGenerationOptionsTree, withOptions.SqlGenerationOptions);
                sqlGenerationOptionsTree.Close();
                adapter.Reader.Read();
            }
        }
    }
}
