//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2022 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System.Drawing;

namespace GeneralAssembly.Common
{
    public static class Extensions
    {
        public static Point ToNativePoint(this ActiveQueryBuilder.View.CPoint cPoint)
        {
            return new Point((int)cPoint.X, (int)cPoint.Y);
        }

        public static ActiveQueryBuilder.View.CPoint FromNativePoint(this Point Point)
        {
            return new ActiveQueryBuilder.View.CPoint(Point.X, Point.Y);
        }
    }
}
