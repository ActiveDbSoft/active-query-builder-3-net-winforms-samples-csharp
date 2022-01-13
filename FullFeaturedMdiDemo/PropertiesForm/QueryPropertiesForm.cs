//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2022 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.Core.PropertiesEditors;
using ActiveQueryBuilder.View;
using ActiveQueryBuilder.View.PropertiesEditors;
using ActiveQueryBuilder.View.WinForms.DatabaseSchemaView;
using ActiveQueryBuilder.View.WinForms.ExpressionEditor;
using ActiveQueryBuilder.View.WinForms.QueryView;
using GeneralAssembly;

namespace FullFeaturedMdiDemo.PropertiesForm
{
    internal partial class QueryPropertiesForm : Form
    {
        private readonly IDictionary<Control, UserControl> _linkToPage1 = new Dictionary<Control, UserControl>();
        private readonly IDictionary<Control, UserControl> _linkToPage2 = new Dictionary<Control, UserControl>();

        private LinkLabel _currentSelectedLink1;
        private LinkLabel _currentSelectedLink2;

        private readonly ChildForm _childForm;
        private readonly DatabaseSchemaView _dbView;
        private readonly TextEditorOptions _textEditorOptions = new TextEditorOptions();
        private readonly SqlTextEditorOptions _textEditorSqlOptions = new SqlTextEditorOptions();

        private bool _structureOptionsChanged = false;

        private void RegisterPropertyPage(Control link, ObjectProperties propertiesObject)
        {
            var propertiesContainer = PropertiesFactory.GetPropertiesContainer(propertiesObject);

            // create property page control
            var propertyPage = new PropertiesBar
            {
                EditorsOptions =
                {
                    WideEditControlsMaxWidth = ScreenHelpers.ScaleByCurrentDPI(225),
                    WideEditControlsMinWidth = ScreenHelpers.ScaleByCurrentDPI(100),
                    ShowDescriptions = true
                }
            };

            // set properties to property page
            var propertiesControl = (IPropertiesControl)propertyPage;
            propertiesControl.SetProperties(propertiesContainer);

            // register link -> propertyPage mapping
            _linkToPage1.Add(link, propertyPage);
        }

