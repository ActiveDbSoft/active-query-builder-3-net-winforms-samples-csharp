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
using System.Collections.Generic;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.Core.Commands;
using ActiveQueryBuilder.View.WinForms;
using ActiveQueryBuilder.View.WinForms.Commands;
using Helpers = ActiveQueryBuilder.View.Helpers;
using MetadataEditorControl = MetadataEditorDemo.Common.MetadataEditorControl;

namespace MetadataEditorDemo
{
    internal partial class MetadataEditor : Form
    {
        private readonly SQLContext _originalContext;
        private readonly SQLContext _sqlContext;

        private MetadataEditorOptions _options = 0;
        private int _structurePaneWidth = -1;

        private readonly CompositeDisposable _subscriptions = new CompositeDisposable();

        private Command _importContainerCommand;
        private Command _exportContainerCommand;
        private Command _importStructureCommand;
        private Command _exportStructureCommand;

        private Command _previewCommand;

        private Command _stopLoadingCommand;

        public MetadataEditor()
        {
            InitializeComponent();

            CreateAndBindCommands();                        

            foreach (Type type in ActiveQueryBuilder.Core.Helpers.SyntaxProviderList)
            {
                if (type == typeof(AutoSyntaxProvider))
                {
                    continue;                    
                }

                var syntax = Activator.CreateInstance(type) as BaseSyntaxProvider;
                if (syntax != null)
                {
                    cbSyntaxProvider.Items.Add(syntax);
                }                
            }

            metadataEditorControl.OpenContainerLoadFormIfNotConnected = true;
            metadataEditorControl.LoadStart += LoadStart;
            metadataEditorControl.LoadFinish += LoadFinish;
            metadataEditorControl.LoadStep += LoadStep;

            cbSyntaxProvider.SelectedIndexChanged += CbSyntaxProvider_SelectedIndexChanged;
            tsmiLoadFromDatabase.Click += loadFromDatabaseToolStripMenuItem_Click;

            _subscriptions.Add(ActiveQueryBuilder.View.Helpers.Localizer.Subscribe(LocalizerOnLanguageChanged));

            Text = "Metadata Editor - Active Query Builder 3 for .NET";
            AddAboutMenuItem();
            Icon = Properties.Resources.App;

            UpdateLocalization();

            _originalContext = new SQLContext() { SyntaxProvider = new MSSQLSyntaxProvider() };
            _originalContext.MetadataContainer.LoadingOptions.OfflineMode = true;
            _originalContext.MetadataContainer.ImportFromXML("Northwind.xml");
            _sqlContext = new SQLContext();
            _sqlContext.Assign(_originalContext);

            if (_sqlContext.SyntaxProvider == null)
            {
                _sqlContext.SyntaxProvider = new GenericSyntaxProvider();
            }

            _sqlContext.SyntaxProviderChanged += SqlContext_SyntaxProviderChanged;

            foreach (var item in cbSyntaxProvider.Items)
            {
                if (item.GetType() == _sqlContext.SyntaxProvider.GetType())
                {
                    cbSyntaxProvider.SelectedIndexChanged -= CbSyntaxProvider_SelectedIndexChanged;
                    try
                    {
                        cbSyntaxProvider.SelectedItem = item;
                        break;
                    }
                    finally
                    {
                        cbSyntaxProvider.SelectedIndexChanged += CbSyntaxProvider_SelectedIndexChanged;
                    }
                }
            }

            metadataEditorControl.Init(_sqlContext);
        }

        private void LocalizerOnLanguageChanged(string newLang)
        {
            UpdateLocalization();
        }

        private void UpdateLocalization()
        {

            tsmiLoadFromDatabase.Text = Helpers.Localizer.GetString("strLoadFromDatabase", LocalizableConstantsInternal.strLoadFromDatabase);
            containerToolStripMenuItem.Text = Helpers.Localizer.GetString("strMetadataContainer", LocalizableConstantsInternal.strMetadataContainer);
            structureToolStripMenuItem.Text = Helpers.Localizer.GetString("strMetadataStructure", LocalizableConstantsInternal.strMetadataStructure);
            toolStripLabel.Text = Helpers.Localizer.GetString("strSyntaxProvider", LocalizableConstantsInternal.strSyntaxProvider);

            if (_aboutMenuItem != null)
                _aboutMenuItem.Text = Helpers.Localizer.GetString("strAboutShort", LocalizableConstantsUI.strAboutShort);
        }

        private ToolStripMenuItem _aboutMenuItem;
        private void AddAboutMenuItem()
        {
            _aboutMenuItem = new ToolStripMenuItem(Helpers.Localizer.GetString("strAboutShort", LocalizableConstantsUI.strAboutShort));
            _aboutMenuItem.Click += AboutOnClick;
            menuStrip1.Items.Add(_aboutMenuItem);
        }

