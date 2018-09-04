//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2018 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System.Windows.Forms;

namespace FullFeaturedMdiDemo.Dailogs
{
    public partial class SaveForm : Form
    {
        public bool IsSave { set; get; }
        
        public SaveForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            IsSave = true;
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            IsSave = false;
        }
    }
}
