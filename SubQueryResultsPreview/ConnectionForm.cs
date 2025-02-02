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
using System.Windows.Forms;
using GeneralAssembly;
using GeneralAssembly.ConnectionFrames;

namespace SubQueryResultsPreview
{
    public partial class ConnectionForm : Form
    {
        public ConnectionInfo SelectedConnection
        {
            get
            {
                if (tabControl1.SelectedIndex == 0)
                {
                    if (lvConnections.SelectedItems.Count > 0)
                    {
                        return (ConnectionInfo)lvConnections.SelectedItems[0].Tag;
                    }

                    return null;
                }
                else
                {
                    if (lvXmlFiles.SelectedItems.Count > 0)
                    {
                        return (ConnectionInfo)lvXmlFiles.SelectedItems[0].Tag;
                    }

                    return null;
                }
            }
        }

        public ConnectionForm()
        {
            InitializeComponent();

            // fill connection list
            for (int i = 0; i < Program.Connections.Count; i++)
            {
                ListViewItem lvi = lvConnections.Items.Add(Program.Connections[i].Name);
                lvi.SubItems.Add(Program.Connections[i].Type.ToString());
                lvi.Tag = Program.Connections[i];
            }

            if (lvConnections.Items.Count > 0)
            {
                lvConnections.Items[0].Selected = true;
            }

            // add preset

            bool found = false;
            ConnectionInfo northwind = new ConnectionInfo(ConnectionTypes.MSSQL, "Northwind.xml", "Northwind.xml", true, "");

            for (int i = 0; i < Program.XmlFiles.Count; i++)
            {
                if (Program.XmlFiles[i].Equals(northwind))
                {
                    found = true;
                }
            }

            if (!found)
            {
                Program.XmlFiles.Insert(0, northwind);
            }

            // fill XML files list
            for (int i = 0; i < Program.XmlFiles.Count; i++)
            {
                ListViewItem lvi = lvXmlFiles.Items.Add(Program.XmlFiles[i].Name);
                lvi.SubItems.Add(Program.XmlFiles[i].Type.ToString());
                lvi.Tag = Program.XmlFiles[i];
            }

            if (lvXmlFiles.Items.Count > 0)
            {
                lvXmlFiles.Items[0].Selected = true;
            }

            Application.Idle += Application_Idle;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                Application.Idle -= Application_Idle;

                if (components != null)
                    components.Dispose();
            }
            base.Dispose(disposing);
        }

        private string GetNewConnectionEntryName()
        {
            int x = 0;
            bool found;
            string name;

            do
            {
                x++;
                found = false;
                name = String.Format("Connection {0}", x);

                for (int i = 0; i < Program.Connections.Count; i++)
                {
                    if (Program.Connections[i].Name == name)
                    {
                        found = true;
                        break;
                    }
                }
            } while (found);

            return name;
        }

        private string GetNewXmlFileEntryName()
        {
            int x = 0;
            bool found;
            string name;

            do
            {
                x++;
                found = false;
                name = String.Format("XML File {0}", x);

                for (int i = 0; i < Program.XmlFiles.Count; i++)
                {
                    if (Program.XmlFiles[i].Name == name)
                    {
                        found = true;
                        break;
                    }
                }
            } while (found);

            return name;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ConnectionInfo ci = new ConnectionInfo(ConnectionTypes.MSSQL, GetNewConnectionEntryName(), null, false, "");

            using (ConnectionEditForm cef = new ConnectionEditForm(ci))
            {
                if (cef.ShowDialog() == DialogResult.OK)
                {
                    ListViewItem lvi = lvConnections.Items.Add(ci.Name);
                    lvi.SubItems.Add(ci.Type.ToString());
                    lvi.Tag = ci;
                    lvi.Selected = true;

                    Program.Connections.Add(ci);
                }
            }

            lvConnections.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ConnectionInfo ci = (ConnectionInfo)lvConnections.SelectedItems[0].Tag;

            lvConnections.Items.Remove(lvConnections.SelectedItems[0]);
            Program.Connections.Remove(ci);

            lvConnections.Focus();
        }

