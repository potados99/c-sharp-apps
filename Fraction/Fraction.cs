using System;
using System.Collections.Generic;

namespace Fraction
{
    class Fraction
    {
        #region Properties

        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        #endregion


        #region Constructor

        public Fraction(int Numerator, int Denominator = 1)
        {
            if (Denominator == 0)
            {
                throw new DivideByZeroException("감히 분모가 0인 수를 만들려고 하다니!");
            }

            var gcd = GetGCD(Numerator, Denominator);
            this.Numerator = Numerator / gcd;
            this.Denominator = Denominator / gcd;
        }

        #endregion


        #region Public Methods

        public override string ToString()
        {
            return String.Format("{0}/{1}", this.Numerator, this.Denominator);
        }

        #region Operator

        public static Fraction operator +(Fraction left, Object right)
        {
            return Add(left, right);
        }
        public static Fraction operator +(Object left, Fraction right)
        {
            return Add(left, right);
        }

        public static Fraction operator-(Fraction left, Object right)
        {
            return Subtract(left, right);
        }
        public static Fraction operator-(Object left, Fraction right)
        {
            return Subtract(left, right);
        }

        public static Fraction operator*(Fraction left, Object right)
        {
            return Multiply(left, right);
        }
        public static Fraction operator*(Object left, Fraction right)
        {
            return Multiply(left, right);
        }

        public static Fraction operator/(Fraction left, Object right)
        {
            return Divide(left, right);
        }
        public static Fraction operator/(Object left, Fraction right)
        {
            return Divide(left, right);
        }

        #endregion

        #endregion


        #region Private Methods

        private static Fraction Add(Object left, Object right)
        {
            int leftNumerator, leftDenominator = 1, rightNumerator, rightDenominator = 1;

            if (left.GetType() == typeof(Fraction))
            {
                leftNumerator = (left as Fraction).Numerator;
                leftDenominator = (left as Fraction).Denominator;
            }
            else if(left.GetType() == typeof(int))
            {
                leftNumerator = (int)left;
                leftDenominator = 1;
            }
            else
            {
                throw new TypeAccessException("Cannot apply + operation between " + left.GetType().ToString() + " and " + right.GetType().ToString());
            }

            if (right.GetType() == typeof(Fraction))
            {
                rightNumerator = (right as Fraction).Numerator;
                rightDenominator = (right as Fraction).Denominator;
            }
            else if (left.GetType() == typeof(int))
            {
                rightNumerator = (int)right;
                rightDenominator = 1;
            }
            else
            {
                throw new TypeAccessException("Cannot apply + operation between " + left.GetType().ToString() + " and " + right.GetType().ToString());
            }

            var lcm = GetLCM(leftDenominator, rightDenominator);

            var leftMultiplied = lcm / leftDenominator;
            var rightMultiplied = lcm / rightDenominator;

            var leftNumResult= leftNumerator * leftMultiplied;
            var rightNumResult = rightNumerator * rightMultiplied;

            Fraction Added = new Fraction(leftNumResult + rightNumResult, lcm);

            return Added;
        }

        private static Fraction Subtract(Object left, Object right)
        {
            Fraction Suctracted;

            if (right.GetType() == typeof(Fraction))
            {
                Suctracted = Add(left, (right as Fraction) * -1);
            }
            else if (right.GetType() == typeof(int))
            {
                Suctracted = Add(left, (int)right * -1);
            }
            else
            {
                throw new TypeAccessException("Cannot apply - operation between " + left.GetType().ToString() + " and " + right.GetType().ToString());
            }

            return Suctracted;
        }

        private static Fraction Multiply(Object left, Object right)
        {
            int leftNumerator, leftDenominator, rightNumerator, rightDenominator;

            if (left.GetType() == typeof(Fraction))
            {
                leftNumerator = (left as Fraction).Numerator;
                leftDenominator = (left as Fraction).Denominator;
            }
            else if (left.GetType() == typeof(int))
            {
                leftNumerator = (int)left;
                leftDenominator = 1;
            }
            else
            {
                throw new TypeAccessException("Cannot apply * operation between " + left.GetType().ToString() + " and " + right.GetType().ToString());
            }

            if (right.GetType() == typeof(Fraction))
            {
                rightNumerator = (right as Fraction).Numerator;
                rightDenominator = (right as Fraction).Denominator;
            }
            else if (left.GetType() == typeof(int))
            {
                rightNumerator = (int)right;
                rightDenominator = 1;
            }
            else
            {
                throw new TypeAccessException("Cannot apply * operation between " + left.GetType().ToString() + " and " + right.GetType().ToString());
            }

            return new Fraction(leftNumerator * rightNumerator, leftDenominator * rightDenominator);
        }

        private static Fraction Divide(Object left, Object right)
        {
            Fraction Divided;

            if (right.GetType() == typeof(Fraction))
            {
                Divided = Multiply(left, new Fraction((right as Fraction).Denominator, (right as Fraction).Numerator));
            }
            else if (right.GetType() == typeof(int))
            {
                Divided = Multiply(left, new Fraction(1, (int)right));
            }
            else
            {
                throw new TypeAccessException("Cannot apply / operation between " + left.GetType().ToString() + " and " + right.GetType().ToString());
            }

            return Divided;
        }

        #region Math

        private static int GetGCD(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        private static int GetLCM(int a, int b)
        {
            return a * b / GetGCD(a, b);
        }

        #endregion

        #endregion
    }
}
