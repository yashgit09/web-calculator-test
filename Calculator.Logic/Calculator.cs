using System;

namespace Calculator_Logic
{
    public class Calculator
    {
        //functionality for addition
        public double Add(double left, double right)
        {
            return left + right;
        }
        //functionality for subtraction
        public double Subtract(double left, double right)
        {
            return left - right;
        }
        //functionality for multiply
        public double Multiply(double left, double right)
        {
            if (right == 0 || left == 0)
            {
                return 0;
            }
            else
            {
                return left * right;
            }

        }

        //functionality for division
        public double Divide(double left, double right)
        {
            if (right != 0)
            {
                return left / right;
            }
            else
            {
                throw new DivideByZeroException();
            }

        }
    }
}
