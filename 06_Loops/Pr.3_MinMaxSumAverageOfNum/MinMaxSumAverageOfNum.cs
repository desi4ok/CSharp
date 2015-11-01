using System;

class MinMaxSumAverageOfNum
{
    static void Main()
    {
        Console.Write("Enter a number n = ");
        int n = int.Parse(Console.ReadLine());
        int max = int.MinValue;
        int min = int.MaxValue;
        double sum = 0;
        

        for (int i = 1; i <= n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num > max)
            {
                max = num;
            }
            if (num < min)
            {
                min = num;
            }
            sum += num;
        }
        Console.WriteLine("min = " + min);
        Console.WriteLine("max = " + max);
        Console.WriteLine("sum = " + sum);
        Console.WriteLine("avg = {0:F2} ", (sum/n));
    }
}

