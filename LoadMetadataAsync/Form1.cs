//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2025 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System.ComponentModel;
using System.Data.SQLite;
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
            using (var sqlContext = new SQLContext())
            {
                // Create temporary MetadataProvider
                using (var metadataProvider = new SQLiteMetadataProvider())
                {
                    // Create connection to database
                    metadataProvider.Connection = new SQLiteConnection("Data Source=northwind.sqlite;Version=3;");
                    // Set up the QueryBuilder
                    sqlContext.MetadataProvider = metadataProvider;
                    sqlContext.SyntaxProvider = new SQLiteSyntaxProvider();
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
