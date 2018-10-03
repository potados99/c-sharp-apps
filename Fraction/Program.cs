using System;

namespace Fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Fraction(2,3);
            var b = new Fraction(-3,2);
            var one = new Fraction(1);

            var c = a - b;
            var d = a + 2;

            PerformAndPrintOperation(a, b, '+' ,(x, y) => x + y);
            PerformAndPrintOperation(a, b, '-', (x, y) => x - y);
            PerformAndPrintOperation(a, b, '*', (x, y) => x * y);
            PerformAndPrintOperation(a, b, '/', (x, y) => x / y);

            Console.Read();
        }


        static void PerformAndPrintOperation(Fraction left, Fraction right, char operatorChar, Func<Fraction, Fraction, Fraction> action) {

            Console.WriteLine("Operation " + operatorChar + ": " + 
                              String.Format("{0}{1} {2} {3}{4} = {5}", 
                                            left.IsNegative() ? "-" : "", 
                                            left.ToString(false), 
                                            operatorChar == '+' || operatorChar == '-' ? (right.IsNegative() && operatorChar == '-' ? '+' : '-') : operatorChar, 
                                            right.IsNegative() && operatorChar != '+' && operatorChar != '-' ? "-" : "", 
                                            right.ToString(false),
                                            action(left, right).ToString()
                                           ));
        }
    }
}
