//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2019 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.Core.PropertiesEditors;
using ActiveQueryBuilder.Core.Serialization;
using ActiveQueryBuilder.View;
using ActiveQueryBuilder.View.PropertiesEditors;
using ActiveQueryBuilder.View.WinForms.Images;
using ActiveQueryBuilder.View.WinForms.QueryView;
using Helpers = ActiveQueryBuilder.Core.Helpers;

namespace FullFeaturedMdiDemo
{
    public partial class EditConnectionForm : Form
    {
        private readonly ConnectionInfo _connection;
        private bool _isFilterPageInitialized;

        public EditConnectionForm()
        {
            InitializeComponent();
        }

        public EditConnectionForm(ConnectionInfo connection)
            : this()
        {
            pnlFilterInfo.InfoText = "1. Add unwanted objects to Exclude tab. Any other objects will be displayed.\r\n" +
                                     "2. Add the needed objects to Include tab. Only those objects will be displayed.";

            pnlFilterInfo.Tooltip =
                "By adding a namespace (database, schema, etc.) you instruct to include or exclude all objects from this namespace.\r\n\r\n" +
                "You can add the needed namespaces to the Include tab but exclude certain objects or nested namespaces by adding them to the Exclude tab at the same time.";

            lbMenu.SelectedIndex = 0;
            _connection = connection;
            tbConnectionName.Text = connection.Name;

            FillConnectionTypes();
            FillSyntaxTypes();

            cbConnectionType.SelectedItem = _connection.ConnectionDescriptor.GetDescription();
            UpdateConnectionPropertiesFrames();

            FillImageList();
        }

        private void FillImageList()
        {
            imageList.Images.Add("Server", Metadata.Server.Value);
            imageList.Images.Add("Database", Metadata.Database.Value);
            imageList.Images.Add("Schema", Metadata.Schema.Value);
            imageList.Images.Add("Package", Metadata.Package.Value);
            imageList.Images.Add("Table", Metadata.UserTable.Value);
            imageList.Images.Add("View", Metadata.UserView.Value);
            imageList.Images.Add("Procedure", Metadata.UserProcedure.Value);
            imageList.Images.Add("Synonym", Metadata.UserSynonym.Value);            
        }

        private void FillSyntaxTypes()
        {
            foreach (Type syntax in Helpers.SyntaxProviderList)
            {
                var instance = Activator.CreateInstance(syntax) as BaseSyntaxProvider;
                cbSyntax.Items.Add(instance.Description);
            }
        }

        private void FillConnectionTypes()
        {
            foreach (var name in Common.Helpers.ConnectionDescriptorNames)
            {
                cbConnectionType.Items.Add(name);
            }
        }

        private void tbConnectionName_TextChanged(object sender, EventArgs e)
        {
            _connection.Name = tbConnectionName.Text;
        }

        private void cbConnectionType_SelectedIndexChanged(object sender, EventArgs e)
        {            
            var descriptorType = GetSelectedDescriptorType();
            if (_connection.ConnectionDescriptor != null && _connection.ConnectionDescriptor.GetType() == descriptorType)
            {
                return;
            }
            
            _connection.ConnectionDescriptor = CreateConnectionDescriptor(descriptorType);

            if (_connection.ConnectionDescriptor == null)
            {
                LockUI();
                return;
            }
            else
                UnlockUI();

            _connection.Type = _connection.GetConnectionType(descriptorType);

            UpdateConnectionPropertiesFrames();
        }

        private void LockUI()
        {
            lbMenu.Enabled = false;
            btnOk.Enabled = false;

            RemoveConnectionPropertiesFrame();
            RemoveSyntaxFrame();
        }

        private void UnlockUI()
        {
            lbMenu.Enabled = true;
            btnOk.Enabled = true;
        }

        private void UpdateConnectionPropertiesFrames()
        {
            SetupSyntaxCombobox();
            RecreateConnectionFrame();
            RecreateSyntaxFrame();
            RecreateLoadingOptions();
            RecreateStructureOptions();
        }

        private void RecreateLoadingOptions()
        {
            RecreateProperties(pbMetadataLoading, _connection.ConnectionDescriptor.MetadataLoadingOptions);
        }

        private void RecreateStructureOptions()
        {
            RecreateProperties(pbStructureOptions, _connection.StructureOptions);
        }

