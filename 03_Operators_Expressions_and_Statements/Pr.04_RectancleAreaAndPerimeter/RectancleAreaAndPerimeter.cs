using System;

class RectancleAreaAndPerimeter
{
    static void Main()
    {
        Console.Write("Width: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Height: ");
        double b = double.Parse(Console.ReadLine());

        double recArea = a * b;
        double recPerimeter = 2 * a + 2 * b;
        Console.WriteLine("The rectangle's area is: " + recArea);
        Console.WriteLine("The rectangle's perimeter is: " + recPerimeter);
    }
}

