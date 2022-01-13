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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View;
using ActiveQueryBuilder.View.DatabaseSchemaView;
using ActiveQueryBuilder.View.EventHandlers.MetadataStructureItems;
using ActiveQueryBuilder.View.ExpressionEditor;
using ActiveQueryBuilder.View.WinForms;
using ActiveQueryBuilder.View.WinForms.ExpressionEditor;
using GeneralAssembly.Common;
using DragEventArgs = ActiveQueryBuilder.View.EventHandlers.DragEventArgs;

namespace ExpressionEditorDemo
{
    public partial class ExpressionEditorControl : UserControl
    {
        private Rectangle _dragBoxFromMouseDown;
        private readonly CompositeDisposable _querySubscriptions = new CompositeDisposable();
        private readonly CompositeDisposable _contextSubscriptions = new CompositeDisposable();
        private readonly Dictionary<MetadataStructureItem, object> _mapTreeItems =
            new Dictionary<MetadataStructureItem, object>();

        private SQLContext _sqlContext;
        private UnionSubQuery _activeUnionSubQuery;
        private IQueryController _query;
        private BaseSyntaxProvider _syntaxProvider;
        private readonly CompositeDisposable _viewSubscriptions = new CompositeDisposable();

        private readonly ExpressionEditorOptions _options = new ExpressionEditorOptions();
        private readonly SqlTextEditorOptions _textEditorSqlOptions = new SingleLineSqlTextEditorOptions();
        private readonly TextEditorOptions _textEditorOptions = new TextEditorOptions();
        private readonly CompositeDisposable _subscriptions = new CompositeDisposable();

        public event AddCustomKeywordsEventHandler CustomizeKeywords
        {
            add { sqlTextEditor1.CustomizeKeywords += value; }
            remove { sqlTextEditor1.CustomizeKeywords -= value; }
        }
        public event AddCustomFunctionsEventHandler CustomizeFunctions
        {
            add { sqlTextEditor1.CustomizeFunctions += value; }
            remove { sqlTextEditor1.CustomizeFunctions -= value; }
        }
        public event ValidateContextMenuEventHandler ValidateContextMenu
        {
            add { sqlTextEditor1.ValidateContextMenu += value; }
            remove { sqlTextEditor1.ValidateContextMenu -= value; }
        }

