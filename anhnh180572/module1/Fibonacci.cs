static int Fibonacci(int n, bool flag)
{
    if (flag)
    {
        if (n <= 1)
            return n;
        return Fibonacci(n - 1, true) + Fibonacci(n - 2, true);
    }
    return -1;
}