        private void AboutOnClick(object sender, EventArgs e)
        {
            QueryBuilder.ShowAboutDialog();
        }

        private void CreateAndBindCommands()
        {
            _importContainerCommand = new Command(btnImportMetadataFromXml_Click);
            _exportContainerCommand = new Command(btnExportMetadataToXml_Click);
            _importStructureCommand = new Command(btnImportStructureFromXml_Click);
            _exportStructureCommand = new Command(btnExportStructureToXml_Click);

            _previewCommand = new Command(BtnPreview_Click);
            _stopLoadingCommand = new Command(metadataEditorControl.StopLoading);

            _subscriptions.Add(CommandBinder.Bind(tsmiExportContainer, _exportContainerCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.ExportContainer, x => tsmiExportContainer.Enabled = x));
            _subscriptions.Add(CommandBinder.Bind(tsmiImportContainer, _importContainerCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.ImportContainer, x => tsmiImportContainer.Enabled = x));
            _subscriptions.Add(CommandBinder.Bind(tsmiExportStructure, _exportStructureCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.ExportStructure, x => tsmiExportStructure.Enabled = x));
            _subscriptions.Add(CommandBinder.Bind(tsmiImportStructure, _importStructureCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.ImportStructure, x => tsmiImportStructure.Enabled = x));

            _subscriptions.Add(CommandBinder.Bind(btnPreview, _previewCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.Preview, x => btnPreview.Enabled = x));
            _subscriptions.Add(CommandBinder.Bind(btnStop, _stopLoadingCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.StopLoading, x => btnStop.Enabled = x));
        }

        private void CbSyntaxProvider_SelectedIndexChanged(object sender, EventArgs eventArgs)
        {
            _sqlContext.SyntaxProvider = cbSyntaxProvider.SelectedItem as BaseSyntaxProvider;
        }

        

        private void SqlContext_SyntaxProviderChanged(object sender, EventArgs e)
        {
            BaseSyntaxProvider currentSyntax = _sqlContext.SyntaxProvider;
            if (currentSyntax is AutoSyntaxProvider)
                currentSyntax = ((AutoSyntaxProvider)currentSyntax).DetectedSyntaxProvider;

            if (currentSyntax != null)
            {
                for (int i = 0; i < cbSyntaxProvider.Items.Count; i++)
                {
                    BaseSyntaxProvider sp = (BaseSyntaxProvider)cbSyntaxProvider.Items[i];

                    if (sp.GetType() == currentSyntax.GetType())
                    {
                        cbSyntaxProvider.SelectedIndex = i;
                    }
                }
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_sqlContext != null)
                    _sqlContext.SyntaxProviderChanged -= SqlContext_SyntaxProviderChanged;

                metadataEditorControl.LoadStart -= LoadStart;
                metadataEditorControl.LoadFinish -= LoadFinish;
                metadataEditorControl.LoadStep -= LoadStep;
                cbSyntaxProvider.SelectedIndexChanged -= CbSyntaxProvider_SelectedIndexChanged;
                tsmiLoadFromDatabase.Click -= loadFromDatabaseToolStripMenuItem_Click;

                _subscriptions.Dispose();
                components?.Dispose();
            }

            base.Dispose(disposing);
        }

        private bool IsStructureTreeEnabled()
        {
            return (_options & MetadataEditorOptions.DisableStructurePane) == 0;
        }

        public bool StructureTreeVisible
        {
            get { return metadataEditorControl.StructureTreeVisible; }
            set
            {
                if (value == metadataEditorControl.StructureTreeVisible)
                {
                    return;
                }

                if (value && !IsStructureTreeEnabled())
                {
                    return;
                }

                if (!value)
                {
                    _structurePaneWidth = metadataEditorControl.splitContainerInner.SplitterDistance;
                }

                metadataEditorControl.StructureTreeVisible = value;

                if (!value)
                {
                    Width -= _structurePaneWidth;
                }
                else if (_structurePaneWidth != -1)
                {
                    Width += _structurePaneWidth;
                }
            }
        }

        public MetadataEditorOptions Options
        {
            get { return _options; }
            set
            {
                _options = value;

                if (!IsStructureTreeEnabled()
                    && metadataEditorControl.splitContainerInner.Panel1Collapsed == false)
                {
                    StructureTreeVisible = false;
                    structureToolStripMenuItem.Visible = false;
                }
                else if (IsStructureTreeEnabled()
                         && metadataEditorControl.splitContainerInner.Panel1Collapsed == true)
                {
                    StructureTreeVisible = true;
                    structureToolStripMenuItem.Visible = true;
                }

                metadataEditorControl.tsbMetadataLoadAll.Visible = ((value & MetadataEditorOptions.DisableLoadDatabaseButton) != MetadataEditorOptions.DisableLoadDatabaseButton);
                metadataEditorControl.HideVirtualObjects = (value & MetadataEditorOptions.DisableVirtualObjects) ==
                                                           MetadataEditorOptions.DisableVirtualObjects;
            }
        }

