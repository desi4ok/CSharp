using System;

    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Console.Write("Enter the radius r = ");
            double r = double.Parse(Console.ReadLine());
            double p = 2 * Math.PI * r;
            double s = Math.PI * r * r;

            Console.WriteLine("The perimeter of the circle is: {0:F2}", p);
            Console.WriteLine("The area is: {0:F2}", s);
        }
    }

