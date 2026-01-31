namespace duongnqhs186529.module1
{
    public class FibonacciImpl2 : IFibonacci
    {
        public int Fibonacci(int n, bool flag)
        {
            if (!flag || n < 0) return -1;
            if (n <= 1) return n;

            int a = 0, b = 1;
            for (int i = 2; i <= n; i++)
            {
                int c = a + b;
                a = b;
                b = c;
            }
            return b;
        }
    }
}
