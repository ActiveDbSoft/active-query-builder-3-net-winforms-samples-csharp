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
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View;
using ActiveQueryBuilder.View.DatabaseSchemaView;
using ActiveQueryBuilder.View.EventHandlers.MetadataStructureItems;
using ActiveQueryBuilder.View.ExpressionEditor;
using ActiveQueryBuilder.View.MetadataStructureView;
using ActiveQueryBuilder.View.WinForms;
using ExpressionEditorDemo.Common;
using Helpers = ActiveQueryBuilder.View.Helpers;

namespace ExpressionEditorDemo
{
    public partial class View : UserControl, IView
    {
        private Rectangle _dragBoxFromMouseDown;

        public event MetadataStructureItemMenuEventHandler ObjectTreeValidateItemContextMenu;
        public event MetadataStructureItemMenuEventHandler QueryObjectTreeValidateItemContextMenu;
        public event MetadataStructureItemEventHandler ObjectTreeDoubleClick;
        public event MetadataStructureItemEventHandler QueryObjectTreeDoubleClick;
        public event EventHandler OperatorButtonClick;
        public event CKeyEventHandler FilterForFunctionsKeyDown;
        public event CKeyEventHandler FunctionTreeKeyDown;
        public event CMouseEventHandler FunctionTreeMouseUp;
        public event CMouseEventHandler FunctionTreeMouseMove;

        public event EventHandler FilterFunctionsChanged
        {
            add { cbFilterFunctions.CheckedChanged += value; }
            remove { cbFilterFunctions.CheckedChanged -= value; }
        }

        public event EventHandler FilterTextForFunctionsChanged;

        public event EventHandler FunctionTreeDoubleClick
        {
            add { treeFunctions.SuperMouseDoubleClick += value; }
            remove { treeFunctions.SuperMouseDoubleClick -= value; }
        }

        private readonly Controller _controller;

        [Browsable(true)]
        [DefaultValue(false)]
        [Category("Editor")]
        [Description("Disables code completion in editor.")]
        public bool DisableCodeCompletion
        {
            get { return _controller.TextEditorDisableCodeCompletion; }
            set { _controller.TextEditorDisableCodeCompletion = value; }
        }

        [Browsable(true)]
        [DefaultValue(false)]
        [Category("Editor")]
        [Description("Enables word wrapping in editor.")]
        public bool WordWrap
        {
            get { return _controller.TextEditorWordWrap; }
            set { _controller.TextEditorWordWrap = value; }
        }

        [Browsable(true)]
        [Category("Editor")]
        public string Expression
        {
            get { return _controller.Expression; }
            set { _controller.Expression = value; }
        }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public AstNode ExpressionAST
        {
            set { _controller.ExpressionAST = value; }
        }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public UnionSubQuery ActiveUnionSubQuery
        {
            get { return _controller.ActiveUnionSubQuery; }
            set { _controller.ActiveUnionSubQuery = value; }
        }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public IQueryController Query
        {
            get { return _controller.Query; }
            set { _controller.Query = value; }
        }

        [Browsable(true)]
        [DefaultValue(true)]
        [Category("Editor")]
        [Description("When and you press ENTER, the new line of text is automatically indented to the same tab stop as the line preceding it. ")]
        public bool AutoIndent
        {
            get { return _controller.TextEditorAutoIndent; }
            set { _controller.TextEditorAutoIndent = value; }
        }

        [Browsable(true)]
        [DefaultValue(false)]
        [Category("Editor")]
        [Description("Always show scroll bars.")]
        public bool ScrollBarsAlwaysVisible
        {
            get { return _controller.TextEditorScrollBarsAlwaysVisible; }
            set { _controller.TextEditorScrollBarsAlwaysVisible = value; }
        }

        [Browsable(true)]
        [DefaultValue(4)]
        [Category("Editor")]
        public int TabSize
        {
            get { return _controller.TextEditorTabSize; }
            set { _controller.TextEditorTabSize = value; }
        }

