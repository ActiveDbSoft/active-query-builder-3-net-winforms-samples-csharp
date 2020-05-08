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
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.Core.PropertiesEditors;
using ActiveQueryBuilder.View;
using ActiveQueryBuilder.View.PropertiesEditors;
using ActiveQueryBuilder.View.WinForms.QueryView;
using MetadataEditorDemo.Common.LoadingWizardPages;
using Helpers = ActiveQueryBuilder.View.Helpers;

namespace MetadataEditorDemo.Common
{
    delegate void ShowProc();
	delegate void CheckProc();
	delegate void PrepareProc();
    public partial class MetadataContainerLoadForm : Form, IMetadataContainerLoadForm

    {
        private readonly List<WizardPageInfo> _pages;

		private int _currentPage;
	    private BaseConnectionDescriptor _connection;
		private UserControl _usedConnectionProps;
	    private MetadataProviderObjectProperties _metadataProperties;
		private MetadataSelection<MetadataNamespace> _databases;

	    private readonly CompositeDisposable _subscriptions = new CompositeDisposable();

        private readonly SQLContext _temporarySQLContext;

        private readonly WelcomeWizardPage _wizardPageWelcome;
	    private readonly ConnectionTypeWizardPage _wizardPageConnectionType;
		private readonly MetadataOptsWizardPage _wizardPageMetadataOpts;
		private readonly LoadOptsWizardPage _wizardPageLoadOpts;
		private readonly FilterWizardPage _wizardPageFilter;
		private readonly LoadingWizardPage _wizardPageLoading;

        private readonly BaseConnectionDescriptor _initialConnection;
        private int _connectionIndex = -1;

        public bool LoadFields { get; set; }

        public BaseConnectionDescriptor Connection => _connection;

        public new bool ShowDialog()
        {
            return base.ShowDialog() != DialogResult.Cancel;
        }

        public string DefaultDatabase { get; private set; }

        public MetadataContainer EditedMetadataContainer { get; }
        public MetadataContainer TemporaryMetadataContainer { get; }

        public MetadataContainerLoadForm(MetadataContainer metadataContainer, BaseConnectionDescriptor connection = null)
		{
			Debug.Assert(metadataContainer != null);

			_pages = new List<WizardPageInfo>();

			// store reference to edited object
			EditedMetadataContainer = metadataContainer;

		    _initialConnection = connection;
            _connection = connection;

            // create new SQLContext for loading
            _temporarySQLContext = new SQLContext();
		    _temporarySQLContext.Assign(EditedMetadataContainer.SQLContext);

			// create temporary MetadataContainer
			TemporaryMetadataContainer = new MetadataContainer(_temporarySQLContext);
		    _temporarySQLContext.MetadataContainer = TemporaryMetadataContainer;

			TemporaryMetadataContainer.Assign(EditedMetadataContainer);
			TemporaryMetadataContainer.LoadingOptions = new MetadataLoadingOptions();
			TemporaryMetadataContainer.LoadingOptions.Assign(EditedMetadataContainer.LoadingOptions);

			InitializeComponent();

			// set up pages

		    _wizardPageWelcome = new WelcomeWizardPage
		    {
		        Dock = DockStyle.Fill,
		        Visible = false
		    };
		    Controls.Add(_wizardPageWelcome);

		    _wizardPageConnectionType = new ConnectionTypeWizardPage
		    {
		        Dock = DockStyle.Fill,
		        Visible = false
		    };
		    Controls.Add(_wizardPageConnectionType);

		    _wizardPageMetadataOpts = new MetadataOptsWizardPage
		    {
		        Dock = DockStyle.Fill,
		        Visible = false
		    };
		    Controls.Add(_wizardPageMetadataOpts);

		    _wizardPageLoadOpts = new LoadOptsWizardPage
		    {
		        Dock = DockStyle.Fill,
		        Visible = false
		    };
		    Controls.Add(_wizardPageLoadOpts);

		    _wizardPageFilter = new FilterWizardPage
		    {
		        Dock = DockStyle.Fill,
		        Visible = false
		    };
		    Controls.Add(_wizardPageFilter);

		    _wizardPageLoading = new LoadingWizardPage
		    {
		        Dock = DockStyle.Fill,
		        Visible = false
		    };
		    Controls.Add(_wizardPageLoading);

			_pages.Add(new WizardPageInfo(ShowWelcome));
		    _pages.Add(new WizardPageInfo(ShowConnection, CheckConnectionSelected));
			_pages.Add(new WizardPageInfo(ShowMetadataOpts, CheckShowMetadataOpts, true, BeforeMetadataOpts));
			_pages.Add(new WizardPageInfo(ShowLoadOpts, CheckLoadOpts, (_temporarySQLContext.SyntaxProvider != null && _temporarySQLContext.SyntaxProvider.IsSupportDatabases()), BeforeLoadOpts));
			_pages.Add(new WizardPageInfo(ShowFilter, CheckFilter));	
			_pages.Add(new WizardPageInfo(ShowLoading));
			
			_currentPage = 0;

			_pages[_currentPage].showProc();

			_wizardPageMetadataOpts.bConnectionTest.Click += buttonConnectionTest_Click;
            _wizardPageConnectionType.cbConnectionType.SelectedIndexChanged += cbConnectionType_SelectedIndexChanged;
            _wizardPageConnectionType.cbSyntax.SelectedIndexChanged += cbSyntax_SelectedIndexChanged;
            
			bBack.Click += buttonBack_Click;
			bNext.Click += buttonNext_Click;

            Load += MetadataContainerLoadForm_Load;
		}

