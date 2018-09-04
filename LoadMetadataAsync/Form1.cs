//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2018 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System.ComponentModel;
using System.Data.OleDb;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;

namespace LoadMetadataAsync
{
	public partial class Form1 : Form
	{
	    public Form1()
		{
		    InitializeComponent();

			// Disable the control so it will be unusable untill the metadata is loaded
			queryBuilder.Enabled = false;

			// Run metadata loading in separate thread
			var backgroundWorker = new BackgroundWorker();
			backgroundWorker.DoWork += BackgroundWorker_DoWork;
			backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
			backgroundWorker.WorkerReportsProgress = false;
			backgroundWorker.RunWorkerAsync();
		}

		private static void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			// Create temporary QueryBuilder instance
            using (SQLContext sqlContext = new SQLContext())
			{
				// Create temporary MetadataProvider
				using (OLEDBMetadataProvider oledbMetadataProvider = new OLEDBMetadataProvider())
				{
					// Create connection to database
					oledbMetadataProvider.Connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=demo.mdb");
					// Set up the QueryBuilder
					sqlContext.MetadataProvider = oledbMetadataProvider;
					sqlContext.SyntaxProvider = new MSAccessSyntaxProvider();
					// Load metadata, force fields loading for all metadata objects
					sqlContext.MetadataContainer.LoadAll(true);

					// Put copy of filled metadata container to worker result
					e.Result = sqlContext.MetadataContainer.Clone(sqlContext);
				}
			}
		}

		private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			// Assign filled metadata container to the main instance of the QueryBuilder
			queryBuilder.MetadataContainer.Assign((MetadataItem)e.Result);
			// Enable the control
			queryBuilder.Enabled = true;
			queryBuilder.InitializeDatabaseSchemaTree();
		}
	}
}
