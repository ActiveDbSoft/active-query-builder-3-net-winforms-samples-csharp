//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2022 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System.Windows.Forms;

namespace GeneralAssembly.ConnectionFrames
{
    public class ConnectionFrameBase : UserControl
    {
        public virtual string ConnectionString
        {
            get { return null; }
            set { }
        }

        public virtual bool TestConnection()
        {
            return false;
        }
    }
}
