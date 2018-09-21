using System;

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

        #region Operations

        private static Fraction Add(Object left, Object right) {
            long leftNumerator, leftDenominator = 1, rightNumerator, rightDenominator = 1;

            Extract(left, right, out leftNumerator, out leftDenominator, out rightNumerator, out rightDenominator);

            return Add(leftNumerator, leftDenominator, rightNumerator, rightDenominator);
        }
        private static Fraction Add(long leftNumerator, long leftDenominator, long rightNumerator, long rightDenominator) {
            var lcm = GetLCM(leftDenominator, rightDenominator);

            var leftMultiplied = lcm / leftDenominator;
            var rightMultiplied = lcm / rightDenominator;

            var leftNumResult = leftNumerator * leftMultiplied;
            var rightNumResult = rightNumerator * rightMultiplied;

            return new Fraction(leftNumResult + rightNumResult, lcm);
        }

        private static Fraction Subtract(Object left, Object right) {
            long leftNumerator, leftDenominator = 1, rightNumerator, rightDenominator = 1;

            Extract(left, right, out leftNumerator, out leftDenominator, out rightNumerator, out rightDenominator);

            return Add(leftNumerator, leftDenominator, -rightNumerator, rightDenominator);
        }

        private static Fraction Multiply(Object left, Object right) {
            long leftNumerator, leftDenominator = 1, rightNumerator, rightDenominator = 1;

            Extract(left, right, out leftNumerator, out leftDenominator, out rightNumerator, out rightDenominator);

            return new Fraction(leftNumerator * rightNumerator, leftDenominator * rightDenominator);
        }
        private static Fraction Multiply(long leftNumerator, long leftDenominator, long rightNumerator, long rightDenominator) {
            return new Fraction(leftNumerator * rightNumerator, leftDenominator * rightDenominator);

        }

        private static Fraction Divide(Object left, Object right) {
            long leftNumerator, leftDenominator = 1, rightNumerator, rightDenominator = 1;

            Extract(left, right, out leftNumerator, out leftDenominator, out rightNumerator, out rightDenominator);

            return Multiply(leftNumerator, leftDenominator, rightDenominator, rightNumerator);
        }

        #endregion

        private static void Extract(Object left, Object right, out long leftNumerator, out long leftDenominator, out long rightNumerator, out long rightDenominator) {
            if (left is Fraction) {
                leftNumerator = (left as Fraction).Numerator;
                leftDenominator = (left as Fraction).Denominator;
            }
            else if (IsAvailableType(left)) {
                leftNumerator = Convert.ToInt64(left);
                leftDenominator = 1;
            }
            else {
                throw new InvalidOperationException("Cannot apply operation between " + left.GetType().ToString() + " and " + right.GetType().ToString());
            }

            if (right is Fraction) {
                rightNumerator = (right as Fraction).Numerator;
                rightDenominator = (right as Fraction).Denominator;
            }
            else if (IsAvailableType(right)) {
                rightNumerator = Convert.ToInt64(right);
                rightDenominator = 1;
            }
            else {
                throw new InvalidOperationException("Cannot apply operation between " + left.GetType().ToString() + " and " + right.GetType().ToString());
            }
        }

        private static bool IsAvailableType(Object boxed) {
            return (boxed is short || boxed is int || boxed is long);
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
