﻿//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2019 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.Drawing;
using ActiveQueryBuilder.View;

namespace ExpressionEditorDemo.Common
{
    internal static class Helpers
    {
        private const int DesignTimeDpi = 96;
        private static int _currentDPI = -1;

        private static int MulDiv(int number, int numerator, int denominator)
        {
            return (int)(((long)number * numerator) / denominator);
        }

        public static int GetCurrentDPI()
        {
            try
            {
                var graphics = Graphics.FromHwnd(IntPtr.Zero);
                var result = (int)graphics.DpiX;
                graphics.Dispose();

                return result;
            }
            catch
            {
                return DesignTimeDpi;
            }
        }

        public static int ScaleByCurrentDPI(int value)
        {
            if (_currentDPI == -1)
            {
                _currentDPI = GetCurrentDPI();
            }

            return MulDiv(value, _currentDPI, DesignTimeDpi);
        }

        public static Rectangle ScaleByCurrentDPI(Rectangle bounds)
        {
            if (_currentDPI == -1)
            {
                _currentDPI = GetCurrentDPI();
            }

            return new Rectangle(MulDiv(bounds.X, _currentDPI, DesignTimeDpi), MulDiv(bounds.Y, _currentDPI, DesignTimeDpi),
                MulDiv(bounds.Width, _currentDPI, DesignTimeDpi), MulDiv(bounds.Height, _currentDPI, DesignTimeDpi));
        }
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
