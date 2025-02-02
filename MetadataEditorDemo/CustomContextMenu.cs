//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2025 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ActiveQueryBuilder.View;
using ActiveQueryBuilder.View.WinForms;

namespace MetadataEditorDemo
{
    [ToolboxItem(false)]
    internal class CustomContextMenu : ContextMenuStrip
    {
        public new event EventHandler Closing;
        public new event EventHandler MouseDown;

        public int ItemCount => Items.Count;


        public new bool RightToLeft
        {
            get { return base.RightToLeft == System.Windows.Forms.RightToLeft.Yes; }
            set { base.RightToLeft = value ? System.Windows.Forms.RightToLeft.Yes : System.Windows.Forms.RightToLeft.Inherit; }
        }

        protected override void OnClosing(ToolStripDropDownClosingEventArgs e)
        {
            Closing?.Invoke(this, EventArgs.Empty);
            base.OnClosing(e);
        }

        private void CustomContextMenu_MouseDown(object sender, EventArgs e)
        {
            MouseDown?.Invoke(sender, e);
        }

        private void CustomContextMenu_Closing(object sender, EventArgs e)
        {
            Closing?.Invoke(sender, e);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                Closing -= CustomContextMenu_Closing;
                MouseDown -= CustomContextMenu_MouseDown;
            }

            base.Dispose(disposing);
        }

        public ICustomSubMenu AddSubMenu(string itemText)
        {
            ICustomSubMenu menuItem = ControlFactory.Instance.GetCustomSubMenu();
            menuItem.Text = itemText;
            menuItem.MouseDown += MenuItem_MouseDown;

            Items.Add((ToolStripItem)menuItem);

            return menuItem;
        }

        public ICustomSubMenu InsertSubMenu(int position, string itemText)
        {
            ICustomSubMenu menuItem = ControlFactory.Instance.GetCustomSubMenu();
            menuItem.Text = itemText;
            menuItem.MouseDown += MenuItem_MouseDown;

            Items.Insert(position, (ToolStripItem)menuItem);

            return menuItem;
        }

        public ICustomMenuItem AddItem(string itemText, EventHandler eventHandler, bool isChecked, bool isEnabled, object image, Object tag)
        {
            ICustomMenuItem menuItem = ControlFactory.Instance.GetCustomMenuItem();
            menuItem.Text = itemText;
            menuItem.Image = image;
            menuItem.Checked = isChecked;
            menuItem.Enabled = isEnabled;
            menuItem.Tag = tag;
            menuItem.Click += eventHandler;
            menuItem.MouseDown += MenuItem_MouseDown;
            Items.Add((ToolStripItem)menuItem);

            return menuItem;
        }

        private void MenuItem_MouseDown(object sender, EventArgs e)
        {
            MouseDown?.Invoke(sender, e);
        }

        public ICustomMenuItem AddItem(string itemText, EventHandler eventHandler)
        {
            return AddItem(itemText, eventHandler, false, true, null, null);
        }

        public ICustomMenuItem InsertItem(int position, string itemText, EventHandler eventHandler, bool isChecked, bool isEnabled, object image, Object tag)
        {
            ICustomMenuItem menuItem = ControlFactory.Instance.GetCustomMenuItem();
            menuItem.Text = itemText;
            menuItem.Image = image;
            menuItem.Checked = isChecked;
            menuItem.Enabled = isEnabled;
            menuItem.Tag = tag;
            menuItem.Click += eventHandler;
            menuItem.MouseDown += MenuItem_MouseDown;
            Items.Insert(position, (ToolStripItem)menuItem);

            return menuItem;
        }

        public ICustomMenuItem InsertItem(int position, string itemText, EventHandler eventHandler)
        {
            return InsertItem(position, itemText, eventHandler, false, true, null, null);
        }

        public void AddSeparator()
        {
            Items.Add(new ToolStripSeparator());
        }

        public void InsertSeparator(int position)
        {
            Items.Insert(position, new ToolStripSeparator());
        }

        public void ClearItems()
        {
            Items.Clear();
        }

        public void RemoveItemAt(int position)
        {
            Items.RemoveAt(position);
        }

        public void Show(object owner, double x, double y)
        {
            Control target = owner as Control;
            if (target != null)
            {
                Show(target, target.PointToClient(new Point((int) x, (int) y)));
            }
            else
            {
                Show((int) x, (int) y);
            }
        }

