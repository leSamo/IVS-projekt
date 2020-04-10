﻿//using System.Math;
/**
@file
*/


using System;

namespace MathComponentsNS
{
    public class MathComponents
    {
        /**
         * doplnit
         */
        // all functions return (bool, decimal) tuple where first operand is set to true when there 
        // is an error (e.g. out of bounds, division by zero), second is result

        (bool, decimal) error = (true, 0);

#pragma warning disable CS1717 // Assignment made to same variable
        static decimal PI = PI;
        static decimal E = E;
#pragma warning restore CS1717



        /**
         * @return error/scientific notation if more than 9 whole places
         * @brief  truncates result to fit calc screen
         * if less than 9 whole, leave all whole and truncate decimal to sum up to 9 max 
         */
        public (bool, decimal) TruncateToFit((bool, decimal) a)
        {
            if (a.Item1) return error;
            int wholeDigits = (int)Math.Floor(1 + Math.Log10((double)Math.Abs(a.Item2)));
            if (wholeDigits > 9) return error;
            else if (a.Item2 == 0)
            {
                return (false, 0);
            }
            else
            {
                decimal result = (decimal)(Math.Truncate((double)a.Item2 * Math.Pow(10, 9 - wholeDigits)) / Math.Pow(10, 9 - wholeDigits));
                return (false, result);
            }
        }

        /**
         * @brief Addition operation function 
         * @param[in] decimal a
         * @param[in] decimal b
         * @return result of a - b
         */
        public (bool, decimal) Add(decimal a, decimal b)
        {
            decimal res = a + b;
            return TruncateToFit((false, res));
        }

        /**
          * @brief Subtraction operation function 
          * @param[in] decimal a
          * @param[in] decimal b
          * @return result of a - b
          */
        public (bool, decimal) Subtract(decimal a, decimal b)
        {
            decimal res = a - b;
            return TruncateToFit((false, res));
        }

        /**
          * @brief Multiplication operation function
          * @param[in] decimal a
          * @param[in] decimal b
          * @return result of a * b 
          */
        public (bool, decimal) Multiply(decimal a, decimal b)
        {
            decimal res = a * b;
            return TruncateToFit((false, res));
        }

        /**
         * @brief Division operation function
         * @param[in] decimal a
         * @param[in] decimal b
         * @return result of a / b
         * @return error if division by zero
         */
        public (bool, decimal) Divide(decimal a, decimal b)
        {
            if (b == 0) return error;

            decimal res = a / b;
            return TruncateToFit((false, res));
        }


        /**
         *  non-integer exponent or base expect error
         *  @brief binary exp algo: https://cp-algorithms.com/algebra/binary-exp.html
         *  @param[in] decimal a
         *  @param[in] decimal b
         *  @return result of a^b
         *  @return error if 0^0
         *  
         */
        public (bool, decimal) Exponentiate(decimal b, decimal e)
        {
            if (b == 0 && e == 0) return error;
            if (e == 0) return (false, 1m);
            if (e < 0)
            {
                (bool, decimal) part = Divide(1m, b);
                if (part.Item1) return error;
                b = part.Item2;
                e = -e;
            }

            decimal res = (decimal)Math.Pow((double)b, (double)e);
            return TruncateToFit((false, res));
        }

        /**
         * @brief Funtion of root to ath
         * @param[in] decimal d
         * @param[in] decimal radicant r
         * @return ath root of b 
         * @return error if negative radicant
         * Newton's method: https://www.geeksforgeeks.org/n-th-root-number/
         */
        public (bool, decimal) Root(decimal d, decimal r)
        {
            if (r < 0 || d == 0) return error;

            decimal res = (decimal)System.Math.Pow((double)r, 1d / (double)d);
            return TruncateToFit((false, res));
        }