        [Browsable(true)]
        [DefaultValue(ParenthesesHighlighting.HighlightWithColor)]
        [Category("Editor")]
        [Description("Highlight matching parentheses with color or outline.")]
        public ParenthesesHighlighting HighlightMatchingParentheses
        {
            get { return _controller.TextEditorHighlightMatchingParentheses; }
            set { _controller.TextEditorHighlightMatchingParentheses = value; }
        }

        [Browsable(true)]
        [DefaultValue(true)]
        [Category("Editor")]
        [Description("Auto-insert closing parentheses and quotes.")]
        public bool AutoInsertPairs
        {
            get { return _controller.TextEditorAutoInsertPairs; }
            set { _controller.TextEditorAutoInsertPairs = value; }
        }


        [Browsable(true)]
        [DefaultValue(AutocompletedKeywordsCasing.Uppercase)]
        [Category("Editor")]
        [Description("Case of auto-completed SQL keywords.")]
        public AutocompletedKeywordsCasing AutocompletedKeywordsCasing
        {
            get { return _controller.TextEditorKeywordsCasing; }
            set { _controller.TextEditorKeywordsCasing = value; }
        }

        [Browsable(true)]
        [Category("Editor Colors")]
        [Editor("System.Drawing.Design.ColorEditor, System.Drawing.Design", typeof(UITypeEditor))]
        public Color Background
        {
            get { return (Color)_controller.TextEditorBackColor; }
            set { _controller.TextEditorBackColor = value; }
        }

        [Browsable(true)]
        [DefaultValue(true)]
        [Description("Load object fields on demand when searching through database objects.")]
        public bool LoadFieldsOnSearching
        {
            get { return _controller.LoadFieldsOnSearching; }
            set { _controller.LoadFieldsOnSearching = value; }
        }

        [Browsable(true)]
        [DefaultValue(1)]
        [Category("Editor")]
        [Description("Show suggestion list after count of character typed.")]
        public int ShowSuggestionAfterCharCount
        {
            get { return _controller.TextEditorShowSuggestionAfterCharCount; }
            set { _controller.TextEditorShowSuggestionAfterCharCount = value; }
        }

        [Browsable(true)]
        [TypeConverter(typeof(FlagsEnumConverter))]
        [Category("Editor")]
        [DefaultValue(SuggestionObjectType.All)]
        [Description("Defines entities contained in the editor's suggestion list.")]
        public SuggestionObjectType SuggestionListContent
        {
            get { return _controller.TextEditorSuggestionListContent; }
            set { _controller.TextEditorSuggestionListContent = value; }
        }

        [Browsable(true)]
        [Category("Editor")]
        [DefaultValue(false)]
        [Description("Show database objects on the top of suggestion list before keywords and functions.")]
        public bool KeepMetadataObjectsOnTopOfSuggestionList
        {
            get { return _controller.TextEditorKeepMetadataObjectsOnTopOfSuggestionList; }
            set { _controller.TextEditorKeepMetadataObjectsOnTopOfSuggestionList = value; }
        }

        [Browsable(true)]
        [Category("Editor")]
        [DefaultValue(false)]
        [Description("Load database objects from underlying server before displaying suggestions.")]
        public bool LoadMetadataOnCodeCompletion
        {
            get { return _controller.TextEditorLoadMetadataOnCodeCompletion; }
            set { _controller.TextEditorLoadMetadataOnCodeCompletion = value; }
        }

        [Browsable(true)]
        [Category("Editor")]
        [Editor("System.Drawing.Design.FontEditor, System.Drawing.Design", typeof(UITypeEditor))]
        public object TextEditorFont
        {
            get { return _controller.TextEditorFont; }
            set { _controller.TextEditorFont = value; }
        }

        [Browsable(true)]
        [Category("Editor")]
        public SQLFormattingOptions SQLFormattingOptions
        {
            get { return _controller.SQLFormattingOptions; }
            set { _controller.SQLFormattingOptions = value; }
        }

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

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public SQLGenerationOptions SQLGenerationOptions
        {
            get { return _controller.SQLGenerationOptions; }
            set { _controller.SQLGenerationOptions = value; }
        }

