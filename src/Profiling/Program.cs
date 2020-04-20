using MathComponentsNS;
using System;

namespace Profiling
{
    internal class Program
    {
        private static int Main(string[] args)
        {
            MathComponents math = new MathComponents();

            bool conversionSuccessful;
            string input;
            decimal currentNumber = 0;
            decimal linearAccumulator = 0;
            decimal quadraticAccumulator = 0;
            int count = 0;

            while (!string.IsNullOrEmpty(input = Console.ReadLine()))
            {
                conversionSuccessful = Decimal.TryParse(input, out currentNumber);
                if (!conversionSuccessful)
                {
                    Console.WriteLine("Conversion error");
                    return -1;
                }
                count++;
                linearAccumulator += currentNumber;
                // TODO: error handling
                quadraticAccumulator += math.Exponentiate(currentNumber, 2).Item2;
            }

            // TODO: error handling
            decimal average = math.Divide(1, count).Item2;
            average = math.Multiply(average, linearAccumulator).Item2;

            decimal deviationLeft = math.Subtract(count, 1).Item2;
            deviationLeft = math.Divide(1, deviationLeft).Item2;

            decimal deviationRight = math.Exponentiate(average, 2).Item2;
            deviationRight = math.Multiply(count, deviationRight).Item2;
            deviationRight = math.Subtract(quadraticAccumulator, deviationRight).Item2;

            decimal deviation = math.Multiply(deviationLeft, deviationRight).Item2;
            deviation = math.Root(2, deviation).Item2;

            /* DEBUG INFO */
            Console.WriteLine("N: " + count);
            Console.WriteLine("sum x: " + linearAccumulator);
            Console.WriteLine("sum x^2: " + quadraticAccumulator);
            Console.WriteLine("average x: " + average);
            /* END INFO */

            Console.WriteLine(deviation);
            // remove this vvv
            Console.ReadLine();

            return 0;
        }
    }
}