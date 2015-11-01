using System;

    class QuadraticEquation
    {
        static void Main()
        {
            Console.Write("Enter a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter c = ");
            double c = double.Parse(Console.ReadLine());
            double discriminant = Math.Sqrt((b * b) - (4 * a * c));
            double x1 = (-b + discriminant) / (2 * a);
            double x2 = (-b - discriminant) / (2 * a);

            Console.WriteLine("x1 of the quadratic equation ax2 + bx + c = 0 is: " + x1);
            Console.WriteLine("x2 = " + x2);


        }
    }

