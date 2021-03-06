﻿using System;
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

            Console.WriteLine("Input anything to test if it's a number. Input a new line to stop.");
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                    break;
                Console.WriteLine("Input {0} IsNumber: {1}", input, ItMath.IsNumber(input, culture1));
            }
        }
    }
}
