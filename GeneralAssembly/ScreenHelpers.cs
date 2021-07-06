//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2021 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.Drawing;

namespace GeneralAssembly
{
    public class ScreenHelpers
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
    }
}
