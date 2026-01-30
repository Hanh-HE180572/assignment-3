static int Fibonacci(int n, bool flag)
{

    if (!flag) 
    {
        if (n <= 1) return n;

        int a = 0, b = 1;
        for (int i = 2; i <= n; i++)
        {
            int temp = a + b;
            a = b;
            b = temp;
        }
        return b;

    if (flag)
    {
        if (n <= 1)
            return n;
        return Fibonacci(n - 1, true) + Fibonacci(n - 2, true);  }
    return -1;
}

