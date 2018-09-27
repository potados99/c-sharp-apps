using System;

namespace Fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Fraction(2,3);
            var b = new Fraction(3,2);
            var one = new Fraction(1);

            var c = a - b;
            var d = a + 2;

            Console.WriteLine(a.ToString() + " - " + b.ToString() + " = " + c.ToString());
            Console.WriteLine(a.ToString() + " + " + 2.ToString() + " = " + d.ToString());

            Console.Read();
        }
    }
}
