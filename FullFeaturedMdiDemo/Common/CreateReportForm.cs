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

using System.Windows.Forms;

namespace FullFeaturedMdiDemo.Common
{
    public partial class CreateReportForm : Form
    {
        public ReportType? SelectedReportType { get; set; }
    
        public CreateReportForm()
        {
            InitializeComponent();
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            if (rbActiveReport.Checked)
            {
                SelectedReportType = ReportType.ActiveReports14;
                return;
            }

            if (rbStimulsoft.Checked)
            {
                SelectedReportType = ReportType.Stimulsoft;
                return;
            }

            if (rbFastReport.Checked)
            {
                SelectedReportType = ReportType.FastReport;
            }
        }
    }
}
