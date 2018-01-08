using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighAndLow
{
    public class Program
    {
        public static string HighAndLow(string value)
        {
            int[] nums = value.Split().Select(int.Parse).ToArray();
            //int[] nums = substrings.Select(int.Parse).ToArray();
            return nums.Max() + " " + nums.Min();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
            Console.ReadKey();
        }

    }
}
