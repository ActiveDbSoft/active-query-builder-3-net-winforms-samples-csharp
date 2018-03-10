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
using System.ComponentModel;
using System.Data.Odbc;
using System.Data.OleDb;
using Oracle.ManagedDataAccess.Client;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View;
using ActiveQueryBuilder.View.EventHandlers.MetadataStructureItems;
using ActiveQueryBuilder.View.WinForms;
using FullFeaturedMdiDemo.Dailogs;
using FullFeaturedMdiDemo.PropertiesForm;
using MySql.Data.MySqlClient;
using Npgsql;
using Helpers = ActiveQueryBuilder.Core.Helpers;

namespace FullFeaturedMdiDemo
{
	public partial class MainForm : Form
	{
        private ConnectionInfo _selectedConnection;
        private SQLContext _sqlContext;
        private readonly SQLFormattingOptions _sqlFormattingOptions;
        private readonly SQLGenerationOptions _sqlGenerationOptions;

        public MainForm()
		{
			InitializeComponent();

            // Options to present the formatted SQL query text to end-user
            // Use names of virtual objects, do not replace them with appropriate derived tables
            _sqlFormattingOptions = new SQLFormattingOptions { ExpandVirtualObjects = false };

            // Options to generate the SQL query text for execution against a database server
            // Replace virtual objects with derived tables
            _sqlGenerationOptions = new SQLGenerationOptions { ExpandVirtualObjects = true };

            if (Program.Settings.WindowPlacement == Rectangle.Empty)
				StartPosition = FormStartPosition.WindowsDefaultLocation;
			else
				Bounds = Program.Settings.WindowPlacement;

			if (Program.Settings.IsMaximized)
				WindowState = FormWindowState.Maximized;

            LoadLanguages();

			SizeChanged += MainForm_SizeChanged;
			LocationChanged += MainForm_LocationChanged;
            MdiChildActivate += MainForm_MdiChildActivate;
			Application.Idle += Application_Idle;
            DBView.ItemDoubleClick += DBView_ItemDoubleClick;

		    // DEMO WARNING
		    Panel trialNoticePanel = new Panel
		    {
		        AutoSize = true,
		        AutoSizeMode = AutoSizeMode.GrowAndShrink,
		        BackColor = Color.LightPink,
		        BorderStyle = BorderStyle.FixedSingle,
		        Dock = DockStyle.Top,
		        Padding = new Padding(6, 5, 3, 0),
		    };

		    Label label = new Label
		    {
		        AutoSize = true,
		        Margin = new Padding(0),
		        Text = @"Generation of random aliases for the query output columns is the limitation of the trial version. The full version is free from this behavior.",
		        Dock = DockStyle.Fill,
		        UseCompatibleTextRendering = true
		    };

		    var buttonClose = new PictureBox { Image = Properties.Resources.cancel, SizeMode = PictureBoxSizeMode.AutoSize, Cursor = Cursors.Hand };
		    buttonClose.Click += delegate { Controls.Remove(trialNoticePanel); };

		    trialNoticePanel.Controls.Add(buttonClose);

		    trialNoticePanel.Resize += delegate
		    {
		        buttonClose.Location = new Point(trialNoticePanel.Width - buttonClose.Width - 10, trialNoticePanel.Height / 2 - buttonClose.Height / 2);
		    };

		    trialNoticePanel.Controls.Add(label);
		    Controls.Add(trialNoticePanel);

		    Controls.SetChildIndex(trialNoticePanel, 2);
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
	    {
	        ChildForm childForm = ActiveMdiChild as ChildForm;
	        if(childForm == null)
	        {
	            userQueriesView1.QueryView = null;
	        } else
	        {
	            userQueriesView1.QueryView = childForm.QueryView;
	            userQueriesView1.SQLQuery = childForm.SqlQuery;
	        }
	    }

	    void DBView_ItemDoubleClick(object sender, MetadataStructureItem clickedItem)
        {
			// Adding a table to the currently active query.
            if((MetadataType.Objects & clickedItem.MetadataItem.Type) == 0 &&
                (MetadataType.ObjectMetadata & clickedItem.MetadataItem.Type) == 0)
            {
                return;
            }
            if (ActiveMdiChild == null)
            {
                ChildForm childWindow = CreateChildForm();
                if(childWindow == null)
                {
                    return;
                }
                childWindow.Show();
                childWindow.Activate();
            }
            ChildForm window = (ChildForm)ActiveMdiChild;
            if(window == null)
            {
                return;
            }
            MetadataItem metadataItem = clickedItem.MetadataItem;
            if(metadataItem == null)
            {
                return;
            }
            if((metadataItem.Type & MetadataType.Objects) <= 0 && metadataItem.Type != MetadataType.Field)
            {
                return;
            }
            using (var qualifiedName = metadataItem.GetSQLQualifiedName(null, true))
            {
                window.QueryView.AddObjectToActiveUnionSubQuery(qualifiedName.GetSQL());
            }
        }

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				Application.Idle -= Application_Idle;
                DBView.ItemDoubleClick -= DBView_ItemDoubleClick;

				if (components != null)
					components.Dispose();
			}

