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
using System.Collections.Generic;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using Helpers = ActiveQueryBuilder.View.Helpers;

namespace MetadataEditorDemo.Common
{
    internal partial class MetadataFilterItemControl : UserControl
    {
        public event EventHandler OkClicked;
        public event EventHandler CancelClicked;

        private readonly MetadataFilter _filter;
        private readonly MetadataFilterItem _filterItem;
        private MetadataFilterItem _originalFilterItem;

        private List<string> _databaseList = new List<string>();
        private List<string> _schemaList = new List<string>();

        private bool _showServer = false;
        private bool _showDatabase = true;
        private bool _showSchema = true;
        private bool _showPackage = false;

        public event EventHandler ItemUpdated;

        private void DoItemUpdated()
        {
            if (ItemUpdated != null) ItemUpdated(this, EventArgs.Empty);
        }

        public MetadataFilterItem FilterItem
        {
            get { return _filterItem; }
            set
            {
                _originalFilterItem = value;
                _filterItem.Assign(value);
                UpdateControls();
            }
        }

        public List<string> DatabaseList
        {
            get { return _databaseList; }
            set
            {
                _databaseList = value;

                if (cmbDatabases != null && cmbDatabases.IsHandleCreated)
                {
                    cmbDatabases.TextChanged -= cmbDatabases_TextChanged;

                    cmbDatabases.Items.Clear();
                    cmbDatabases.Items.Add("");

                    if (_databaseList != null)
                    {
                        cmbDatabases.Items.AddRange(_databaseList.ToArray());
                    }

                    cmbDatabases.TextChanged += cmbDatabases_TextChanged;
                }
            }
        }

        public List<string> SchemaList
        {
            get { return _schemaList; }
            set
            {
                _schemaList = value;

                if (cmbSchemas != null && cmbSchemas.IsHandleCreated)
                {
                    cmbSchemas.TextChanged -= cmbSchemas_TextChanged;

                    string text = cmbSchemas.Text;

                    cmbSchemas.Items.Clear();
                    cmbSchemas.Items.Add("");

                    if (_schemaList != null)
                    {
                        cmbSchemas.Items.AddRange(_schemaList.ToArray());
                    }

                    cmbSchemas.Text = text;

                    cmbSchemas.TextChanged += cmbSchemas_TextChanged;
                }
            }
        }

        public bool ShowServer
        {
            get { return _showServer; }
            set
            {
                _showServer = value;

                lblServer.Visible = _showServer;
                tbServer.Visible = _showServer;
            }
        }

        public bool ShowDatabase
        {
            get { return _showDatabase; }
            set
            {
                _showDatabase = value;

                lblDatabase.Visible = _showDatabase;
                cmbDatabases.Visible = _showDatabase;
            }
        }

        public bool ShowSchema
        {
            get { return _showSchema; }
            set
            {
                _showSchema = value;

                lblSchema.Visible = _showSchema;
                cmbSchemas.Visible = _showSchema;
            }
        }

        public bool ShowPackage
        {
            get { return _showPackage; }
            set
            {
                _showPackage = value;

                lblPackage.Visible = _showPackage;
                tbPackage.Visible = _showPackage;
            }
        }

        private readonly CompositeDisposable _subscriptions = new CompositeDisposable();

        public MetadataFilterItemControl()
        {
            InitializeComponent();

            _filter = new MetadataFilter();
            _filterItem = new MetadataFilterItem(_filter);

            tbServer.TextChanged += tbServer_TextChanged;
            cmbDatabases.TextChanged += cmbDatabases_TextChanged;
            cmbSchemas.TextChanged += cmbSchemas_TextChanged;
            tbPackage.TextChanged += tbPackage_TextChanged;
            tbObject.TextChanged += tbObject_TextChanged;
            cbUser.CheckedChanged += cbUser_CheckedChanged;
            cbSystem.CheckedChanged += cbSystem_CheckedChanged;
            cbTable.CheckedChanged += cbTable_CheckedChanged;
            cbView.CheckedChanged += cbView_CheckedChanged;
            cbProcedure.CheckedChanged += cbProcedure_CheckedChanged;
            cbSynonym.CheckedChanged += cbSynonym_CheckedChanged;
            tbField.TextChanged += tbField_TextChanged;

            BindLocalization();
        }

