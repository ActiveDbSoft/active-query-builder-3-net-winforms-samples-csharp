//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2025 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Stimulsoft.Base.Drawing;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;

namespace StimulsoftExtension
{
    public partial class StimulsoftForm : Form
    {
        private DataTable DataTable { get; set; }
        public StimulsoftForm(DataTable dataTable)
        {
            DataTable = dataTable;

            InitializeComponent();
        }

        private void StimulsoftForm_Load(object sender, System.EventArgs e)
        {
            StiReport report = new StiReport();

            // Add data to datastore
            report.RegData(DataTable);

            // Fill dictionary
            report.Dictionary.Synchronize();

            var page = report.Pages[0];

            //Create HeaderBand
            var headerBand = new StiHeaderBand { Height = 0.5, Name = "HeaderBand" };
            page.Components.Add(headerBand);

            //Create Databand
            var dataBand = new StiDataBand
            {
                DataSourceName = "result",
                Height = 0.5,
                Name = "DataBand"
            };
            page.Components.Add(dataBand);
            var width = page.Width / DataTable.Columns.Count;
            foreach (DataColumn column in DataTable.Columns)
            {
                //Create text on header
                var headerText = new StiText(new RectangleD(0, 0, width, 0.5))
                {
                    Text = column.ColumnName,
                    HorAlignment = StiTextHorAlignment.Center,
                    Brush = new StiSolidBrush(Color.Gainsboro),
                    Dockable = true,
                    DockStyle = StiDockStyle.Left,
                    CanShrink = true,
                    CanGrow = true,
                    VertAlignment = StiVertAlignment.Center
                };
                headerBand.Components.Add(headerText);

                //Create text
                var dataText = new StiText(new RectangleD(0, 0, width, 0.5))
                {
                    Text = "{result." + column.ColumnName + "}",
                    Dockable = true,
                    DockStyle = StiDockStyle.Left,
                    VertAlignment = StiVertAlignment.Center,
                    CanShrink = true,
                    CanGrow = true,
                };
                dataBand.Components.Add(dataText);
            }

            stiViewerControl1.Report = report;
            report.Compile();
            report.Render(true);
        }

        private void buttonDesigner_Click(object sender, System.EventArgs e)
        {
            stiViewerControl1.Report.Design();
        }
    }
}