	    private void ReplaceSyntaxEditControl(UserControl control)
	    {
	        if (control == null)
	        {
	            _wizardPageConnectionType.panelSyntaxOpts.Controls.Clear();
	            return;
	        }

	        _wizardPageConnectionType.panelSyntaxOpts.Controls.Clear();
	        control.Dock = DockStyle.Fill;
	        _wizardPageConnectionType.panelSyntaxOpts.Controls.Add(control);
	    }

	    private void cbSyntax_SelectedIndexChanged(object sender, EventArgs eventArgs)
	    {
	        if (_connection != null)
	        {
	            _connection.SyntaxProvider = _wizardPageConnectionType.cbSyntax.SelectedItem as BaseSyntaxProvider;
	            var syntaxEditControl = CreateSyntaxEditControl(_connection);
	            ReplaceSyntaxEditControl(syntaxEditControl);
	        }
	    }        

        private void cbConnectionType_SelectedIndexChanged(object sender, EventArgs eventArgs)
	    {
	        SetShown(ShowLoadOpts, false);
	        SetShown(ShowMetadataOpts, false);

	        var connectionCombo = _wizardPageConnectionType.cbConnectionType;
	        if (connectionCombo.SelectedIndex != -1)
	        {
	            var connectionName = connectionCombo.SelectedItem as string;
	            if (_initialConnection != null && connectionName == _initialConnection.GetDescription())
	            {
	                _connection = _initialConnection;
                }
	            else
	            {
	                var type = ActiveQueryBuilder.Core.Helpers.ConnectionDescriptorList[connectionCombo.SelectedIndex];
	                try
	                {
	                    _connection = Activator.CreateInstance(type) as BaseConnectionDescriptor;
	                }
	                catch (Exception e)
	                {
	                    var message = GetMostInnerException(e).Message;
	                    MessageBox.Show(message + "\r\n \r\n" +
	                                    "To fix this error you may need to install the appropriate database client software or re-compile the project from sources and add the needed assemblies to the References section.",
	                        "Error",
	                        MessageBoxButtons.OK,
	                        MessageBoxIcon.Error);

	                    connectionCombo.SelectedIndex = _connectionIndex;
                        return;                        
	                }
	            }

	            _wizardPageConnectionType.SyntaxVisible = _connection.IsGenericSyntax();
                SelectSyntax();
            }

	        _connectionIndex = connectionCombo.SelectedIndex;
	    }

        private Exception GetMostInnerException(Exception exception)
        {
            var e = exception;
            while (e.InnerException != null)
                e = e.InnerException;

            return e;
        }

        private void SelectSyntax()
        {
            if (_connection == null || _connection.SyntaxProvider == null)
            {
                return;
            }

            foreach (var item in _wizardPageConnectionType.cbSyntax.Items)
            {
                if (item.GetType() == _connection.SyntaxProvider.GetType())
                {
                    _wizardPageConnectionType.cbSyntax.SelectedItem = item;
                    return;
                }
            }
        }

