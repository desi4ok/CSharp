using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Enter a number n, (1 <= n <= 20): n = ");
        int n = int.Parse(Console.ReadLine());

        if (n < 1 || n > 20)
        {
            Console.WriteLine("Invalid number.");
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {

                for (int j = i; j <= i + (n - 1); j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
