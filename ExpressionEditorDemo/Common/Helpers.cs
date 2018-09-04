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
            return new Point((int) customPoint.X, (int) customPoint.Y);
        }
        
        public static CFont ToCFont(object font)
        {
            var castedFont = font as Font;
            if (castedFont == null)
                return null;

            return new CFont(castedFont.FontFamily.Name, castedFont.Size, castedFont.Bold, castedFont.Italic)
            {
                LineSpacing = castedFont.Height / castedFont.Size
            };
        }
    }
}
