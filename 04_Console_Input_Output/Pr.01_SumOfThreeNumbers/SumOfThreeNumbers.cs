using System;

    class SumOfThreeNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter three real numbers: ");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("The sum of these three nubers is: " + (a + b + c));
        }
    }

