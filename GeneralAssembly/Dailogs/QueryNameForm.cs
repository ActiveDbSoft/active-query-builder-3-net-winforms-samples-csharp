//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2021 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System.Windows.Forms;

namespace GeneralAssembly.Dailogs
{
    public partial class QueryNameForm : Form
    {
        public QueryNameForm()
        {
            InitializeComponent();
        }

        public string QueryName {
            get
            {
                return textBox1.Text;
            }
            set {
                textBox1.Text = value;
            }
        }

        private void QueryNameForm_Shown(object sender, System.EventArgs e)
        {
            textBox1.SelectAll();
        }
    }
}
