using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace week4
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo culture1 = new CultureInfo("fi-FI",false);
            Console.WriteLine("The current culture is {0}", culture1.Name);
            Console.WriteLine("Culture Name:    {0}", culture1.Name);
            Console.WriteLine("User Overrides:  {0}", culture1.UseUserOverride);
            Console.WriteLine("Currency Symbol: {0}", culture1.NumberFormat.CurrencySymbol);
            Console.WriteLine("Decimal Separator: {0}\n", culture1.NumberFormat.NumberDecimalSeparator);

            ItMath.IsNumber(Console.ReadLine());
            Console.ReadKey(true);
        }
    }
}
