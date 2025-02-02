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
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActiveQueryBuilder.View.WinForms;
using CriteriaBuilderCustomize.Properties;
using GeneralAssembly;

namespace CriteriaBuilderCustomize
{
    static class Program
    {
        public static Settings Settings = new Settings();
        public static ConnectionList Connections = new ConnectionList();
        public static ConnectionList XmlFiles = new ConnectionList();

        [STAThread]
        static void Main()
        {
            var i = ControlFactory.Instance; // force call static constructor of control factory

            //if new version, import upgrade from previous version
            if (Settings.CallUpgrade)
            {
                Settings.Upgrade();
                Settings.CallUpgrade = false;
            }

            if (Settings.Connections != null)
            {
                Connections = Settings.Connections;
                Connections.RemoveObsoleteConnectionInfos();
                Connections.RestoreData();
            }

            if (Settings.XmlFiles != null)
            {
                XmlFiles = Settings.XmlFiles;
                XmlFiles.RemoveObsoleteConnectionInfos();
            }

            // Catch ungandled exceptions for debugging purposes
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.ThreadException += Thread_UnhandledException;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Connections.SaveData();

            Settings.Connections = Connections;
            Settings.XmlFiles = XmlFiles;
            Settings.Save();
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception exception = e.ExceptionObject as Exception;
            if (exception == null) return;

            ThreadExceptionDialog exceptionDialog = new ThreadExceptionDialog(exception);
            if (exceptionDialog.ShowDialog() == DialogResult.Abort)
            {
                Application.Exit();
            }
        }

        private static void Thread_UnhandledException(object sender, ThreadExceptionEventArgs e)
        {
            if (e.Exception == null) return;

            ThreadExceptionDialog exceptionDialog = new ThreadExceptionDialog(e.Exception);

            if (exceptionDialog.ShowDialog() == DialogResult.Abort)
            {
                Application.Exit();
            }
        }
    }
}
