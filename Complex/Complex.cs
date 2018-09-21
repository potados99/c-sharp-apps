using System;

namespace Complex
{
    class Complex {
        #region Properties

        public double Real { get; private set; }
        public double Image { get; private set; }

        #endregion


        #region Constructors

        public Complex() {
            this.Real = 0;
            this.Image = 0;
        }

        public Complex(double image) {
            this.Real = 0;
            this.Image = image;
        }

        public Complex(double real, double image) {
            this.Real = real;
            this.Image = image;
        }

        #endregion


        #region Public Methods

        public override string ToString() {
            return String.Format("({0:G3} + {1:G3}i)", this.Real, this.Image);
        }

        public string PreciseString() {
            return String.Format("({0:G17} + {1:G17}i)", this.Real, this.Image);
        }

        #region Operator

        public static Complex operator+(Complex left, Complex right) {
            return Add(left, right);
        }
        public static Complex operator+(Complex left, Object right) {
            return Add(left, right);
        }
        public static Complex operator+(Object left, Complex right) {
            return Add(left, right);
        }

        public static Complex operator-(Complex left, Complex right) {
            return Subtract(left, right);
        }
        public static Complex operator-(Complex left, Object right) {
            return Subtract(left, right);
        }
        public static Complex operator-(Object left, Complex right) {
            return Subtract(left, right);
        }

        public static Complex operator*(Complex left, Complex right) {
            return Multiply(left, right);
        }
        public static Complex operator*(Complex left, Object right) {
            return Multiply(left, right);
        }
        public static Complex operator*(Object left, Complex right) {
            return Multiply(left, right);
        }

        public static Complex operator/(Complex left, Complex right) {
            return Divide(left, right);
        }
        public static Complex operator/(Complex left, Object right) {
            return Divide(left, right);
        }
        public static Complex operator/(Object left, Complex right) {
            return Divide(left, right);
        }

        #endregion

        #endregion


        #region Private Methods

        #region Operations

        private static Complex Add(Object left, Object right) {
            double leftReal, leftImage, rightReal, rightImage;

            Extract(left, right, out leftReal, out leftImage, out rightReal, out rightImage);

            return new Complex(leftReal + rightReal, leftImage + rightImage);
        }

        private static Complex Subtract(Object left, Object right) {
            double leftReal, leftImage, rightReal, rightImage;

            Extract(left, right, out leftReal, out leftImage, out rightReal, out rightImage);

            return new Complex(leftReal - rightReal, leftImage - rightImage);
        }

        private static Complex Multiply(Object left, Object right) {
            double leftReal, leftImage, rightReal, rightImage;

            Extract(left, right, out leftReal, out leftImage, out rightReal, out rightImage);

            return new Complex(leftReal * rightReal, leftImage * rightImage);
        }

        private static Complex Divide(Object left, Object right) {
            double leftReal, leftImage, rightReal, rightImage;

            Extract(left, right, out leftReal, out leftImage, out rightReal, out rightImage);

            return new Complex(leftReal / rightReal, leftImage / rightImage);
        }

        #endregion

        private static void Extract(Object left, Object right, out double leftReal, out double leftImage, out double rightReal, out double rightImage) {
            if (left is Complex) {
                leftReal = (left as Complex).Real;
                leftImage = (left as Complex).Image;
            }
            else if (IsAvailableType(left)) {
                leftReal = Convert.ToDouble(left);
                leftImage = 0;
            }
            else {
                throw new TypeAccessException("Cannot apply operation between " + left.GetType().ToString() + " and " + right.GetType().ToString());
            }

            if (right is Complex) {
                rightReal = (right as Complex).Real;
                rightImage = (right as Complex).Image;
            }
            else if (IsAvailableType(right)) {
                rightReal = Convert.ToDouble(right);
                rightImage = 0;
            }
            else {
                throw new TypeAccessException("Cannot apply operation between " + left.GetType().ToString() + " and " + right.GetType().ToString());
            }
        }

        private static bool IsAvailableType(Object boxed) {
            return (boxed is short || boxed is int || boxed is float || boxed is double);
        }

        #endregion


        #region Requirements

        public static Complex AddComplex(Complex left, Complex right) {
            return Add(left, right);
        }
        public static Complex SubComplex(Complex left, Complex right) {
            return Subtract(left, right);
        }
        public static Complex MulComplex(Complex left, Complex right) {
            return Multiply(left, right);
        }
        public static Complex DivComplex(Complex left, Complex right) {
            return Divide(left, right);
        }

        public void PrintComplex() {
            Console.Write(this);
        }

        #endregion
    }
}
