using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.Write("Enter a number n = ");
        int n = int.Parse(Console.ReadLine());
        if (n < 1)
        {
            Console.WriteLine("Invalid number.");
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
        }   
    }
}

