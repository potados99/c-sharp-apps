using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Fraction(1,2);
            var b = new Fraction(2,3);

            var c = a - b;
            var d = a + 2;

            Console.WriteLine(c.ToString() + " " + d.ToString());

            Console.Read();
        }
    }
}
