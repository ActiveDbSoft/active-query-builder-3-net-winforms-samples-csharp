//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2025 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System.Windows.Forms;

namespace FullFeaturedMdiDemo
{
    public partial class ConnectionStringEditForm : Form
    {
        public string ConnectionString
        {
            get { return tbConnectionString.Text; }
            set
            {
                tbConnectionString.Text = value;
                tbConnectionString.Modified = false;
            }
        }

        public bool Modified
        {
            get { return tbConnectionString.Modified; }
        }

        public ConnectionStringEditForm()
        {
            InitializeComponent();
        }
    }
}
