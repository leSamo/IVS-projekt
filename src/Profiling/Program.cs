/*
* IVS - project 2 - Calculator
* Team Orient Express
* Ac. y. 2019/20
*/
/**
* @file Program.cs
* @author Samuel Olekšák
* @brief Profiling console app calculating standard deviating from set of numbers
* Expecting input from stdin with numbers separated by newline
* Outputs single number - standard deviating of input set
* Using operations from math library 
*/

using MathComponentsNS;
using System;

namespace Profiling
{
    internal class Program
    {
        /* @brief Loads numbers from input, accumulates their sum, sum of their squares and their count; calculated standard deviation and prints it
         */
        private static int Main(string[] args)
        {
            MathComponents math = new MathComponents();

            bool conversionSuccessful;
            string input;
            decimal square = 0;
            decimal linearAccumulator = 0;
            decimal quadraticAccumulator = 0;
            int count = 0;

            while (!string.IsNullOrEmpty(input = Console.ReadLine()))
            {
                conversionSuccessful = Decimal.TryParse(input, out decimal currentNumber);
                if (!conversionSuccessful)
                {
                    Console.WriteLine("Conversion error");
                    return -1;
                }
                count++;
                linearAccumulator = CheckNull(math.Add(linearAccumulator, currentNumber));
                square = CheckNull(math.Exponentiate(currentNumber, 2));
                quadraticAccumulator = CheckNull(math.Add(quadraticAccumulator, square));
            }

            if (count < 2)
            {
                Console.WriteLine("Minimum of 2 numbers required");
                return -1;
            }

            decimal average = CheckNull(math.Divide(1, count));
            average = CheckNull(math.Multiply(average, linearAccumulator));

            decimal deviationLeft = CheckNull(math.Subtract(count, 1));
            deviationLeft = CheckNull(math.Divide(1, deviationLeft));

            decimal deviationRight = CheckNull(math.Exponentiate(average, 2));
            deviationRight = CheckNull(math.Multiply(count, deviationRight));
            deviationRight = CheckNull(math.Subtract(quadraticAccumulator, deviationRight));

            decimal deviation = CheckNull(math.Multiply(deviationLeft, deviationRight));
            deviation = CheckNull(math.Root(2, deviation));

            /* DEBUG INFO
            Console.WriteLine("N: " + count);
            Console.WriteLine("sum x: " + linearAccumulator);
            Console.WriteLine("sum x^2: " + quadraticAccumulator);
            Console.WriteLine("average x: " + average);
            // END INFO */

            Console.WriteLine(deviation);
            
            //Console.ReadLine();

            return 0;
        }

        /* @brief Checks if number received from math lib isn't null which would mean an error occured
         * @param[in] input - nullable decimal which contains either result or null
         * @returns non-nullable decimal with result of halts program in case of error
         */ 
        private static decimal CheckNull(decimal? input)
        {
            if (input == null)
            {
                Console.WriteLine("Math error");
                Environment.Exit(-1);
            }

            return input ?? 0;
        }
    }
}
