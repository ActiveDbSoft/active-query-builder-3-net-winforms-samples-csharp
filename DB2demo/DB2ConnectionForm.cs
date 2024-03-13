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
#if NETCOREAPP
using IBM.Data.DB2.Core;
#else
using IBM.Data.DB2;
#endif

namespace DB2demo
{
    public partial class DB2ConnectionForm : Form
    {
        public string ConnectionString = "";


        public DB2ConnectionForm()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            DB2ConnectionStringBuilder builder = new DB2ConnectionStringBuilder();

            builder.Server = textboxServer.Text;
            builder.Database = textboxDatabase.Text;
            builder.UserID = textboxUser.Text;

            if (textboxPassword.Text.Length > 0)
            {
                builder.Password = textboxPassword.Text;
            }

            this.ConnectionString = builder.ConnectionString;
        }
    }
}
