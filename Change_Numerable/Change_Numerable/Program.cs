using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_Numerable
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var l in System.IO.File.ReadAllLines(@"..\..\Program.cs").Every2nd(6))
            {
                Console.WriteLine(l); 
            }
        }
    }


    public static class StringExtensions
    {
        public static IEnumerable<string> Every2nd(this IEnumerable<string> str)
        {
            bool isFirst = true; 
            foreach (var l in str)
            {
                if (isFirst) { yield return l; }

                isFirst = !isFirst;
            }
        }
        public static IEnumerable<string> Every2nd(this IEnumerable<string> str, int value)
        {
            int counter = 0; 
            foreach(var l in str)
            {
                if (counter < value)
                    yield return l;

                counter++;
            }
        }
    }

}
