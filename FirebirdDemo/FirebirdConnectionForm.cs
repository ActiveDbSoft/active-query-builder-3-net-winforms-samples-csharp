//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2024 Active Database Software              //
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

using FirebirdSql.Data.FirebirdClient;


namespace FirebirdDemo
{
    public partial class FirebirdConnectionForm : Form
    {
        public string ConnectionString = "";


        public FirebirdConnectionForm()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textboxDatabase.Text = openFileDialog1.FileName;
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {

            FbConnectionStringBuilder builder = new FbConnectionStringBuilder();

            builder.DataSource = textboxServer.Text;
            builder.Database = textboxDatabase.Text;
            
            if (textboxUser.Text.Length > 0)
            {
                builder.UserID = textboxUser.Text;
            }

            if (textboxPassword.Text.Length > 0)
            {
                builder.Password = textboxPassword.Text;
            }

            this.ConnectionString = builder.ConnectionString;
        }
    }
}