        private void RecreateProperties(PropertiesBar propertiesBar, object properties)
        {
            propertiesBar.Controls.Clear();
            var container = PropertiesFactory.GetPropertiesContainer(properties);
            (propertiesBar as IPropertiesControl).SetProperties(container);
        }

        private void SetupSyntaxCombobox()
        {
            if (_connection.IsGenericConnection())
            {
                pnlTop.Height = cbSyntax.Bottom + 8;
                cbSyntax.SelectedItem = _connection.ConnectionDescriptor.SyntaxProvider.Description;
            }
            else
            {
                pnlTop.Height = cbConnectionType.Bottom + 8;
            }
        }

        private Type GetSelectedDescriptorType()
        {
            return Common.Helpers.ConnectionDescriptorList[cbConnectionType.SelectedIndex];
        }

        private BaseConnectionDescriptor CreateConnectionDescriptor(Type type)
        {
            try
            {
                return Activator.CreateInstance(type) as BaseConnectionDescriptor;
            }
            catch (Exception e)
            {
                var message = e.InnerException != null ? e.InnerException.Message : e.Message;
                MessageBox.Show(message + "\r\n \r\n" +
                                "To fix this error you may need to install the appropriate database client software or \r\n re-compile the project from sources and add the needed assemblies to the References section.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return null;
            }
        }

        private void RecreateConnectionFrame()
        {
            RemoveConnectionPropertiesFrame();
            ClearProperties(_connection.ConnectionDescriptor.MetadataProperties);
            var container = PropertiesFactory.GetPropertiesContainer(_connection.ConnectionDescriptor.MetadataProperties);
            (pbConnection as IPropertiesControl).SetProperties(container);
        }

        private void ClearProperties(ObjectProperties properties)
        {
            properties.GroupProperties.Clear();
            properties.PropertiesEditors.Clear();
        }

        private void RemoveConnectionPropertiesFrame()
        {
            pbConnection.Controls.Clear();
        }

        private void RecreateSyntaxFrame()
        {
            RemoveSyntaxFrame();
            var syntxProps = _connection.ConnectionDescriptor.SyntaxProperties;
            if (syntxProps == null)
            {
                pbSyntax.Height = 0;
                return;
            }

            ClearProperties(syntxProps);
            var container = PropertiesFactory.GetPropertiesContainer(syntxProps);
            (pbSyntax as IPropertiesControl).SetProperties(container);
            
            pbSyntax.Height = pbSyntax.Controls[0].Bottom + 5;
        }

        private void RemoveSyntaxFrame()
        {
            pbSyntax.Controls.Clear();
        }

        private void lbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lbMenu.SelectedIndex)
            {
                case 0:
                    tcProperties.SelectedTab = tpConnection;
                    break;
                case 1:
                    InitializeFilterPage();
                    break;
                case 2:
                    tcProperties.SelectedTab = tpMetadataLoading;
                    break;
                case 3:
                    tcProperties.SelectedTab = tpStructureOptions;
                    break;
            }
        }

        private void InitializeFilterPage()
        {
            if (!_isFilterPageInitialized)
            {
                Cursor = Cursors.WaitCursor;
                try
                {
                    databaseSchemaView1.SQLContext = _connection.ConnectionDescriptor.GetSqlContext();
                    ClearFilters(databaseSchemaView1.SQLContext.LoadingOptions);
                    databaseSchemaView1.InitializeDatabaseSchemaTree();
                    LoadFilters();
                    _isFilterPageInitialized = true;
                }
                catch
                {
                    _isFilterPageInitialized = false;
                }
                finally
                {
                    Cursor = Cursors.Default;
                }
            }            
            
            tcProperties.SelectedTab = tpFilter;
        }

        private void ClearFilters(MetadataLoadingOptions options)
        {
            options.ExcludeFilter.Objects.Clear();
            options.IncludeFilter.Objects.Clear();
            options.ExcludeFilter.Schemas.Clear();
            options.IncludeFilter.Schemas.Clear();
        }

        private void LoadFilters()
        {
            LoadIncludeFilters();
            LoadExcludeFilters();
            UpdateTabFiltersCaption();
        }

        private void LoadIncludeFilters()
        {
            var filter = _connection.ConnectionDescriptor.MetadataLoadingOptions.IncludeFilter;
            LoadFilterTo(filter, lvInclude);
        }

