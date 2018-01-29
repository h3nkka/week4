using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ex2
{
    public static class ItMath
    {
        public static bool IsFinnishDate(string input, CultureInfo culture1)
        {
            DateTime date;
            return DateTime.TryParseExact(input, new string[] { "d", "d.M.yy" }, culture1.DateTimeFormat, DateTimeStyles.AssumeLocal, out date);
        }
    }
}
