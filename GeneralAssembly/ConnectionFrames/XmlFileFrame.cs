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

namespace GeneralAssembly.ConnectionFrames
{
    public partial class XmlFileFrame : ConnectionFrameBase
    {
        public override string ConnectionString
        {
            get { return tbXmlFile.Text; }
            set { tbXmlFile.Text = value; }
        }

        public XmlFileFrame(string xmlFilePath)
        {
            InitializeComponent();

            tbXmlFile.Text = xmlFilePath;
        }

        public override bool TestConnection()
        {
            if (String.IsNullOrEmpty(ConnectionString))
            {
                MessageBox.Show(@"Invalid Xml file path.", @"Demo project");

                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnLoadMetadata_Click(object sender, EventArgs e)
        {
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = ConnectionString;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ConnectionString = openFileDialog1.FileName;
            }
        }
    }
}