        private void MetadataContainerLoadForm_Load(object sender, EventArgs e)
        {
            Load -= MetadataContainerLoadForm_Load;

            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataContainerLoadForm.LoadMetadataWizardCaption.Subscribe(x => Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.Common.ButtonCancel.Subscribe(x => bCancel.Text = x));

            bBack.Text = "< " + ActiveQueryBuilder.Core.Localization.Common.ButtonBack.Value;
            bNext.Text = ActiveQueryBuilder.Core.Localization.Common.ButtonNext.Value + " >";
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _subscriptions.Dispose();

                _wizardPageMetadataOpts.bConnectionTest.Click -= buttonConnectionTest_Click;
                _wizardPageConnectionType.cbConnectionType.SelectedIndexChanged -= cbConnectionType_SelectedIndexChanged;
                _wizardPageConnectionType.cbSyntax.SelectedIndexChanged -= cbSyntax_SelectedIndexChanged;
                bBack.Click -= buttonBack_Click;
                bNext.Click -= buttonNext_Click;

                components?.Dispose();
            }

            base.Dispose(disposing);
        }


		private void LoadDatabaseList()
		{
			DefaultDatabase = null;
			_databases = null;

            if (_connection.MetadataProvider != null && _connection.SyntaxProvider.IsSupportDatabases())
			{
			    _temporarySQLContext.MetadataProvider = _connection.MetadataProvider;
			    _temporarySQLContext.SyntaxProvider = _connection.SyntaxProvider;

                MetadataLoadingOptions oldOptions = new MetadataLoadingOptions();
				oldOptions.Assign(TemporaryMetadataContainer.LoadingOptions);

				MetadataLoadingOptions tempOptions = new MetadataLoadingOptions();
				tempOptions.LoadDefaultDatabaseOnly = false;
				tempOptions.LoadSystemObjects = true;

				try
				{
					TemporaryMetadataContainer.LoadingOptions = tempOptions;
					MetadataList list = new MetadataList(TemporaryMetadataContainer);
					list.Load(MetadataType.Database, false);
					_databases = list.Databases;
				}
				finally
				{
					TemporaryMetadataContainer.LoadingOptions = oldOptions;
					tempOptions.Dispose();
				}
			}

			_wizardPageLoadOpts.checklistDatabases.Items.Clear();

            if (_databases == null) return;

            foreach (var database in _databases)
            {
                if (database.Default)
                    DefaultDatabase = database.Name;

                _wizardPageLoadOpts.checklistDatabases.Items.Add(new DatabaseObjectForListbox(database.Name, database.Default), database.Default);
            }
        }

		private void SetActivePage(UserControl page)
		{
			_wizardPageWelcome.Visible = (page is WelcomeWizardPage);
		    _wizardPageConnectionType.Visible = (page is ConnectionTypeWizardPage);
			_wizardPageMetadataOpts.Visible = (page is MetadataOptsWizardPage);
			_wizardPageLoadOpts.Visible = (page is LoadOptsWizardPage);
			_wizardPageFilter.Visible = (page is FilterWizardPage);
			_wizardPageLoading.Visible = (page is LoadingWizardPage);
			panelBottom.SendToBack();
		}

		private void ShowWelcome()
		{
			SetActivePage(_wizardPageWelcome);
            var check = TemporaryMetadataContainer.Items.IsLoaded(MetadataType.Namespaces) 
                        || TemporaryMetadataContainer.Items.IsLoaded(MetadataType.Objects) 
                        || TemporaryMetadataContainer.Items.IsLoaded(MetadataType.ObjectMetadata);

            _wizardPageWelcome.cbClearBeforeLoading.Checked = check;
			_wizardPageWelcome.cbClearBeforeLoading.Enabled = check;
		}

	    private void CheckConnectionSelected()
	    {
	        if (_connection == null)
	        {
	            throw new QueryBuilderException(Helpers.Localizer.GetString("strSelectConnectionType", LocalizableConstantsInternal.strSelectConnectionType));
	        }

	        if (_connection.IsGenericSyntax() && _wizardPageConnectionType.cbSyntax.SelectedItem == null)
	        {
	            throw new QueryBuilderException(Helpers.Localizer.GetString("strSelectSyntaxProvider", LocalizableConstantsInternal.strSelectSyntaxProvider));
            }

	        SetPageEnabled(ShowLoadOpts, _connection.SyntaxProvider.IsSupportDatabases());
        }

