using System;

    class NumberComparer
    {
        static void Main()
        {
            Console.Write("Enter a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b = ");
            double b = double.Parse(Console.ReadLine());
            double grater = Math.Max(a, b);

            Console.WriteLine("The grater number og them is: " + grater);
        }
    }