        private void LoadExcludeFilters()
        {
            var filter = _connection.ConnectionDescriptor.MetadataLoadingOptions.ExcludeFilter;
            LoadFilterTo(filter, lvExclude);
        }

        private void LoadFilterTo(MetadataSimpleFilter filter, ListView listBox)
        {
            foreach (var filterObject in filter.Objects)
            {
                var item = FindItemByName(GetNameForSearch(filterObject));
                var listItem = listBox.Items.Add(item.NameFull, GetImageKeyByItem(item));
                listItem.Tag = filterObject;
            }

            foreach (var filterSchema in filter.Schemas)
            {
                var item = FindItemByName(GetNameForSearch(filterSchema));
                var listItem = listBox.Items.Add(item.NameFull, GetImageKeyByItem(item));
                listItem.Tag = filterSchema;
            }
        }

        private string GetNameForSearch(string name)
        {
            return name.Replace(".%", "").Replace("%.", "");
        }

        private MetadataItem FindItemByName(string name)
        {
            return databaseSchemaView1.MetadataStructure.MetadataItem.FindItem<MetadataItem>(name);
        }

        private void btnAddFilter_Click(object sender, EventArgs e)
        {
            if (tcFilters.SelectedTab == tpInclude)
            {
                AddIncludeFilter(databaseSchemaView1.SelectedItems);
            }
            else if (tcFilters.SelectedTab == tpExclude)
            {
                AddExcludeFilter(databaseSchemaView1.SelectedItems);
            }
        }

        private void AddIncludeFilter(MetadataStructureItem[] items)
        {
            var filter = _connection.ConnectionDescriptor.MetadataLoadingOptions.IncludeFilter;
            foreach (var structureItem in items)
            {
                var metadataItem = structureItem.MetadataItem;
                if (metadataItem == null)
                {
                    continue;                    
                }

                var filtrationName = GetObjectNameForFilter(metadataItem);
                if (metadataItem.Type.IsNamespace())
                {                    
                    filter.Schemas.Add(filtrationName);                    
                }
                else if (metadataItem.Type.IsObject())
                {                 
                    filter.Objects.Add(filtrationName);                    
                }

                var listItem = lvInclude.Items.Add(metadataItem.NameFull, GetImageKeyByItem(metadataItem));
                listItem.Tag = filtrationName;
            }

            UpdateTabFiltersCaption();
        }

        private void AddExcludeFilter(MetadataStructureItem[] items)
        {
            var filter = _connection.ConnectionDescriptor.MetadataLoadingOptions.ExcludeFilter;
            foreach (var structureItem in items)
            {
                var metadataItem = structureItem.MetadataItem;
                if (metadataItem == null)
                {
                    continue;
                }

                var filtrationName = GetObjectNameForFilter(metadataItem);
                if (metadataItem.Type.IsNamespace())
                {
                    filter.Schemas.Add(filtrationName);                    
                }
                else if (metadataItem.Type.IsObject())
                {
                    filter.Objects.Add(filtrationName);
                }

                var listItem = lvExclude.Items.Add(metadataItem.NameFull, GetImageKeyByItem(metadataItem));
                listItem.Tag = filtrationName;
            }

            UpdateTabFiltersCaption();
        }

        private void UpdateTabFiltersCaption()
        {
            tpInclude.Text = "Include";
            if (lvInclude.Items.Count != 0)
                tpInclude.Text += string.Format(" ({0})", lvInclude.Items.Count);

            tpExclude.Text = "Exclude";
            if (lvExclude.Items.Count != 0)
                tpExclude.Text += string.Format(" ({0})", lvExclude.Items.Count);
        }

        private string GetObjectNameForFilter(MetadataItem item)
        {
            if (_connection.ConnectionDescriptor == null || _connection.ConnectionDescriptor.SyntaxProvider == null)
                return string.Empty;

            if (item.Type.IsObject())
                return item.NameFull;

            var syntax = _connection.ConnectionDescriptor.SyntaxProvider;
            var servers = syntax.IsSupportServers();
            var databases = syntax.IsSupportDatabases();
            var packages = syntax.IsSupportPackages();
            var schemas = syntax.IsSupportSchemas();

            var result = new StringBuilder();
            if (servers)
            {                
                result.Append(item.Server != null ? item.Server.Name : "%");
            }

            if (databases)
            {
                if (result.Length != 0)
                    result.Append(".");

                result.Append(item.Database != null ? item.Database.Name : "%");
            }

            if (packages)
            {
                if (result.Length != 0)
                    result.Append(".");

                result.Append(item.Package != null ? item.Package.Name : "%");
            }

            if (schemas)
            {
                if (result.Length != 0)
                    result.Append(".");

                result.Append(item.Schema != null ? item.Schema.Name : "%");
            }

            return result.ToString();
        }

