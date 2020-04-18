/**
* @file Math.cs
* @brief File responsible for implementing math operations and constants
* all functions return (bool, decimal) tuple where first operand is set to true if there 
* is an error (e.g. out of bounds, division by zero), second is result
*/

using System;

namespace MathComponentsNS
{
    public class MathComponents
    {


        (bool, decimal) error = (true, 0);

        public (bool, decimal) constPI = (false, (decimal)Math.PI);
        public (bool, decimal) constE = (false, (decimal)Math.E);

        /**
         * @return error/scientific notation if more than 9 whole places (?)
         * @brief truncates result to fit calc screen
         * @brief if less than 9 whole, leave all whole and truncate decimal to sum up to 9 max 
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
            else if (Math.Abs(a.Item2) < 10)
            {
                decimal result = (decimal)(Math.Truncate((double)a.Item2 * 10e7) / 10e7);
                return (false, result);
            }
            else
            {
                decimal result = (decimal)(Math.Truncate((double)a.Item2 * Math.Pow(10, 9 - wholeDigits)) / Math.Pow(10, 9 - wholeDigits));
                return (false, result);
            }
        }

        /**
        * @brief Addition operation function 
        * @param[in] decimal first addend (a)
        * @param[in] decimal second addend (b)
        * @return sum (result of a + b)
        */
        public (bool, decimal) Add(decimal a, decimal b)
        {
            decimal res = a + b;
            return TruncateToFit((false, res));
        }

        /**
         * @brief Subtraction operation function 
         * @param[in] decimal minuend (a)
         * @param[in] decimal subtrahend (b)
         * @return difference (result of a - b)
         */
        public (bool, decimal) Subtract(decimal a, decimal b)
        {
            decimal res = a - b;
            return TruncateToFit((false, res));
        }

        /**
         * @brief Multiplication operation function
         * @param[in] decimal first factor (a)
         * @param[in] decimal second factor (b)
         * @return product (result of a * b) 
         */
        public (bool, decimal) Multiply(decimal a, decimal b)
        {
            decimal res = a * b;
            return TruncateToFit((false, res));
        }

        /**
         * @brief Division operation function
         * @param[in] decimal dividend (a)
         * @param[in] decimal divisor (b)
         * @return quotient (result of a / b)
         * @return error if divisor is zero
         */
        public (bool, decimal) Divide(decimal a, decimal b)
        {
            if (b == 0) return error;

            decimal res = a / b;
            return TruncateToFit((false, res));
        }


        /**
         *  @brief non-integer exponent or base expect error (?)
         *  @param[in] decimal base (b)
         *  @param[in] decimal exponent (e)
         *  @return result of b^e
         *  @return error if 0^0 or 0^-1
         */
        public (bool, decimal) Exponentiate(decimal b, decimal e)
        {
            if ((b == 0 && e == 0) || (b == 0 && e == -1)) return error;
            if (e == 0) return (false, 1m);
            /*
            if (e < 0)
            {
                (bool, decimal) part = Divide(1m, b);
                if (part.Item1) return error;
                b = part.Item2;
                e = -e;
            }
            */

            decimal res = (decimal)Math.Pow((double)b, (double)e);
            return TruncateToFit((false, res));
        }

        /**
         * @brief Funtion of root to ath
         * @param[in] decimal degree d
         * @param[in] decimal radicand r
         * @return ath root of b 
         * @return error if negative radicant
         */
        public (bool, decimal) Root(decimal d, decimal r)
        {
            if (r < 0 || d == 0) return error;

            decimal res = (decimal)System.Math.Pow((double)r, 1d / (double)d);
            return TruncateToFit((false, res));
        }

        /**
         * @param[in] decimal argument (a)
         * @param[in] decimal base (b)
         * @brief Logarithm function
         * @brief expect log-argument positive
         * @brief expect base positive and different from 1
         * @return log of a with base of b
         */
        public (bool, decimal) Logarithm(decimal a, decimal b)
        {
            if (b <= 0 || b == 1 || a <= 0) return error;
            decimal res = (decimal)System.Math.Log((double)a, (double)b);
            return TruncateToFit((false, res));
        }

