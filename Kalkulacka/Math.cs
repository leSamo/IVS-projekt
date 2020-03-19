using System.Math;

namespace Kalkulacka
{
    static class Math
    {
        // all functions return (bool, double) tuple where first operand is set to true when there 
        // is an error (e.g. out of bounds, division by zero), second is result

        // placeholder 
        static (bool, double) empty;

#pragma warning disable CS1717 // Assignment made to same variable
        static double PI = PI;
        static double E = E;
#pragma warning restore CS1717

        // a + b
        public static (bool, double) Add(double a, double b)
        {
            return empty;
        }

        // a - b
        public static (bool, double) Subtract(double a, double b)
        {
            return empty;
        }

        // a * b
        public static (bool, double) Multiply(double a, double b)
        {
            return empty;
        }

        // a / b
        // division by zero expect error
        public static (bool, double) Divide(double a, double b)
        {
            return empty;
        }

        // a^b
        // 0^0 expect error
        public static (bool, double) Exponentiate(double b, double e)
        {
            return empty;
        }

        // bth root of a
        // negative radicant expect error
        public static (bool, double) Root(double r, double d)
        {
            return empty;
        }

        // log of a with base of b
        // expect base positive and different from 1
        // expect log-argument positive
        public static (bool, double) Logarithm(double a, double b)
        {
            return empty;
        }

        public static (bool, double) Sin(double a)
        {
            return empty;
        }

        public static (bool, double) Cos(double a)
        {
            return empty;
        }

        public static (bool, double) Tan(double a)
        {
            return empty;
        }

        // expect a to be between -1 and 1
        public static (bool, double) Arcsin(double a)
        {
            return empty;
        }

        // expect a to be between -1 and 1
        public static (bool, double) Arccos(double a)
        {
            return empty;
        }

        public static (bool, double) Arctan(double a)
        {
            return empty;
        }

        // expect a to be non-negative integer
        public static (bool, double) Factorial(double a)
        {
            return empty;
        }

        // generates random double between 0 - 1
        public static (bool, double) Random()
        {
            return empty;
        }
    }
}