			base.Dispose(disposing);
		}

        private void LoadLanguages() {
            foreach(string language in Helpers.Localizer.Languages) {
                string lang = language.ToLower();
                ToolStripItem menuItem;
                if(lang == "auto") {
                    menuItem = tsmiLanguageAuto;
                } else if(lang == "default") {
                    menuItem = tsmiLanguageDefault;
                } else {
                    CultureInfo culture = CultureInfo.GetCultureInfo(lang);
                    menuItem = languageToolStripMenuItem.DropDownItems.Add(culture.NativeName, null, Language_Click);
                    menuItem.Tag = lang;
                }
                if(string.Equals(menuItem.Tag as string, Program.Settings.Language, StringComparison.OrdinalIgnoreCase)) {
                    ((ToolStripMenuItem)menuItem).Checked = true;
                }
            }
        }

        private void Language_Click(object sender, EventArgs e) {
            ToolStripMenuItem currentItem = sender as ToolStripMenuItem;
            if(currentItem == null || Equals(currentItem.Tag, Helpers.Localizer.Language)) {
                return;
            }
            ToolStripMenuItem checkedItem = languageToolStripMenuItem.DropDownItems.OfType<ToolStripMenuItem>().FirstOrDefault(item => item.Checked);
            if(checkedItem != null) {
                checkedItem.Checked = false;
            }
            Program.Settings.Language = (string)currentItem.Tag;
            if(ActiveMdiChild != null) {
                ((ChildForm)ActiveMdiChild).UpdateLanguage();
            }
            currentItem.Checked = true;
        }

