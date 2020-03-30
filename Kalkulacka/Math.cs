//using System.Math;


using System;

namespace MathComponentsNS
{
    public class MathComponents
    {
        // all functions return (bool, double) tuple where first operand is set to true when there 
        // is an error (e.g. out of bounds, division by zero), second is result

        // placeholder 
        static (bool, decimal) empty;
        (bool, decimal) error = (true, 0);

#pragma warning disable CS1717 // Assignment made to same variable
        static decimal PI = PI;
        static decimal E = E;
#pragma warning restore CS1717
            
        // a + b  
        public (bool, decimal) Add(decimal a, decimal b)
        {
            decimal res = a + b;
            return (false, res);
        }

        // a - b
        public (bool, decimal) Subtract(decimal a, decimal b)
        {
            decimal res = a - b;
            return (false, res);
        }

        // a * b
        public (bool, decimal) Multiply(decimal a, decimal b)
        {
            decimal res = a * b;
            return (false, res);
        }

        // a / b
        // division by zero expect error
        public (bool, decimal) Divide(decimal a, decimal b)
        {
            if (b == 0) return error;

            decimal res = a / b;
            return (false, res);
        }

        // a^b
        // 0^0 expect error
        public (bool, decimal) Exponentiate(decimal b, decimal e)
        {
            if (b == 0 && e == 0) return error;

            decimal res = (decimal)System.Math.Pow((double)b, (double)e);
            return (false, res);
        }

        // ath root of b
        // negative radicant expect error
        public (bool, decimal) Root(decimal d, decimal r)
        {
            if (r < 0 || d == 0) return error;

            decimal res = (decimal)System.Math.Pow((double)r, 1f/(double)d);
            return (false, res);
        }

        // log of a with base of b
        // expect base positive and different from 1
        // expect log-argument positive
        public (bool, decimal) Logarithm(decimal a, decimal b)
        {
            if (b <= 0 || b == 1 || a <= 0) return error;
            decimal res = (decimal)System.Math.Log((double)a, (double)b);
            return (false, res);
        }

        public (bool, decimal) Sin(decimal a)
        {
            double res = Math.Sin((double)a);
            decimal ress = (decimal)(Math.Round(res * 1e10d) / 1e10d);
            return (false, ress);
        }

        public (bool, decimal) Cos(decimal a)
        {
            double res = Math.Cos((double)a);
            decimal ress = (decimal)(Math.Round(res * 1e10d) / 1e10d);
            return (false, ress);
        }

        public (bool, decimal) Tan(decimal a)
        {
            double b = (double)a;
            if (b % Math.PI == Math.PI / 2d) return error;
            double res = Math.Tan((double)a);
            decimal ress = (decimal)(Math.Round(res * 1e10d) / 1e10d);
            return (false, ress);
        }

        // expect a to be between -1 and 1
        public (bool, decimal) Arcsin(decimal a)
        {
            return empty;
        }

        // expect a to be between -1 and 1
        public (bool, decimal) Arccos(decimal a)
        {
            return empty;
        }

        public (bool, decimal) Arctan(decimal a)
        {
            return empty;
        }

        // expect a to be non-negative integer
        public (bool, decimal) Factorial(decimal a)
        {
            if (a % 1 != 0 || a < 0) return error;
            else if (a == 0) return (false, 1);
            else return Factorial(a - 1);
        }

        // generates random double between 0 - 1
        public (bool, decimal) Random()
        {
            decimal res = (decimal) new Random().NextDouble();
            return (false, res);
        }
    }
}
