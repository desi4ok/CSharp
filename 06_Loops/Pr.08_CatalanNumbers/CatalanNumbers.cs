using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter a number n, (1 < n < 100): n = ");
        int n = int.Parse(Console.ReadLine());
        BigInteger n2Factorial = 1;
        BigInteger nPlus1Factorial = 1;
        BigInteger nFactorial = 1;
        BigInteger result;

        if (n < 1 || n > 100)
        {
            Console.WriteLine("Invalid number.");
        }
        else
        {
            for (int i = 1; i <= 2 * n; i++)
            {
                n2Factorial *= i;
                if (n == i)
                {
                    nFactorial = n2Factorial;
                }
                if (n + 1 == i)
                {
                    nPlus1Factorial = n2Factorial;
                }
            }
            result = n2Factorial / (nPlus1Factorial * nFactorial);
            Console.WriteLine(result);
        }
    }
}

