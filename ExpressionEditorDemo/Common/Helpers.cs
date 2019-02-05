//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2019 Active Database Software              //
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
        public static CPoint FromNativePoint(this Point stdPoint)
        {
            return new CPoint(stdPoint.X, stdPoint.Y);
        }

        public static Point ToNativePoint(this CPoint customPoint)
        {
            return new Point((int) customPoint.X, (int) customPoint.Y);
        }
        
        public static CFont ToCFont(object font)
        {
            var castedFont = font as Font;
            if (castedFont == null)
                return null;

            return new CFont(castedFont.FontFamily.Name, castedFont.Size, castedFont.Bold, castedFont.Italic);
        }

        public static Font ToFont(this CFont font)
        {
            FontStyle style = FontStyle.Regular;
            if (font.Bold)
            {
                style |= FontStyle.Bold;
            }
            if (font.Italic)
            {
                style |= FontStyle.Italic;
            }

            return new Font(font.Family, (float)font.Size, style, (GraphicsUnit)font.Unit);
        }

        public static CFont ToCFont(this Font font)
        {

            return new CFont(font.FontFamily.Name, font.Size, font.Bold, font.Italic) { Unit = (CFont.FontUnit)font.Unit };
        }
    }
}
