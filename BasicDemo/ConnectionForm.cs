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
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.Core.PropertiesEditors;
using ActiveQueryBuilder.Core.Serialization;
using ActiveQueryBuilder.View;
using ActiveQueryBuilder.View.PropertiesEditors;
using ActiveQueryBuilder.View.WinForms.Images;
using FirebirdSql.Data.FirebirdClient;
using Helpers = ActiveQueryBuilder.Core.Helpers;

namespace BasicDemo
{
    public partial class ConnectionForm : Form
    {
        private bool _isFilterPageInitialized;
        private BaseConnectionDescriptor _connection;

        public BaseConnectionDescriptor Connection
        {
            get { return _connection; }
        }

        public ConnectionForm()
        {
            InitializeComponent();
            _connection = new MSSQLConnectionDescriptor();
            
            lbMenu.SelectedIndex = 0;

            FillConnectionTypes();
            FillSyntaxTypes();

            cbConnectionType.SelectedItem = _connection.GetDescription();
            UpdateConnectionPropertiesFrames();
            cbLoadFromDefaultDatabase.Visible = _connection.SyntaxProvider.IsSupportDatabases();
            cbLoadFromDefaultDatabase.Checked =
                _connection.MetadataLoadingOptions.LoadDefaultDatabaseOnly;

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
            foreach (var name in Misc.ConnectionDescriptorNames)
            {
                cbConnectionType.Items.Add(name);
            }
        }

        private void cbConnectionType_SelectedIndexChanged(object sender, EventArgs e)
        {            
            var descriptorType = GetSelectedDescriptorType();
            if (_connection != null && _connection.GetType() == descriptorType)
            {
                return;
            }

            _connection = CreateConnectionDescriptor(descriptorType);

            if (_connection == null)
            {
                LockUI();
                return;
            }
            else
                UnlockUI();

            UpdateConnectionPropertiesFrames();
        }

        private void LockUI()
        {
            lbMenu.Enabled = false;
            btnOk.Enabled = false;
            cbLoadFromDefaultDatabase.Visible = false;

            RemoveConnectionPropertiesFrame();
            RemoveSyntaxFrame();
        }

        private void UnlockUI()
        {
            lbMenu.Enabled = true;
            btnOk.Enabled = true;
            cbLoadFromDefaultDatabase.Visible = true;
        }

        private void UpdateConnectionPropertiesFrames()
        {
            SetupSyntaxCombobox();
            RecreateConnectionFrame();
            RecreateSyntaxFrame();
        }

        private void SetupSyntaxCombobox()
        {
            if (IsGenericConnection())
            {
                pnlTop.Height = cbSyntax.Bottom + 8;
                cbSyntax.SelectedItem = _connection.SyntaxProvider.Description;
            }
            else
            {
                pnlTop.Height = cbConnectionType.Bottom + 8;
            }
        }

        private bool IsGenericConnection()
        {
            return _connection is ODBCConnectionDescriptor || _connection is OLEDBConnectionDescriptor;
        }

        private Type GetSelectedDescriptorType()
        {
            return Misc.ConnectionDescriptorList[cbConnectionType.SelectedIndex];
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
            ClearProperties(_connection.MetadataProperties);
            var container = PropertiesFactory.GetPropertiesContainer(_connection.MetadataProperties);
            (pbConnection as IPropertiesControl).SetProperties(container);
            cbLoadFromDefaultDatabase.Top = pbConnection.Controls[0].Bottom + 5;
        }

        private void ClearProperties(ObjectProperties properties)
        {
            properties.GroupProperties.Clear();
            properties.PropertiesEditors.Clear();
        }

        private void RemoveConnectionPropertiesFrame()
        {            
            var container = pbConnection.Controls.OfType<IPropertiesContainer>().FirstOrDefault() as Control;
            if (container != null)
            {
                pbConnection.Controls.Remove(container);
            }
        }

        private void RecreateSyntaxFrame()
        {
            RemoveSyntaxFrame();
            var syntxProps = _connection.SyntaxProperties;
            if (syntxProps == null)
            {
                pbSyntax.Height = 0;
                return;
            }

            ClearProperties(syntxProps);
            var container = PropertiesFactory.GetPropertiesContainer(syntxProps);
            (pbSyntax as IPropertiesControl).SetProperties(container);

            cbLoadFromDefaultDatabase.Visible = _connection.SyntaxProvider.IsSupportDatabases();
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
            }
        }

