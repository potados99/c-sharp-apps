﻿using System;

namespace Fraction {
    class Fraction {
        #region Properties

        public long Numerator { get; private set; }
        public long Denominator { get; private set; }

        #endregion


        #region Constructor

        public Fraction(long Numerator, long Denominator = 1) {
            if (Denominator == 0) {
                throw new DivideByZeroException("감히 분모가 0인 수를 만들려고 하다니!");
            }

            var gcd = GetGCD(Numerator, Denominator);
            this.Numerator = Numerator / gcd;
            this.Denominator = Denominator / gcd;
        }

        #endregion


        #region Public Methods

        public override string ToString() {
            var underZero = this.Numerator * this.Denominator < 0;
            return underZero
                ? String.Format("-({0}/{1})", Math.Abs(this.Numerator), Math.Abs(this.Denominator))
                : String.Format("{0}/{1}", Math.Abs(this.Numerator), Math.Abs(this.Denominator));
        }

        #region Operator

        public static Fraction operator +(Fraction left, Fraction right) {
            return Add(left, right);
        }
        public static Fraction operator +(Fraction left, Object right) {
            return Add(left, right);
        }
        public static Fraction operator +(Object left, Fraction right) {
            return Add(left, right);
        }

        public static Fraction operator -(Fraction left, Fraction right) {
            return Subtract(left, right);
        }
        public static Fraction operator -(Fraction left, Object right) {
            return Subtract(left, right);
        }
        public static Fraction operator -(Object left, Fraction right) {
            return Subtract(left, right);
        }

        public static Fraction operator *(Fraction left, Object right) {
            return Multiply(left, right);
        }
        public static Fraction operator *(Fraction left, Fraction right) {
            return Multiply(left, right);
        }
        public static Fraction operator *(Object left, Fraction right) {
            return Multiply(left, right);
        }

        public static Fraction operator /(Fraction left, Fraction right) {
            return Divide(left, right);
        }
        public static Fraction operator /(Fraction left, Object right) {
            return Divide(left, right);
        }
        public static Fraction operator /(Object left, Fraction right) {
            return Divide(left, right);
        }

        #endregion

        #endregion


        #region Private Methods

        private static Fraction Add(Object left, Object right) {
            long leftNumerator, leftDenominator = 1, rightNumerator, rightDenominator = 1;

            if (left is Fraction) {
                leftNumerator = (left as Fraction).Numerator;
                leftDenominator = (left as Fraction).Denominator;
            }
            else if (left is int || left is long) {
                leftNumerator = Convert.ToInt64(left);
                leftDenominator = 1;
            }
            else {
                throw new TypeAccessException("Cannot apply + operation between " + left.GetType().ToString() + " and " + right.GetType().ToString());
            }

            if (right is Fraction) {
                rightNumerator = (right as Fraction).Numerator;
                rightDenominator = (right as Fraction).Denominator;
            }
            else if (right is int || right is long) {
                rightNumerator = Convert.ToInt64(right);
                rightDenominator = 1;
            }
            else {
                throw new TypeAccessException("Cannot apply + operation between " + left.GetType().ToString() + " and " + right.GetType().ToString());
            }

            var lcm = GetLCM(leftDenominator, rightDenominator);

            var leftMultiplied = lcm / leftDenominator;
            var rightMultiplied = lcm / rightDenominator;

            var leftNumResult = leftNumerator * leftMultiplied;
            var rightNumResult = rightNumerator * rightMultiplied;

            Fraction Added = new Fraction(leftNumResult + rightNumResult, lcm);

            return Added;
        }

        private static Fraction Subtract(Object left, Object right) {
            Fraction Suctracted;

            if (right is Fraction) {
                Suctracted = Add(left, (right as Fraction) * -1);
            }
            else if (right is int || right is long) {
                Suctracted = Add(left, Convert.ToInt64(right) * -1);
            }
            else {
                throw new TypeAccessException("Cannot apply - operation between " + left.GetType().ToString() + " and " + right.GetType().ToString());
            }

            return Suctracted;
        }

        private static Fraction Multiply(Object left, Object right) {
            long leftNumerator, leftDenominator, rightNumerator, rightDenominator;

            if (left is Fraction) {
                leftNumerator = (left as Fraction).Numerator;
                leftDenominator = (left as Fraction).Denominator;
            }
            else if (left is int || left is long) {
                leftNumerator = Convert.ToInt64(left);
                leftDenominator = 1;
            }
            else {
                throw new TypeAccessException("Cannot apply * operation between " + left.GetType().ToString() + " and " + right.GetType().ToString());
            }

            if (right is Fraction) {
                rightNumerator = (right as Fraction).Numerator;
                rightDenominator = (right as Fraction).Denominator;
            }
            else if (right is int || right is long) {
                rightNumerator = Convert.ToInt64(right);
                rightDenominator = 1;
            }
            else {
                throw new TypeAccessException("Cannot apply * operation between " + left.GetType().ToString() + " and " + right.GetType().ToString());
            }

            return new Fraction(leftNumerator * rightNumerator, leftDenominator * rightDenominator);
        }

        private static Fraction Divide(Object left, Object right) {
            Fraction Divided;

            if (right is Fraction) {
                Divided = Multiply(left, new Fraction((right as Fraction).Denominator, (right as Fraction).Numerator));
            }
            else if (right is int || right is long) {
                Divided = Multiply(left, new Fraction(1, Convert.ToInt64(right)));
            }
            else {
                throw new TypeAccessException("Cannot apply / operation between " + left.GetType().ToString() + " and " + right.GetType().ToString());
            }

            return Divided;
        }

        #region Math

        private static long GetGCD(long a, long b) {
            while (b != 0) {
                long r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        private static long GetLCM(long a, long b) {
            return a * b / GetGCD(a, b);
        }

        #endregion

        #endregion
    }
}
