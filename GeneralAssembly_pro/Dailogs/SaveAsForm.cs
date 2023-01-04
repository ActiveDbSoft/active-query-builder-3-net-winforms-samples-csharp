//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2023 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System.Windows.Forms;

namespace GeneralAssembly.Dailogs
{
    public partial class SaveAsForm : Form
    {
        public bool SaveAsFile { set; get; }
        
        public SaveAsForm(string nameQuery)
        {
            InitializeComponent();

            label1.Text = string.Format("Save changes to the [{0}]?", nameQuery);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            SaveAsFile = true;
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            SaveAsFile = false;
        }
    }
}