	    private void ShowConnection()
	    {
            SetActivePage(_wizardPageConnectionType);

	        if (FirstShow(ShowConnection))
	        {
	            SetShown(ShowConnection, true);

	            for (int i = 0; i < ActiveQueryBuilder.Core.Helpers.ConnectionDescriptorList.Count; i++)
	            {
	                var name = ActiveQueryBuilder.Core.Helpers.ConnectionDescriptorList.Names[i];
	                _wizardPageConnectionType.cbConnectionType.Items.Add(name);
	            }

	            foreach (Type type in ActiveQueryBuilder.Core.Helpers.SyntaxProviderList)
	            {
	                if (_connection != null && _connection.IsGenericSyntax() && _connection.SyntaxProvider != null &&
	                    _connection.SyntaxProvider.GetType() == type)
	                {
	                    _wizardPageConnectionType.cbSyntax.Items.Add(_connection.SyntaxProvider);
                        continue;
	                }

	                var syntax = Activator.CreateInstance(type) as BaseSyntaxProvider;
	                if (syntax != null)
	                {
	                    _wizardPageConnectionType.cbSyntax.Items.Add(syntax);
                    }	                
	            }

	            if (_connection != null)
	            {
	                _wizardPageConnectionType.cbConnectionType.SelectedItem = _connection.GetDescription();

	                if (_connection.IsGenericSyntax() && _connection.SyntaxProvider != null)
	                {
	                    _wizardPageConnectionType.cbSyntax.SelectedItem = _connection.SyntaxProvider;
	                }
	            }
            }
	    }

	    private UserControl CreateConnectionEditControl(BaseConnectionDescriptor connection)
	    {
	        _metadataProperties = connection.MetadataProperties;
	        if (_metadataProperties != null)
	        {	            
                _metadataProperties.PropertiesEditors.Clear();
	            var propsContainer = PropertiesFactory.GetPropertiesContainer(_metadataProperties);
	            var propertiesBar = new PropertiesBar();
	            propertiesBar.EditorsOptions.NarrowEditControlsMinWidth = 160;
	            propertiesBar.EditorsOptions.MultiLineEditorsMaxWidth = 570;
                var propertiesControl = (IPropertiesControl)propertiesBar;
	            propertiesControl.SetProperties(propsContainer);
	            return propertiesBar;
	        }

            return null;
        }

	    private UserControl CreateSyntaxEditControl(BaseConnectionDescriptor connection)
	    {
	        var properties = connection.SyntaxProperties;
	        if (properties != null)
	        {
                properties.PropertiesEditors.Clear();
	            var propsContainer = PropertiesFactory.GetPropertiesContainer(properties);
	            var propertiesBar = new PropertiesBar();
	            var propertiesControl = (IPropertiesControl)propertiesBar;
	            propertiesControl.SetProperties(propsContainer);
	            return propertiesBar;
	        }

	        return null;
        }

		private void BeforeMetadataOpts()
		{
			if (_connection != null)
			{
				ClearPropsPage();

                if (!_connection.MetadataProvider.ConnectionObjectsCreated)
				{
					_connection.MetadataProvider.CreateAndBindInternalConnectionObj();
				}				

				if (_usedConnectionProps == null)
				{			        
                    _usedConnectionProps = CreateConnectionEditControl(_connection);				                         
				}

			    ReplaceConnectionEditControl(_usedConnectionProps);
			}
			else
			{
				_usedConnectionProps = null;
			}

			SetPageEnabled(ShowMetadataOpts, (_usedConnectionProps != null));
		}

	    private void ReplaceConnectionEditControl(UserControl control)
	    {
	        _wizardPageMetadataOpts.panelMetadataOpts.Controls.Clear();

            if (control != null)
	        {
	            control.Dock = DockStyle.Fill;
	            _wizardPageMetadataOpts.panelMetadataOpts.Controls.Add(control);
	        }
        }

		private void ClearPropsPage()
		{
			if (_usedConnectionProps != null)
			{
				_wizardPageMetadataOpts.panelMetadataOpts.Controls.Remove(_usedConnectionProps);
				_usedConnectionProps.Dispose();
				_usedConnectionProps = null;
			}

			SetShown(ShowLoadOpts, false);
		}

		private void ShowMetadataOpts()
		{
			SetActivePage(_wizardPageMetadataOpts);

			if (FirstShow(ShowMetadataOpts))
			{
				SetShown(ShowMetadataOpts, true);			    

                if (_connection != null)
				{
					if (!_connection.MetadataProvider.ConnectionObjectsCreated)
					{
					    _connection.MetadataProvider.CreateAndBindInternalConnectionObj();
					}
				}
			}
		}

