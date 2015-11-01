using System;

    class TheBiggestOf3Numbers
    {
        static void Main()
        {
            Console.Write("Enter a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter c = ");
            double c = double.Parse(Console.ReadLine());
            double biggestNum = int.MinValue;

            if (a >= b && a >= c)
            {
                biggestNum = a;
            }
            if (b >= a && b >= c)
            {
                biggestNum = b;
            }
            if (c >= a && c >= b)
            {
                biggestNum = c;
            }
            Console.WriteLine(biggestNum + " is the biggest one.");
        }
    }

