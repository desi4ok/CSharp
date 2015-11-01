using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Enter a positive integer number n (n ≤ 100), n = ");
        int n = int.Parse(Console.ReadLine());
        bool prime = true;

        if (n < 0 || n > 100)
            Console.WriteLine("Invalid number");
        else if (n < 2)
        {
            prime = false;
            Console.WriteLine(prime);
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
            Console.WriteLine(prime);
        }

    }
}

