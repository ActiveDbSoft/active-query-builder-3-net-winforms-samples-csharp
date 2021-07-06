//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2021 Active Database Software              //
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
using ActiveQueryBuilder.View.WinForms.Commands;
using Helpers = ActiveQueryBuilder.View.Helpers;

namespace MetadataEditorDemo.Common
{
	internal partial class MetadataFilterControl : UserControl
	{
		private MetadataFilter _metadataFilter = null;
		private Orientation  _orientation = Orientation.Horizontal;
	    private readonly MetadataFilterItemControl _itemControl;
	    private ToolStripDropDown _dropDown;

        private string _inclompleteItemCaption;
		
		public MetadataFilter MetadataFilter
		{
			get { return _metadataFilter; }
			set
			{
			    if (_metadataFilter == value) return;
			    _metadataFilter = value;

			    FillListBox();
			}
		}

		public List<string> DatabaseList
		{
		    get { return _itemControl.DatabaseList; }
		    set { _itemControl.DatabaseList = value; }
        }

		public List<string> SchemaList
		{
			get { return _itemControl.SchemaList; }
		    set { _itemControl.SchemaList = value; }
		}

		public bool ShowServer
		{
			get { return _itemControl.ShowServer; }
			set { _itemControl.ShowServer = value; }
		}

		public bool ShowDatabase
		{
		    get { return _itemControl.ShowDatabase; }
		    set { _itemControl.ShowDatabase = value; }
        }

		public bool ShowSchema
		{
		    get { return _itemControl.ShowSchema; }
		    set { _itemControl.ShowSchema = value; }
        }

		public bool ShowPackage
		{
		    get { return _itemControl.ShowPackage; }
		    set { _itemControl.ShowPackage = value; }
        }

		[DefaultValue(Orientation.Horizontal)]
		public Orientation Orientation
		{
			get { return _orientation; }
			set
			{
				_orientation = value;
				
				if (IsHandleCreated)
				{
					splitContainer1.Orientation = _orientation;
					splitContainer1.SplitterDistance = (_orientation == Orientation.Horizontal) ? 70 : 140;
				}
			}
		}

	    private readonly CompositeDisposable _subscriptions = new CompositeDisposable();
	    private Command _addIncludeCommand;
	    private Command _addExcludeCommand;
	    private Command _deleteIncludeCommand;
	    private Command _deleteExcludeCommand;
	    private Command _editIncludeCommand;
	    private Command _editExcludeCommand;

		public MetadataFilterControl()
		{
		    _inclompleteItemCaption =
		        $"<{ActiveQueryBuilder.View.Helpers.Localizer.GetString("strIncompleteFilterItem", LocalizableConstantsUI.strIncompleteFilterItem)}>";

            InitializeComponent();
            _itemControl = new MetadataFilterItemControl();
            _itemControl.OkClicked += ItemControlOkClicked;
            _itemControl.CancelClicked += ItemControlCancelClicked;

            BindCommands();
		    BindLocalization();

            _subscriptions.Add(Helpers.Localizer.Subscribe(Localizer_LanguageChanged));
		}

	    private void ItemControlCancelClicked(object sender, EventArgs e)
	    {
	        _dropDown.Close();
	    }

	    private void ItemControlOkClicked(object sender, EventArgs e)
	    {
	        _dropDown.Close();
        }

	    private void Localizer_LanguageChanged(string newLang)
	    {
	        _inclompleteItemCaption =
	            $"<{ActiveQueryBuilder.View.Helpers.Localizer.GetString("strIncompleteFilterItem", LocalizableConstantsUI.strIncompleteFilterItem)}>";
        }

	    private void BindCommands()
	    {
	        _addIncludeCommand = new Command(tsbAdd_Click);
            _addExcludeCommand = new Command(tsbAddExclude_Click);
	        _deleteIncludeCommand = new Command(tsbDelete_Click);
            _deleteExcludeCommand = new Command(tsbDeleteExclude_Click);
            _editIncludeCommand = new Command(tsbEditInclude_Click);
            _editExcludeCommand = new Command(tsbEditExclude_Click);

            _subscriptions.Add(CommandBinder.Bind(tsbAddInclude, _addIncludeCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.Add, x => tsbAddInclude.Enabled = x));
            _subscriptions.Add(CommandBinder.Bind(tsbAddExclude, _addExcludeCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.Add, x => tsbAddExclude.Enabled = x));
            _subscriptions.Add(CommandBinder.Bind(tsbDeleteInclude, _deleteIncludeCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.Delete, x => tsbDeleteInclude.Enabled = x));
            _subscriptions.Add(CommandBinder.Bind(tsbDeleteExclude, _deleteExcludeCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.Delete, x => tsbDeleteExclude.Enabled = x));
            _subscriptions.Add(CommandBinder.Bind(tsbEditInclude, _editIncludeCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.Edit, x => tsbEditInclude.Enabled = x));
            _subscriptions.Add(CommandBinder.Bind(tsbEditExclude, _editExcludeCommand, ActiveQueryBuilder.View.WinForms.Commands.MetadataEditor.Edit, x => tsbEditExclude.Enabled = x));
        }

