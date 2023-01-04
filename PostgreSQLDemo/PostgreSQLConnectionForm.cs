//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2023 Active Database Software              //
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

using Npgsql;

namespace PostgreSQLDemo
{
    public partial class PostgreSQLConnectionForm : Form
    {
        public string ConnectionString = "";


        public PostgreSQLConnectionForm()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            string connectionString =
                "Server=" + tbServer.Text +
                ";Port=" + tbPort.Text +
                ";Database=" + tbDatabase.Text +
                ";Userid=" + tbLogin.Text +
                ";Password=" + tbPassword.Text;

            this.ConnectionString = connectionString;
        }
    }
}
