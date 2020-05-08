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
using System.Drawing;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.Core.Commands;
using ActiveQueryBuilder.Core.PropertiesEditors;
using ActiveQueryBuilder.View;
using ActiveQueryBuilder.View.DatabaseSchemaView;
using ActiveQueryBuilder.View.MetadataEditor;
using ActiveQueryBuilder.View.QueryView;
using ActiveQueryBuilder.View.WinForms;
using ActiveQueryBuilder.View.WinForms.Commands;
using Helpers = ActiveQueryBuilder.View.Helpers;

namespace MetadataEditorDemo.Common
{
	public sealed partial class MetadataEditorControl : UserControl, IMetadataEditorView
    {
		public event EventHandler LoadStart
		{
		    add { _controller.LoadStart += value; }
		    remove { _controller.LoadStart -= value; }
		}

        public event EventHandler LoadStep
        {
            add { _controller.LoadStep += value; }
            remove { _controller.LoadStep -= value; }
        }

        public event EventHandler LoadFinish
        {
            add { _controller.LoadFinish += value; }
            remove { _controller.LoadFinish -= value; }
        }

		private SQLContext _sqlContext;

	    public bool IsChanged
	    {
	        get { return _controller.IsChanged; }
	        set { _controller.IsChanged = value; }
	    }

	    private readonly InformationMessageControl _messageControl;

		private MetadataEditorOptions _metadataEditorOptions = 0;
	    private ToolStripDropDown _fillDropDown = null;
	    private bool _structureTreeVisible = true;

	    public bool OpenContainerLoadFormIfNotConnected { get; set; }

	    private Command _fillStructurePopupOpenCommand;	    

        private readonly CompositeDisposable _subscriptions = new CompositeDisposable();
        private readonly MetadataEditorController _controller;
        private CustomContextMenu _metadataStructureTreeSeparatorMenu;

        #region Interface implemetations

        public IDatabaseSchemaView ContainerView => treeDatabaseSchema;

        public IDatabaseSchemaView StructureView => treeStructure;

        public IPropertiesBar PropertiesBar => propertiesBar;

        public IControlFactory ControlFactory => ActiveQueryBuilder.View.WinForms.ControlFactory.Instance;

        public string Language => Helpers.Localizer.Language;

        public void SetCustomControlToPropertiesBar(object control)
        {
            var c = control as Control;
            if (c == null)
                return;

            c.Dock = DockStyle.Fill;
            propertiesBar.Controls.Add(c);
        }

        public void AppendStructureFilterControl(object control, bool isExpanded)
        {
            var c = control as Control;
            if (c == null)
                return;

            var filterControl = new GroupContainer
            {
                CanCollapse = true,
                Text = Helpers.Localizer.GetString("strMetadataStructureFilter", LocalizableConstantsInternal.strMetadataStructureFilter),
                Dock = DockStyle.Top,
                IsExpanded = isExpanded
            };

            filterControl.AddSecondaryControl(c);

            propertiesBar.Controls.Add(filterControl);
            propertiesBar.Controls.SetChildIndex(filterControl, 0);
        }

        #endregion

        public class ListLog : ILog
        {
            private readonly List<string> _errorList;

            public ListLog(List<string> errorList)
            {
                _errorList = errorList;
            }

            public void Trace(string msg)
            {
                _errorList.Add("Trace: " + msg);
            }

            public void Warning(string msg)
            {
                _errorList.Add("Warn : " + msg);
            }

            public void Error(string msg)
            {
                _errorList.Add("Error: " + msg);
            }

            public void Error(string msg, Exception e)
            {
                Error(msg);
                _errorList.Add(e.ToString());
            }
        }

        public bool HideVirtualObjects
        {
            get { return _controller.HideVirtualObjects;}
            set { _controller.HideVirtualObjects = value; }
        }

	    public bool StructureTreeVisible
	    {
	        get { return _structureTreeVisible; }
	        set
	        {
	            if (_structureTreeVisible == value)
	            {
                    return;
	            }

	            _structureTreeVisible = value;
	            splitContainerInner.Panel1Collapsed = !_structureTreeVisible;
	        }
	    }

