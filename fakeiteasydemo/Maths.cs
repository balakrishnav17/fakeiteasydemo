using System;
using System.Collections.Generic;
using System.Text;

namespace fakeiteasydemo
{
    public class Maths : IMaths
    {
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Substract(double a, double b)
        {
            return a - b;
        }

        public double Divide(double a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                return a / b;
            }

        }


    }
}
