//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2019 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.Threading;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View.WinForms;
using GeneralAssembly;

namespace FullFeaturedMdiDemo
{
	internal static class Program
	{
		public static string Name = "Active Query Builder Demo";
		public static Properties.Settings Settings = new Properties.Settings();

		public static ConnectionList Connections = new ConnectionList();
		public static ConnectionList XmlFiles = new ConnectionList();

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
			Application.ThreadException += Thread_UnhandledException;

            var i = ControlFactory.Instance; // force call static constructor of control factory
		    
		    //if new version, import upgrade from previous version
            if (Settings.CallUpgrade)
			{
				Settings.Upgrade();
				Settings.CallUpgrade = false;
			}

			if (Program.Settings.Connections != null)
			{
				Connections = Program.Settings.Connections;
                Connections.RemoveObsoleteConnectionInfos();
                Connections.RestoreData();
			}

			if (Program.Settings.XmlFiles != null)
			{
				XmlFiles = Program.Settings.XmlFiles;
			    XmlFiles.RemoveObsoleteConnectionInfos();
            }

		    Helpers.Localizer.Language = Settings.Language;

            Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());

            Connections.SaveData();		    

            Program.Settings.Connections = Connections;
			Program.Settings.XmlFiles = XmlFiles;
			Program.Settings.Save();
		}

		private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
		{
			Exception exception = e.ExceptionObject as Exception;
			if (exception != null)
			{
				ThreadExceptionDialog exceptionDialog = new ThreadExceptionDialog(exception);
				if (exceptionDialog.ShowDialog() == DialogResult.Abort)
				{
					Application.Exit();
				}
			}
		}

		private static void Thread_UnhandledException(object sender, ThreadExceptionEventArgs e)
		{
			Exception exception = e.Exception;
            if (exception == null) return;

            var exceptionDialog = new ThreadExceptionDialog(exception);
            if (exceptionDialog.ShowDialog() == DialogResult.Abort)
                Application.Exit();
        }
	}
}
