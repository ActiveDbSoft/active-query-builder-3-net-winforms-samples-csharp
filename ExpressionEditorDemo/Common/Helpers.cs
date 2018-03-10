//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2018 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System.Drawing;
using ActiveQueryBuilder.View;

namespace ExpressionEditorDemo.Common
{
    internal static class Helpers
    {
        public static CPoint FromNativePoint(Point stdPoint)
        {
            return new CPoint(stdPoint.X, stdPoint.Y);
        }

        public static Point ToNativePoint(CPoint customPoint)
        {
            return new Point(customPoint.X, customPoint.Y);
        }
    }
}