        private void InitializeFilterPage()
        {
            if (!_isFilterPageInitialized)
            {
                Cursor = Cursors.WaitCursor;
                try
                {
                    databaseSchemaView1.SQLContext = _connection.GetSqlContext();
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
        }

        private void LoadIncludeFilters()
        {
            var filter = _connection.MetadataLoadingOptions.IncludeFilter;
            LoadFilterTo(filter, lvInclude);
        }

        private void LoadExcludeFilters()
        {
            var filter = _connection.MetadataLoadingOptions.ExcludeFilter;
            LoadFilterTo(filter, lvExclude);
        }

        private void LoadFilterTo(MetadataSimpleFilter filter, ListView listBox)
        {
            foreach (var filterObject in filter.Objects)
            {
                var item = FindItemByName(filterObject);
                listBox.Items.Add(filterObject, filterObject, GetImageKeyByItem(item));
            }

            foreach (var filterSchema in filter.Schemas)
            {
                var item = FindItemByName(filterSchema);
                listBox.Items.Add(filterSchema, filterSchema, GetImageKeyByItem(item));
            }
        }

        private MetadataItem FindItemByName(string name)
        {
            return databaseSchemaView1.MetadataStructure.MetadataItem.FindItem<MetadataItem>(name);
        }

        private void cbLoadFromDefaultDatabase_CheckedChanged(object sender, EventArgs e)
        {
            _connection.MetadataLoadingOptions.LoadDefaultDatabaseOnly =
                cbLoadFromDefaultDatabase.Checked;            
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
            var filter = _connection.MetadataLoadingOptions.IncludeFilter;
            foreach (var structureItem in items)
            {
                var metadataItem = structureItem.MetadataItem;
                if (metadataItem == null)
                {
                    continue;                    
                }

                if (metadataItem.Type.IsNamespace())
                {
                    filter.Schemas.Add(metadataItem.NameFull);
                    lvInclude.Items.Add(metadataItem.NameFull, metadataItem.NameFull, GetImageKeyByItem(metadataItem));
                }
                else if (metadataItem.Type.IsObject())
                {
                    filter.Objects.Add(metadataItem.NameFull);
                    lvInclude.Items.Add(metadataItem.NameFull, metadataItem.NameFull, GetImageKeyByItem(metadataItem));
                }
            }
        }

        private void AddExcludeFilter(MetadataStructureItem[] items)
        {
            var filter = _connection.MetadataLoadingOptions.ExcludeFilter;
            foreach (var structureItem in items)
            {
                var metadataItem = structureItem.MetadataItem;
                if (metadataItem == null)
                {
                    continue;
                }

                if (metadataItem.Type.IsNamespace())
                {
                    filter.Schemas.Add(metadataItem.NameFull);
                    lvExclude.Items.Add(metadataItem.NameFull, GetImageKeyByItem(metadataItem));
                }
                else if (metadataItem.Type.IsObject())
                {
                    filter.Objects.Add(metadataItem.NameFull);
                    lvExclude.Items.Add(metadataItem.NameFull, GetImageKeyByItem(metadataItem));
                }
            }
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
                    DeleteFilter(selectedItem.Text);
                }
            }
            else if (tcFilters.SelectedTab == tpExclude)
            {
                foreach (ListViewItem selectedItem in lvExclude.SelectedItems)
                {
                    DeleteFilter(selectedItem.Text);
                }                
            }
        }

        private void DeleteFilter(string itemName)
        {
            MetadataSimpleFilter filter = null;
            if (tcFilters.SelectedTab == tpInclude)
            {
                filter = _connection.MetadataLoadingOptions.IncludeFilter;
            }
            else if (tcFilters.SelectedTab == tpExclude)
            {
                filter = _connection.MetadataLoadingOptions.ExcludeFilter;
            }

            if (filter != null)
            {
                filter.Objects.Remove(itemName);
                filter.Schemas.Remove(itemName);
            }

            if (tcFilters.SelectedTab == tpInclude)
            {
                var items = lvInclude.Items.Find(itemName, false);
                if (items.Length != 0)                
                {
                    lvInclude.Items.Remove(items[0]);
                }                
            }
            else if (tcFilters.SelectedTab == tpExclude)
            {
                var items = lvExclude.Items.Find(itemName, false);
                if (items.Length != 0)
                {
                    lvExclude.Items.Remove(items[0]);
                }
            }
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
            if (!IsGenericConnection())
            {
                return;
            }

            var syntaxType = GetSelectedSyntaxType();
            if (_connection.SyntaxProvider.GetType() == syntaxType)
            {
                return;
            }

            _connection.SyntaxProvider = CreateSyntaxProvider(syntaxType);

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
    }
}
