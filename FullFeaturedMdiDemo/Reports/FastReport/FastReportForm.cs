//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2025 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.Data;
using System.Windows.Forms;
using FastReport;
using FastReport.Utils;

namespace FullFeaturedMdiDemo.Reports
{
    public partial class FastReportForm : Form
    {
        private DataTable DataTable { get; set; }
        private Report _report;

        public FastReportForm(DataTable dataTable)
        {
            DataTable = dataTable;
            InitializeComponent();
        }

        private void buttonDesigner_Click(object sender, EventArgs e)
        {
            _report.Design();
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            _report.Show();
        }

        private void FastReportForm_Load(object sender, EventArgs e)
        {
            var dataSet = new DataSet(DataTable.TableName);
            dataSet.Tables.Add(DataTable);
            _report = new Report();

            // register all data tables and relations
            _report.RegisterData(dataSet);

            // enable the "result" table to use it in the report
            _report.GetDataSource(DataTable.TableName).Enabled = true;

            // add report page
            ReportPage page = new ReportPage();
            _report.Pages.Add(page);
            // always give names to objects you create. You can use CreateUniqueName method to do this;
            // call it after the object is added to a report.
            page.CreateUniqueName();

            // create title band
            page.ReportTitle = new ReportTitleBand { Height = Units.Centimeters * 1 };

            page.ReportTitle.CreateUniqueName();

            // create title text
            TextObject titleText = new TextObject
            {
                Bounds = new System.Drawing.RectangleF(Units.Centimeters * 5, 0, Units.Centimeters * 10, Units.Centimeters * 1),
                Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold),
                Text = "Report result",
                HorzAlign = HorzAlign.Center,
                Parent = page.ReportTitle
            };
            titleText.CreateUniqueName();

            // create data band
            DataBand dataBand = new DataBand();
            page.Bands.Add(dataBand);
            dataBand.CreateUniqueName();
            dataBand.DataSource = _report.GetDataSource(DataTable.TableName);
            dataBand.Height = Units.Centimeters * 0.5f;
            var width = page.PaperWidth / DataTable.Columns.Count;

            foreach (DataColumn column in DataTable.Columns)
            {
                // create two text objects with employee's name and birth date
                TextObject empNameText = new TextObject
                {
                    Bounds = new System.Drawing.RectangleF(0, 0, width * Units.Millimeters, Units.Centimeters * 0.5f),
                    Text = "[" + DataTable.TableName + "." + column.ColumnName + "]",
                    Parent = dataBand,
                    Dock = DockStyle.Left,
                };
                empNameText.CreateUniqueName();
            }
        }
    }
}