        private void Application_Idle(object sender, EventArgs e)
	    {
	        tsmiSave.Enabled = (ActiveMdiChild != null);
	        tsmiParseQuery.Enabled = (ActiveMdiChild != null);
	        tsmiBuildQuery.Enabled = (ActiveMdiChild != null);
	        tsmiRunQuery.Enabled = (ActiveMdiChild != null);
	        tsmiQueryStatistics.Enabled = (ActiveMdiChild != null);
            toolStripButtonNewQuery.Enabled = newQueryToolStripMenuItem1.Enabled = (_sqlContext != null);
	        tsmiUndo.Enabled = (ActiveMdiChild != null && ((ChildForm) ActiveMdiChild).CanUndo());
	        tsmiRedo.Enabled = (ActiveMdiChild != null && ((ChildForm) ActiveMdiChild).CanRedo());
	        tsmiCut.Enabled = (ActiveMdiChild != null && ((ChildForm) ActiveMdiChild).CanCut());
	        tsmiCopy.Enabled = (ActiveMdiChild != null && ((ChildForm) ActiveMdiChild).CanCopy());
	        tsmiPaste.Enabled = (ActiveMdiChild != null && ((ChildForm) ActiveMdiChild).CanPaste());
	        tsmiSelectAll.Enabled = (ActiveMdiChild != null && ((ChildForm) ActiveMdiChild).CanSelectAll());
	        tsbSave.Enabled = (ActiveMdiChild != null);
	        tsbCascade.Enabled = (MdiChildren.Length > 0);
	        tsbTileHorizontally.Enabled = (MdiChildren.Length > 0);
	        tsbTileVertically.Enabled = (MdiChildren.Length > 0);
	        tsbCut.Enabled = (ActiveMdiChild != null && ((ChildForm) ActiveMdiChild).CanCut());
	        tsbCopy.Enabled = (ActiveMdiChild != null && ((ChildForm) ActiveMdiChild).CanCopy());
	        tsbPaste.Enabled = (ActiveMdiChild != null && ((ChildForm) ActiveMdiChild).CanPaste());
	        tsmiOfflineMode.Enabled = (ActiveMdiChild != null);
	        tsmiOfflineMode.Checked = (ActiveMdiChild != null && ((ChildForm) ActiveMdiChild).IsOfflineMode());
	        tsmiRefreshMetadata.Enabled = (ActiveMdiChild != null);
	        tsmiEditMetadata.Enabled = (ActiveMdiChild != null);
	        tsmiClearMetadata.Enabled = (ActiveMdiChild != null);
	        tsmiLoadMetadataFromXML.Enabled = (ActiveMdiChild != null);
	        tsmiSaveMetadataToXML.Enabled = (ActiveMdiChild != null);

	        addDerivedTableToolStripMenuItem.Enabled = (ActiveMdiChild != null &&
	                                                    ((ChildForm) ActiveMdiChild).CanAddDerivedTable());
	        addObjectToolStripMenuItem.Enabled = (ActiveMdiChild != null &&
	                                              ((ChildForm) ActiveMdiChild).CanAddObject());
	        addUnionSubqueryToolStripMenuItem.Enabled = (ActiveMdiChild != null &&
	                                                     ((ChildForm) ActiveMdiChild).CanAddUnionSubQuery());
	        copyUnionSubwueryToolStripMenuItem.Enabled = (ActiveMdiChild != null &&
	                                                      ((ChildForm) ActiveMdiChild).CanCopyUnionSubQuery());

            tsbEditMetadata.Enabled = _sqlContext != null && _sqlContext.MetadataContainer != null;
	    }

	    private void tsbNew_Click(object sender, EventArgs e)
		{
			tsmiNew_Click(sender, e);
		}