        public QueryPropertiesForm(ChildForm childForm, DatabaseSchemaView dbView)
        {
            InitializeComponent();
            LocalizeGroups();
            _childForm = childForm;
            _dbView = dbView;

            _linkToPage1.Add(linkSqlGeneration, new SqlGenerationPage(childForm.SqlGenerationOptions, childForm.SqlFormattingOptions)); 

            // create and register property pages ==================================
            // BehaviorOptions page
            RegisterPropertyPage(linkBehaviorOptions, new ObjectProperties(childForm.BehaviorOptions));
            // DatabaseSchemaViewOptions page
            RegisterPropertyPage(linkDatabaseSchemaView, new ObjectProperties(dbView.Options));
            // DesignPaneOptions page
            RegisterPropertyPage(linkDesignPane, new ObjectProperties(childForm.DesignPaneOptions));
            // VisualOptions page
            RegisterPropertyPage(linkVisualOptions, new ObjectProperties(childForm.VisualOptions));
            // AddObjectDialogOptions page
            RegisterPropertyPage(linkAddObjectDialog, new ObjectProperties(childForm.AddObjectDialogOptions));
            // DataSourceOptions page
            RegisterPropertyPage(linkDatasourceOptions, new ObjectProperties(childForm.DataSourceOptions));
            // QueryColumnListOptions page
            RegisterPropertyPage(linkQueryColumnList, new ObjectProperties(childForm.QueryColumnListOptions));
            // QueryNavBarOptions
            RegisterPropertyPage(linkQueryNavBar, new ObjectProperties(childForm.QueryNavBarOptions));
            // UserInterfaceOptions
            RegisterPropertyPage(linkQueryView, new ObjectProperties(childForm.UserInterfaceOptions));

            RegisterPropertyPage(lbExpressionEditor, new ObjectProperties(childForm.ExpressionEditorOptions));

            _textEditorOptions.Assign(childForm.TextEditorOptions);
            _textEditorOptions.Updated += TextEditorOptionsOnUpdated;
            RegisterPropertyPage(lbTextEditor, new ObjectProperties(_textEditorOptions));

            _textEditorSqlOptions.Assign(childForm.TextEditorSqlOptions);
            _textEditorSqlOptions.Updated += TextEditorOptionsOnUpdated;
            RegisterPropertyPage(lbTextEditorSql, new ObjectProperties(_textEditorSqlOptions));

            childForm.MetadataStructureOptions.Updated += MetadataStructureOptionsOnUpdated;

            // SQL Formatting options ============================
            // main query
            _linkToPage2.Add(linkMain, new MainQueryTab(childForm.SqlFormattingOptions));
            _linkToPage2.Add(linkMainCommon, new CommonTab(childForm.SqlFormattingOptions, childForm.SqlFormattingOptions.MainQueryFormat));
            _linkToPage2.Add(linkMainExpressions, new ExpressionsTab(childForm.SqlFormattingOptions, childForm.SqlFormattingOptions.MainQueryFormat));
            // CTE query
            _linkToPage2.Add(linkCte, new SubQueryTab(childForm.SqlFormattingOptions, SubQueryType.Cte));
            _linkToPage2.Add(linkCteCommon, new CommonTab(childForm.SqlFormattingOptions, childForm.SqlFormattingOptions.CTESubQueryFormat));
            _linkToPage2.Add(linkCteExpressions, new ExpressionsTab(childForm.SqlFormattingOptions, childForm.SqlFormattingOptions.CTESubQueryFormat));
            // Derived table
            _linkToPage2.Add(linkDerived, new SubQueryTab(childForm.SqlFormattingOptions, SubQueryType.Derived));
            _linkToPage2.Add(linkDerivedCommon, new CommonTab(childForm.SqlFormattingOptions, childForm.SqlFormattingOptions.DerivedQueryFormat));
            _linkToPage2.Add(linkDerivedExpressions, new ExpressionsTab(childForm.SqlFormattingOptions, childForm.SqlFormattingOptions.DerivedQueryFormat));
            // expression
            _linkToPage2.Add(linkExpression, new SubQueryTab(childForm.SqlFormattingOptions, SubQueryType.Expression));
            _linkToPage2.Add(linkExpressionCommon, new CommonTab(childForm.SqlFormattingOptions, childForm.SqlFormattingOptions.ExpressionSubQueryFormat));
            _linkToPage2.Add(linkExpressionExpressions, new ExpressionsTab(childForm.SqlFormattingOptions, childForm.SqlFormattingOptions.ExpressionSubQueryFormat));

            // Activate the first page on tab1
            SideMenu1_LinkClicked(linkSqlGeneration,
                new LinkLabelLinkClickedEventArgs(linkSqlGeneration.Links[0], MouseButtons.Left));
            // Activate the first page on tab2
            SideMenu2_LinkClicked(linkMain,
                new LinkLabelLinkClickedEventArgs(linkMain.Links[0], MouseButtons.Left));
        }

        private void LocalizeGroups()
        {
            var localizer = ActiveQueryBuilder.Core.Helpers.Localizer;
            linkBehaviorOptions.Text = localizer.GetString("strBehaviorOptions", LocalizableConstantsInternal.strBehaviorOptions);
            linkDatabaseSchemaView.Text = localizer.GetString("strDatabaseSchemaViewOptions", LocalizableConstantsInternal.strDatabaseSchemaViewOptions);
            linkDesignPane.Text = localizer.GetString("strDesignPaneOptions", LocalizableConstantsInternal.strDesignPaneOptions);
            linkVisualOptions.Text = localizer.GetString("strVisualOptions", LocalizableConstantsInternal.strVisualOptions);
            linkAddObjectDialog.Text = localizer.GetString("strAddObjectDialogOptions", LocalizableConstantsInternal.strAddObjectDialogOptions);
            linkQueryColumnList.Text = localizer.GetString("strQueryColumnListOptions", LocalizableConstantsInternal.strQueryColumnListOptions);
            linkQueryNavBar.Text = localizer.GetString("strQueryNavbarOptions", LocalizableConstantsInternal.strQueryNavbarOptions);
            linkQueryView.Text = localizer.GetString("strUserInterfaceOptions", LocalizableConstantsInternal.strUserInterfaceOptions);
            lbExpressionEditor.Text = localizer.GetString("strExpressionEditorOptions", LocalizableConstantsInternal.strExpressionEditorOptions);
            lbTextEditor.Text = localizer.GetString("strTextEditorOptions", LocalizableConstantsInternal.strTextEditorOptions);
            lbTextEditorSql.Text = localizer.GetString("strTextEditorSqlOptions", LocalizableConstantsInternal.strTextEditorSqlOptions);
        }