		private void CheckShowMetadataOpts()
		{
			try
			{
                if (_connection.MetadataProvider.Connected)
                    _connection.MetadataProvider.Disconnect();

				_metadataProperties.ApplyConnectionString();
                _connection.MetadataProvider.Connect();
			}
			catch (Exception e)
			{
				throw new QueryBuilderException(Helpers.Localizer.GetString("strFailedToConnectDatabase", LocalizableConstantsInternal.strFailedToConnectDatabase) + "\n" + e.Message);
			}
		}

		private void BeforeLoadOpts()
		{
			LoadDatabaseList();

			if (_connection.SyntaxProvider.IsSupportDatabases())
			{
				SetPageEnabled(ShowLoadOpts, (_databases != null && _databases.Count != 0));
			}
		}

		private void ShowLoadOpts()
		{
			SetActivePage(_wizardPageLoadOpts);
			_wizardPageLoadOpts.ActiveControl = _wizardPageLoadOpts.checklistDatabases;

			if (FirstShow(ShowLoadOpts))
			{
				SetShown(ShowLoadOpts, true);
			}
		}

		private void CheckLoadOpts()
		{
			if (_wizardPageLoadOpts.checklistDatabases.CheckedItems.Count == 0)
			{
				throw new QueryBuilderException(Helpers.Localizer.GetString("strLoadingWizardPageDatabaseWelcom", LocalizableConstantsInternal.strLoadingWizardPageDatabaseWelcom));
			}
		}

		private void ShowFilter()
		{
		    _wizardPageFilter.LoadFileds = LoadFields;

            SetActivePage(_wizardPageFilter);
            
		    _wizardPageFilter.MetadataFilter = TemporaryMetadataContainer.LoadingOptions.MetadataFilter;
		    _wizardPageFilter.ShowPackage = _connection.SyntaxProvider.IsSupportPackages();
		    _wizardPageFilter.ShowServer = _connection.SyntaxProvider.IsSupportServers();

		    if (_connection.SyntaxProvider.IsSupportDatabases())
		    {
		        _wizardPageFilter.ShowDatabase = true;
		        _wizardPageFilter.DatabaseList = LoadMetadata(MetadataType.Database);
            }

            if (_connection.SyntaxProvider.IsSupportSchemas())
            {
                _wizardPageFilter.ShowSchema = true;
                _wizardPageFilter.SchemaList = LoadMetadata(MetadataType.Schema);
            }
        }

        private void CheckFilter()
        {
            var itemsToDelete = new List<MetadataFilterItem>();
            var filters = TemporaryMetadataContainer.LoadingOptions.MetadataFilter;

            foreach (var filter in filters)
            {
                if (filter.IsEmpty)
                    itemsToDelete.Add(filter);
            }

            foreach (var filter in itemsToDelete)
            {
                filters.Remove(filter);
            }

            LoadFields = _wizardPageFilter.LoadFileds;
        }

        private List<string> LoadMetadata(MetadataType type)
        {
            var loadingOptions = new MetadataLoadingOptions
            {
                LoadDefaultDatabaseOnly = type != MetadataType.Database,
                LoadSystemObjects = true
            };

            var container = new MetadataContainer(TemporaryMetadataContainer.SQLContext)
            {
                LoadingOptions = loadingOptions
            };

            var list = new MetadataList(container);
            list.Load(type, false);
            //list.Load(MetadataType.Database, false);

            //if (type == MetadataType.Schema)
            //{
            //    var defaultDb = list.Databases.FirstOrDefault(x => x.Default);
            //    if (defaultDb != null)
            //    {
            //        defaultDb.Items.Load(type, false);
            //        list = defaultDb.Items;
            //    }
            //}

            return list.Select(x => x.Name).ToList();
        }

        private MetadataLoader _loader;

