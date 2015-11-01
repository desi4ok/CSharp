using System;

class PointInACircle
{
    static void Main()
    {
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        double y = double.Parse(Console.ReadLine());
        bool insideTheCyrcle = ((x * x) + (y * y) <= 4) && x <= 2 && y <= 2;
        Console.WriteLine("The point (x, y) is inside the cyrcle ({0,0}, 2): " + insideTheCyrcle);
    }
}