        [Browsable(true)]
        [Category("Editor Colors")]
        [Description("Normal text color")]
        [Editor("System.Drawing.Design.ColorEditor, System.Drawing.Design", typeof(UITypeEditor))]
        public object TextColor
        {
            get { return _controller.TextEditorTextColor; }
            set { _controller.TextEditorTextColor = value; }
        }

        [Browsable(true)]
        [Category("Editor Colors")]
        [Description("Background color of selected text")]
        [Editor("System.Drawing.Design.ColorEditor, System.Drawing.Design", typeof(UITypeEditor))]
        public object SelectionBackColor
        {
            get { return _controller.TextEditorSelectionBackColor; }
            set { _controller.TextEditorSelectionBackColor = value; }
        }

        [Browsable(true)]
        [Category("Editor Colors")]
        [Description("Selected text color")]
        [Editor("System.Drawing.Design.ColorEditor, System.Drawing.Design", typeof(UITypeEditor))]
        public object SelectionTextColor
        {
            get { return _controller.TextEditorSelectionTextColor; }
            set { _controller.TextEditorSelectionTextColor = value; }
        }

        [Browsable(true)]
        [Category("Editor Colors")]
        [Description("Background color of inactive selected text")]
        [Editor("System.Drawing.Design.ColorEditor, System.Drawing.Design", typeof(UITypeEditor))]
        public object InactiveSelectionBackColor
        {
            get { return _controller.TextEditorInactiveSelectionBackColor; }
            set { _controller.TextEditorInactiveSelectionBackColor = value; }
        }

        [Browsable(true)]
        [Category("Editor Colors")]
        [Description("Color of commentaries")]
        [Editor("System.Drawing.Design.ColorEditor, System.Drawing.Design", typeof(UITypeEditor))]
        public object CommentColor
        {
            get { return _controller.TextEditorCommentColor; }
            set { _controller.TextEditorCommentColor = value; }
        }

        [Browsable(true)]
        [Category("Editor Colors")]
        [Description("Color of quoted string constants")]
        [Editor("System.Drawing.Design.ColorEditor, System.Drawing.Design", typeof(UITypeEditor))]
        public object StringColor
        {
            get { return _controller.TextEditorStringColor; }
            set { _controller.TextEditorStringColor = value; }
        }

        [Browsable(true)]
        [Category("Editor Colors")]
        [Description("Color of numbers")]
        [Editor("System.Drawing.Design.ColorEditor, System.Drawing.Design", typeof(UITypeEditor))]
        public object NumberColor
        {
            get { return _controller.TextEditorNumberColor; }
            set { _controller.TextEditorNumberColor = value; }
        }

        [Browsable(true)]
        [Category("Editor Colors")]
        [Description("Color of keywords")]
        [Editor("System.Drawing.Design.ColorEditor, System.Drawing.Design", typeof(UITypeEditor))]
        public object KeywordColor
        {
            get { return _controller.TextEditorKeywordColor; }
            set { _controller.TextEditorKeywordColor = value; }
        }

        [Browsable(true)]
        [Category("Editor Colors")]
        [Description("Color of functions")]
        [Editor("System.Drawing.Design.ColorEditor, System.Drawing.Design", typeof(UITypeEditor))]
        public object FunctionColor
        {
            get { return _controller.TextEditorFunctionColor; }
            set { _controller.TextEditorFunctionColor = value; }
        }

        public bool FilterFunctions
        {
            get { return cbFilterFunctions.Checked; }
        }

        public string FilterTextForFunctions
        {
            get { return tbFilterForFunctions.Text; }
        }

        public IDatabaseSchemaView ObjectsTree
        {
            get
            {
                return treeObjects;
            }
        }

        public IDatabaseSchemaView QueryObjectsTree
		{
			get { return treeQueryObjects; }
		}

		public ITreeViewMod FunctionsTree
		{
			get { return treeFunctions; }
		}