        [Browsable(true)]
        [TypeConverter(typeof(ExpandableObjectConverter)), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ExpressionEditorOptions Options
        {
            get { return _options; }
            set { _options.Assign(value); }
        }

        [Browsable(true)]
        [TypeConverter(typeof(ExpandableObjectConverter)), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public SqlTextEditorOptions TextEditorSqlOptions
        {
            get { return _textEditorSqlOptions; }
            set { _textEditorSqlOptions.Assign(value); }
        }

        [Browsable(true)]
        [TypeConverter(typeof(ExpandableObjectConverter)), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public TextEditorOptions TextEditorOptions
        {
            get { return _textEditorOptions; }
            set { _textEditorOptions.Assign(value); }
        }

        [Browsable(false)]
        [Category("Editor")]
        public string Expression
        {
            get { return sqlTextEditor1.Text; }
            set { sqlTextEditor1.Text = value; }
        }

        [Browsable(false)]
        public AstNode ExpressionAST
        {
            set
            {
                var formattingOptions = SQLFormattingOptions ??
                                        new SQLFormattingOptions
                                        {
                                            UseAltNames = SQLGenerationOptions.UseAltNames,
                                            QuoteIdentifiers = SQLGenerationOptions.QuoteIdentifiers,
                                        };
                Expression = value != null && Query != null ? value.GetSQL(formattingOptions) : string.Empty;
            }
        }

        [Browsable(false)]
        public UnionSubQuery ActiveUnionSubQuery
        {
            get { return _activeUnionSubQuery; }
            set
            {
                if (_activeUnionSubQuery == value)
                    return;

                _activeUnionSubQuery = value;

                if (_activeUnionSubQuery != null)
                {
                    ReloadQueryObjects();
                }
            }
        }

        [Browsable(true)]
        [DefaultValue(null)]
        public IQueryController Query
        {
            get { return _query; }
            set
            {
                if (_query == value)
                    return;

                _querySubscriptions.Clear();

                _query = value;
                sqlTextEditor1.Query = _query;

                if (_query != null)
                {
                    _query.SQLContextChanged += Query_SQLContextChanged;
                    _querySubscriptions.Add(Disposable.Create(() => _query.SQLContextChanged -= Query_SQLContextChanged));

                    if (_query.SQLContext != null)
                        SQLContext = _query.SQLContext;
                }
            }
        }

        [Browsable(true)]
        [DefaultValue(null)]
        public SQLContext SQLContext
        {
            get { return _sqlContext; }
            set
            {
                if (_sqlContext == value)
                    return;

                UnsubscribeFromContext();

                _sqlContext = value;
                sqlTextEditor1.SQLContext = value;
                treeQueryObjects.SQLContext = SQLContext;
                treeObjects.SQLContext = SQLContext;

                if (_sqlContext == null) return;

                SubscribeToContext(_sqlContext);
                SyntaxProvider = GetSyntaxFromContext(_sqlContext);
                ReloadMetadata();
            }
        }

        public BaseSyntaxProvider SyntaxProvider
        {
            get { return _syntaxProvider; }
            private set
            {
                if (_syntaxProvider == value)
                    return;

                _syntaxProvider = value;

                if (_syntaxProvider == null)
                    return;

                if (Query != null && !Query.IsDisposing)
                {
                    ReloadOperators();
                    ReloadFunctions();
                }
            }
        }

        [Category("Editor Colors")]
        public new Color BackColor
        {
            get { return sqlTextEditor1.BackColor; }
            set { sqlTextEditor1.BackColor = value; }
        }

        private bool ShouldSerializeBackColor()
        {
            return BackColor != Color.Empty;
        }

        public override void ResetBackColor()
        {
            BackColor = Color.Empty;
        }

        [Browsable(false)]
        public SQLGenerationOptions SQLGenerationOptions
        {
            get { return sqlTextEditor1.SQLGenerationOptions; }
            set { sqlTextEditor1.SQLGenerationOptions = value; }
        }

        [Browsable(true)]
        [Category("Editor")]
        public SQLFormattingOptions SQLFormattingOptions { get; set; }

        [Browsable(true)]
        [Category("Editor")]
        [DefaultValue(IdentQuotation.IfNeed)]
        public IdentQuotation QuoteIdentifiers
        {
            get { return SQLGenerationOptions.QuoteIdentifiers; }
            set
            {
                SQLGenerationOptions.QuoteIdentifiers = value;
                SQLFormattingOptions.QuoteIdentifiers = value;
            }
        }

        [Browsable(true)]
        [Category("Editor")]
        [DefaultValue(true)]
        [Description("If metadata objects has the alt name specified, use it in the suggesion list instead of the real object name.")]
        public bool UseAltNames
        {
            get { return SQLGenerationOptions.UseAltNames; }
            set
            {
                SQLGenerationOptions.UseAltNames = value;
                SQLFormattingOptions.UseAltNames = value;
            }
        }

        public ExpressionEditorControl()
        {
            InitializeComponent();

            RefreshCaptions();

            var il = new ImageList
            {
                ColorDepth = ColorDepth.Depth32Bit
            };

            il.Images.Add(ActiveQueryBuilder.View.WinForms.Images.Metadata.Field.Value);         // 0
            il.Images.Add(ActiveQueryBuilder.View.WinForms.Images.Metadata.UserTable.Value);     // 1
                           
            il.Images.Add(ActiveQueryBuilder.View.WinForms.Images.Metadata.UserProcedure.Value); // 3
            il.Images.Add(ActiveQueryBuilder.View.WinForms.Images.Metadata.UserSynonym.Value);   // 4
            il.Images.Add(ActiveQueryBuilder.View.WinForms.Images.TextEditor.Function.Value);    // 5

            SetImageList(il);

            treeObjects.ItemDoubleClick += TreeObjects_ItemDoubleClick;
            _viewSubscriptions.Add(Disposable.Create(() => treeObjects.ItemDoubleClick -= TreeObjects_ItemDoubleClick));

            treeObjects.ValidateItemContextMenu += OnTreeObjectsValidateItemContextMenu;
            _viewSubscriptions.Add(Disposable.Create(() => treeObjects.ValidateItemContextMenu -= OnTreeObjectsValidateItemContextMenu));

            treeQueryObjects.ItemDoubleClick += TreeQueryObjects_ItemDoubleClick;
            _viewSubscriptions.Add(Disposable.Create(() => treeQueryObjects.ItemDoubleClick -= TreeQueryObjects_ItemDoubleClick));

            treeQueryObjects.ValidateItemContextMenu += OnQueryObjectTreeValidateItemContextMenu;
            _viewSubscriptions.Add(Disposable.Create(() => treeQueryObjects.ValidateItemContextMenu -= OnQueryObjectTreeValidateItemContextMenu));

            treeFunctions.DoubleClick += TreeFunctions_DoubleClick;
            _viewSubscriptions.Add(Disposable.Create(() => treeFunctions.DoubleClick -= TreeFunctions_DoubleClick));

            treeFunctions.DrawMode = TreeViewDrawMode.Normal;

            treeFunctions.DrawNode += TreeFunctions_DrawNode;
            _viewSubscriptions.Add(Disposable.Create(() => treeFunctions.DrawNode -= TreeFunctions_DrawNode));

            treeFunctions.MouseDown += TreeFunctions_MouseDown;
            _viewSubscriptions.Add(Disposable.Create(() => treeFunctions.MouseDown -= TreeFunctions_MouseDown));

            treeFunctions.MouseUp += TreeFunctions_MouseUp;
            _viewSubscriptions.Add(Disposable.Create(() => treeFunctions.MouseUp -= TreeFunctions_MouseUp));

            treeFunctions.MouseMove += TreeFunctions_MouseMove;
            _viewSubscriptions.Add(Disposable.Create(() => treeFunctions.MouseMove -= TreeFunctions_MouseMove));
            treeFunctions.KeyDown += TreeFunctions_KeyDown;

            tbFilterForFunctions.KeyDown += FilterForFunctions_KeyDown;
            _viewSubscriptions.Add(Disposable.Create(() => tbFilterForFunctions.KeyDown -= FilterForFunctions_KeyDown));

            BindIcons();

            sqlTextEditor1.PreProcessDragDrop += SqlTextEditor_OnPreProcessDragDrop;
            _subscriptions.Add(Disposable.Create(() => sqlTextEditor1.PreProcessDragDrop -= SqlTextEditor_OnPreProcessDragDrop));

            Assign(_options);
            sqlTextEditor1.Options = _textEditorOptions;

            treeObjects.Options.SortingType = ObjectsSortingType.NameExceptFields;
            treeQueryObjects.Options.SortingType = ObjectsSortingType.NameExceptFields;

            treeQueryObjects.SQLGenerationOptions.UseAltNames = true;

            treeObjects.SQLContext = SQLContext;
            treeQueryObjects.SQLContext = SQLContext;

            Disposed += ExpressionEditorControl_Disposed;
        }

        private void ExpressionEditorControl_Disposed(object sender, EventArgs e)
        {
            Disposed -= ExpressionEditorControl_Disposed;

            _querySubscriptions.Dispose();
            _contextSubscriptions.Dispose();
            _viewSubscriptions.Dispose();
        }

        public void Assign(IExpressionEditorOptions options)
        {
            switch (options.DatabaseSchemaViewPanelDocking)
            {
                case SidePanelDockStyle.Left:
                    dockPanelDatabaseSchema.Docking = Docking.Left;
                    break;
                case SidePanelDockStyle.Right:
                    dockPanelDatabaseSchema.Docking = Docking.Right;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            dockPanelDatabaseSchema.AutoHide = !options.DatabaseSchemaViewPanelPinned;

            switch (options.SqlContextPanelDocking)
            {
                case SidePanelDockStyle.Left:
                    dockPanelSqlContext.Docking = Docking.Left;

                    break;
                case SidePanelDockStyle.Right:
                    dockPanelSqlContext.Docking = Docking.Right;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            dockPanelSqlContext.AutoHide = !options.SqlContextPanelPinned;

            treeObjects.Options.SearchFields = options.SearchFields;
        }

        public void AssignTextEditorOptions(ITextEditorOptions options)
        {
            sqlTextEditor1.Options.Assign(options);
        }

        public void AssignSqlTextEditorOptions(ISqlTextEditorOptions options)
        {
            sqlTextEditor1.SqlOptions.Assign(options);
        }

        public void InsertMetadataItemNameIntoEditor(MetadataItem metadataItem)
        {
            InsertTextIntoEditor(GetNameMetadataItem(metadataItem, false));
        }

        public void InsertTextIntoEditor(string text)
        {
            int cursor = text.IndexOf("%CURSOR%", StringComparison.Ordinal);

            if (cursor != -1)
                text = text.Replace("%CURSOR%", "");

            int start = sqlTextEditor1.SelectionStart;

            sqlTextEditor1.ReplaceSelection(text);

            if (cursor != -1)
                sqlTextEditor1.SelectionStart = start + cursor;

            sqlTextEditor1.Focus();
        }

        public void ShowInformationMessage(string message)
        {
            pnlNotification.InfoText = message;
            pnlNotification.Visible = true;
        }

        public void HideInformationMessage()
        {
            pnlNotification.Hide();
        }

        private void UnsubscribeFromContext()
        {
            _contextSubscriptions.Clear();
        }

        private void SubscribeToContext(SQLContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            context.SyntaxProviderChanged += SQLContext_SyntaxProviderChanged;
            _contextSubscriptions.Add(Disposable.Create(() =>
                context.SyntaxProviderChanged -= SQLContext_SyntaxProviderChanged));

            context.Disposing += SQLContext_Disposing;
            _contextSubscriptions.Add(Disposable.Create(() => context.Disposing -= SQLContext_Disposing));

            var metadataContainer = context.MetadataContainer;
            if (metadataContainer != null)
            {
                metadataContainer.Updated += MetadataContainer_Updated;
                _contextSubscriptions.Add(Disposable.Create(() => metadataContainer.Updated -= MetadataContainer_Updated));

                metadataContainer.Disposing += MetadataContainer_Disposing;
                _contextSubscriptions.Add(Disposable.Create(() => metadataContainer.Disposing -= MetadataContainer_Disposing));
            }
        }

        private void SQLContext_SyntaxProviderChanged(object sender, EventArgs e)
        {
            SyntaxProvider = GetSyntaxFromContext(SQLContext);
        }

        private void SQLContext_Disposing(object sender, EventArgs e)
        {
            SQLContext = null;
        }

        private void MetadataContainer_Updated(object sender, EventArgs e)
        {
            if (Query != null && !Query.IsDisposing)
            {
                ReloadMetadata();
            }
        }

        private void MetadataContainer_Disposing(object sender, EventArgs e)
        {
            ((MetadataContainer)sender).Updated -= MetadataContainer_Updated;
            ((MetadataContainer)sender).Disposing -= MetadataContainer_Disposing;
        }

        private BaseSyntaxProvider GetSyntaxFromContext(SQLContext context)
        {
            if (context?.SyntaxProvider == null)
                return null;

            var autoSyntaxProvider = context.SyntaxProvider as AutoSyntaxProvider;
            return autoSyntaxProvider != null ? autoSyntaxProvider.DetectedSyntaxProvider : context.SyntaxProvider;

        }

        private void Query_SQLContextChanged(object sender, EventArgs eventArgs)
        {
            QueryRoot query = (QueryRoot)sender;

            SQLContext = query.SQLContext;
        }

        private void SqlTextEditor_OnPreProcessDragDrop(object sender, DragEventArgs eventArgs)
        {
            var metadataDragObject = GetDragObject<MetadataDragObject>(eventArgs.Data);

            if (metadataDragObject != null)
            {
                foreach (var metadataStructureItem in metadataDragObject.MetadataStructureItems)
                    InsertTextIntoEditor(GetNameFromMetadataStructureItem(metadataStructureItem));
            }
            else
            {
                var text = GetDragObject<string>(eventArgs.Data);

                if (!string.IsNullOrEmpty(text))
                    InsertTextIntoEditor(text);
            }

            eventArgs.Handled = true;
        }

        private void TreeFunctions_DoubleClick(object sender, EventArgs e)
        {
            var tag = GetNodeTag(treeFunctions.SelectedNode);

            if (tag != null)
            {
                InsertTextIntoEditor(((AdvancedKeywordInfo)tag).Template);
            }
        }

        private void TreeQueryObjects_ItemDoubleClick(object sender, MetadataStructureItem structureItem)
        {
            InsertTextIntoEditor(GetNameFromMetadataStructureItem(structureItem));
        }

        private void TreeObjects_ItemDoubleClick(object sender, MetadataStructureItem metadataStructureItem)
        {
            var name = GetNameMetadataItem(metadataStructureItem.MetadataItem, true);
            InsertTextIntoEditor(name);
        }

        private string GetNameFromMetadataStructureItem(MetadataStructureItem structureItem)
        {
            if (structureItem.MetadataItem == null)
            {
                return structureItem.Caption;
            }

            string insertString;

            if (structureItem.MetadataItem is MetadataField)
            {
                var nameField = GetNameMetadataItem(structureItem.MetadataItem, false);

                var mapItem =
                    (_mapTreeItems.ContainsKey(structureItem.Parent) ? _mapTreeItems[structureItem.Parent] : null) as DataSource;

                var nameObject = mapItem?.AliasAST != null ?
                    mapItem.NameInQuery :
                    GetNameMetadataItem(structureItem.MetadataItem.Parent, mapItem == null);

                insertString = $"{nameObject}.{nameField}";
            }
            else
            {
                var mapItem =
                    (_mapTreeItems.ContainsKey(structureItem) ? _mapTreeItems[structureItem] : null) as DataSource;

                insertString = mapItem?.AliasAST != null
                    ? mapItem.NameInQuery
                    : GetNameMetadataItem(structureItem.MetadataItem, mapItem == null);
            }

            return insertString;
        }

        private string GetNameMetadataItem(MetadataItem metadataItem, bool isFullName)
        {
            if (metadataItem == null)
                return "";

            return metadataItem.GetQualifiedNameSQL(isFullName ? null : metadataItem.Parent, SQLGenerationOptions, ObjectPrefixSkipping.SkipAll);

        }

        private static object GetNodeTag(object node) => ((TreeNode)node)?.Tag;

        private void ReloadMetadata()
        {
            ShowWaitCursor();
            try
            {
                var metadataStructure = new MetadataStructure
                {
                    Options =
                    {
                        GroupBySchemas = true,
                        GroupByTypes = true
                    },
                    MetadataItem = SQLContext.MetadataContainer
                };
                metadataStructure.LoadChildItems();

                FillObjectTree(metadataStructure);
            }
            finally
            {
                ResetCursor();
            }
        }

        private void ReloadQueryObjects()
        {
            if (ActiveUnionSubQuery == null)
                return;

            _mapTreeItems.Clear();

            var metadataStructure = new MetadataStructure() { AllowChildAutoItems = false };

            List<DataSource> listDataSource = ActiveUnionSubQuery.GetVisibleDataSources();

            foreach (var dataSource in listDataSource)
            {
                var itemStructure = new MetadataStructureItem { MetadataItem = dataSource.MetadataObject };

                _mapTreeItems.Add(itemStructure, dataSource);

                if (dataSource.AliasAST != null && !(dataSource is DataSourceQuery))
                {
                    itemStructure.Caption = dataSource.NameInQuery + " (" +
                                            dataSource.GetObjectNameInQuery(SQLGenerationOptions) + ")";
                }

                if (dataSource.MetadataObject == null)
                {
                    if (string.IsNullOrEmpty(itemStructure.Caption))
                        itemStructure.Caption = dataSource.NameInQuery;

                    itemStructure.ImageIndex = 5;

                    foreach (var field in dataSource.Metadata.Fields)
                    {
                        var metadataItemField = new MetadataStructureItem { ImageIndex = 11 };
                        _mapTreeItems.Add(metadataItemField, field);

                        if (SQLGenerationOptions.UseAltNames && !string.IsNullOrEmpty(field.AltName))
                            metadataItemField.Caption = field.AltName;
                        else
                            metadataItemField.Caption = field.Name;

                        itemStructure.Items.Add(metadataItemField);
                    }
                }

                metadataStructure.Items.Add(itemStructure);
            }

            FillQueryObjectsTree(metadataStructure);
        }

        private void ReloadOperators()
        {
            List<string> operatorList = new List<string>();

            SyntaxProvider?.GetComparisonOperators(operatorList);

            FillOperators(operatorList);
        }

        private void ReloadFunctions()
        {
            bool filtering = cbFilterFunctions.Checked;
            string filter = tbFilterForFunctions.Text;
            List<NodeData> newNodes = new List<NodeData>();

            if (Query != null)
            {
                foreach (KeyValuePair<string, AdvancedKeywordInfo> kvp in sqlTextEditor1.SuggestionObjects.Functions)
                {
                    if (filtering)
                    {
                        if (filter.Length <= 0) continue;

                        if (kvp.Key.IndexOf(filter, StringComparison.InvariantCultureIgnoreCase) == -1) continue;

                        var node = new NodeData(kvp.Value.Name)
                        {
                            Tag = kvp.Value,
                            ImageIndex = 5,
                            ToolTipText = TextHelpers.Wrap(kvp.Value.Description, 120)
                        };

                        newNodes.Add(node);
                    }
                    else
                    {
                        NodeData node = new NodeData(kvp.Value.Name)
                        {
                            Tag = kvp.Value,
                            ImageIndex = 5,
                            ToolTipText = TextHelpers.Wrap(kvp.Value.Description, 120)
                        };

                        newNodes.Add(node);
                    }
                }
            }

            FillFunctionsTree(newNodes);
        }

        private void BindIcons()
        {
            _subscriptions.Add(ActiveQueryBuilder.View.WinForms.Images.Common.Filter.Subscribe(x => cbFilterFunctions.Image = x));
            _subscriptions.Add(ActiveQueryBuilder.View.WinForms.Images.Common.Find.Subscribe(x => pictureBox2.Image = x));
        }

        private void TreeFunctions_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyData & Keys.F3) != Keys.F3) return;

            if (string.IsNullOrEmpty(tbFilterForFunctions.Text)) return;

            var index = e.Shift
                ? treeFunctions.SelectedNode.Index - 1
                : treeFunctions.SelectedNode.Index + 1;

            while (index > 0 && index < treeFunctions.GetNodeCount(false))
            {
                var node = treeFunctions.Nodes[index];

                if (!node.Text.ToLowerInvariant().Contains(tbFilterForFunctions.Text.ToLowerInvariant()))
                {
                    if (!e.Shift)
                        index++;
                    else
                        index--;
                    continue;
                }

                if (treeFunctions.SelectedNode != node)
                {
                    treeFunctions.SelectedNode = node;
                    node.EnsureVisible();
                }

                break;
            }
        }

        private void RefreshCaptions()
        {
            dockPanelSqlContext.Text = ActiveQueryBuilder.View.Helpers.Localizer.GetString("strSqlContextPanelTitle", LocalizableConstantsUI.strSqlContextPanelTitle);
            dockPanelDatabaseSchema.Text = ActiveQueryBuilder.View.Helpers.Localizer.GetString("strDatabaseSchemaPanelTitle", LocalizableConstantsUI.strDatabaseSchemaPanelTitle);

        }

        private void SetImageList(object imageList)
        {
            treeFunctions.ImageList = (ImageList)imageList;
        }

        private void FilterForFunctions_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyData & Keys.F3) != Keys.F3) return;
            treeFunctions.Focus();
            TreeFunctions_KeyDown(treeFunctions, e);

        }

