using System;
using System.Collections.Generic;
using System.Text;

namespace Hand_testing_class_Calculator
{
    public class Calculator
    {


        public double calc { get; set; }

        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Subtract(double a, double b)
        {
            return a - b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }



    }
}
