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
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using MetadataEditorDemo.Common;

namespace MetadataEditorDemo
{
    static class Program
    {
        /// <summary>
        /// ������� ����� ����� ��� ����������.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MSSQLConnectionDescriptor.Register();
            ODBCConnectionDescriptor.Register();
            OLEDBConnectionDescriptor.Register();
            OracleNativeConnectionDescriptor.Register();
            MySQLConnectionDescriptor.Register();
            FirebirdConnectionDescriptor.Register();
            SybaseConnectionDescriptor.Register();
            PostgreSQLConnectionDescriptor.Register();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MetadataEditor());
        }
    }
}
