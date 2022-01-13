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
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using iAnywhere.Data.SQLAnywhere;

namespace SybaseDemo
{
    public partial class SybaseConnectionForm : Form
    {
        public string ConnectionString = "";


        public SybaseConnectionForm()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textboxDatabaseFile.Text = openFileDialog1.FileName;
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            SAConnectionStringBuilder builder = new SAConnectionStringBuilder();

            builder.ServerName = textboxServerName.Text;
            builder.DataSourceName = textboxDataSourceName.Text;
            builder.DatabaseFile = textboxDatabaseFile.Text;
            builder.UserID = textboxUser.Text;
            builder.Password = textboxPassword.Text;

            this.ConnectionString = builder.ConnectionString;
        }
    }
}
