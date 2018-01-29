using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace week4
{
    public static class ItMath
    {
        public static bool IsNumber(string input, CultureInfo culture1)
        {
            try
            {
                float.Parse(input, culture1.NumberFormat);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
