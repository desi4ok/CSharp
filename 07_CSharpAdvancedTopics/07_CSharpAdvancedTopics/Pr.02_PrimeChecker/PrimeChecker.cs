using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

class PrimeChecker
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        Console.WriteLine(IsPrime(n));
    }
    static bool IsPrime(long n)
    {
        bool prime = true;

        if (n < 2)
        {
            prime = false;
        }

        else
        {
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    prime = false;
                }
            }
        }
        return prime;
    }
}

