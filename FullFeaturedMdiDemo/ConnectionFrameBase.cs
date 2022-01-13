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
using System.Windows.Forms;

namespace FullFeaturedMdiDemo
{
    public class ConnectionFrameBase : UserControl
    {
        public delegate void SyntaxProviderDetected(Type syntaxType);

        public event SyntaxProviderDetected OnSyntaxProviderDetected;

        public virtual void SetServerType(string serverType)
        {

        }

        public void DoSyntaxDetected(Type syntaxType)
        {
            if (OnSyntaxProviderDetected != null)
            {
                OnSyntaxProviderDetected(syntaxType);
            }
        }

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