	    private void InitializeSqlContext()
	    {
            try
            {
                Cursor = Cursors.WaitCursor;

                BaseMetadataProvider metadataProvaider = null;
                
				// create new SqlConnection object using the connections string from the connection form
                if (!_selectedConnection.IsXmlFile)
                {
                    switch (_selectedConnection.ConnectionType)
                    {
                        case ConnectionTypes.MSSQL:
                            metadataProvaider = new MSSQLMetadataProvider
                            {
                                Connection = new SqlConnection(_selectedConnection.ConnectionString)
                            };
                            break;
                        case ConnectionTypes.MSAccess:
                            metadataProvaider = new OLEDBMetadataProvider
                            {
                                Connection = new OleDbConnection(_selectedConnection.ConnectionString)
                            };
                            break;
                        case ConnectionTypes.Oracle:
                            // previous version of this demo uses deprecated System.Data.OracleClient
                            // current version uses Oracle.ManagedDataAccess.Client which doesn't support "Integrated Security" setting
                            var updatedConnectionString = Regex.Replace(_selectedConnection.ConnectionString,
                                "Integrated Security=.*?;", "");
                            metadataProvaider = new OracleNativeMetadataProvider
                            {
                                Connection = new OracleConnection(updatedConnectionString)
                            };
                            break;
                        case ConnectionTypes.MySQL:
                            metadataProvaider = new OracleNativeMetadataProvider
                            {
                                Connection = new MySqlConnection(_selectedConnection.ConnectionString)
                            };
                            break;
                        case ConnectionTypes.PostgreSQL:
                            metadataProvaider = new PostgreSQLMetadataProvider
                            {
                                Connection = new NpgsqlConnection(_selectedConnection.ConnectionString)
                            };
                            break;
                        case ConnectionTypes.OLEDB:
                            metadataProvaider = new OLEDBMetadataProvider
                            {
                                Connection = new OleDbConnection(_selectedConnection.ConnectionString)
                            };
                            break;
                        case ConnectionTypes.ODBC:
                            metadataProvaider = new ODBCMetadataProvider
                            {
                                Connection = new OdbcConnection(_selectedConnection.ConnectionString)
                            };
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }

                if (_selectedConnection.IsXmlFile && _selectedConnection.SyntaxProvider == null)
                {
                    _selectedConnection.CreateSyntaxByType();
                }

                // setup the query builder with metadata and syntax providers
                _sqlContext = new SQLContext
                {
                    MetadataProvider = metadataProvaider,
                    SyntaxProvider = _selectedConnection.SyntaxProvider,
                    LoadingOptions = { OfflineMode = (metadataProvaider == null) }
                };

                if(metadataProvaider == null)
                {
                    _sqlContext.MetadataContainer.ImportFromXML(_selectedConnection.ConnectionString);
                }
                CaptionConnection.Text = _selectedConnection.ConnectionName;

                DBView.SQLContext = _sqlContext;
                DBView.InitializeDatabaseSchemaTree();

                userQueriesView1.SQLContext = _sqlContext;
                userQueriesView1.SQLQuery = new SQLQuery(_sqlContext);

                if (!string.IsNullOrEmpty(_selectedConnection.UserQueries)) {
                    var bytes = Encoding.UTF8.GetBytes(_selectedConnection.UserQueries);

                    using (var reader = new MemoryStream(bytes))
                    {
                        userQueriesView1.ImportFromXML(reader);
                    }
                }
            }
            finally
            {
                Cursor = Cursors.Default;
            }
	    }

	    private void tsmiNew_Click(object sender, EventArgs e)
	    {
	        Connect();
	    }

	    private void Connect() {
            using (ConnectionForm cf = new ConnectionForm())
            {
                if (cf.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Cursor = Cursors.WaitCursor;
                        if(Equals(_selectedConnection, cf.SelectedConnection))
                        {
                            return;
                        }
                        foreach(var mdiChild in MdiChildren)
                        {
                            mdiChild.Close();
                        }
                        if(MdiChildren.Length > 0)
                        {
                            return;
                        }
                        _selectedConnection = cf.SelectedConnection;
                        InitializeSqlContext();
                        if (!string.IsNullOrEmpty(_selectedConnection.UserQueries))
                        {
                            byte[] bytes = Encoding.UTF8.GetBytes(_selectedConnection.UserQueries);
                            using (var reader = new MemoryStream(bytes))
                            {
                                userQueriesView1.ImportFromXML(reader);
                            }
                        }
                    }
                    finally
                    {
                        Cursor = Cursors.Default;
                    }
                }
            }
	    }

