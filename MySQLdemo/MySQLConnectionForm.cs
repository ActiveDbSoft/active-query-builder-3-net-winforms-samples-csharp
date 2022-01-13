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
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySqlDemo
{
    public partial class MySQLConnectionForm : Form
    {
        public string ConnectionString = "";


        public MySQLConnectionForm()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

            builder.Server = tbServer.Text;
            builder.Database = tbDatabase.Text;
            builder.UserID = tbUser.Text;
            //builder.UseOldSyntax = true;

            if (tbPassword.Text.Length > 0)
            {
                builder.Password = tbPassword.Text;
            }

            this.ConnectionString = builder.ConnectionString;
        }
    }
}
