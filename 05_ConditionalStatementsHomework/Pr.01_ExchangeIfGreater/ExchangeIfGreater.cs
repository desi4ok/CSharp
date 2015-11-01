using System;

    class ExchangeIfGreater
    {
        static void Main()
        {
            Console.Write("Enter a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b = ");
            double b = double.Parse(Console.ReadLine());
            bool grater = (a > b);
            bool equal = (a == b);

            if (grater)
            {
                Console.WriteLine(b + " " + a);
            }

            else if (equal) 
            {
                Console.WriteLine("a = b = " + a);
            }

            else
            {
                Console.WriteLine(a + " " + b);
            }
        }
    }