        private void BindLocalization()
        {
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataEditor.IncludeRange.Subscribe(x => lblInclude.Text = x));
            _subscriptions.Add(ActiveQueryBuilder.Core.Localization.MetadataEditor.ExcludeRange.Subscribe(x => lblExclude.Text = x));
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

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			splitContainer1.Orientation = _orientation;
			splitContainer1.SplitterDistance = (_orientation == Orientation.Horizontal) ? 70 : 140;			

			FillListBox();		    
		}

		private void FillListBox()
		{		
			lbInclude.BeginUpdate();
			lbExclude.BeginUpdate();
			try
			{
				lbInclude.Items.Clear();

				if (_metadataFilter != null)
				{
					foreach (MetadataFilterItem filterItem in _metadataFilter)
					{
					    if (filterItem.Exclude)
					        lbExclude.Items.Add(filterItem);
                        else
    						lbInclude.Items.Add(filterItem);
					}
				}
			}
			finally
			{
				lbInclude.EndUpdate();
			    lbExclude.EndUpdate();
            }

			if (lbInclude.Items.Count > 0)
			{
				lbInclude.SelectedIndex = 0;
			}

		    if (lbExclude.Items.Count > 0)
		    {
		        lbExclude.SelectedIndex = 0;
		    }
        }
        
	    private void tsbAdd_Click()
		{
			if (_metadataFilter != null)
			{
				lbInclude.SelectedIndex = lbInclude.Items.Add(_metadataFilter.Add());
			    EditFilterItem(lbInclude);
            }
		}

		private void tsbDelete_Click()
		{
		    DeleteSelectedItem(lbInclude);
        }

        private void tsbAddExclude_Click()
        {
            if (_metadataFilter != null)
            {
                var item = _metadataFilter.Add();
                item.Exclude = true;
                lbExclude.SelectedIndex = lbExclude.Items.Add(item);
                EditFilterItem(lbExclude);
            }
        }

        private void tsbDeleteExclude_Click()
        {
            DeleteSelectedItem(lbExclude);
        }

	    private void DeleteSelectedItem(ListBox list)
	    {
	        var item = list.SelectedItem as MetadataFilterItem;
	        if (item == null)
	        {
	            return;
	        }

	        var idx = list.SelectedIndex;
	        list.Items.Remove(item);
	        _metadataFilter.Remove(item);

	        if (list.Items.Count == 0)
	        {
	            return;
	        }

	        if (idx == list.Items.Count)
	        {
	            list.SelectedIndex = idx - 1;
	        }
	        else if (idx < list.Items.Count)
	        {
	            list.SelectedIndex = idx;
	        }
        }

	    private void ShowItemDropDown(Point location)
	    {
	        var stripHost = new ToolStripControlHost(_itemControl)
	        {
                Margin = Padding.Empty,
                Padding = Padding.Empty,
                AutoSize = false,
                Size = _itemControl.Size
            };

	        _dropDown = new ToolStripDropDown()
	        {
                Padding = Padding.Empty
	        };

	        _dropDown.Items.Add(stripHost);
            _dropDown.Closed += DropDownOnClosed;
	        _dropDown.Show(location);
        }

	    private void DropDownOnClosed(object sender, ToolStripDropDownClosedEventArgs e)
	    {
	        if (e.CloseReason != ToolStripDropDownCloseReason.CloseCalled)
                _itemControl.ApplyChanges();
	    }

	    private void EditFilterItem(ListBox list)
	    {
	        if (list.SelectedIndex == -1)
	        {
	            return;
	        }

	        _itemControl.FilterItem = list.SelectedItem as MetadataFilterItem;

	        var itemRect = list.GetItemRectangle(list.SelectedIndex);
	        var p = list.PointToScreen(itemRect.Location);
	        p.Y += itemRect.Height;

	        ShowItemDropDown(p);
        }

        private void tsbEditInclude_Click()
        {
            EditFilterItem(lbInclude);
        }

        private void tsbEditExclude_Click()
        {
            EditFilterItem(lbExclude);
        }

        private void lbInclude_DoubleClick(object sender, EventArgs e)
        {
            EditFilterItem(lbInclude);
        }

        private void lbExclude_DoubleClick(object sender, EventArgs e)
        {
            EditFilterItem(lbExclude);
        }

        private void lbInclude_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    tsbDelete_Click();
                    break;
                case Keys.Insert:
                    tsbAdd_Click();
                    break;
            }
        }

        private void lbExclude_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    tsbDeleteExclude_Click();
                    break;
                case Keys.Insert:
                    tsbAddExclude_Click();
                    break;
            }
        }

        private void lbInclude_DrawItem(object sender, DrawItemEventArgs e)
        {
            DrawItem(lbInclude, e);
        }

	    private void DrawItem(ListBox listBox, DrawItemEventArgs e)
	    {
	        if (e.Index == -1)
	            return;

	        e.DrawBackground();

	        var item = listBox.Items[e.Index] as MetadataFilterItem;
	        var isEmpty = item.IsEmpty;

	        e.Graphics.DrawString(isEmpty ? _inclompleteItemCaption : item.ToString(), e.Font, isEmpty ? Brushes.Red : new SolidBrush(e.ForeColor), e.Bounds, StringFormat.GenericDefault);

	        e.DrawFocusRectangle();
        }

        private void lbExclude_DrawItem(object sender, DrawItemEventArgs e)
        {
            DrawItem(lbExclude, e);
        }
    }
}