        private void MetadataStructureOptionsOnUpdated(object sender, EventArgs eventArgs)
        {
            _structureOptionsChanged = true;
        }

        private void TextEditorOptionsOnUpdated(object sender, EventArgs eventArgs)
        {
            _childForm.TextEditorOptions = _textEditorOptions;
            _childForm.TextEditorSqlOptions = _textEditorSqlOptions;
        }

        private void QueryBuilderPropertiesForm_Paint(object sender, PaintEventArgs e)
        {
            Rectangle r = Rectangle.Inflate(panelQueryBuilder.Bounds, 1, 1);

            e.Graphics.DrawRectangle(SystemPens.ControlDark, r);
        }

        private void SideMenu1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_currentSelectedLink1 != null)
                _currentSelectedLink1.LinkColor = Color.Black;

            _currentSelectedLink1 = (LinkLabel) sender;
            _currentSelectedLink1.LinkColor = Color.Blue;

            SwitchPage1(_linkToPage1[_currentSelectedLink1]);
        }

        private void SideMenu2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_currentSelectedLink2 != null)
                _currentSelectedLink2.LinkColor = Color.Black;

            _currentSelectedLink2 = (LinkLabel)sender;
            _currentSelectedLink2.LinkColor = Color.Blue;

            SwitchPage2(_linkToPage2[_currentSelectedLink2]);
        }

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(SystemColors.ControlDark, 1);
            Point first = new Point(flowLayoutPanel1.ClientRectangle.Right - 1, flowLayoutPanel1.ClientRectangle.Top + 10);
            Point second = new Point(flowLayoutPanel1.ClientRectangle.Right - 1, flowLayoutPanel1.ClientRectangle.Bottom - 10);

            e.Graphics.DrawLine(p, first, second);
        }

        private void SwitchPage1(UserControl page)
        {
            panelPages1.SuspendLayout();
            panelPages1.AutoScrollPosition = new Point(0, 0);
            panelPages1.Controls.Clear();
            page.Location = new Point(10, 10);
            page.Dock = DockStyle.Fill;
            panelPages1.Controls.Add(page);
            panelPages1.ResumeLayout();
        }

        private void SwitchPage2(UserControl page)
        {
            panelPages2.SuspendLayout();
            panelPages2.AutoScrollPosition = new Point(0, 0);
            panelPages2.Controls.Clear();
            page.Location = new Point(10, 10);
            page.Dock = DockStyle.Fill;
            panelPages2.Controls.Add(page);
            panelPages2.ResumeLayout();
        }

        private void buttonLoad_Click(object sender, System.EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() != DialogResult.OK) return;

                var options = _childForm.GetOptions();
                options.DeserializeFromFile(dialog.FileName);
            }
        }

        private void buttonSave_Click(object sender, System.EventArgs e)
        {
            using (var catalog = new SaveFileDialog())
            {
                if (catalog.ShowDialog() != DialogResult.OK) return;

                var options = _childForm.GetOptions();
                options.SerializeToFile(catalog.FileName);
            }
        }

        private void QueryPropertiesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.Settings.Options = _childForm.GetOptions().SerializeToString();
            Program.Settings.Save();

            _childForm.TextEditorOptions = _textEditorOptions;
            _childForm.TextEditorSqlOptions = _textEditorSqlOptions;
            if (_structureOptionsChanged)
                _dbView.InitializeDatabaseSchemaTree();
        }
    }
}
