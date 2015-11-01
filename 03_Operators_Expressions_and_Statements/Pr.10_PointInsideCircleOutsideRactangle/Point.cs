using System;

    class PointInsideCyrcle
    {
        static void Main()
        {
            Console.Write("Enter x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            double y = double.Parse(Console.ReadLine());
            double xAbs = Math.Abs(x - 1);
            bool outsideRec = (((x - 1) * (x - 1) + (y - 1) * (y - 1) <= 1.5 * 1.5) && y > 1 && (y-1)<= 1.5 && xAbs <= 1.5);

            Console.Write("Is the point inside the circle and outside the rectangle? ");
            if (outsideRec == true)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }

