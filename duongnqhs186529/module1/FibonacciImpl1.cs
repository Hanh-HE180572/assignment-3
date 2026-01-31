namespace duongnqhs186529.module1
{
    public class FibonacciImpl1 : IFibonacci
    {
        public int Fibonacci(int n, bool flag)
        {
            if (!flag) return -1;
            return Calc(n);
        }

        private int Calc(int n)
        {
            if (n <= 1) return n;
            return Calc(n - 1) + Calc(n - 2);
        }
    }
}