        public MetadataEditorOptions MetadataEditorOptions
		{
			get { return _metadataEditorOptions; } 
			set
			{
				if ((value & MetadataEditorOptions.DisableStructurePane) == MetadataEditorOptions.DisableStructurePane
					&& splitContainerInner.Panel1Collapsed == false)
				{
				    StructureTreeVisible = false;

				}
				else if ((value & MetadataEditorOptions.DisableStructurePane) == 0
					&& splitContainerInner.Panel1Collapsed)
				{
				    StructureTreeVisible = true;
				}
			    
                _metadataEditorOptions = value;
			}
		}

		public MetadataEditorControl()
		{
			InitializeComponent();

		    _controller = new MetadataEditorController(this);

            HideVirtualObjects = false;

		    _messageControl = new InformationMessageControl
		    {
		        Anchor = (AnchorStyles.Top | AnchorStyles.Left),
		        BackColor = SystemColors.Control
		    };

		    Controls.Add(_messageControl);

		    _messageControl.FixIssueEvent += MessageControl_FixIssueEvent;
            _messageControl.Closing += MessageControl_Closing;

		    propertiesBar.InformationMessageHost = this;

            treeDatabaseSchema.Options.DefaultExpandMetadataType |= MetadataType.Root;
            treeStructure.Options.DefaultExpandMetadataType |= MetadataType.Root;

            treeDatabaseSchema.Options.DefaultExpandFolderNodes = true;
            treeStructure.Options.DefaultExpandFolderNodes = true;

            SubscribeLocalizableStrings();
		    CreateAndBindCommands();
        }

        private void MessageControl_Closing(object sender, EventArgs eventArgs)
	    {
            _controller.SetCurrentError(null);

	        var element = _messageControl.Owner as ISupportFocusOnError;
            element?.Revert();
        }

