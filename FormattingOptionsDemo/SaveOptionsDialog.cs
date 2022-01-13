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

namespace FormattingOptionsDemo
{
    public partial class SaveOptionsDialog : Form
    {
        public string OptionsName { get; private set; }

        public bool Result { get; private set; }

        public SaveOptionsDialog()
        {
            InitializeComponent();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show(Owner, "The name can't be empty!");
                return;
            }

            OptionsName = textBox.Text;

            Result = true;

            Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Result = false;

            Close();
        }
    }
}
