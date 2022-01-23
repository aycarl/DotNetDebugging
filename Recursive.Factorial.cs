class Factorial
{
  public int RecursiveFactorial(int num)
  {
    if (num == 2)
    {
      return 2;
    }

    return num * RecursiveFactorial(num - 1);
  }

  public int IterativeFactorial(int num)
  {
    int factorial = 1;

    while(num > 1)
    {
      factorial *= num;
      num--;
    }

    return factorial;
  }
}