        private void RefreshCaptions()
        {
            dockPanelSqlContext.Text = Helpers.Localizer.GetString("strSqlContextPanelTitle", Constants.strSqlContextPanelTitle);
            dockPanelDatabaseSchema.Text = Helpers.Localizer.GetString("strDatabaseSchemaPanelTitle", Constants.strDatabaseSchemaPanelTitle);

        }
        
		public void LocalizeForm()
		{
            RefreshCaptions();
        }

		public void SetImageList(object imageList)
		{
            treeFunctions.ImageList = (ImageList) imageList;
		}

		public object GetNodeTag(object node)
		{
			return node != null ? ((TreeNode) node).Tag : null;
		}

		public string GetNodeText(object node)
		{
			return ((TreeNode) node).Text;
		}

		private void FilterForFunctions_KeyDown(object sender, KeyEventArgs e)
		{
		    if ((e.KeyData & Keys.F3) == Keys.F3)
		    {
		        treeFunctions.Focus();
		        TreeFunctions_KeyDown(treeFunctions, e);
		        return;
		    }

			if (FilterForFunctionsKeyDown != null) 
				FilterForFunctionsKeyDown(sender, new CKeyEventArgs((CKeys) e.KeyData));
		}

        protected override void OnVisibleChanged(EventArgs e)
        {
            // Another workaround for Microsoft's NullReferenceException bug of TreeView in custom draw mode
            // http://www.beta.microsoft.com/VisualStudio/feedback/details/553204/treeview-nullreferenceexception-with-drawmode-ownerdraw-xxx
            treeFunctions.DrawMode = Visible ? TreeViewDrawMode.OwnerDrawText : TreeViewDrawMode.Normal;

            base.OnVisibleChanged(e);
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

            if (FunctionTreeMouseUp != null)
                FunctionTreeMouseUp(treeFunctions.HitTest(e.Location).Node, new CMouseEventArgs((CMouseButtons)e.Button, e.Clicks, e.X, e.Y, e.Delta));
        }

        private void TreeFunctions_MouseMove(object sender, MouseEventArgs e)
        {
            if (FunctionTreeMouseMove != null)
            {
                FunctionTreeMouseMove(treeFunctions.HitTest(e.Location).Node, new CMouseEventArgs((CMouseButtons)e.Button, e.Clicks, e.X, e.Y, e.Delta));
            }
        }

