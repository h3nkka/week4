using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo culture1 = new CultureInfo("fi-FI", false);
            Console.WriteLine("The current culture is {0}", culture1.Name);
            Console.WriteLine("Culture Name:    {0}", culture1.Name);
            Console.WriteLine("User Overrides:  {0}", culture1.UseUserOverride);
            Console.WriteLine("Currency Symbol: {0}", culture1.NumberFormat.CurrencySymbol);
            Console.WriteLine("Date Separator: {0}\n", culture1.DateTimeFormat.DateSeparator);

            Console.WriteLine("Input a date to see if it's in Finnish format. Input a new line to stop.");
            while (true)
            {
                string date = Console.ReadLine();
                if (date == "")
                    break;
                Console.WriteLine("Input {0} IsFinnishDate: {1}", date, ItMath.IsFinnishDate(date, culture1));
            }
        }
    }
}
