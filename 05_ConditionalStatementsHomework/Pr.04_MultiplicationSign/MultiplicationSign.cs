using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.Write("Enter a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c = ");
        double c = double.Parse(Console.ReadLine());
        int countMinus = 0;

        if (a < 0)
        {
            countMinus++;
        }
        if (b < 0)
        {
            countMinus++;
        }
        if (c < 0)
        {
            countMinus++;
        }

        if (a == 0 | b == 0 | c == 0)
        {
            Console.WriteLine("The sign of the product of these three numbers is: 0");
        }
        else if (countMinus % 2 != 0)
        {
            Console.WriteLine("The sign of the product of these three numbers is: -");
        }
        else
            Console.WriteLine("The sign of the product of these three numbers is: +");
    }
}

