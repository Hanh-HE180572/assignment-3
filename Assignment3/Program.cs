using System;
using Assignment3.danghoangson.module1;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFibonacci fib = new FibonacciService();

            int n = 6;
            bool flag = true;

            int result = fib.Fibonacci(n, flag);

            Console.WriteLine($"Fibonacci({n}) = {result}");
        }
    }
}