        private void ShowLoading()
		{
			SetActivePage(_wizardPageLoading);
			
			bBack.Enabled = false;
			bNext.Enabled = false;
		    bCancel.DialogResult = DialogResult.None;

            _temporarySQLContext.MetadataProvider = _connection.MetadataProvider;
		    _temporarySQLContext.SyntaxProvider = _connection.SyntaxProvider;

            TemporaryMetadataContainer.Items.SetLoaded(MetadataType.All, false);

            if (_wizardPageWelcome.cbClearBeforeLoading.Checked)
			{
				EditedMetadataContainer.Items.Clear();
                TemporaryMetadataContainer.Items.Clear();
            }

		    TemporaryMetadataContainer.LoadingOptions.LoadDefaultDatabaseOnly = false;
		    TemporaryMetadataContainer.LoadingOptions.LoadSystemObjects = false;

            var databasesToLoad = new List<string>();
            if ((!_connection.SyntaxProvider.IsSupportDatabases() || _databases.Count == 0) && DefaultDatabase != null)
                databasesToLoad.Add(DefaultDatabase);
            else
            {
                for (int i = 0; i < _wizardPageLoadOpts.checklistDatabases.Items.Count; i++)
                {
                    var item = _wizardPageLoadOpts.checklistDatabases.Items[i] as DatabaseObjectForListbox;
                    if (item == null)
                        continue;

                    if (_wizardPageLoadOpts.checklistDatabases.GetItemChecked(i))
                        databasesToLoad.Add(item.Database);
                }
            }

			_loader = new MetadataLoader(TemporaryMetadataContainer, databasesToLoad)
			{
			    LoadFields = LoadFields
			};

			_loader.DatabaseLoadingStart += LoaderOnDatabaseLoadingStart;
			_loader.LoadingFinished += LoadingFinished;
			_loader.LoadingFailed += LoadingFailed;
			_loader.EntitiesLoaded += EntitiesLoaded;
            _loader.Start();
		}

        private void EntitiesLoaded(object sender, MetadataItem metadataItem, int databases, int schemas, int packages, int objects, int fields, int foreignkeys)
        {
            _wizardPageLoading.lblLoaded.Invoke((MethodInvoker)delegate 
            {
                _wizardPageLoading.lblLoaded.Text = string.Format(Helpers.Localizer.GetString("strContainerLoadingStatistics", LocalizableConstantsInternal.strContainerLoadingStatistics),
                    databases, schemas, packages, objects, fields, foreignkeys);

            });

            WriteMetadataLoadingLog($"Loading {metadataItem.Type} {metadataItem.Name}");
        }

        private void LoadingFailed(object sender, string message)
        {
            WriteMetadataLoadingLog(Helpers.Localizer.GetString("strContainerLoadingFailed", LocalizableConstantsInternal.strContainerLoadingFailed) + " " + message);
        }

        private void LoaderOnDatabaseLoadingStart(object sender, string database)
        {
            WriteMetadataLoadingLog(string.Format(Helpers.Localizer.GetString("strContainerLoadingFromDatabase", LocalizableConstantsInternal.strContainerLoadingFromDatabase), database));
        }

        private void LoadingFinished(object sender, EventArgs e)
        {
            bCancel.Invoke((MethodInvoker) delegate
            {
                bCancel.Text = ActiveQueryBuilder.Core.Localization.Common.ButtonClose.Value;
                bCancel.Enabled = true;
                bCancel.DialogResult = DialogResult.OK;
            });

            WriteMetadataLoadingLog(Helpers.Localizer.GetString("strContainerLoadingSuccess", LocalizableConstantsInternal.strContainerLoadingSuccess));

            WriteMetadataLoadingLog(string.Format(
                                        Helpers.Localizer.GetString("strContainerLoadedEntities", LocalizableConstantsInternal.strContainerLoadedEntities),
                                        (_loader.LoadedDatabases + _loader.LoadedSchemas + _loader.LoadedPackages + _loader.LoadedObjects + _loader.LoadedFields + _loader.LoadedForeignKeys)
                                        .ToString(CultureInfo.InvariantCulture)));

            _loader.DatabaseLoadingStart -= LoaderOnDatabaseLoadingStart;
            _loader.LoadingFinished -= LoadingFinished;
            _loader.LoadingFailed -= LoadingFailed;
            _loader.EntitiesLoaded -= EntitiesLoaded;

            _wizardPageLoading.Invoke((MethodInvoker)delegate
            {
                _wizardPageLoading.ShowSuccess();
            });

            _loader = null;
        }

		private int IndexOfPage(ShowProc APageProc)
		{
			for (int i = 0; i < _pages.Count; i++)
			{
				if (_pages[i].showProc == APageProc)
				{
					return i;
				}
			}

			return -1;
		}

		private bool FirstShow(ShowProc APageProc)
		{
			int i = IndexOfPage(APageProc);

			if (i != -1)
			{
				return !_pages[i].pageShown;
			}
			
			return false;
		}

		private void SetShown(ShowProc APageProc, bool AShown /*= true*/)
		{
			int i = IndexOfPage(APageProc);

			if (i != -1)
			{
				_pages[i].pageShown = AShown;
			}
		}

