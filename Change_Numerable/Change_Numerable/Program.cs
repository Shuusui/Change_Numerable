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
            foreach (var l in System.IO.File.ReadAllLines(@"..\..\Program.cs").Every2nd())
            {
                Console.WriteLine(l); 
            }
        }
    }


    public static class StringExtensions
    {
        public static IEnumerable<string> Every2nd(this IEnumerable<string> str)
        {

            return str;
        }
    }
    
    class ExtenededEnumerable : IEnumerable<string>
    {
        private IEnumerator<string> str;

        ExtenededEnumerable(IEnumerator<string> str)
        {
            this.str = str; 
        }

        public IEnumerator<string> GetEnumerator()
        {
            ExtendedEnumerator numerator = new ExtendedEnumerator(str); 
            return numerator; 
        }

        IEnumerator IEnumerable.GetEnumerator() //egal
        {
            throw new NotImplementedException();
        }

    }

    class ExtendedEnumerator : IEnumerator<string>
    {
        public string Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        public ExtendedEnumerator(IEnumerator<string> str)
        {

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
