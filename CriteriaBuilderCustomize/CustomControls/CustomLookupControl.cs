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
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View;
using ActiveQueryBuilder.View.CriteriaBuilder.CustomEditors;
using ContentAlignment = System.Drawing.ContentAlignment;
using Helpers = ActiveQueryBuilder.View.Helpers;

namespace CriteriaBuilderCustomize.CustomControls
{
	internal sealed class CustomLookupControl : Form, ICriteriaBuilderCustomLookupControl
	{
		private Size _singleColumnSize = new Size(200, 200);
		private Size _multipleColumnSize = new Size(500, 200);

		private readonly CustomGrid _grid;
		private readonly LinkLabel _moreLinkLabel;
		private readonly LinkLabel _allLinkLabel;
		
		public int SelectedIndex => _grid.SelectedIndex;

        public string SelectedItem => _grid.SelectedItem;

        public new CPoint Location
		{
			get { return new CPoint(base.Location.X, base.Location.Y); }
			set { base.Location = new Point((int)value.X, (int)value.Y); }
		}

		public object DataSource
		{
			get { return _grid.DataSource; }
			set
			{
				_grid.DataSource = value;
				_grid.ColumnHeadersVisible = _grid.Columns.Count > 1;
				_grid.AutoSizeColumnsMode = _grid.Columns.Count > 1 ? DataGridViewAutoSizeColumnsMode.DisplayedCells : DataGridViewAutoSizeColumnsMode.Fill;
			}
		}

		public int KeyColumnIndex
		{
			get { return _grid.KeyColumnIndex; }
			set { _grid.KeyColumnIndex = value; }
		}

		public int RowCount
		{
			get { return _grid.RowCount; }
			set { _grid.RowCount = value; }
		}

		public int FirstDisplayedScrollingRowIndex
		{
			get { return _grid.FirstDisplayedScrollingRowIndex; }
			set { _grid.FirstDisplayedScrollingRowIndex = value; }
		}

		public new object Owner
		{
			get { return base.Owner; }
			set { base.Owner = (Form) value; }
		}

		public bool MoreLinkLabelVisible
		{
			get { return _moreLinkLabel.Visible; }
			set { _moreLinkLabel.Visible = value; }
		}

		public bool AllLinkLabelVisible
		{
			get { return _allLinkLabel.Visible; }
			set { _allLinkLabel.Visible = value; }
		}

		public Size SingleColumnSize => _singleColumnSize;

        public Size MultipleColumnSize => _multipleColumnSize;

        public event EventHandler ItemSelected
		{
			add { _grid.ItemSelected += value; }
			remove { _grid.ItemSelected -= value; }
		}

		public event EventHandler LoadMoreClick
		{
			add { _moreLinkLabel.Click += value; }
			remove { _moreLinkLabel.Click -= value; }
		}

		public event EventHandler LoadAllClick
		{
			add { _allLinkLabel.Click += value; }
			remove { _allLinkLabel.Click -= value; }
		}

	    protected override bool ShowWithoutActivation => true;

        protected override CreateParams CreateParams
		{
			get
			{
				CreateParams value = base.CreateParams;
				value.ExStyle |= 0x00000008 /*WS_EX_TOPMOST*/;
				return value;
			}
		}

		private int _defaultCountOfLookupValues;

		public int DefaultCountOfLookupValues
		{
			get { return _defaultCountOfLookupValues; }
			set
			{
				_defaultCountOfLookupValues = value;
				_moreLinkLabel.Text = string.Format(Helpers.Localizer.GetString("strLoadMoreItems", LocalizableConstantsUI.strLoadMoreItems), value) + "...";
			}
		}

