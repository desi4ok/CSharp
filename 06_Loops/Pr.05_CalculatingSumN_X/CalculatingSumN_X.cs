using System;

class CalculatingSumN_X
{
    static void Main()
    {
        Console.Write("Enter n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter x = ");
        int x = int.Parse(Console.ReadLine());
        double product = 1;
        double index = 1;
        double sum = 1;

        for (int i = 1; i <= n; i++)
        {
            product *= i;
            index *= x;
            sum += (product / index);
        }
        Console.WriteLine("{0:F5}", sum);
    }
}

