using System;
using System.Collections.Generic;

namespace Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            Ordinary();
            Extra();
        }

        static void Ordinary() {
            var a = new Complex(2, 3);
            var b = new Complex(3, 4);

            Dictionary<String, Complex> dict = new Dictionary<string, Complex> {
                { "+", Complex.AddComplex(a, b) },
                { "-", Complex.SubComplex(a, b) },
                { "*", Complex.MulComplex(a, b) },
                { "/", Complex.DivComplex(a, b) }
            };

            foreach (var item in dict) {
                a.PrintComplex();
                Console.Write(" " + item.Key + " ");
                b.PrintComplex();
                Console.Write(" = ");
                item.Value.PrintComplex();
                Console.Write("\n");
            }
            Console.Write("\n");
        }

        static void Extra() {
            var a = new Complex(2, 3);
            var b = new Complex(6, 1.5);

            var divided = a / b;
            var addedMore = divided + 2.5;

            var l1 = a.ToString() + " / " + b.ToString() + " = " + divided.ToString();
            var l2 = divided.ToString() + " + " + 2.5.ToString() + " = " + addedMore.ToString();
            var l2p = divided.ToString() + " + " + 2.5.ToString() + " = " + addedMore.PreciseString();

            Console.WriteLine(l1 + "\n" + l2 + "\n" + l2p);
        }
    }
}
