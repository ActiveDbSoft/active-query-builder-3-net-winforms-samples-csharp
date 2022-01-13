//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2022 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.Threading;
using System.Windows.Forms;
using ActiveQueryBuilder.View.WinForms;
using BasicDemo.Properties;
using GeneralAssembly;

namespace BasicDemo
{
    internal static class Program
    {
        public static Settings Settings = new Settings();

        public static ConnectionList Connections = new ConnectionList();
        public static ConnectionList XmlFiles = new ConnectionList();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
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

            // Catch ungandled exceptions for debugging purposes
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.ThreadException += Thread_UnhandledException;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

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