        private string GetImageKeyByItem(MetadataItem item)
        {
            if (item == null)
            {
                return string.Empty;
            }

            switch (item.Type)
            {
                case MetadataType.Server:
                    return "Server";
                case MetadataType.Database:
                    return "Database";
                case MetadataType.Schema:
                    return "Schema";
                case MetadataType.Package:
                    return "Package";
                case MetadataType.Table:
                    return "Table";
                case MetadataType.View:
                    return "View";
                case MetadataType.Procedure:
                    return "Procedure";
                case MetadataType.Synonym:
                    return "Synonym";
                default:
                    return string.Empty;
            }
        }

        private void btnDeleteFilter_Click(object sender, EventArgs e)
        {
            if (tcFilters.SelectedTab == tpInclude)
            {
                foreach (ListViewItem selectedItem in lvInclude.SelectedItems)
                {
                    DeleteFilter(selectedItem);
                }
            }
            else if (tcFilters.SelectedTab == tpExclude)
            {
                foreach (ListViewItem selectedItem in lvExclude.SelectedItems)
                {
                    DeleteFilter(selectedItem);
                }                
            }
        }

        private void DeleteFilter(ListViewItem item)
        {
            MetadataSimpleFilter filter = null;
            if (tcFilters.SelectedTab == tpInclude)
            {
                filter = _connection.ConnectionDescriptor.MetadataLoadingOptions.IncludeFilter;
            }
            else if (tcFilters.SelectedTab == tpExclude)
            {
                filter = _connection.ConnectionDescriptor.MetadataLoadingOptions.ExcludeFilter;
            }

            if (filter != null)
            {
                filter.Objects.Remove(item.Tag as string);
                filter.Schemas.Remove(item.Tag as string);
            }

            if (tcFilters.SelectedTab == tpInclude)
            {
                lvInclude.Items.Remove(item);
            }
            else if (tcFilters.SelectedTab == tpExclude)
            {
                lvExclude.Items.Remove(item);
            }

            UpdateTabFiltersCaption();
        }

        private void lbInclude_DragDrop(object sender, DragEventArgs e)
        {
            DropItems(e, true);
        }

        private void DropItems(DragEventArgs e, bool toInclude)
        {
            var dragObject = e.Data.GetData(e.Data.GetFormats()[0]) as MetadataDragObject;
            if (dragObject != null)
            {
                if (toInclude)
                {
                    AddIncludeFilter(dragObject.MetadataStructureItems.ToArray());
                }
                else
                {
                    AddExcludeFilter(dragObject.MetadataStructureItems.ToArray());
                }
            }
        }

        private void lbInclude_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void lbExclude_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void lbExclude_DragDrop(object sender, DragEventArgs e)
        {
            DropItems(e, false);
        }

        private void databaseSchemaView1_ItemDoubleClick(object sender, MetadataStructureItem item)
        {
            btnAddFilter_Click(this, EventArgs.Empty);
        }

        private void cbSyntax_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_connection.IsGenericConnection())
            {
                return;
            }

            var syntaxType = GetSelectedSyntaxType();
            if (_connection.ConnectionDescriptor.SyntaxProvider.GetType() == syntaxType)
            {
                return;
            }

            _connection.ConnectionDescriptor.SyntaxProvider = CreateSyntaxProvider(syntaxType);
            _connection.SyntaxProviderName = syntaxType.ToString();

            RecreateSyntaxFrame();
        }

        private Type GetSelectedSyntaxType()
        {
            return Helpers.SyntaxProviderList[cbSyntax.SelectedIndex];
        }

        private BaseSyntaxProvider CreateSyntaxProvider(Type type)
        {
            return Activator.CreateInstance(type) as BaseSyntaxProvider;
        }

        private void lvInclude_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                btnDeleteFilter_Click(this, EventArgs.Empty);
        }

        private void lvExclude_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                btnDeleteFilter_Click(this, EventArgs.Empty);
        }
    }
}
