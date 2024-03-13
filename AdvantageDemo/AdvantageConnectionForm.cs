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
using System.Windows.Forms;

using Advantage.Data.Provider;

namespace AdvantageDemo
{
    public partial class AdvantageConnectionForm : Form
    {
        public string ConnectionString { get; set; }

        public AdvantageConnectionForm()
        {
            InitializeComponent();

            cbServerType.SelectedItem = "local";
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textboxDataSource.Text = openFileDialog1.FileName;
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            AdsConnectionStringBuilder builder = new AdsConnectionStringBuilder();

            builder.DataSource = textboxDataSource.Text;
            builder.ServerType = cbServerType.SelectedItem.ToString();

            if (textboxUser.Text.Length > 0)
                builder.UserID = textboxUser.Text;

            if (textboxPassword.Text.Length > 0)
                builder.Password = textboxPassword.Text;

            ConnectionString = builder.ConnectionString;
        }
    }
}
