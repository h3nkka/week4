using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    public class ItParser
    {
        public static int Count(string input)
        {
            try
            {
                string[] stringarray = input.Split(',');
                return stringarray.Count();
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input! Count failed.");
                return -1;
            }
        }

        public static int Sum(string input)
        {
            try
            {
                int[] intarray = Array.ConvertAll(input.Split(','), int.Parse);
                return intarray.Sum();
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input! Sum failed.");
                return -1;
            }
        }

        public static int Average(string input)
        {
            try
            { 
                int[] intarray = Array.ConvertAll(input.Split(','), int.Parse);
                return intarray.Sum()/intarray.Count();
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input! Average failed.");
                return -1;
            }
        }
    }
}