        private void btnConfigure_Click(object sender, EventArgs e)
        {
            if (lvConnections.SelectedItems.Count > 0)
            {
                ConnectionInfo ci = (ConnectionInfo)lvConnections.SelectedItems[0].Tag;

                using (ConnectionEditForm cef = new ConnectionEditForm(ci))
                {
                    if (cef.ShowDialog() == DialogResult.OK)
                    {
                        lvConnections.SelectedItems[0].SubItems[0].Text = ci.Name;
                        lvConnections.SelectedItems[0].SubItems[1].Text = ci.Type.ToString();
                    }
                }
            }

            lvConnections.Focus();
        }

        private void lvConnections_SizeChanged(object sender, EventArgs e)
        {
            lvConnections.Columns[0].Width = lvConnections.Width - lvConnections.Columns[1].Width - SystemInformation.VerticalScrollBarWidth;
        }

        private void lvXmlFiles_SizeChanged(object sender, EventArgs e)
        {
            lvXmlFiles.Columns[0].Width = lvXmlFiles.Width - lvXmlFiles.Columns[1].Width - SystemInformation.VerticalScrollBarWidth;
        }

        private void Application_Idle(object sender, EventArgs e)
        {
            btnRemove.Enabled = (lvConnections.SelectedItems.Count > 0);
            btnConfigure.Enabled = (lvConnections.SelectedItems.Count > 0);
            btnRemoveXml.Enabled = (lvXmlFiles.SelectedItems.Count > 0);
            btnConfigureXml.Enabled = (lvXmlFiles.SelectedItems.Count > 0);

            if (tabControl1.SelectedIndex == 0)
            {
                btnOk.Enabled = (lvConnections.SelectedItems.Count > 0);
            }
            else
            {
                btnOk.Enabled = (lvXmlFiles.SelectedItems.Count > 0);
            }
        }

        private void lvConnections_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void lvXmlFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnAddXml_Click(object sender, EventArgs e)
        {
            ConnectionInfo ci = new ConnectionInfo(ConnectionTypes.MSSQL, GetNewXmlFileEntryName(), null, true, "");

            using (ConnectionEditForm cef = new ConnectionEditForm(ci))
            {
                if (cef.ShowDialog() == DialogResult.OK)
                {
                    ListViewItem lvi = lvXmlFiles.Items.Add(ci.Name);
                    lvi.SubItems.Add(ci.Type.ToString());
                    lvi.Tag = ci;
                    lvi.Selected = true;

                    Program.XmlFiles.Add(ci);
                }
            }

            lvXmlFiles.Focus();
        }

        private void btnRemoveXml_Click(object sender, EventArgs e)
        {
            ConnectionInfo ci = (ConnectionInfo)lvXmlFiles.SelectedItems[0].Tag;

            lvXmlFiles.Items.Remove(lvXmlFiles.SelectedItems[0]);
            Program.XmlFiles.Remove(ci);

            lvXmlFiles.Focus();
        }

        private void btnConfigureXml_Click(object sender, EventArgs e)
        {
            if (lvXmlFiles.SelectedItems.Count > 0)
            {
                ConnectionInfo ci = (ConnectionInfo)lvXmlFiles.SelectedItems[0].Tag;

                using (ConnectionEditForm cef = new ConnectionEditForm(ci))
                {
                    if (cef.ShowDialog() == DialogResult.OK)
                    {
                        lvXmlFiles.SelectedItems[0].SubItems[0].Text = ci.Name;
                        lvXmlFiles.SelectedItems[0].SubItems[1].Text = ci.Type.ToString();
                    }
                }
            }
        
            lvXmlFiles.Focus();
        }
    }
}
