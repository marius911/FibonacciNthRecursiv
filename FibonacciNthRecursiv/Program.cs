using System;

namespace FibonacciNthRecursiv
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Fibonacci(Convert.ToInt32(Console.ReadLine())));
        }

        static int Fibonacci(int n)
        {
            int previous = 0;
            return Fibonacci(n, ref previous);
        }

        static int Fibonacci(int n, ref int previous)
        {
            const int endOfFib = 2;
            if (n < endOfFib)
            {
                return n;
            }

            int beforePrevious = 0;
            previous = Fibonacci(n - 1, ref beforePrevious);
            return previous + beforePrevious;
        }
    }
}