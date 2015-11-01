using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        int val;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(rnd.Next(min, max + 1));
        }

    }
}