        /**
         * @param[in] decimal a
         * @param[in] decimal b
         * @brief Logarithm function
         * expect log-argument positive
         * expect base positive and different from 1
         * @return log of a with base of b
         */
        public (bool, decimal) Logarithm(decimal a, decimal b)
        {
            if (b <= 0 || b == 1 || a <= 0) return error;
            decimal res = (decimal)System.Math.Log((double)a, (double)b);
            return TruncateToFit((false, res));
        }

        /**
         * @param[in] decimal a
         * @brief sine function
         * sin x = x − x^3/3! + x^5/5! − x^7/7! + ...
         * @return  result with 5 decimal places precision
         */
        public (bool, decimal) Sin(decimal a)
        {
            //double res = Math.Sin((double)a);
            //decimal ress = (decimal)(Math.Round(res * 1e10d) / 1e10d);
            decimal res = a;
            res -= Exponentiate(a, 3).Item2 / Factorial(3).Item2;
            res += Exponentiate(a, 5).Item2 / Factorial(5).Item2;
            res -= Exponentiate(a, 7).Item2 / Factorial(7).Item2;
            res += Exponentiate(a, 9).Item2 / Factorial(9).Item2;
            Console.WriteLine(res);

            return TruncateToFit((false, res));
        }

        /**
         * @brief Function cosine
         * @param[in] decimal a
         * Taylor series
         * cos x = 1 − x^2/2! + x^4/4! − x^6/6! + ...
         * @return  result with 5 decimal places precision 
         */
        public (bool, decimal) Cos(decimal a)
        {
            //double res = Math.Cos((double)a);
            //decimal ress = (decimal)(Math.Round(res * 1e10d) / 1e10d);

            decimal res = 1;
            res -= Exponentiate(a, 2).Item2 / Factorial(2).Item2;
            res += Exponentiate(a, 4).Item2 / Factorial(4).Item2;
            res -= Exponentiate(a, 6).Item2 / Factorial(6).Item2;
            res += Exponentiate(a, 8).Item2 / Factorial(8).Item2;
            return TruncateToFit((false, res));
        }

        /**
        * @brief Function tangent
        * @param[in] decimal a
        * tan x = sin x / cos x
        * @return  result with 5 decimal places precision 
        */
        public (bool, decimal) Tan(decimal a)
        {
            double b = (double)a;
            if (b % Math.PI == Math.PI / 2d) return error;
            double res = Math.Tan((double)a);
            decimal ress = (decimal)(Math.Round(res * 1e10d) / 1e10d);
            return TruncateToFit((false, ress));
        }

        /**
        * @brief Function arcsin
        * @param[in] decimal a
        * expect a to be between -1 and 1
        * https://dsp.stackexchange.com/questions/25770/looking-for-an-arcsin-algorithm
        * @return  result with 5 decimal places precision 
        */
        public (bool, decimal) Arcsin(decimal a)
        {
            return error;
        }

        /**
        * @brief Function arccos
        * @param[in] decimal a
        * expect a to be between -1 and 1
        * @return  result with 5 decimal places precision 
        */
        public (bool, decimal) Arccos(decimal a)
        {
            return error;
        }

        /**
          * @brief Function arctan
          * @param[in] decimal a
          * 
          * @return  result with 5 decimal places precision 
          */
        public (bool, decimal) Arctan(decimal a)
        {
            return error;
        }

        /**
          * @brief Factorial operation function
          * @param[in] decimal a
          * expect a to be non-negative integer
          * expect number not greater than 12
          * @return error if a is negative integer
          * @return error if a is greater than 12
          * @return error if a has decimal point
          */
        public (bool, decimal) Factorial(decimal a)
        {
            if (a % 1 != 0 || a < 0 || a > 12) return error;
            else if (a == 0) return (false, 1);
            else return (false, a * Factorial(a - 1).Item2);
        }

        /**
        * @brief Function of random number
        * generates random double between 0 - 1
        * @return  result with 5 decimal places precision 
        */
        public (bool, decimal) Random()
        {
            decimal res = (decimal)new Random().NextDouble();
            return (false, res);
        }
    }
}
