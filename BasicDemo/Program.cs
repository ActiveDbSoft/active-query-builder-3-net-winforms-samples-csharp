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

namespace BasicDemo
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			// Catch ungandled exceptions for debugging purposes
			AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
			Application.ThreadException += Thread_UnhandledException;

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
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
			if (e.Exception != null)
			{
				ThreadExceptionDialog exceptionDialog = new ThreadExceptionDialog(e.Exception);

				if (exceptionDialog.ShowDialog() == DialogResult.Abort)
				{
					Application.Exit();
				}
			}
		}
	}
}
