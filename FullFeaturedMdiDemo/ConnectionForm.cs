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
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using GeneralAssembly;


namespace FullFeaturedMdiDemo
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
            AddPresets();

            // fill connection list
            for (int i = 0; i < Program.Connections.Count; i++)
            {
                ListViewItem lvi = lvConnections.Items.Add(Program.Connections[i].Name);
                lvi.SubItems.Add(Program.Connections[i].ConnectionDescriptor.GetDescription());
                lvi.Tag = Program.Connections[i];
            }

            if (lvConnections.Items.Count > 0)
            {
                lvConnections.Items[0].Selected = true;
            }            

            // fill XML files list
            for (int i = 0; i < Program.XmlFiles.Count; i++)
            {
                ListViewItem lvi = lvXmlFiles.Items.Add(Program.XmlFiles[i].Name);
                lvi.SubItems.Add(Program.XmlFiles[i].ConnectionDescriptor.SyntaxProvider.Description);
                lvi.Tag = Program.XmlFiles[i];
            }

            if (lvXmlFiles.Items.Count > 0)
            {
                lvXmlFiles.Items[0].Selected = true;
            }

            Application.Idle += Application_Idle;
        }

        private void AddPresets()
        {
            var presets = new List<ConnectionInfo>
            {
                new ConnectionInfo("Northwind.xml", "Northwind.xml", ConnectionTypes.ODBC)
                {
                    IsXmlFile = true
                },

                new ConnectionInfo(new SQLiteConnectionDescriptor(), "SQLite", ConnectionTypes.SQLite, @"data source=northwind.sqlite"),
                new ConnectionInfo(new MSAccessConnectionDescriptor(), "MS Access", ConnectionTypes.MSAccess, @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Nwind.mdb")
            };

            foreach (var preset in presets)
            {
                if (!FindConnectionInfo(preset))
                    if (preset.IsXmlFile)
                        Program.XmlFiles.Add(preset);
                    else
                        Program.Connections.Add(preset);
            }
        }

        private bool FindConnectionInfo(ConnectionInfo connectionInfo)
        {
            ConnectionList connectionList;
            if (connectionInfo.IsXmlFile)
                connectionList = Program.XmlFiles;
            else
                connectionList = Program.Connections;

            for (int i = 0; i < connectionList.Count; i++)
            {
                if (connectionList[i].Equals(connectionInfo))
                {
                    return true;
                }
            }

            return false;
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
            ConnectionInfo ci = new ConnectionInfo(new MSSQLConnectionDescriptor(), GetNewConnectionEntryName(), ConnectionTypes.MSSQL, "");

            using (EditConnectionForm cef = new EditConnectionForm(ci))
            {
                if (cef.ShowDialog() == DialogResult.OK)
                {
                    ListViewItem lvi = lvConnections.Items.Add(ci.Name);
                    lvi.SubItems.Add(ci.ConnectionDescriptor.GetDescription());
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

                using (EditConnectionForm cef = new EditConnectionForm(ci))
                {
                    if (cef.ShowDialog() == DialogResult.OK)
                    {
                        lvConnections.SelectedItems[0].SubItems[0].Text = ci.Name;
                        lvConnections.SelectedItems[0].SubItems[1].Text = ci.ConnectionDescriptor.GetDescription();
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
            var name = GetNewXmlFileEntryName();
            ConnectionInfo ci = new ConnectionInfo(string.Empty, name, ConnectionTypes.ODBC)
            {
                IsXmlFile = true
            };

            using (EditXMLConnectionForm cef = new EditXMLConnectionForm(ci))
            {
                if (cef.ShowDialog() == DialogResult.OK)
                {
                    ListViewItem lvi = lvXmlFiles.Items.Add(ci.Name);
                    lvi.SubItems.Add(ci.ConnectionDescriptor.SyntaxProvider.Description);
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

                using (EditXMLConnectionForm cef = new EditXMLConnectionForm(ci))
                {
                    if (cef.ShowDialog() == DialogResult.OK)
                    {
                        lvConnections.SelectedItems[0].SubItems[0].Text = ci.Name;
                        lvConnections.SelectedItems[0].SubItems[1].Text = ci.ConnectionDescriptor.GetDescription();
                    }
                }
            }

            lvXmlFiles.Focus();
        }
    }
}
