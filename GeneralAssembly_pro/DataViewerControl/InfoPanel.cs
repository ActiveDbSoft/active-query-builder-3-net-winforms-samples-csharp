//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2021 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeneralAssembly.DataViewerControl
{
    public partial class InfoPanel : UserControl
    {
        public string Message
        {
            set
            {
                label1.Text = value;
                Visible = !string.IsNullOrEmpty(value);
                if (Visible) AdjustLabel();

            }
            get { return label1.Text; }
        }

        private void AdjustLabel()
        {
            pictureBox1.Location =
                new Point(Width - pictureBox1.Width - 5, Height / 2 - pictureBox1.Height / 2);
        }

        public InfoPanel()
        {
            InitializeComponent();
            Visible = false;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AdjustLabel();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Message = "";
        }
    }
}
