using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexCalcWIndowApps
{
    class Complex
    {
        private double real;
        private double imaginary;

        public double Real{
            get
            {
                return this.real;
            }
            set
            {
                real = value;
            }

         }

        public double Imagianry
        {
            get
            {
                return imaginary;
            }
            set
            {
                imaginary = value;
            }
        }


        public Complex(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public static Complex operator+ (Complex c1, Complex c2)
        {
            Complex c = new Complex(0, 0);
            c.real = c1.real + c2.real;
            c.imaginary = c1.imaginary + c2.imaginary;
            return c;
            
        }
        public static Complex operator* (Complex c1, Complex c2)
        {
            Complex c = new Complex(0,0);
            c.real = (c1.real * c2.real) - (c1.imaginary * c2.imaginary);
            c.imaginary = (c1.imaginary * c2.real) + (c1.real * c2.imaginary);

            return c;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
