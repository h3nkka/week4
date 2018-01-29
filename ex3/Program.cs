using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a comma-separated series of values ranging from 1 to 10.");
            string series = Console.ReadLine();
            Console.WriteLine("Input count: {0}", ItParser.Count(series));
            Console.WriteLine("Input sum: {0}", ItParser.Sum(series));
            Console.WriteLine("Input average: {0}", ItParser.Average(series));
            Console.ReadKey(true);
        }
    }
}
