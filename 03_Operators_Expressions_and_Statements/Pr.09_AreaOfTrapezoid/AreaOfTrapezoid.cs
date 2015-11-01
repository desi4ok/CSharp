using System;

    class AreaOfTrapezoid
    {
        static void Main()
        {
            Console.Write("Enter the first base: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the second base: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height of the trapezoid: ");
            double h = double.Parse(Console.ReadLine());

            double area = ((a + b) * h) / 2;
            Console.WriteLine("The area of the trapezoid is: " + area);
        }
    }