		private void WriteMetadataLoadingLog(String message)
        {
            _wizardPageLoading.textLog.Invoke((MethodInvoker) delegate
            {
                _wizardPageLoading.textLog.AppendText($"[{DateTime.Now:HH:mm:ss}] {message}\r\n");
            });
        }

		private void SetPageEnabled(ShowProc APageProc, bool AEnabled)
		{
			int i = IndexOfPage(APageProc);

			if (i != -1)
			{
				_pages[i].pageEnabled = AEnabled;
			}
		}

		private void buttonNext_Click(object sender, EventArgs e)
		{
			if (_pages[_currentPage].checkProc != null)
			{
				try
				{
					_pages[_currentPage].checkProc();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, Helpers.Localizer.GetString("strError", LocalizableConstantsUI.strError));
					return;
				}
			}

			if (_currentPage + 1 < _pages.Count)
			{
				do 
				{
					_currentPage++;

					if (_pages[_currentPage].prepareProc != null)
					{
						try
						{
							_pages[_currentPage].prepareProc();
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.Message, Helpers.Localizer.GetString("strError", LocalizableConstantsUI.strError));
						    _currentPage--;
                            return;
						}
					}
				}
				while (!_pages[_currentPage].pageEnabled);

				bBack.Enabled = true;
				bNext.Enabled = (_currentPage + 1 < _pages.Count);

				if (_currentPage + 2 == _pages.Count)
				{
					bNext.Text = ActiveQueryBuilder.Core.Localization.Common.ButtonLoad.Value;
				}
				else
				{
					bNext.Text = ActiveQueryBuilder.Core.Localization.Common.ButtonNext.Value + " >";
				}