	    private void tsmiOpen_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				StringBuilder sb = new StringBuilder();
				using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
				{
					string s;
					while ((s = sr.ReadLine()) != null)
					{
						sb.AppendLine(s);
					}
				}
			    if(_selectedConnection == null)
			    {
			        Connect();
			    }
			    if(_selectedConnection == null)
			    {
			        return;
			    }
			    ChildForm f = CreateChildForm(openFileDialog1.FileName);
                f.QueryText = sb.ToString();
                f.FileSourcePath = openFileDialog1.FileName;
                f.SqlSourceType = ChildForm.SourceType.File;
                f.Show();
            }
		}

		private void tsmiSave_Click(object sender, EventArgs e)
		{
			if (ActiveMdiChild != null)
			{
			    ((ChildForm) ActiveMdiChild).Save(false);
			}
		}

		private void tsmiExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void MainForm_LocationChanged(object sender, EventArgs e)
		{
			if (WindowState != FormWindowState.Maximized)
			{
				Program.Settings.WindowPlacement = Bounds;
			}
		}

		private void MainForm_SizeChanged(object sender, EventArgs e)
		{
			if (Program.Settings.IsMaximized != (WindowState == FormWindowState.Maximized))
			{
				Program.Settings.IsMaximized = (WindowState == FormWindowState.Maximized);
			}

			if (!Program.Settings.IsMaximized)
			{
				Program.Settings.WindowPlacement = Bounds;
			}
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		private void tsbCascade_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.Cascade);
		}

		private void tsbTileHorizontally_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void tsbTileVertically_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileVertical);
		}

		private void tsmiParseQuery_Click(object sender, EventArgs e)
		{
			if (ActiveMdiChild != null)
			{
				((ChildForm) ActiveMdiChild).ParseQuery();
			}
		}

		private void tsmiBuildQuery_Click(object sender, EventArgs e)
		{
			if (ActiveMdiChild != null)
			{
				((ChildForm) ActiveMdiChild).ActivateBuildQueryTab();
			}
		}

		private void tsmiRunQuery_Click(object sender, EventArgs e)
		{
			if (ActiveMdiChild != null)
			{
				((ChildForm) ActiveMdiChild).ActivateRunQueryTab();
			}
		}

		private void tsmiQueryStatistics_Click(object sender, EventArgs e)
		{
			if (ActiveMdiChild != null)
			{
				((ChildForm) ActiveMdiChild).ShowQueryStatistics();
			}
		}

		private void tsmiAbout_Click(object sender, EventArgs e)
		{
			using (AboutForm f = new AboutForm())
			{
				f.ShowDialog();
			}
		}

		private void tsmiUndo_Click(object sender, EventArgs e)
		{
			if (ActiveMdiChild != null)
			{
				((ChildForm) ActiveMdiChild).Undo();
			}
		}

		private void tsmiRedo_Click(object sender, EventArgs e)
		{
			if (ActiveMdiChild != null)
			{
				((ChildForm) ActiveMdiChild).Redo();
			}
		}

		private void tsmiCut_Click(object sender, EventArgs e)
		{
			if (ActiveMdiChild != null)
			{
				((ChildForm) ActiveMdiChild).Cut();
			}
		}

		private void tsmiCopy_Click(object sender, EventArgs e)
		{
			if (ActiveMdiChild != null)
			{
				((ChildForm) ActiveMdiChild).Copy();
			}
		}

		private void tsmiPaste_Click(object sender, EventArgs e)
		{
			if (ActiveMdiChild != null)
			{
				((ChildForm) ActiveMdiChild).Paste();
			}
		}

		private void tsmiSelectAll_Click(object sender, EventArgs e)
		{
			if (ActiveMdiChild != null)
			{
				((ChildForm) ActiveMdiChild).SelectAll();
			}
		}

		private void tsbOpen_Click(object sender, EventArgs e)
		{
			tsmiOpen_Click(sender, e);
		}

		private void tsbSave_Click(object sender, EventArgs e)
		{
			tsmiSave_Click(sender, e);
		}

		private void tsbAbout_Click(object sender, EventArgs e)
		{
			tsmiAbout_Click(sender, e);
		}

		private void tsbCut_Click(object sender, EventArgs e)
		{
			tsmiCut_Click(sender, e);
		}

		private void tsbCopy_Click(object sender, EventArgs e)
		{
			tsmiCopy_Click(sender, e);
		}

		private void tsbPaste_Click(object sender, EventArgs e)
		{
			tsmiPaste_Click(sender, e);
		}

		private void tsmiOfflineMode_Click(object sender, EventArgs e)
		{
            if (tsmiOfflineMode.Checked)
            {
                try
                {
                    Cursor = Cursors.WaitCursor;

                    _sqlContext.MetadataContainer.LoadAll(true);
                }
                finally
                {
                    Cursor = Cursors.Arrow;
                }
            }

            _sqlContext.MetadataContainer.LoadingOptions.OfflineMode = tsmiOfflineMode.Checked;
		}

		private void tsmiRefreshMetadata_Click(object sender, EventArgs e)
		{
			if (ActiveMdiChild != null)
			{
				// to refresh metadata, just clear already loaded items
				((ChildForm) ActiveMdiChild).ClearMetadata();
				((ChildForm) ActiveMdiChild).RefreshMetadata();
			}
		}

		private void tsmiEditMetadata_Click(object sender, EventArgs e)
		{
			if (ActiveMdiChild != null)
			{
				((ChildForm) ActiveMdiChild).EditMetadata();
			}
		}

		private void tsmiClearMetadata_Click(object sender, EventArgs e)
		{
			if (ActiveMdiChild != null)
			{
				// to refresh metadata, just clear already loaded items
				((ChildForm) ActiveMdiChild).ClearMetadata();
			}
		}

		private void tsmiLoadMetadataFromXML_Click(object sender, EventArgs e)
		{
			if (ActiveMdiChild != null)
			{
				((ChildForm) ActiveMdiChild).LoadMetadataFromXml();
			}
		}

		private void tsmiSaveMetadataToXML_Click(object sender, EventArgs e)
		{
			if (ActiveMdiChild != null)
			{
				((ChildForm) ActiveMdiChild).SaveMetadataToXml();
			}
		}

		private void tsmiLanguageAuto_Click(object sender, EventArgs e)
		{
			Program.Settings.Language = "Auto";

			if (ActiveMdiChild != null)
			{
				((ChildForm) ActiveMdiChild).UpdateLanguage();
			}
		}

		private void tsmiLanguageDefault_Click(object sender, EventArgs e)
		{
			Program.Settings.Language = "Default";
			if (ActiveMdiChild != null)
			{
				((ChildForm) ActiveMdiChild).UpdateLanguage();
			}
		}

        private void newQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateChildForm("New query").Show();
        }

	    private ChildForm CreateChildForm(string caption = null)
	    {
            ChildForm childForm = new ChildForm(_sqlContext, _selectedConnection) {
                MdiParent = this,
                SqlFormattingOptions = _sqlFormattingOptions,
                SqlGenerationOptions = _sqlGenerationOptions,
                Text = string.IsNullOrEmpty(caption) ? "New query" : caption
            };
            childForm.FormClosed += ChildForm_FormClosed;
            childForm.SaveQueryEvent += ChildForm_SaveQueryEvent;
            childForm.SaveAsInFileEvent += ChildForm_SaveAsInFileEvent;
            childForm.SaveAsNewUserQueryEvent += ChildForm_SaveAsNewUserQueryEvent;
            return childForm;
        }

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChildForm childForm = (ChildForm)sender;
            childForm.FormClosed -= ChildForm_FormClosed;
            childForm.SaveQueryEvent -= ChildForm_SaveQueryEvent;
            childForm.SaveAsInFileEvent -= ChildForm_SaveAsInFileEvent;
            childForm.SaveAsNewUserQueryEvent -= ChildForm_SaveAsNewUserQueryEvent;
        }

        private void ChildForm_SaveAsNewUserQueryEvent(object sender, CancelEventArgs e)
        {
            ChildForm childForm = (ChildForm)sender;
            e.Cancel = !SaveNewUserQuery(childForm);
        }

        private void ChildForm_SaveAsInFileEvent(object sender, CancelEventArgs e)
        {
            e.Cancel = !SaveInFile((ChildForm)sender, true);
        }

        private void ChildForm_SaveQueryEvent(object sender, CancelEventArgs e)
        {
			// Saving the current query
            ChildForm childForm = (ChildForm)sender;
            switch (childForm.SqlSourceType)
            {
				// as a new user query
                case ChildForm.SourceType.New:
                    e.Cancel = !SaveNewUserQuery(childForm);
                    break;
				// in a text file
                case ChildForm.SourceType.File:
                    e.Cancel = !SaveInFile(childForm, false);
                    break;
				// replacing an exising user query 
                case ChildForm.SourceType.UserQuery:
                    e.Cancel = !SaveUserQuery(childForm);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private static bool SaveInFile(ChildForm childForm, bool saveAs)
        {
            if (saveAs || string.IsNullOrEmpty(childForm.FileSourcePath))
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog
                {
                    DefaultExt = "sql",
                    FileName = "query",
                    Filter = @"SQL query files (*.sql)|*.sql|All files|*.*"
                };
                if(saveFileDialog1.ShowDialog() != DialogResult.OK)
                {
                    return false;
                }
                childForm.SqlSourceType = ChildForm.SourceType.File;
                childForm.FileSourcePath = saveFileDialog1.FileName;
            }
            using (StreamWriter sw = new StreamWriter(childForm.FileSourcePath))
            {
                sw.Write(childForm.FormattedQueryText);
            }
            return true;
        }

        private bool SaveUserQuery(ChildForm childForm)
        {
                if (childForm.SqlQuery.QueryRoot.IsQueryWithCTE && !childForm.SqlQuery.SQLContext.SyntaxProvider.IsSupportSubQueryCTE())
                {
                    var cannotSaveQuery = "Error: Queries with Common Table Expressions can not be saved to the repository.";
                    MessageBox.Show(cannotSaveQuery, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            if(childForm.UserMetadataStructureItem == null)
            {
                return false;
            }
            if(!UserQueries.IsUserQueryExist(childForm.SqlQuery.SQLContext.MetadataContainer, childForm.UserMetadataStructureItem.MetadataItem.Name))
            {
                return false;
            }
            UserQueries.SaveUserQuery(childForm.SqlQuery.SQLContext.MetadataContainer, childForm.UserMetadataStructureItem, childForm.SqlQuery.SQL, childForm.QueryView.LayoutSQL);
            SaveSettings();
            return true;
        }

	    private bool SaveNewUserQuery(ChildForm childWindow)
	    {
                if (childWindow.SqlQuery.QueryRoot.IsQueryWithCTE && !childWindow.SqlQuery.SQLContext.SyntaxProvider.IsSupportSubQueryCTE())
                {
                    var cannotSaveQuery = "Error: Queries with Common Table Expressions can not be saved to the repository.";
                    MessageBox.Show(cannotSaveQuery, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

	        MetadataStructureItem node;
	        string title;
	        do
	        {
	            QueryNameForm window = new QueryNameForm();
	            if(window.ShowDialog() != DialogResult.OK)
	            {
	                return false;
	            }
	            title = window.QueryName;
	            if(!UserQueries.IsUserQueryExist(childWindow.SqlQuery.SQLContext.MetadataContainer, title))
	            {
	                var atItem = userQueriesView1.SelectedItem ?? userQueriesView1.MetadataStructure;
	                if(!UserQueries.IsFolder(atItem))
	                {
	                    atItem = atItem.Parent;
	                }
	                node = UserQueries.AddUserQuery(childWindow.SqlQuery.SQLContext.MetadataContainer, atItem, title,
	                    childWindow.SqlQuery.SQL, (int) DefaultImageListImageIndices.VirtualObject, childWindow.QueryView.LayoutSQL);
	                break;
	            }

                var path = userQueriesView1.GetPathAtUserQuery(title);
                var message = string.IsNullOrEmpty(path)
                    ? @"The same-named query already exists in the root folder."
                    : string.Format("The same-named query already exists in the \"{0}\" folder.", path);

                MessageBox.Show(message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

	        } while(true);
	        childWindow.SqlSourceType = ChildForm.SourceType.UserQuery;
            childWindow.FileSourcePath = title;
            childWindow.Text = title;
	        childWindow.UserMetadataStructureItem = node;
            SaveSettings();
	        return true;
	    }

		// Saving user queries to the connection settings
	    private void SaveSettings()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                userQueriesView1.ExportToXML(stream);
                stream.Position = 0;

                using (StreamReader reader = new StreamReader(stream))
                {
                    _selectedConnection.UserQueries = reader.ReadToEnd();
                }
            }
            Properties.Settings.Default.XmlFiles = Program.XmlFiles;
            Properties.Settings.Default.Connections = Program.Connections;
            Properties.Settings.Default.Save();
            userQueriesView1.QueryView = null;
        }

        private void addDerivedTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ActiveMdiChild == null) return;
            var form = (ChildForm) ActiveMdiChild;
            form.AddDerivedTable();
        }

        private void addUnionSubqueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null) return;
            var form = (ChildForm)ActiveMdiChild;
            form.AddUnionSubQuery();
        }

        private void copyUnionSubwueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null) return;
            var form = (ChildForm)ActiveMdiChild;
            form.CopyUnionSubQuery();
        }

        private void addObjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null) return;
            var form = (ChildForm)ActiveMdiChild;
            form.AddObject();
        }

        private void queryPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null) return;
            var form = (ChildForm)ActiveMdiChild;
            form.PropertiesQuery();
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var propWindow = new QueryPropertiesForm(_sqlContext, _sqlFormattingOptions);
            propWindow.ShowDialog();
        }

        private void tsbEditMetadata_Click(object sender, EventArgs e)
        {
            QueryBuilder.EditMetadataContainer(_sqlContext.MetadataContainer, _sqlContext.MetadataStructure, _sqlContext.MetadataContainer.LoadingOptions);
        }

        private void userQueriesView1_EditUserQuery(object sender, MetadataStructureItemCancelEventArgs e)
        {
			// Opening the user query in a new query window.
            if(e.MetadataStructureItem == null) return;
            
            ChildForm childWindow = CreateChildForm(e.MetadataStructureItem.MetadataItem.Name);
            childWindow.UserMetadataStructureItem = e.MetadataStructureItem;
            childWindow.SqlSourceType = ChildForm.SourceType.UserQuery;
            childWindow.Show();
            childWindow.Activate();
            childWindow.QueryText = ((MetadataObject)e.MetadataStructureItem.MetadataItem).Expression.Trim('(', ')');
        }

		// Closing the current query window on deleting the corresponding user query.
        private void userQueriesView1_UserQueryItemRemoved(object sender, MetadataStructureItem item)
        {
            var childWindow = MdiChildren.OfType<ChildForm>().FirstOrDefault(x => x.UserMetadataStructureItem == item);
            if(childWindow != null)
            {
                childWindow.Close();
            }
            SaveSettings();
        }

        private void userQueriesView1_ErrorMessage(object sender, MetadataStructureItemErrorEventArgs eventArgs)
        {
            MessageBox.Show(eventArgs.Message, @"UserQueries error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void userQueriesView1_UserQueryItemRenamed(object sender, MetadataStructureItemTextChangedEventArgs e)
        {
            SaveSettings();
        }

        private void userQueriesView1_ValidateItemContextMenu(object sender, MetadataStructureItemMenuEventArgs e)
        {
            e.Menu.InsertItem(2, "Copy SQL", Execute_SqlExpression, false, true, null,
                ((MetadataObject)e.MetadataStructureItem.MetadataItem).Expression);
        }

	    private static void Execute_SqlExpression(object sender, EventArgs eventArgs)
	    {
	        var item = (ICustomMenuItem)sender;

	        Clipboard.SetText(item.Tag.ToString(), TextDataFormat.UnicodeText);

	        Debug.WriteLine("SQL: {0}", item.Tag);
	    }

        private void toolStripExecuteUserQuery_Click(object sender, EventArgs e)
        {
            if (userQueriesView1.SelectedItem == null) return;

            var childWindow = CreateChildForm(userQueriesView1.SelectedItem.MetadataItem.Name);
            childWindow.UserMetadataStructureItem = userQueriesView1.SelectedItem;
            childWindow.SqlSourceType = ChildForm.SourceType.UserQuery;
            childWindow.Show();
            childWindow.Activate();
            childWindow.QueryText = ((MetadataObject)userQueriesView1.SelectedItem.MetadataItem).Expression.Trim('(', ')');
            childWindow.OpenExecuteTab();
        }

        private void userQueriesView1_SelectedItemChanged(object sender, EventArgs e)
        {
            toolStripExecuteUserQuery.Enabled = userQueriesView1.SelectedItem != null && !userQueriesView1.SelectedItem.IsFolder();
        }
    }
}