        public object GetBoldFont()
        {
            return new Font(Font, FontStyle.Bold);
        }

        public List<T> GetItems<T>()
        {
            var arrayItems = new ToolStripItem[Items.Count];
            Items.CopyTo(arrayItems, 0);

            return arrayItems.Cast<T>().ToList();
        }
    }

    [ToolboxItem(false)]
    internal class CustomMenuItem : ToolStripMenuItem, ICustomMenuItem
    {
        public new event EventHandler MouseDown;

        object ICustomMenuItem.Font
        {
            get { return base.Font; }
            set { base.Font = (Font)value; }
        }

        public ICustomSubMenu AddSubMenu(string itemText)
        {
            ICustomSubMenu menuItem = ControlFactory.Instance.GetCustomSubMenu();
            menuItem.Text = itemText;

            DropDownItems.Add((ToolStripItem)menuItem);

            return menuItem;
        }

        public ICustomSubMenu InsertSubMenu(int position, string itemText)
        {
            ICustomSubMenu menuItem = ControlFactory.Instance.GetCustomSubMenu();
            menuItem.Text = itemText;

            DropDownItems.Insert(position, (ToolStripItem)menuItem);

            return menuItem;
        }

        public ICustomMenuItem AddItem(string itemText, EventHandler eventHandler, bool isChecked, bool isEnabled, object image, object tag)
        {
            ICustomMenuItem menuItem = ControlFactory.Instance.GetCustomMenuItem();
            menuItem.Text = itemText;
            menuItem.Image = image;
            menuItem.Checked = isChecked;
            menuItem.Enabled = isEnabled;
            menuItem.Tag = tag;
            menuItem.Click += eventHandler;
            menuItem.MouseDown += MenuItem_MouseDown;
            DropDownItems.Add((ToolStripItem)menuItem);

            return menuItem;
        }

        private void MenuItem_MouseDown(object sender, EventArgs e)
        {
            MouseDown?.Invoke(sender, e);
        }

        public ICustomMenuItem AddItem(string itemText, EventHandler eventHandler)
        {
            return AddItem(itemText, eventHandler, false, true, null, null);
        }

        public ICustomMenuItem InsertItem(int position, string itemText, EventHandler eventHandler, bool isChecked, bool isEnabled, object image, object tag)
        {
            ICustomMenuItem menuItem = ControlFactory.Instance.GetCustomMenuItem();
            menuItem.Text = itemText;
            menuItem.Image = image;
            menuItem.Checked = isChecked;
            menuItem.Enabled = isEnabled;
            menuItem.Tag = tag;
            menuItem.Click += eventHandler;
            menuItem.MouseDown += MenuItem_MouseDown;
            DropDownItems.Insert(position, (ToolStripItem)menuItem);

            return menuItem;
        }

        public ICustomMenuItem InsertItem(int position, string itemText, EventHandler eventHandler)
        {
            return InsertItem(position, itemText, eventHandler, false, true, null, null);
        }

        public void AddSeparator()
        {
            DropDownItems.Add(new ToolStripSeparator());
        }

        public void InsertSeparator(int position)
        {
            DropDownItems.Insert(position, new ToolStripSeparator());
        }

        public void ClearItems()
        {
            DropDownItems.Clear();
        }

        public List<T> GetItems<T>()
        {
            var arrayItems = new ToolStripItem[DropDownItems.Count];
            DropDownItems.CopyTo(arrayItems, 0);

            return arrayItems.Cast<T>().ToList();
        }

        object ICustomMenuItem.Image
        {
            get { return base.Image; }
            set { base.Image = (Image)value; }
        }

        CKeys ICustomMenuItem.ShortcutKeys
        {
            get { return (CKeys)ShortcutKeys; }
            set { ShortcutKeys = (Keys)value; }
        }

        public CustomMenuItem()
        {
            ImageScaling = ToolStripItemImageScaling.None;
            base.MouseDown += CustomMenuItem_MouseDown;
        }

        private void CustomMenuItem_MouseDown(object sender, EventArgs e)
        {
            MouseDown?.Invoke(sender, e);
        }
    }

    [ToolboxItem(false)]
    internal class CustomSubMenu : CustomMenuItem
    {

    }
}