        /**
         * @brief sine function
         * @brief using Taylor series algorithm
         * @brief sin x = x − x^3/3! + x^5/5! − x^7/7! + ...
         * @param[in] decimal a
         * @return  result with 5 decimal places precision
         */
        public (bool, decimal) Sin(decimal a)
        {
            decimal res = (decimal) Math.Sin((double)a);
            /*
            decimal res = a;
            res -= Exponentiate(a, 3).Item2 / UnconstrainedFactorial(3).Item2;
            res += Exponentiate(a, 5).Item2 / UnconstrainedFactorial(5).Item2;
            res -= Exponentiate(a, 7).Item2 / UnconstrainedFactorial(7).Item2;
            res += Exponentiate(a, 9).Item2 / UnconstrainedFactorial(9).Item2;
            res -= Exponentiate(a, 11).Item2 / UnconstrainedFactorial(11).Item2;
            res += Exponentiate(a, 13).Item2 / UnconstrainedFactorial(13).Item2;
            res -= Exponentiate(a, 15).Item2 / UnconstrainedFactorial(15).Item2;
            res += Exponentiate(a, 17).Item2 / UnconstrainedFactorial(17).Item2;
            res -= Exponentiate(a, 19).Item2 / UnconstrainedFactorial(19).Item2;
            */

            return TruncateToFit((false, res));
        }

        /**
         * @brief Function cosine
         * @brief using Taylor series algorithm
         * @brief cos x = 1 − x^2/2! + x^4/4! − x^6/6! + ...
         * @param[in] decimal number a
         * @return result with 5 decimal places precision (?)
         */
        public (bool, decimal) Cos(decimal a)
        {
            decimal res = (decimal)Math.Cos((double)a);
            //decimal ress = (decimal)(Math.Round(res * 1e10d) / 1e10d);
            /*
            decimal res = 1;
            res -= Exponentiate(a, 2).Item2 / UnconstrainedFactorial(2).Item2;
            res += Exponentiate(a, 4).Item2 / UnconstrainedFactorial(4).Item2;
            res -= Exponentiate(a, 6).Item2 / UnconstrainedFactorial(6).Item2;
            res += Exponentiate(a, 8).Item2 / UnconstrainedFactorial(8).Item2;
            res -= Exponentiate(a, 10).Item2 / UnconstrainedFactorial(10).Item2;
            res += Exponentiate(a, 12).Item2 / UnconstrainedFactorial(12).Item2;
            res -= Exponentiate(a, 14).Item2 / UnconstrainedFactorial(14).Item2;
            res += Exponentiate(a, 16).Item2 / UnconstrainedFactorial(16).Item2;
            res -= Exponentiate(a, 18).Item2 / UnconstrainedFactorial(18).Item2;
            */

            return TruncateToFit((false, res));
        }

        /**
        * @brief Function tangent
        * @param[in] decimal number a
        * @brief tan x = sin x / cos x
        * @return result with 5 decimal places precision (?)
        */
        public (bool, decimal) Tan(decimal a)
        {
            double b = (double)a;
            if (b % Math.PI == Math.PI / 2d) return error;
            decimal res = (decimal)Math.Tan((double)a);
            return TruncateToFit((false, res));
        }

        /**
        * @brief Function arcsin
        * @param[in] decimal number a
        * @return result with 5 decimal places precision (?)
        * expect value between -pi/2 and pi/2 
        */
        public (bool, decimal) Arcsin(decimal a)
        {
            if (a < -1.57079632679m || a > 1.57079632679m) return error;
            decimal res = (decimal)Math.Asin((double)a);
            return TruncateToFit((false, res));
        }

        /**
        * @brief Function arccos
        * @param[in] decimal number a
        * @return result with 5 decimal places precision (?)
        * @brief expect value between -1 and 1
        */
        public (bool, decimal) Arccos(decimal a)
        {
            if (a < -1 || a > 1) return error;
            decimal res = (decimal)Math.Acos((double)a);
            return TruncateToFit((false, res));
        }

        /**
          * @brief Function arctan
          * @param[in] decimal number a
          * @return result with 5 decimal places precision (?)
          */
        public (bool, decimal) Arctan(decimal a)
        {
            decimal res = (decimal)Math.Atan((double)a);
            return TruncateToFit((false, res));
        }

        /**
          * @brief Factorial operation function
          * @param[in] decimal number a
          * @brief expect number non-negative integer not greater than 12
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
          * @brief Factorial operation function without upper limit
          * @brief helper function, don't use in calculator
          * @param[in] decimal number a
          * @brief expect number non-negative integer
          * @return error if a is negative integer
          * @return error if a has decimal point
          */
        public (bool, decimal) UnconstrainedFactorial(decimal a)
        {
            if (a % 1 != 0 || a < 0) return error;
            else if (a == 0) return (false, 1);
            else return (false, a * UnconstrainedFactorial(a - 1).Item2);
        }

        /**
        * @brief Function of random number
        * @brief generates random decimal number between 0 inclusive to 1 exclusive
        */
        public (bool, decimal) Random()
        {
            decimal res = (decimal)new Random().NextDouble();
            return TruncateToFit((false, res));
        }
    }
}
