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
        public static bool IsNumber(string input)
        {
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ",";
            int kek = Int32.Parse(input);
            return true;
        }
    }
}