        private void btnOK_Click()
        {
            var errorList = metadataEditorControl.ValidateBeforeApply();
            if (errorList.Count == 0)
            {
                ApplyChanges();
                DialogResult = DialogResult.OK;
                return;
            }

            var form = new ErrorListForm("Warning", Helpers.Localizer.GetString("strErrorsFound", LocalizableConstantsInternal.strErrorsFound), errorList, true);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                ApplyChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private void ApplyChanges()
        {
            var groupFields = _originalContext.MetadataStructure.Options.GroupFieldsByTypes;
            _originalContext.Assign(_sqlContext);
            _originalContext.MetadataStructure.Options.GroupFieldsByTypes = groupFields;
            _originalContext.MetadataStructure.Refresh();
        }

        private void LoadStart(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            lblProgress.Visible = true;
            btnStop.Text = string.Empty;
            btnStop.Visible = true;
            btnStop.Focus();

            progressBar1.Value = 0;

            Application.DoEvents();
        }

        private void LoadStep(object sender, EventArgs e)
        {
            progressBar1.PerformStep();

            if (progressBar1.Value >= progressBar1.Maximum)
            {
                progressBar1.Value = 0;
            }

            Application.DoEvents();
        }

        private void LoadFinish(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
            lblProgress.Visible = false;
            btnStop.Visible = false;
            ShowStatusMessage(ActiveQueryBuilder.Core.Localization.MetadataEditor.LoadCompleted.Value);
        }

        private void ShowStatusMessage(string message)
        {
            lblStatus.Text = message;
            lblStatus.Visible = true;

            Timer t = new Timer();
            t.Interval = 3000;
            t.Tick += t_Tick;
            t.Start();
        }

        void t_Tick(object sender, EventArgs e)
        {
            lblStatus.Visible = false;
            ((Timer)sender).Stop();
            ((Timer)sender).Tick -= t_Tick;
            ((Timer)sender).Dispose();
        }

        private void btnCancel_Click()
        {
            if (metadataEditorControl.IsChanged)
            {
                var result = MessageBox.Show(Helpers.Localizer.GetString("strAllChangesWillLost", LocalizableConstantsInternal.strAllChangesWillLost), Helpers.Localizer.GetString("strWarning", LocalizableConstantsUI.strWarning), MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void loadFromDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metadataEditorControl.ShowContainerLoadForm();
        }

        private void btnExportMetadataToXml_Click()
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Title = Helpers.Localizer.GetString("strContainerExportDescr", LocalizableConstantsInternal.strContainerExportDescr);
                saveDialog.Filter = @"XML files (*.xml)|*.xml|All files (*.*)|*.*";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    _sqlContext.MetadataContainer.ExportToXML(saveDialog.FileName);
                }
            }
        }

        private void btnImportMetadataFromXml_Click()
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Title = Helpers.Localizer.GetString("strContainerExportDescr", LocalizableConstantsInternal.strContainerImportDescr);
                openDialog.Filter = @"XML files (*.xml)|*.xml|All files (*.*)|*.*";

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    var errorList = new List<string>();
                    var log = new MetadataEditorControl.ListLog(errorList);
                    _sqlContext.MetadataContainer.SQLContext.Logger.Log = log;
                    _sqlContext.MetadataContainer.ImportFromXML(openDialog.FileName);

                    if (errorList.Count > 1)
                    {
                        var errorForm = new ErrorListForm("Warning", Helpers.Localizer.GetString("strErrorWhileImport", LocalizableConstantsInternal.strErrorWhileImport) + ":", errorList);
                        errorForm.ShowDialog();
                    }

                    metadataEditorControl.RefreshContainerTree();
                    metadataEditorControl.IsChanged = false;
                }
            }
        }

        private void BtnPreview_Click()
        {
            var form = new MetadataTreePreviewForm(_sqlContext);
            form.ShowDialog();
        }

        private void btnExportStructureToXml_Click()
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Title = Helpers.Localizer.GetString("strStructureExportDescr", LocalizableConstantsInternal.strStructureExportDescr);
                saveDialog.Filter = @"XML files (*.xml)|*.xml|All files (*.*)|*.*";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    _sqlContext.MetadataStructure.ExportToXML(saveDialog.FileName);
                }
            }
        }

        private void btnImportStructureFromXml_Click()
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Title = Helpers.Localizer.GetString("strStructureImportDescr", LocalizableConstantsInternal.strStructureImportDescr);
                openDialog.Filter = @"XML files (*.xml)|*.xml|All files (*.*)|*.*";

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    _sqlContext.MetadataStructure.ImportFromXML(openDialog.FileName);
                    _sqlContext.MetadataStructure.Refresh();

                    metadataEditorControl.IsChanged = false;
                }
            }
        }
    }
}
