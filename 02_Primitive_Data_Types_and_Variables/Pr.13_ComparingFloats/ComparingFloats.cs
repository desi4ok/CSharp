using System;

    class ComparingFloats
    {
        static void Main()
        {
            Console.Write("Enter the first number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double b = Convert.ToDouble(Console.ReadLine());

            bool equal = Math.Abs(a - b) < 0.000001;

            if (equal)
            {
                Console.WriteLine("{0} = {1}", a, b);
            }
            else if (a < b)
            {
                Console.WriteLine("{0} < {1}", a, b);
            }
            else
            {
                Console.WriteLine("{0} < {1}", b, a);
            }
        }
    }
