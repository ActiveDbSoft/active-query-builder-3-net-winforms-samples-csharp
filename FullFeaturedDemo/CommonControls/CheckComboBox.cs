//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2019 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using FullFeaturedDemo.CommonControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FullFeaturedDemo
{
    internal class CheckComboBox : ComboBox
    {
        private readonly CheckedListBox _checkedListBox = new CheckedListBox();
        private readonly ToolStripControlHost _popupControlHost;
        private readonly ToolStripDropDown _dropDownControl = new ToolStripDropDown();
        private readonly Timer _timer = new Timer();
        private bool _dropDownClosing;
        private readonly List<int> _checkedIndices = new List<int>();

        private const int WM_REFLECT_WM_COMMAND = 8465;
        private const int CBN_DROPDOWN = 0x7;
        private const int WM_KILLFOCUS = 0x08;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        public List<object> CheckedItems { get; } = new List<object>();

        public new CheckedListBox.ObjectCollection Items => _checkedListBox.Items;

        public event EventHandler ItemChecked;

        public override string Text
        {
            get { return SelectedItem as string; }
            set
            {
                if (SelectedItem as string == value)
                    return;

                base.Items.Clear();
                base.Items.Add(value);
                SelectedItem = value;
            }
        }

        public void SetItemChecked(int index, bool isChecked)
        {
            _checkedListBox.Refresh();
            _checkedListBox.SetItemChecked(index, isChecked);
        }

        public void ClearCheckedItems()
        {
            _checkedListBox.ClearSelected();
        }

        public bool IsItemChecked(int index)
        {
            return _checkedIndices.Contains(index);
        }

        public CheckComboBox()
        {
            DropDownStyle = ComboBoxStyle.DropDownList;
            DropDownHeight = DropDownWidth = 1;

            _checkedListBox.CheckOnClick = true;
            _checkedListBox.BorderStyle = BorderStyle.None;
            _checkedListBox.Dock = DockStyle.Fill;
            _checkedListBox.ItemCheck += CheckedListBoxOnItemCheck;

            _popupControlHost = new ToolStripControlHost(_checkedListBox);
            _dropDownControl.Items.Add(_popupControlHost);
            _dropDownControl.AutoSize = false;
            _dropDownControl.Closing += DropDownControlOnClosing;

            _timer.Tick += TimerOnTick;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dropDownControl.Closing -= DropDownControlOnClosing;
                _checkedListBox.ItemCheck -= CheckedListBoxOnItemCheck;
            }

            base.Dispose(disposing);
        }

        private void CheckedListBoxOnItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                _checkedIndices.Add(e.Index);
                CheckedItems.Add(_checkedListBox.Items[e.Index]);
            }
            else
            {
                _checkedIndices.Remove(e.Index);
                CheckedItems.Remove(_checkedListBox.Items[e.Index]);
            }

            if (ItemChecked != null)
                ItemChecked(this, EventArgs.Empty);
        }

        private void TimerOnTick(object sender, EventArgs eventArgs)
        {
            _dropDownClosing = false;
        }

        private void DropDownControlOnClosing(object sender, ToolStripDropDownClosingEventArgs toolStripDropDownClosingEventArgs)
        {
            _dropDownClosing = true;
            SendMessage(Handle, WM_KILLFOCUS, 0, 0);
            _timer.Interval = 250;
            _timer.Start();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_REFLECT_WM_COMMAND)
            {
                // prevent native dropdown opening
                if (m.HWnd == Handle && m.WParam.ToInt32() >> 16 == CBN_DROPDOWN)
                {
                    return;
                }
            }
            base.WndProc(ref m);
        }

        protected override void OnClick(EventArgs e)
        {
            if (_dropDownClosing)
            {
                _timer.Stop();
                _dropDownClosing = false;
                return;
            }

            ShowDropDown();
        }

        private void ShowDropDown()
        {
            var rect = RectangleToScreen(ClientRectangle);
            var location = new Point(rect.X, rect.Y + Height);

            _dropDownControl.Size = new Size(rect.Width, _checkedListBox.Items.Count * _checkedListBox.ItemHeight + Helpers.ScaleByCurrentDPI(5));
            _dropDownControl.Show(location);

            _dropDownClosing = true;
            _dropDownControl.Focus();
        }
    }
}
