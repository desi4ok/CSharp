using System;

    class FormattingNumbers
    {
        static void Main()
        {
            Console.Write("Enter integer a (0 ≤ a ≤ 500), a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter floating-point b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter floating-point c = ");
            double c = double.Parse(Console.ReadLine());
            string binaryA = Convert.ToString(a, 2).PadLeft(10, '0');

            Console.WriteLine("| {0,-10:X} | {1} | {2,10:F2} | {3,-10:F3} |", a, binaryA, b, c);

        }
    }

