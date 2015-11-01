using System;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Fib(n));
    }

    static int Fib(int n)
    {
        int firstNum = 0;
        int secondNum = 1;
        int sum = 0;
        if (n == 0)
        {
            sum = secondNum;
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                sum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = sum;
            }
        }
        return sum;
    }
}
