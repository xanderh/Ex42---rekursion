using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex42___rekursion
{
    /// <summary>
    /// Main program class
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            int factorial = 3;
            Console.WriteLine("Factorial of " + factorial + " is " + Factorial(factorial));
            long fibonacci = 40;
            Console.WriteLine("Fibonacci number of " + fibonacci + " is " + Fibonacci(fibonacci));
            long fibonacciFast = 1000000000;
            Console.WriteLine("Fibonacci number of " + fibonacciFast + " is " + FibonacciFast(fibonacciFast));

            Console.ReadKey();
        }

        /// <summary>
        /// Calculates the factorial value of any positive integer. 
        /// </summary>
        /// <param name="value">Throws an ArgumentOutOfRangeException if value is less than 1</param>
        /// <returns>The integer corresponding to the factorial of value</returns>
        public static int Factorial(int value)
        {
            if (value < 1)
            {
                throw new ArgumentOutOfRangeException("Value must be greater than zero");
            }
            if (value == 1)
            {
                return 1;
            }
            else
            {
                return value * Factorial(value - 1);
            }
        }

        /// <summary>
        /// Calculates the Fibonacci number, assuming f(0) is 0, and f(1) is 1
        /// </summary>
        /// <param name="value">Throws an ArgumentOutOfRangeException if value is negative</param>
        /// <returns>Integer corresponding to f(value)</returns>
        public static int Fibonacci(long value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Value must be non-negative");
            }
            else if (value == 0)
            {
                return 0;
            }
            else if (value == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(value - 1) + Fibonacci(value - 2);
            }
        }

        /// <summary>
        /// Calculates the fibonacci number for value, using memory
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static UInt64 FibonacciFast(long value)
        {
            if(value < 2)
            {
                if(value == 1)
                {
                    return 1;
                }else if(value == 0)
                {
                    return 0;
                } else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            UInt64 result = 1;
            UInt64 result1 = 0;
            UInt64 results2 = 1;
            for (int i = 2; i <= value; i++)
            {
                result = result1 + results2;
                result1 = results2;
                results2 = result;
            }
            return result;
        }
    }
}