	    private void SubscribeLocalizableStrings()
        {
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataEditor.ShowHideMetadataStructureTreeToolTip.Subscribe(x =>toolTip1.SetToolTip(splitContainerOuter, x)));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataEditor.DatabaseSchemaCaption.Subscribe(x => label1.Text = x));
	        _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataEditor.MetadataStructureCaption.Subscribe(x => label2.Text = x));
	        _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataEditor.PropertiesBarCaption.Subscribe(x => lblHeader.Text = x));

	        _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataEditor.GroupByServer.Subscribe(x => cbGroupByServer.Text = x));
	        _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataEditor.GroupByDatabase.Subscribe(x => cbGroupByDatabase.Text = x));
	        _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataEditor.GroupBySchema.Subscribe(x => cbGroupBySchema.Text = x));
	        _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataEditor.GroupByTypes.Subscribe(x => cbGroupByTypes.Text = x));
	        _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataEditor.GenerateObjects.Subscribe(x => cbGenerateObjects.Text = x));
	        _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataEditor.StructureWillBeCleared.Subscribe(x => lbWarningFillStructure.Text = x));
	        _subscriptions.Add(ActiveQueryBuilder.Core.Localization.Common.Proceed.Subscribe(x => btnGenerateStructure.Text = x));
	        _subscriptions.Add(ActiveQueryBuilder.Core.Localization.Common.Cancel.Subscribe(x => btnCancelGenerate.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataEditor.Sort.Subscribe(x => tsmiSortContainer.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataEditor.Sort.Subscribe(x => tsmiSortStructure.Text = x));
        }

        private void CreateAndBindCommands()
	    {
	        _fillStructurePopupOpenCommand = new Command(miFillFromSchema_Click);

            _subscriptions.Add(CommandBinder.Bind(miFillFromSchema, _fillStructurePopupOpenCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.FillStructure, x => miFillFromSchema.Enabled = x));

            _subscriptions.Add(CommandBinder.Bind(tsmiAddStructureItem, _controller.AddStructureItemCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.AddStructureItem, x => tsmiAddStructureItem.Enabled = x));
            _subscriptions.Add(CommandBinder.Bind(tsbStructureAdd, _controller.AddStructureItemCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.AddStructureItem, x => tsbStructureAdd.Enabled = x));
            _subscriptions.Add(CommandBinder.Bind(tsbStructureDelete, _controller.DeleteStructureItemCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.DeleteStructureItem, x => tsbStructureDelete.Enabled = x));
            _subscriptions.Add(CommandBinder.Bind(tsmiDeleteStructureItem, _controller.DeleteStructureItemCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.DeleteStructureItem, x => tsmiDeleteStructureItem.Enabled = x));
            _subscriptions.Add(CommandBinder.Bind(tsbMetadataLoadAll, _controller.LoadContainerCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.LoadEntireContainer, x => tsbMetadataLoadAll.Enabled = x));
            _subscriptions.Add(CommandBinder.Bind(tsbMetadataDelete, _controller.DeleteMetadataItemCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.DeleteMetadataItem, x => tsbMetadataDelete.Enabled = x));
            _subscriptions.Add(CommandBinder.Bind(tsmiDeleteSchema, _controller.DeleteMetadataItemCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.DeleteMetadataItem, x => tsmiDeleteSchema.Enabled = x));

            _subscriptions.Add(CommandBinder.Bind(miAddLinkedServer, _controller.AddLinkedServerCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.AddServer, x => miAddLinkedServer.Enabled = x));
            _subscriptions.Add(CommandBinder.Bind(tsmiAddLinkedServer, _controller.AddLinkedServerCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.AddServer, x => tsmiAddLinkedServer.Visible = x));
            _subscriptions.Add(CommandBinder.Bind(miAddDatabase, _controller.AddDatabaseCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.AddDatabase, x => miAddDatabase.Enabled = x));
            _subscriptions.Add(CommandBinder.Bind(tsmiAddDatabase, _controller.AddDatabaseCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.AddDatabase, x => tsmiAddDatabase.Visible = x));
            _subscriptions.Add(CommandBinder.Bind(miAddSchema, _controller.AddSchemaCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.AddSchema, x => miAddSchema.Enabled = x));
            _subscriptions.Add(CommandBinder.Bind(tsmiAddSchema, _controller.AddSchemaCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.AddSchema, x => tsmiAddSchema.Visible = x));
            _subscriptions.Add(CommandBinder.Bind(miAddPackage, _controller.AddPackageCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.AddPackage, x => miAddPackage.Enabled = x));
            _subscriptions.Add(CommandBinder.Bind(tsmiAddPackage, _controller.AddPackageCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.AddPackage, x => tsmiAddPackage.Visible = x));
            _subscriptions.Add(CommandBinder.Bind(miAddTable, _controller.AddTableCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.AddTable, x => miAddTable.Enabled = x));
            _subscriptions.Add(CommandBinder.Bind(tsmiAddTable, _controller.AddTableCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.AddTable, x => tsmiAddTable.Visible = x));
            _subscriptions.Add(CommandBinder.Bind(miAddView, _controller.AddViewCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.AddView, x => miAddView.Enabled = x));
            _subscriptions.Add(CommandBinder.Bind(tsmiAddView, _controller.AddViewCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.AddView, x => tsmiAddView.Visible = x));
            _subscriptions.Add(CommandBinder.Bind(miAddProcedure, _controller.AddProcedureCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.AddProcedure, x => miAddProcedure.Enabled = x));
            _subscriptions.Add(CommandBinder.Bind(tsmiAddProcedure, _controller.AddProcedureCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.AddProcedure, x => tsmiAddProcedure.Visible = x));
            _subscriptions.Add(CommandBinder.Bind(miAddSynonym, _controller.AddSynonymCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.AddSynonym, x => miAddSynonym.Enabled = x));
            _subscriptions.Add(CommandBinder.Bind(tsmiAddSynonym, _controller.AddSynonymCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.AddSynonym, x => tsmiAddSynonym.Visible = x));
            _subscriptions.Add(CommandBinder.Bind(miAddField, _controller.AddFieldCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.AddField, x => miAddField.Enabled = x));
            _subscriptions.Add(CommandBinder.Bind(tsmiAddField, _controller.AddFieldCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.AddField, x => tsmiAddField.Visible = x));
            _subscriptions.Add(CommandBinder.Bind(miAddForeignKey, _controller.AddForeignKeyCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.AddForeignKey, x => miAddForeignKey.Enabled = x));
            _subscriptions.Add(CommandBinder.Bind(tsmiAddForeignKey, _controller.AddForeignKeyCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.AddForeignKey, x => tsmiAddForeignKey.Visible = x));

            _subscriptions.Add(CommandBinder.Bind(byNameToolStripMenuItem, _controller.SortSchemaByNameCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.SortByName, x => byNameToolStripMenuItem.Visible = x));
            _subscriptions.Add(CommandBinder.Bind(byTypeToolStripMenuItem, _controller.SortSchemaByTypeCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.SortByType, x => byTypeToolStripMenuItem.Visible = x));
            _subscriptions.Add(CommandBinder.Bind(tsmiMoveToTopContainer, _controller.MoveUpSchemaCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.MoveToTop, x => tsmiMoveToTopContainer.Visible = x));
            _subscriptions.Add(CommandBinder.Bind(tsmiMoveToBotContainer, _controller.MoveDownSchemaCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.MoveToBottom, x => tsmiMoveToBotContainer.Visible = x));
            _subscriptions.Add(CommandBinder.Bind(tsmiSortStructureByName, _controller.SortStructureByNameCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.SortByName, x => tsmiSortStructureByName.Visible = x));
            _subscriptions.Add(CommandBinder.Bind(tsmiSortStructureByType, _controller.SortStructureByTypeCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.SortByType, x => tsmiSortStructureByType.Visible = x));
            _subscriptions.Add(CommandBinder.Bind(tsmiMoveStructureToTop, _controller.MoveUpStructureCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.MoveToTop, x => tsmiMoveStructureToTop.Visible = x));
            _subscriptions.Add(CommandBinder.Bind(tsmiMoveStructureToBot, _controller.MoveDownStructureCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.MoveToBottom, x => tsmiMoveStructureToBot.Visible = x));

            _subscriptions.Add(CommandBinder.Bind(miClear, _controller.ClearSchemaCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.ClearChildItems, x => miClear.Enabled = x));
            _subscriptions.Add(CommandBinder.Bind(miStructureClear, _controller.ClearStructureCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.ClearChildItems, x => miStructureClear.Enabled = x));

            _subscriptions.Add(CommandBinder.Bind(miStructureLoadAll, _controller.CreateStructureChildsCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.CreateChildStructure, x => miStructureLoadAll.Enabled = x));

            _subscriptions.Add(CommandBinder.Bind(miLoadAll, _controller.LoadSchemaChildsCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.LoadChildItems, x => miLoadAll.Enabled = x));
            _subscriptions.Add(CommandBinder.Bind(tsmiConnectAndLoad, _controller.ConnectAndLoadCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.ConnectAndLoadChilds, x => tsmiConnectAndLoad.Enabled = x));

            _subscriptions.Add(ActiveQueryBuilder.View.WinForms.Images.Common.Add.Subscribe(x => tsddbAdd.Image = x));
        }

	    public void RefreshContainerTree()
	    {
            treeDatabaseSchema.MetadataStructure.Refresh();
	    }

        public void ShowInformationMessage(object sender, PropertyErrorDescription description)
	    {
            _controller.SetCurrentError(description);

            if (description == null || !description.IsError)
	        {
                _messageControl.Hide();
	            return;
	        }

            _messageControl.Owner = sender;
	        _messageControl.Show(description);
	        _messageControl.Left = (ClientSize.Width - _messageControl.Width) / 2;
	        _messageControl.BringToFront();            
	    }

        private void MessageControl_FixIssueEvent(object sender, EventArgs eventArgs)
        {
            _controller.OnFixIssue(_messageControl.ErrorDescription);
        }

        public void Init(SQLContext sqlContext)
        {            
            _sqlContext = sqlContext;

            using (Disposable.Create(() => Cursor = Cursors.Default))
            {
                Cursor = Cursors.WaitCursor;

                _controller.Init(sqlContext);
            }            

            treeDatabaseSchema.Select();

            treeDatabaseSchema.KeyDown += treeDatabaseSchema_KeyDown;
            _subscriptions.Add(Disposable.Create(() => treeDatabaseSchema.KeyDown -= treeDatabaseSchema_KeyDown));

            treeDatabaseSchema.Enter += treeDatabaseSchema_GotFocus;
            _subscriptions.Add(Disposable.Create(() => treeDatabaseSchema.KeyDown -= treeDatabaseSchema_KeyDown));

            treeDatabaseSchema.DragOver += treeDatabaseSchema_DragOver;
            _subscriptions.Add(Disposable.Create(() => treeDatabaseSchema.KeyDown -= treeDatabaseSchema_KeyDown));

            treeStructure.KeyDown += treeStructure_KeyDown;
            _subscriptions.Add(Disposable.Create(() => treeStructure.KeyDown -= treeStructure_KeyDown));

            treeStructure.Enter += treeStructure_GotFocus;
            _subscriptions.Add(Disposable.Create(() => treeStructure.Enter -= treeStructure_GotFocus));

            menuSchemaTree.Opening += menuSchemaTree_Opening;
            _subscriptions.Add(Disposable.Create(() => menuSchemaTree.Opening -= menuSchemaTree_Opening));

            menuStructureTree.Opening += MenuStructureTree_Opening;
            _subscriptions.Add(Disposable.Create(() => menuStructureTree.Opening -= MenuStructureTree_Opening));

            btnGenerateStructure.Click += btnGenerateStructure_Click;
            _subscriptions.Add(Disposable.Create(() => btnGenerateStructure.Click -= btnGenerateStructure_Click));

            btnCancelGenerate.Click += btnCancelGenerate_Click;
            _subscriptions.Add(Disposable.Create(() => btnCancelGenerate.Click -= btnCancelGenerate_Click));

            Resize += OnResize;
            _subscriptions.Add(Disposable.Create(() => Resize -= OnResize));
        }

	    private void OnResize(object sender, EventArgs eventArgs)
	    {
	        _messageControl.Left = (ClientSize.Width - _messageControl.Width) / 2;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _subscriptions.Dispose();
                components?.Dispose();
            }

            base.Dispose(disposing);
        }

	    private void MenuStructureTree_Opening(object sender, CancelEventArgs cancelEventArgs)
	    {
	        var focusedItem = treeStructure.FocusedItem;
	        tsmiSortStructure.Visible = focusedItem?.Parent != null;

            _controller.UpdateStructureCommands();
        }

	    public void StopLoading()
		{
			_controller.StopLoading();
		}

	    public bool ConfirmItemDeletion()
	    {
	        return MessageBox.Show(
	                   Helpers.Localizer.GetString("strDeleteItemConfirmation",
	                       LocalizableConstantsUI.strDeleteItemConfirmation),
	                   Helpers.Localizer.GetString("strConfirmation", LocalizableConstantsUI.strConfirmation),
	                   MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes;

	    }

        private void tsbMetadataDelete_Click()
	    {
	        if (ConfirmItemDeletion())
	            _controller.DeleteSelectedContainerItems();
		}

        private void treeDatabaseSchema_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Delete:
					tsbMetadataDelete_Click();
					break;
				case Keys.Insert:
					_controller.InsertDefaultContainerItem();
					break;
			}
		}

		void treeDatabaseSchema_GotFocus(object sender, EventArgs e)
		{
            _controller.OnContainerItemChanged();
		}

		void treeDatabaseSchema_DragOver(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.None;
		}

		private void treeStructure_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Delete:
				    _controller.DeleteSelectedStructureItems();
                    break;
				case Keys.Insert:
                    _controller.AddStructureItemToFocused();
                    break;
			}
		}

		void treeStructure_GotFocus(object sender, EventArgs e)
		{
		    _controller.OnStructureItemChanged();
        }

        public void ShowContainerLoadForm()
        {
            _controller.ShowContainerLoadForm();
        }

	    private void miFillFromSchema_Click()
	    {
            var stripHost = new ToolStripControlHost(popupFillStructure);
            _fillDropDown = new ToolStripDropDown();
            stripHost.Margin = new Padding(0);
	        _fillDropDown.Padding = new Padding(0);
	        _fillDropDown.Items.Add(stripHost);
	        var showPoint = toolStrip4.PointToScreen(miFillFromSchema.Bounds.Location);
	        showPoint.Y += miFillFromSchema.Bounds.Height;

	        lbWarningFillStructure.Visible = !_controller.IsStructureEmpty(treeStructure.MetadataStructure);

            _fillDropDown.Show(showPoint);
        }

        private void btnGenerateStructure_Click(object sender, EventArgs e)
        {
            _controller.GenerateStructure(cbGroupByServer.Checked, cbGroupByDatabase.Checked, cbGroupBySchema.Checked,
                cbGroupByTypes.Checked, cbGenerateObjects.Checked);
        }
        
        private void btnCancelGenerate_Click(object sender, EventArgs e)
        {
            _fillDropDown?.Close();
        }

	    public List<string> ValidateBeforeApply()
	    {
	        return _controller.ValidateBeforeApply();
	    }

        private void tsddbAdd_DropDownOpening(object sender, EventArgs e)
        {
            _controller.UpdateContainerCommands();
        }

        private void menuSchemaTree_Opening(object sender, CancelEventArgs e)
        {
            _controller.UpdateContainerCommands();
            if (OpenContainerLoadFormIfNotConnected && (_sqlContext.MetadataProvider == null || !_sqlContext.MetadataProvider.Connected))
            {
                miLoadAll.Visible = false;
                tsmiConnectAndLoad.Visible = true;
            }
            else
            {
                miLoadAll.Visible = true;
                tsmiConnectAndLoad.Visible = false;
            }
        }

        private void splitContainerOuter_ButtonDottedClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (_metadataStructureTreeSeparatorMenu != null)
                {
                    _metadataStructureTreeSeparatorMenu.Close(ToolStripDropDownCloseReason.CloseCalled);
                    _metadataStructureTreeSeparatorMenu.Dispose();
                    _metadataStructureTreeSeparatorMenu = null;
                }

                _metadataStructureTreeSeparatorMenu = new CustomContextMenu();
                _metadataStructureTreeSeparatorMenu.AddItem(
                    Helpers.Localizer.GetString("strMetadataStructureTreeVisibility",
                        LocalizableConstantsUI.strMetadataStructureTreeVisibility), SwitchMstVisibility,
                    StructureTreeVisible, true, null, null);
                _metadataStructureTreeSeparatorMenu.Show(splitContainerOuter,
                     e.Location);
                return;
            }

            StructureTreeVisible = !StructureTreeVisible;
        }

        private void SwitchMstVisibility(object sender, EventArgs e)
        {
            StructureTreeVisible = !StructureTreeVisible;
        }
    }

    internal class SplitContainerWithButton : SplitContainer
    {
        public event MouseEventHandler ButtonDottedClick;
        private Point _pointDown = Point.Empty;
        private Rectangle _dotsArea = Rectangle.Empty;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            _pointDown = e.Location;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            if (_pointDown != Point.Empty && _pointDown == e.Location && _dotsArea.Contains(e.Location))
            {
               OnButtonDottedClick(e);
            }

            _pointDown = Point.Empty;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            Cursor = _dotsArea.Contains(PointToClient(MousePosition)) ? Cursors.Hand : DefaultCursor;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            Cursor = _dotsArea.Contains(PointToClient(MousePosition)) ? Cursors.Hand : DefaultCursor;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            Cursor = _dotsArea.Contains(e.Location) ? Cursors.Hand : DefaultCursor;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //paint the three dots'
            Point[] points = new Point[3];

            //calculate the position of the points'
            if (Orientation == System.Windows.Forms.Orientation.Horizontal)
            {
                points[0] = new Point((Width / 2), SplitterDistance + (SplitterWidth / 2));
                points[1] = new Point(points[0].X - 10, points[0].Y);
                points[2] = new Point(points[0].X + 10, points[0].Y);
            }
            else
            {
                points[0] = new Point(SplitterDistance + (SplitterWidth / 2), (Height / 2));
                points[1] = new Point(points[0].X, points[0].Y - 10);
                points[2] = new Point(points[0].X, points[0].Y + 10);
            }

            _dotsArea = new Rectangle(SplitterDistance, points[0].Y - 17, SplitterWidth, 34);

            //draw dots substrate
            e.Graphics.FillRectangle(Brushes.LightGray, _dotsArea);

            foreach (Point p in points)
            {
                p.Offset(-2, -2);
                e.Graphics.FillEllipse(Brushes.Black,
                    new Rectangle(p, new Size(3, 3)));

                p.Offset(1, 1);
                e.Graphics.FillEllipse(SystemBrushes.ControlLight,
                    new Rectangle(p, new Size(3, 3)));
            }
        }

        protected virtual void OnButtonDottedClick(MouseEventArgs e)
        {
            ButtonDottedClick?.Invoke(this, e);
        }
    }
}
