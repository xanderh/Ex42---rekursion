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
            int fibonacci = 5;
            Console.WriteLine("Fibonacci number of " + fibonacci + " is " + Fibonacci(fibonacci));

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
        public static int Fibonacci(int value)
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
    }
}