        private void TreeFunctions_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            Color backColor = ((e.State & TreeNodeStates.Selected) == TreeNodeStates.Selected)
                                  ? SystemColors.Highlight
                                  : treeFunctions.BackColor;
            Color textColor = ((e.State & TreeNodeStates.Selected) == TreeNodeStates.Selected)
                                  ? SystemColors.HighlightText
                                  : treeFunctions.ForeColor;

            Rectangle textRect = e.Bounds;
            textRect.Width = treeFunctions.ClientRectangle.Right - textRect.Left - 1;

            using (Brush b = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(b, textRect);
            }

            textRect.Inflate(-2, 0);

            TextRenderer.DrawText(e.Graphics, e.Node.Text, treeFunctions.Font, textRect, textColor,
                                  TextFormatFlags.NoPrefix | TextFormatFlags.SingleLine | TextFormatFlags.VerticalCenter |
                                  TextFormatFlags.NoPadding);

            String filter = tbFilterForFunctions.Text;
            int x = e.Node.Text.IndexOf(filter, StringComparison.InvariantCultureIgnoreCase);

            while (!String.IsNullOrEmpty(filter) && x != -1)
            {
                filter = e.Node.Text.Substring(x, filter.Length);

                const TextFormatFlags flags = TextFormatFlags.NoPrefix | TextFormatFlags.SingleLine |
                                              TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding | TextFormatFlags.NoClipping;
                Size preSize = TextRenderer.MeasureText(e.Graphics, e.Node.Text.Substring(0, x), treeFunctions.Font, Size.Empty,
                                                        flags);
                Size filterSize = TextRenderer.MeasureText(e.Graphics, filter, treeFunctions.Font, Size.Empty, flags);

                filterSize.Height = textRect.Height - 2;
                e.Graphics.CopyFromScreen(textRect.X + preSize.Width, textRect.Y + 1,
                                          textRect.X + preSize.Width, textRect.Y + 1, filterSize, CopyPixelOperation.PatInvert);

                int pos = x + filter.Length;
                x = e.Node.Text.IndexOf(filter, pos, StringComparison.Ordinal);
            }
        }

        private void TreeFunctions_MouseDown(object sender, MouseEventArgs e)
        {
            treeFunctions.SelectedNode = treeFunctions.HitTest(e.Location).Node;

            if (treeFunctions.SelectedNode != null)
            {
                Size dragSize = SystemInformation.DragSize;
                _dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
            }
            else
            {
                _dragBoxFromMouseDown = Rectangle.Empty;
            }
        }

        private void TreeFunctions_MouseUp(object sender, MouseEventArgs e)
        {
            _dragBoxFromMouseDown = Rectangle.Empty;

            if (e.Button != MouseButtons.Right) return;

            ICustomContextMenu menu = ControlFactory.Instance.GetCustomContextMenu();

            object tag = GetNodeTag(treeFunctions.HitTest(e.Location).Node);

            var aki = tag as AdvancedKeywordInfo;

            if (aki != null)
                menu.AddItem(
                    ActiveQueryBuilder.View.Helpers.Localizer.GetString("strInsertFunction",
                        LocalizableConstantsUI.strInsertFunction), MenuItem_Clicked, false, true, null, aki.Template);

            CPoint point = GetScreenPoint((Control)sender, e.Location.FromNativePoint());

            if (menu.ItemCount > 0)
                menu.Show(null, point.X, point.Y);
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            InsertTextIntoEditor((string)((ICustomMenuItem)sender).Tag);
        }

        private void TreeFunctions_MouseMove(object sender, MouseEventArgs e)
        {
            var tag = GetNodeTag(treeFunctions.HitTest(e.Location).Node);

            if (tag == null) return;

            if ((e.Button & MouseButtons.Left) != MouseButtons.Left) return;

            if (!ShouldBeginDrag(e.X, e.Y)) return;

            var text = ((AdvancedKeywordInfo)tag).Template;

            if (string.IsNullOrEmpty(text)) return;

            treeFunctions.DoDragDrop(text, CDragDropEffects.Copy | CDragDropEffects.Move);
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            InsertTextIntoEditor(((ISimpleButton)sender).Text);
        }

        private void FillObjectTree(MetadataStructure metadataStructure)
        {
            treeObjects.MetadataStructure = metadataStructure;
            treeObjects.InitializeDatabaseSchemaTree();
        }

        private void FillQueryObjectsTree(MetadataStructure metadataStructure)
        {
            treeQueryObjects.MetadataStructure = metadataStructure;
            treeQueryObjects.InitializeDatabaseSchemaTree();
        }

        private void FillOperators(List<string> operatorList)
        {
            foreach (Control control in pnlOperators.Controls)
            {
                if (control is Button)
                    control.Click -= OperatorButton_Click;
            }

            pnlOperators.Controls.Clear();

            if (operatorList.Count > 0)
            {
                foreach (string o in operatorList)
                {
                    ISimpleButton b = ControlFactory.Instance.GetOperatorButton();
                    b.Text = o;
                    b.Click += OperatorButton_Click;
                    pnlOperators.Controls.Add((Control)b);
                }
            }
        }

        private void FillFunctionsTree(List<NodeData> nodes)
        {
            treeFunctions.BeginUpdate();

            try
            {
                treeFunctions.Nodes.Clear();

                foreach (NodeData nodeData in nodes)
                {
                    TreeNode treeNode = new TreeNode(nodeData.Name, nodeData.ImageIndex, nodeData.ImageIndex)
                    {
                        Tag = nodeData.Tag,
                        ToolTipText = nodeData.ToolTipText
                    };
                    treeFunctions.Nodes.Add(treeNode);
                }

                treeFunctions.Sort();
            }
            finally
            {
                treeFunctions.EndUpdate();
            }
        }

        private bool ShouldBeginDrag(double x, double y)
        {
            return !_dragBoxFromMouseDown.IsEmpty && !_dragBoxFromMouseDown.Contains((int)x, (int)y);
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            // Another workaround for Microsoft's NullReferenceException bug of TreeView in custom draw mode
            // http://www.beta.microsoft.com/VisualStudio/feedback/details/553204/treeview-nullreferenceexception-with-drawmode-ownerdraw-xxx
            treeFunctions.DrawMode = Visible ? TreeViewDrawMode.OwnerDrawText : TreeViewDrawMode.Normal;

            base.OnVisibleChanged(e);
        }

        private void ShowWaitCursor()
        {
            Cursor = Cursors.WaitCursor;
        }

        private CPoint GetScreenPoint(Control control, CPoint point)
        {
            return control.PointToScreen(point.ToNativePoint()).FromNativePoint();
        }

        private static T GetDragObject<T>(object dragObject) where T : class
        {
            var dr = dragObject as DataObject;

            return dr?.GetData(typeof(T)) as T;
        }

        private void OnTreeObjectsValidateItemContextMenu(object sender, MetadataStructureItemMenuEventArgs e)
        {
            var metadataItem = e.MetadataStructureItem.MetadataItem;

            if (metadataItem == null) return;

            e.Menu.AddItem(ActiveQueryBuilder.View.Helpers.Localizer.GetString("strInsertName", LocalizableConstantsUI.strInsertName), MenuItem_Clicked, false, true, null, GetNameMetadataItem(metadataItem, false));
            e.Menu.AddItem(ActiveQueryBuilder.View.Helpers.Localizer.GetString("strInsertFullName", LocalizableConstantsUI.strInsertFullName), MenuItem_Clicked, false, true, null, GetNameMetadataItem(metadataItem, true));
        }

        private void OnQueryObjectTreeValidateItemContextMenu(object sender, MetadataStructureItemMenuEventArgs e)
        {
            var metadataItem = e.MetadataStructureItem.MetadataItem;
            var mappedObject = _mapTreeItems.ContainsKey(e.MetadataStructureItem) ? _mapTreeItems[e.MetadataStructureItem] : null;

            if (metadataItem == null)
            {
                var dataSource = mappedObject as DataSource;
                if (dataSource != null)
                {
                    if (dataSource.AliasAST != null)
                    {
                        e.Menu.AddItem(ActiveQueryBuilder.View.Helpers.Localizer.GetString("strInsertAlias", LocalizableConstantsUI.strInsertAlias), MenuItem_Clicked, false, true, null, dataSource.NameInQuery);
                        e.Menu.AddItem(ActiveQueryBuilder.View.Helpers.Localizer.GetString("strInsertName", LocalizableConstantsUI.strInsertName), MenuItem_Clicked, false, true, null,
                            dataSource.GetObjectNameInQuery(SQLGenerationOptions));
                    }
                    else
                    {
                        e.Menu.AddItem(ActiveQueryBuilder.View.Helpers.Localizer.GetString("strInsertName", LocalizableConstantsUI.strInsertName), MenuItem_Clicked, false, true, null, dataSource.NameInQuery);
                    }
                }

                var field = mappedObject as MetadataField;

                if (field != null)
                {
                    e.Menu.AddItem(ActiveQueryBuilder.View.Helpers.Localizer.GetString("strInsertName",  LocalizableConstantsUI.strInsertName), MenuItem_Clicked, false, true, null, field.Name);
                }
            }
            else
            {
                if (mappedObject == null)
                {
                    e.Menu.AddItem(ActiveQueryBuilder.View.Helpers.Localizer.GetString("strInsertName",  LocalizableConstantsUI.strInsertName), MenuItem_Clicked, false, true, null, GetNameMetadataItem(metadataItem, false));
                }
                else
                {
                    var dataSource = mappedObject as DataSource;
                    if (dataSource != null)
                    {
                        if (dataSource.AliasAST != null)
                        {
                            e.Menu.AddItem(ActiveQueryBuilder.View.Helpers.Localizer.GetString("strInsertAlias",  LocalizableConstantsUI.strInsertAlias), MenuItem_Clicked, false, true, null, dataSource.NameInQuery);
                        }

                        e.Menu.AddItem(ActiveQueryBuilder.View.Helpers.Localizer.GetString("strInsertName", LocalizableConstantsUI.strInsertName), MenuItem_Clicked, false, true, null, GetNameMetadataItem(metadataItem, false));
                    }

                    var field = mappedObject as MetadataField;

                    if (field != null)
                    {
                        e.Menu.AddItem(ActiveQueryBuilder.View.Helpers.Localizer.GetString("strInsertName", LocalizableConstantsUI.strInsertName), MenuItem_Clicked, false, true, null, GetNameMetadataItem(field, false));
                    }
                }
            }
        }

        private void cbFilterFunctions_CheckedChanged(object sender, EventArgs e)
        {
            ReloadFunctions();
        }

        private void tbFilterForFunctions_TextChanged(object sender, EventArgs e)
        {
            ReloadFunctions();
        } 
    }
}