		public CustomLookupControl()
		{
			DoubleBuffered = true;
			SetStyle(ControlStyles.ResizeRedraw, true);

			TopLevel = true;
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Size = _singleColumnSize;
			Visible = false;
			StartPosition = FormStartPosition.Manual;
			ShowInTaskbar = false;
			ControlBox = false;

            Controls.Add(new Label
            {
                Dock = DockStyle.Top, Text = "User custom control", BackColor = SystemColors.Info,
                TextAlign = ContentAlignment.MiddleCenter
            });

            _grid = new CustomGrid {Dock = DockStyle.Fill};
            _grid.CellFormatting += Grid_CellFormatting;
			Controls.Add(_grid);

            CustomFlowLayoutPanel panel = new CustomFlowLayoutPanel
            {
                Height = 20,
                Dock = DockStyle.Bottom,
                WrapContents = true,
                AutoSize = true,
                MinimumSize = new Size(20, 20),
                Margin = new Padding(0, 0, 20, 0)
            };
            panel.Paint += panel_Paint;
			panel.SizeChanged += panel_SizeChanged;

            _moreLinkLabel = new LinkLabel
            {
                Text = string.Format(
                    Helpers.Localizer.GetString("strLoadMoreItems", LocalizableConstantsUI.strLoadMoreItems),
                    DefaultCountOfLookupValues) + "...",
                AutoSize = true,
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                Padding = new Padding(4, 2, 4, 2),
                BackColor = Color.Transparent,
                TabStop = false
            };
            panel.Controls.Add(_moreLinkLabel);

			_allLinkLabel = new LinkLabel();
			_allLinkLabel.Text = Helpers.Localizer.GetString("strLoadAllItems", LocalizableConstantsUI.strLoadAllItems) + "...";
			_allLinkLabel.AutoSize = true;
			_allLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			_allLinkLabel.Padding = new Padding(4, 2, 4, 2);
			_allLinkLabel.BackColor = Color.Transparent;
			_allLinkLabel.TabStop = false;
			panel.Controls.Add(_allLinkLabel);

			Controls.Add(panel);
		}
		
		public void UpdateSize()
		{
			Size = _grid.Columns.Count > 1 ? MultipleColumnSize : SingleColumnSize;
		}

		public void SelectRow(int rowIndex)
		{
			_grid.Rows[rowIndex].Selected = true;
		}

		protected override void OnSizeChanged(EventArgs e)
		{
			if (Visible)
			{
				if (_grid.Columns.Count > 1)
					_multipleColumnSize = Size;
				else
					_singleColumnSize = Size;
			}

			base.OnSizeChanged(e);
		}

		void Grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (_grid.ColumnCount > 1 && e.ColumnIndex == KeyColumnIndex)
				e.CellStyle.BackColor = SystemColors.Info;
			else
				e.CellStyle.BackColor = _grid.DefaultCellStyle.BackColor;
		}

		void panel_SizeChanged(object sender, EventArgs e)
		{
			((Control) sender).Invalidate();
		}

		public void ForwardKeyDownToGrid(CKeyEventArgs e)
		{
			_grid.ForwardKeyDown(e);
		}

		public void ForwardMouseWheelToGrid(CMouseEventArgs e)
		{
			_grid.ForwardMouseWheel(e);
		}
		
		protected override void OnLostFocus(EventArgs e)
		{
			Hide();

			base.OnLostFocus(e);
		}

		private VisualStyleRenderer _gripRenderer = null;

		void panel_Paint(object sender, PaintEventArgs e)
		{
			Panel panel = (Panel) sender;
			Rectangle clientRectangle = panel.ClientRectangle;

			e.Graphics.FillRectangle(SystemBrushes.Control, clientRectangle);
			e.Graphics.DrawLine(Pens.DimGray, new Point(clientRectangle.Left, clientRectangle.Top), new Point(clientRectangle.Right, clientRectangle.Top));

			Rectangle rc = new Rectangle(clientRectangle.Right - 17, clientRectangle.Bottom - 17, 16, 16);

			if (Application.RenderWithVisualStyles)
			{
				if (_gripRenderer == null)
					_gripRenderer = new VisualStyleRenderer(VisualStyleElement.Status.Gripper.Normal);
				_gripRenderer.DrawBackground(e.Graphics, rc);
			}
			else
			{
				ControlPaint.DrawSizeGrip(e.Graphics, BackColor, rc);
			}
		}

		protected override void WndProc(ref Message m)
		{
			const int wmNcHitTest = 0x84;
			const int htBottomLeft = 16;
			const int htBottomRight = 17;

			if (m.Msg == wmNcHitTest)
			{
				int x = (int) (m.LParam.ToInt64() & 0xFFFF);
				int y = (int) ((m.LParam.ToInt64() & 0xFFFF0000) >> 16);
				Point pt = PointToClient(new Point(x, y));
				Size clientSize = ClientSize;

				if (pt.X >= clientSize.Width - 16 && pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16)
				{
					m.Result = (IntPtr) (IsMirrored ? htBottomLeft : htBottomRight);
					return;
				}
			}

			base.WndProc(ref m);
		}

		internal sealed class CustomGrid : DataGridView
		{
			public event EventHandler ItemSelected;
			
