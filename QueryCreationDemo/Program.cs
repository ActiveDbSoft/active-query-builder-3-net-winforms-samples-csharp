//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2023 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;
namespace QueryCreationDemo
{

    sealed class Program
    {
        private Program()
        {
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread()]
        static internal void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
