using System;

    class TheBiggestOfFiveNumbers
    {
        static void Main()
        {
            Console.Write("Enter a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter c = ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Enter d = ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Enter e = ");
            double e = double.Parse(Console.ReadLine());
            double biggestOne = int.MinValue;

            if (a >= b && a >= c && a >= d && a >= e)
            {
                biggestOne = a;
            }
            if (b >= a && b >= c && b >= d && b >= e)
            {
                biggestOne = b;
            }
            if (c >= a && c >= b && c >= d && c >= e)
            {
                biggestOne = c;
            }
            if (d >= a && d >= b && d >= c && d >= e)
            {
                biggestOne = d;
            }
            if (e >= a && e >= b && e >= c && e >= d)
            {
                biggestOne = e;
            }
            Console.WriteLine(biggestOne + " is the biggest one.");
        }
    }
