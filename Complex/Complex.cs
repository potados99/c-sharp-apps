using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return base.ToString();
        }

        #region Operator

        public static Complex operator +(Complex left, Complex right) {
            return new Complex();
        }

        #endregion

        #endregion


        #region Private Methods

        private Complex Add(Object left, Object right) {
            double leftReal, leftImage, rightReal, rightImage;

            if (left is Complex) {
                leftReal = (left as Complex).Real;
                leftImage = (left as Complex).Image;
            }
            else if (left is int || left is double) {
                leftReal = (int)left;
                leftImage = 0;
            }
            else {
                throw new TypeAccessException("Cannot apply + operation between " + left.GetType().ToString() + " and " + right.GetType().ToString());
            }

            return new Complex();
        }

        private Complex Subtract(Object left, Object right) {
            return new Complex();
        }

        private Complex Multiply(Object left, Object right) {
            return new Complex();
        }

        private Complex Divide(Object left, Object right) {
            return new Complex();
        }

        #endregion


        #region Requirements

        private Complex AddComplex(Complex left, Complex right) {
            return Add(left, right);
        }
        private Complex SubComplex(Complex left, Complex right) {
            return Subtract(left, right);
        }
        private Complex MulComplex(Complex left, Complex right) {
            return Multiply(left, right);
        }
        private Complex DivComplex(Complex left, Complex right) {
            return Divide(left, right);
        }

        #endregion
    }
}
