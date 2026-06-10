using System;
using System.Collections.Generic;
using System.Text;

namespace Sem2Lab1
{
    class Task1
    {
        public delegate double MathOperation(double a, double b);

        public static double Add(double a, double b) => a + b;
        public static double Subtract(double a, double b) => a - b;
        public static double Multiply(double a, double b) => a * b;
        public static double Divide(double a, double b) => b != 0 ? a / b : throw new DivideByZeroException();
    }
}

