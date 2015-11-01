using System;

class CalculatingNKfactorial
{
    static void Main()
    {
        Console.Write("Enter a number n, (1 < n < 100): n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter a number k, (1 < k < n < 100), k = ");
        int k = int.Parse(Console.ReadLine());
        double nFactorial = 1;
        double kFactorial = 1;

        if (k < 1 || n < 1 || k > 100 || n > 100 || k > n)
        {
            Console.WriteLine("Invalid number.");
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                nFactorial *= i;
                if (i == k)
                {
                    kFactorial = nFactorial;
                }
            }
            Console.WriteLine(nFactorial / kFactorial);
        }
    }
}