        private void TreeFunctions_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyData & Keys.F3) != Keys.F3) return;

            if (string.IsNullOrEmpty(FilterTextForFunctions)) return;

            var index = e.Shift
                ? treeFunctions.SelectedNode.Index - 1
                : treeFunctions.SelectedNode.Index + 1;

            while (index > 0 && index < treeFunctions.GetNodeCount(false))
            {
                var node = treeFunctions.Nodes[index];

                if (!node.Text.ToLowerInvariant().Contains(FilterTextForFunctions.ToLowerInvariant()))
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

        private void tbFilterForFunctions_TextChanged(object sender, EventArgs e)
        {
            treeFunctions.Invalidate();

            if (FilterTextForFunctionsChanged != null)
                FilterTextForFunctionsChanged(treeFunctions, EventArgs.Empty);

            foreach (TreeNode node in treeFunctions.Nodes)
            {
                if (!node.Text.ToLowerInvariant().Contains(FilterTextForFunctions.ToLowerInvariant()))
                    continue;
                if (treeFunctions.SelectedNode != node)
                {
                    treeFunctions.SelectedNode = node;
                    node.EnsureVisible();
                }

                break;
            }
        }

		private void OperatorButton_Click(object sender, EventArgs e)
		{
			if (OperatorButtonClick != null)
			{
				OperatorButtonClick(sender, e);
			}
		}

		public void AddTextEditor(object textEditor)
		{
			panel1.Controls.Add((Control) textEditor);
			((Control) textEditor).BringToFront();
		}

	    public void FillObjectTree(MetadataStructure metadataStructure)
	    {
            treeObjects.MetadataStructure = metadataStructure;
            treeObjects.InitializeDatabaseSchemaTree();
        }

	    public void FillQueryObjectsTree(MetadataStructure metadataStructure)
	    {
            treeQueryObjects.MetadataStructure = metadataStructure;
            treeQueryObjects.InitializeDatabaseSchemaTree();
        }		

		public void FillOperators(List<string> operatorList)
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
					pnlOperators.Controls.Add((Control) b);
				}
			}
		}

		public void FillFunctionsTree(List<NodeData> nodes)
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

		public bool ShouldBeginDrag(int x, int y)
		{
			return !_dragBoxFromMouseDown.IsEmpty && !_dragBoxFromMouseDown.Contains(x, y);
		}	

		public void ShowWaitCursor()
		{
			Cursor = Cursors.WaitCursor;
		}

		public CPoint GetScreenPoint(object sender, CPoint point)
		{
			if (sender == treeFunctions)
                return Common.Helpers.FromNativePoint(treeFunctions.PointToScreen(Common.Helpers.ToNativePoint(point)));
			if (sender == treeQueryObjects)
                return Common.Helpers.FromNativePoint(treeQueryObjects.PointToScreen(Common.Helpers.ToNativePoint(point)));

			return	CPoint.Empty;
		}

	    public T GetDragObject<T>(object dragObject) where T : class
	    {
	        var dr = dragObject as DataObject;
	        if (dr == null) return null;

	        return dr.GetData(typeof(T)) as T;
	    }

        private void TreeObjects_ItemDoubleClick(object sender, MetadataStructureItem clickedItem)
        {
            if (ObjectTreeDoubleClick != null)
            {
                ObjectTreeDoubleClick(treeObjects.SchemaView, clickedItem);
            }
        }

        private void TreeQueryObjects_ItemDoubleClick(object sender, MetadataStructureItem clickedItem)
        {
            if (QueryObjectTreeDoubleClick != null)
            {
                QueryObjectTreeDoubleClick(treeObjects.SchemaView, clickedItem);
            }
        }

	    private void OnTreeObjectsValidateItemContextMenu(object sender, MetadataStructureItemMenuEventArgs e)
	    {
	        var handler = ObjectTreeValidateItemContextMenu;
            if (handler != null) handler(sender, e);
	    }

        private void OnQueryObjectTreeValidateItemContextMenu(object sender, MetadataStructureItemMenuEventArgs e)
	    {
	        var handler = QueryObjectTreeValidateItemContextMenu;
	        if (handler != null) handler(this, e);
	    }

        public View()
        {
            InitializeComponent();

            LocalizeForm();


            ImageList il = new ImageList
            {
                ColorDepth = ColorDepth.Depth32Bit
            };
            il.Images.Add(Properties.Resources.field);		// 0
            il.Images.Add(Properties.Resources.table);		// 1
            il.Images.Add(Properties.Resources.view);		// 2
            il.Images.Add(Properties.Resources.procedure);	// 3
            il.Images.Add(Properties.Resources.synonym);	// 4
            il.Images.Add(Properties.Resources.function);	// 5

            SetImageList(il);

            treeObjects.ItemDoubleClick += TreeObjects_ItemDoubleClick;
            treeObjects.ValidateItemContextMenu += OnTreeObjectsValidateItemContextMenu;

            treeQueryObjects.ItemDoubleClick += TreeQueryObjects_ItemDoubleClick;
            treeQueryObjects.ValidateItemContextMenu += OnQueryObjectTreeValidateItemContextMenu;

            treeFunctions.DrawMode = TreeViewDrawMode.Normal;
            treeFunctions.DrawNode += TreeFunctions_DrawNode;
            treeFunctions.MouseDown += TreeFunctions_MouseDown;
            treeFunctions.MouseUp += TreeFunctions_MouseUp;
            treeFunctions.MouseMove += TreeFunctions_MouseMove;
            treeFunctions.KeyDown += TreeFunctions_KeyDown;

            tbFilterForFunctions.KeyDown += FilterForFunctions_KeyDown;

            _controller = new Controller(this);
        }
    }
}
