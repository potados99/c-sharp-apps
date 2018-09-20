using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Complex
    {
        #region Properties

        public double Real { get; private set; }
        public double Image { get; private set; }

        #endregion


        #region Constructors

        public Complex()
        {
            this.Real = 0;
            this.Image = 0;
        }

        public Complex(double image)
        {
            this.Real = 0;
            this.Image = image;
        }

        public Complex(double real, double image)
        {
            this.Real = real;
            this.Image = image;
        }

        #endregion


        #region Public Methods

        public override string ToString()
        {
            return base.ToString();
        }

        #endregion


        #region Private Methods

        private Complex Add(Complex left, Complex right)
        {
            return new Complex();
        }

        private Complex Subtract(Complex left, Complex right)
        {
            return new Complex();
        }

        private Complex Multiply(Complex left, Complex right)
        {
            return new Complex();
        }

        private Complex Divide(Complex left, Complex right)
        {
            return new Complex();
        }

        #endregion



    }
}