			public int KeyColumnIndex { get; set; }

			public int SelectedIndex
			{
				get { return SelectedRows.Count > 0 ? SelectedRows[0].Index : -1; }
			}

			public string SelectedItem
			{
				get { return Convert.ToString(SelectedRows[0].Cells[KeyColumnIndex].Value); }
			}

			public CustomGrid()
			{
				KeyColumnIndex = 0;
				BorderStyle = BorderStyle.None;
				AutoGenerateColumns = true;
				RowHeadersVisible = false;
				AllowUserToResizeRows = false;
				AllowUserToResizeColumns = true;
				AllowUserToAddRows = false;
				AllowUserToDeleteRows = false;
				SelectionMode = DataGridViewSelectionMode.FullRowSelect;
				AllowUserToOrderColumns = true;
				MultiSelect = false;
				EditMode = DataGridViewEditMode.EditProgrammatically;
				AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
				RowTemplate.Height = (int) (Font.GetHeight() + 6);
				ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

				DataError += CustomGrid_DataError;
				CellPainting += CustomGrid_CellPainting;
			}

			public void ForwardKeyDown(CKeyEventArgs e)
			{
				OnKeyDown(new KeyEventArgs((Keys) e.KeyData));
			}

			public void ForwardMouseWheel(CMouseEventArgs e)
			{
				OnMouseWheel(new MouseEventArgs((MouseButtons) e.Button, e.Clicks, (int)e.X, (int)e.Y, e.Delta));
			}

			public void FireItemSelectedEvent(EventArgs e)
			{
				if (ItemSelected != null)
				{
					ItemSelected(this, e);
				}
			}

			void CustomGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
			{
				e.ThrowException = false;
			}

			void CustomGrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
			{
				if (e.RowIndex >= 0 && e.ColumnIndex == 0)
				{
					e.Paint(e.CellBounds, e.PaintParts & ~DataGridViewPaintParts.Border);

					ControlPaint.DrawBorder(e.Graphics, e.CellBounds, 
						(e.State & DataGridViewElementStates.Selected) > 0 ? e.CellStyle.SelectionBackColor : e.CellStyle.BackColor, 1, ButtonBorderStyle.Solid,
						GridColor, 0, ButtonBorderStyle.Solid, GridColor, 1, ButtonBorderStyle.Solid, GridColor, 1, ButtonBorderStyle.Solid);
				}
				else
					e.Paint(e.CellBounds, e.PaintParts);

				e.Handled = true;
			}

			protected override void OnSelectionChanged(EventArgs e)
			{
				//base.OnSelectionChanged(e);
			}

			protected override void OnKeyDown(KeyEventArgs e)
			{
				switch (e.KeyCode)
				{
					case Keys.Escape:
						Parent.Hide();
						break;
					case Keys.Tab:
					case Keys.Enter:
						if (!e.Shift && !e.Control && !e.Alt)
						{
							FireItemSelectedEvent(EventArgs.Empty);
							e.Handled = true;
						}
						break;
					/*case System.Windows.Forms.Keys.Up:
						if (SelectedIndex == 0)
						{
							SelectedIndex = Items.Count - 1;
							e.SuppressKeyPress = true;
							return;
						}
						break;
					case System.Windows.Forms.Keys.Down:
						if (SelectedIndex == Items.Count - 1)
						{
							SelectedIndex = 0;
							e.SuppressKeyPress = true;
							return;
						}
						break;*/
				}

				base.OnKeyDown(e);
			}

			protected override void OnMouseUp(MouseEventArgs e)
			{
				if (e.Button == MouseButtons.Left)
				{
					if (HitTest(e.X, e.Y).Type == DataGridViewHitTestType.Cell)
						FireItemSelectedEvent(EventArgs.Empty);
				}

				base.OnMouseUp(e);
			}
		}

		internal class CustomFlowLayoutPanel : FlowLayoutPanel
		{
			protected override void WndProc(ref Message m)
			{
				const int WM_NCHITTEST = 0x0084;
				const int HTTRANSPARENT = (-1);

				if (m.Msg == WM_NCHITTEST)
				{
					m.Result = (IntPtr) HTTRANSPARENT;
				}
				else
				{
					base.WndProc(ref m);
				}
			}
		}

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CustomLookupControl
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "CustomLookupControl";
            this.Text = "User custom control";
            this.ResumeLayout(false);

        }
    }
}