        private void BindLocalization()
        {            
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.Metadata.Server.Subscribe(x => lblServer.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.Metadata.Database.Subscribe(x => lblDatabase.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.Metadata.Schema.Subscribe(x => lblSchema.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.Metadata.Package.Subscribe(x => lblPackage.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.Metadata.Fields.Subscribe(x => lblFields.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.Metadata.Object.Subscribe(x => lblObject.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.Metadata.UserObject.Subscribe(x => cbUser.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.Metadata.SystemObject.Subscribe(x => cbSystem.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.Metadata.Table.Subscribe(x => cbTable.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.Metadata.View.Subscribe(x => cbView.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.Metadata.Procedure.Subscribe(x => cbProcedure.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.Metadata.Synonym.Subscribe(x => cbSynonym.Text = x));

            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataEditor.ObjectType.Subscribe(x => lblObjectType.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataEditor.ApplyTo.Subscribe(x => lbApplyTo.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataEditor.FilterByNamespace.Subscribe(x => lbFilterByNamespace.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataEditor.FilterByObjects.Subscribe(x => lbFilterByObjects.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataEditor.FilterByFileds.Subscribe(x => lbFilterByFields.Text = x));

            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.Common.ButtonOk.Subscribe(x => btnOk.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.Common.ButtonCancel.Subscribe(x => btnCancel.Text = x));
        }        

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                tbServer.TextChanged -= tbServer_TextChanged;
                cmbDatabases.TextChanged -= cmbDatabases_TextChanged;
                cmbSchemas.TextChanged -= cmbSchemas_TextChanged;
                tbPackage.TextChanged -= tbPackage_TextChanged;
                tbObject.TextChanged -= tbObject_TextChanged;
                cbUser.CheckedChanged -= cbUser_CheckedChanged;
                cbSystem.CheckedChanged -= cbSystem_CheckedChanged;
                cbTable.CheckedChanged -= cbTable_CheckedChanged;
                cbView.CheckedChanged -= cbView_CheckedChanged;
                cbProcedure.CheckedChanged -= cbProcedure_CheckedChanged;
                cbSynonym.CheckedChanged -= cbSynonym_CheckedChanged;
                tbField.TextChanged -= tbField_TextChanged;

                _subscriptions.Dispose();
                components?.Dispose();
            }
            base.Dispose(disposing);
        }

        protected override void OnLoad(EventArgs e)
        {
            lblServer.Visible = _showServer;
            tbServer.Visible = _showServer;
            lblPackage.Visible = _showPackage;
            tbPackage.Visible = _showPackage;

            if (_databaseList != null)
            {
                cmbDatabases.Items.Add("");
                cmbDatabases.Items.AddRange(_databaseList.ToArray());
            }

            if (_schemaList != null)
            {
                cmbSchemas.Items.Add("");
                cmbSchemas.Items.AddRange(_schemaList.ToArray());
            }

            toolTip1.SetToolTip(this.cmbSchemas,
                Helpers.Localizer.GetString("strMetadataFilterSubstitutionHint", LocalizableConstantsUI.strMetadataFilterSubstitutionHint));
            toolTip1.SetToolTip(this.tbObject,
                Helpers.Localizer.GetString("strMetadataFilterSubstitutionHint", LocalizableConstantsUI.strMetadataFilterSubstitutionHint));
        }

        private string GetFilterText(string text)
        {
            return text == "%" ? "" : text;
        }

        private string SetFilterText(string text)
        {
            return String.IsNullOrEmpty(text) ? "%" : text;
        }

        private void UpdateControls()
        {
            tbServer.TextChanged -= tbServer_TextChanged;
            cmbDatabases.TextChanged -= cmbDatabases_TextChanged;
            cmbSchemas.TextChanged -= cmbSchemas_TextChanged;
            tbPackage.TextChanged -= tbPackage_TextChanged;
            tbObject.TextChanged -= tbObject_TextChanged;
            cbTable.CheckedChanged -= cbTable_CheckedChanged;
            cbView.CheckedChanged -= cbView_CheckedChanged;
            cbProcedure.CheckedChanged -= cbProcedure_CheckedChanged;
            cbSynonym.CheckedChanged -= cbSynonym_CheckedChanged;
            tbField.TextChanged -= tbField_TextChanged;            

            if (_filterItem == null)
            {
                tbServer.Text = "";
                tbServer.Enabled = false;

                cmbDatabases.Items.Clear();
                cmbDatabases.Enabled = false;

                cmbSchemas.Items.Clear();
                cmbSchemas.Enabled = false;

                tbPackage.Text = "";
                tbPackage.Enabled = false;

                tbObject.Text = "";
                tbObject.Enabled = false;

                cbUser.Checked = true;
                cbUser.Enabled = false;

                cbSystem.Checked = true;
                cbSystem.Enabled = false;

                cbTable.Checked = false;
                cbTable.Enabled = false;

                cbView.Checked = false;
                cbView.Enabled = false;

                cbProcedure.Checked = false;
                cbProcedure.Enabled = false;

                cbSynonym.Checked = false;
                cbSynonym.Enabled = false;
            }
            else
            {                
                tbServer.Text = GetFilterText(_filterItem.Server);
                tbServer.Enabled = true;

                cmbDatabases.Text = GetFilterText(_filterItem.Database);
                cmbDatabases.Enabled = true;

                cmbSchemas.Text = GetFilterText(_filterItem.Schema);
                cmbSchemas.Enabled = true;

                tbPackage.Text = GetFilterText(_filterItem.Package);
                tbPackage.Enabled = true;

                tbObject.Text = GetFilterText(_filterItem.Object);
                tbObject.Enabled = true;

                cbUser.Checked = _filterItem.FlagUser;
                cbUser.Enabled = true;

                cbSystem.Checked = _filterItem.FlagSystem;
                cbSystem.Enabled = true;

                cbTable.Checked = ((_filterItem.ObjectTypes & MetadataType.Table) == MetadataType.Table);
                cbTable.Enabled = true;

                cbView.Checked = ((_filterItem.ObjectTypes & MetadataType.View) == MetadataType.View);
                cbView.Enabled = true;

                cbProcedure.Checked = ((_filterItem.ObjectTypes & MetadataType.Procedure) == MetadataType.Procedure);
                cbProcedure.Enabled = true;

                cbSynonym.Checked = ((_filterItem.ObjectTypes & MetadataType.Synonym) == MetadataType.Synonym);
                cbSynonym.Enabled = true;

                tbField.Text = GetFilterText(_filterItem.Field);
                tbField.Enabled = true;
            }

            tbServer.TextChanged += tbServer_TextChanged;
            cmbDatabases.TextChanged += cmbDatabases_TextChanged;
            cmbSchemas.TextChanged += cmbSchemas_TextChanged;
            tbPackage.TextChanged += tbPackage_TextChanged;
            tbObject.TextChanged += tbObject_TextChanged;
            cbUser.CheckedChanged += cbUser_CheckedChanged;
            cbSystem.CheckedChanged += cbSystem_CheckedChanged;
            cbTable.CheckedChanged += cbTable_CheckedChanged;
            cbView.CheckedChanged += cbView_CheckedChanged;
            cbProcedure.CheckedChanged += cbProcedure_CheckedChanged;
            cbSynonym.CheckedChanged += cbSynonym_CheckedChanged;
            tbField.TextChanged += tbField_TextChanged;
        }

        private bool ValidateUserSystemFlags()
        {
            if (!cbSystem.Checked && !cbUser.Checked)
            {
                cbUser.CheckedChanged -= cbUser_CheckedChanged;
                cbSystem.CheckedChanged -= cbSystem_CheckedChanged;

                try
                {
                    cbSystem.Checked = true;
                    cbUser.Checked = true;
                    if (_filterItem != null)
                    {
                        _filterItem.FlagUser = true;
                        _filterItem.FlagSystem = true;
                        DoItemUpdated();
                    }
                }
                finally
                {
                    cbUser.CheckedChanged += cbUser_CheckedChanged;
                    cbSystem.CheckedChanged += cbSystem_CheckedChanged;
                }
                
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidateItemTypeFlags()
        {
            if (!cbProcedure.Checked && !cbSynonym.Checked && !cbView.Checked && !cbTable.Checked)
            {
                cbTable.CheckedChanged -= cbTable_CheckedChanged;
                cbView.CheckedChanged -= cbView_CheckedChanged;
                cbProcedure.CheckedChanged -= cbProcedure_CheckedChanged;
                cbSynonym.CheckedChanged -= cbSynonym_CheckedChanged;

                try
                {
                    cbTable.Checked = true;
                    cbView.Checked = true;
                    cbProcedure.Checked = true;
                    cbSynonym.Checked = true;

                    if (_filterItem != null)
                    {
                        _filterItem.ObjectTypes = MetadataType.Objects;
                        DoItemUpdated();
                    }
                }
                finally
                {
                    cbTable.CheckedChanged += cbTable_CheckedChanged;
                    cbView.CheckedChanged += cbView_CheckedChanged;
                    cbProcedure.CheckedChanged += cbProcedure_CheckedChanged;
                    cbSynonym.CheckedChanged += cbSynonym_CheckedChanged;
                }

                return false;
            }
            else
            {
                return true;
            }
        }

        private void tbServer_TextChanged(object sender, EventArgs e)
        {            
            if (_filterItem != null)
            {
                _filterItem.Server = SetFilterText(tbServer.Text);

                DoItemUpdated();
            }
        }

        private void cmbDatabases_TextChanged(object sender, EventArgs e)
        {
            if (_filterItem != null)
            {
                _filterItem.Database = SetFilterText(cmbDatabases.Text);

                DoItemUpdated();
            }
        }

        private void cmbSchemas_TextChanged(object sender, EventArgs e)
        {
            if (_filterItem != null)
            {
                _filterItem.Schema = SetFilterText(cmbSchemas.Text);

                DoItemUpdated();
            }
        }

        private void tbPackage_TextChanged(object sender, EventArgs e)
        {
            if (_filterItem != null)
            {
                _filterItem.Package = SetFilterText(tbPackage.Text);

                DoItemUpdated();
            }
        }

        private void tbObject_TextChanged(object sender, EventArgs e)
        {
            if (_filterItem != null)
            {
                _filterItem.Object = SetFilterText(tbObject.Text);

                DoItemUpdated();
            }
        }

        void cbUser_CheckedChanged(object sender, EventArgs e)
        {
            if (!ValidateUserSystemFlags())
            {
                return;
            }

            if (_filterItem != null)
            {
                _filterItem.FlagUser = cbUser.Checked;

                DoItemUpdated();
            }
        }

        void cbSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (!ValidateUserSystemFlags())
            {
                return;
            }

            if (_filterItem != null)
            {
                _filterItem.FlagSystem = cbSystem.Checked;

                DoItemUpdated();
            }
        }

        private void cbTable_CheckedChanged(object sender, EventArgs e)
        {
            if (!ValidateItemTypeFlags())
            {
                return;
            }

            if (_filterItem != null)
            {
                if (cbTable.Checked)
                {
                    _filterItem.ObjectTypes |= MetadataType.Table;
                }
                else
                {
                    _filterItem.ObjectTypes &= ~MetadataType.Table;
                }

                DoItemUpdated();
            }
        }

        private void cbView_CheckedChanged(object sender, EventArgs e)
        {
            if (!ValidateItemTypeFlags())
            {
                return;
            }

            if (_filterItem != null)
            {
                if (cbView.Checked)
                {
                    _filterItem.ObjectTypes |= MetadataType.View;
                }
                else
                {
                    _filterItem.ObjectTypes &= ~MetadataType.View;
                }

                DoItemUpdated();
            }
        }

        private void cbProcedure_CheckedChanged(object sender, EventArgs e)
        {
            if (!ValidateItemTypeFlags())
            {
                return;
            }

            if (_filterItem != null)
            {
                if (cbProcedure.Checked)
                {
                    _filterItem.ObjectTypes |= MetadataType.Procedure;
                }
                else
                {
                    _filterItem.ObjectTypes &= ~MetadataType.Procedure;
                }

                DoItemUpdated();
            }
        }

        private void cbSynonym_CheckedChanged(object sender, EventArgs e)
        {
            if (!ValidateItemTypeFlags())
            {
                return;
            }

            if (_filterItem != null)
            {
                if (cbSynonym.Checked)
                {
                    _filterItem.ObjectTypes |= MetadataType.Synonym;
                }
                else
                {
                    _filterItem.ObjectTypes &= ~MetadataType.Synonym;
                }

                DoItemUpdated();
            }
        }

        private void tbField_TextChanged(object sender, EventArgs e)
        {
            if (_filterItem != null)
            {
                _filterItem.Field = SetFilterText(tbField.Text);

                DoItemUpdated();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ApplyChanges();
            OkClicked?.Invoke(this, e);
        }

        public void ApplyChanges()
        {
            _originalFilterItem?.Assign(_filterItem);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelChanges();
            CancelClicked?.Invoke(this, e);
        }

        public void CancelChanges()
        {
            if (_originalFilterItem != null)
                _filterItem.Assign(_originalFilterItem);
        }
    }
}
