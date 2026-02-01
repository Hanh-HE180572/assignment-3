using System;

public class FibonacciModule
{
    public long Fibonacci(int n, bool flag)
    {
        if (flag == false) 
        {
            if (n <= 1) return n;
            long a = 0, b = 1, temp;
            for (int i = 2; i <= n; i++)
            {
                temp = a + b;
                a = b;
                b = temp;
            }
            return b;
        }
        return 0;
    }
}
