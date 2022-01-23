class Fibonacci
{
  public int FibonacciIterative(int n)
    {
      //Debug.WriteLine($"Entering {nameof(Fibonacci)} method");
      //Debug.WriteLine($"We are looking for the {n}th number");

      int n1 = 0;
      int n2 = 1;
      int sum = 0;

      for (int i = 2; i <= n - 1; i++)
      {
        sum = n1 + n2;
        n1 = n2;
        n2 = sum;
        //Debug.WriteLineIf(sum == 1, $"sum is 1, n1 is {n1}, n2 is {n2}");
      }

      //Debug.Assert(n2 == 5, "The return value is not 5 and it should be");
      return n == 0 ? n1 : n2;
    }

    // 0 1 1 2 3 5 8 13 21 34
    // 1 2 3 4 5 6 7 8  9  10
    public int FibonacciRecursive(int n)
    {
      if (n < 2 ) return n;

      return FibonacciRecursive(n - 2) + FibonacciRecursive(n - 1);
    }
}