				_pages[_currentPage].showProc();
			}
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			if (_currentPage > 0)
			{
				_currentPage--;

				while (!_pages[_currentPage].pageEnabled)
				{
					_currentPage--;
				}

				bBack.Enabled = (_currentPage > 0);
				bNext.Enabled = true;
				bNext.Text = ActiveQueryBuilder.Core.Localization.Common.ButtonNext.Value + " >";
				
				_pages[_currentPage].showProc();
			}
		}

		void buttonConnectionTest_Click(object sender, EventArgs e)
		{
			if (_connection != null)
			{
			    _metadataProperties.ApplyConnectionString();
                _connection.Disconnect();

				try
				{
				    _connection.Connect();
				    _connection.Disconnect();

                    MessageBox.Show(Helpers.Localizer.GetString("strTestConnectionSuccess", LocalizableConstantsInternal.strTestConnectionSuccess));
				}
				catch (Exception ex)
				{
					MessageBox.Show(Helpers.Localizer.GetString("strTestConnectionFail", LocalizableConstantsInternal.strTestConnectionFail) + "\n" + ex.Message);
				}
			}
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			if (DialogResult == DialogResult.OK)
			{
				MetadataLoadingOptions loadingOptions = EditedMetadataContainer.LoadingOptions;
				EditedMetadataContainer.Assign(TemporaryMetadataContainer);
				EditedMetadataContainer.LoadingOptions = loadingOptions;
			}

			base.OnClosing(e);
		}

        private void bCancel_Click(object sender, EventArgs e)
        {
            if (_loader != null)
            {
                _loader.Stop();
            }
        }
    }

    internal class WizardPageInfo
	{
		public ShowProc showProc;
		public CheckProc checkProc;
		public bool pageShown;
		public bool pageEnabled;
		public PrepareProc prepareProc;

		public WizardPageInfo(ShowProc AShowProc)
		{
			showProc = AShowProc;
			checkProc = null;
			pageShown = false;
			pageEnabled = true;
			prepareProc = null;
		}

		public WizardPageInfo(ShowProc AShowProc, CheckProc ACheckProc)
		{
			showProc = AShowProc;
			checkProc = ACheckProc;
			pageShown = false;
			pageEnabled = true;
			prepareProc = null;
		}

		public WizardPageInfo(ShowProc AShowProc, CheckProc ACheckProc, bool AEnabled)
		{
			showProc = AShowProc;
			checkProc = ACheckProc;
			pageShown = false;
			pageEnabled = AEnabled;
			prepareProc = null;
		}

		public WizardPageInfo(ShowProc AShowProc, CheckProc ACheckProc, bool AEnabled, PrepareProc APrepareProc)
		{
			showProc = AShowProc;
			checkProc = ACheckProc;
			pageShown = false;
			pageEnabled = AEnabled;
			prepareProc = APrepareProc;
		}
	}

	internal class DatabaseObjectForListbox : Object
	{
		public string Database;
		public bool IsDefaultDatabase;

		public DatabaseObjectForListbox(string database, bool isDefaultDatabase)
		{
			Database = database;
			IsDefaultDatabase = isDefaultDatabase;
		}

		public override string ToString()
		{
			Debug.Assert(Database != null);

			if (!IsDefaultDatabase)
			{
				return Database;
			}
			
			return Database + " " + string.Format("({0})", Helpers.Localizer.GetString("strMetadataTreeCurrentDatabase", LocalizableConstantsInternal.strMetadataTreeCurrentDatabase));
		}
	}

    internal class MetadataLoader
    {
        public delegate void DatabaseLoadingStartEventHandler(object sender, string database);
        public delegate void DatabaseLoadingFailedEventHandler(object sender, string message);
        public delegate void DatabaseEntitiesLoadedEventHandler(object sender, MetadataItem metadataItem, int databases, int schemas, int packages, int objects, int fields, int foreignKeys);

        private Thread _thread;
        private readonly List<string> _databases;
        private readonly MetadataContainer _container;
        private bool _loadingAborted;

        public int LoadedDatabases { get; private set; } = 0;
        public int LoadedSchemas { get; private set; } = 0;
        public int LoadedPackages { get; private set; } = 0;
        public int LoadedObjects { get; private set; } = 0;
        public int LoadedFields { get; private set; } = 0;
        public int LoadedForeignKeys { get; private set; } = 0;

        public bool LoadFields { get; set; }

        public event DatabaseLoadingStartEventHandler DatabaseLoadingStart;
        public event DatabaseLoadingFailedEventHandler LoadingFailed;
        public event EventHandler LoadingFinished;
        public event DatabaseEntitiesLoadedEventHandler EntitiesLoaded;

        public MetadataLoader(MetadataContainer container, List<string> databases = null)
        {
            _container = container;
            _databases = databases;
        }

        public void Start()
        {
            _thread = new Thread(LoadMetadata);
            _thread.Start();
        }

        public void Stop()
        {
            _loadingAborted = true;
            _container.AbortMetadataLoading();
        }

        private void LoadMetadata()
        {
            _container.MetadataChildItemAdded += ContainerOnMetadataChildItemAdded;
            try
            {
                using (new UpdateRegion(_container))
                {
                    if (_databases != null && _databases.Count != 0)
                        LoadForDatabases();
                    else
                        LoadEntireContainer();
                }
            }
            catch (Exception e)
            {
                LoadingFailed?.Invoke(this, e.Message);
            }
            finally
            {
                _container.MetadataChildItemAdded -= ContainerOnMetadataChildItemAdded;
                LoadingFinished?.Invoke(this, EventArgs.Empty);
            }
        }

        private void LoadForDatabases()
        {
            foreach (var database in _databases)
            {
                if (_loadingAborted)
                    break;

                DatabaseLoadingStart?.Invoke(this, database);
                MetadataNamespace db = _container.AddDatabase(database);
                db.Items.Load(LoadFields ? MetadataType.All : MetadataType.All & ~MetadataType.ObjectMetadata, true);
            }
        }

        private void LoadEntireContainer()
        {
            _container.Items.Load(LoadFields ? MetadataType.All : MetadataType.All & ~MetadataType.ObjectMetadata, true);
        }

        private void ContainerOnMetadataChildItemAdded(MetadataItem sender, MetadataItem item)
        {
            UpdateCounters(item);
            EntitiesLoaded?.Invoke(this,item, LoadedDatabases, LoadedSchemas, LoadedPackages, LoadedObjects, LoadedFields, LoadedForeignKeys);
        }

        private void UpdateCounters(MetadataItem item)
        {
            switch (item.Type)
            {
                case MetadataType.Database:
                    LoadedDatabases++;
                    break;
                case MetadataType.Schema:
                    LoadedSchemas++;
                    break;
                case MetadataType.Package:
                    LoadedPackages++;
                    break;
                case MetadataType.Table:
                case MetadataType.View:
                case MetadataType.Procedure:
                case MetadataType.Synonym:
                case MetadataType.Aggregate:
                    LoadedObjects++;
                    break;
                case MetadataType.Parameter:
                case MetadataType.Field:
                    LoadedFields++;
                    break;
                case MetadataType.ForeignKey:
                    LoadedForeignKeys++;
                    break;
            }
        }
    }
}
