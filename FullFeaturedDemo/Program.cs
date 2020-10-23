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
using FullFeaturedDemo.Properties;
using GeneralAssembly;

namespace FullFeaturedDemo
{
	internal static class Program
	{
		public static string Name = "Active Query Builder Demo";
		public static Settings Settings = new Settings();

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

			//if new version, import upgrade from previous version
			if (Settings.CallUpgrade)
			{
				Settings.Upgrade();
				Settings.CallUpgrade = false;
			}

            if (Program.Settings.Connections != null)
			{
				Connections = Program.Settings.Connections;
            }

			if (Program.Settings.XmlFiles != null)
			{
				XmlFiles = Program.Settings.XmlFiles;
			}

            Connections.RestoreData();
            XmlFiles.RestoreData();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
            
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
			if (exception != null)
			{
				ThreadExceptionDialog exceptionDialog = new ThreadExceptionDialog(exception);
				if (exceptionDialog.ShowDialog() == DialogResult.Abort)
				{
					Application.Exit();
				}
			}
		}
	}
}
