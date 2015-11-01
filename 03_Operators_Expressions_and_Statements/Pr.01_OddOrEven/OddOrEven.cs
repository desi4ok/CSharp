using System;

    class OddOrEven
    {
        static void Main()
        {
            Console.Write("Please write an integer: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Is it odd? ");
            Console.WriteLine(a % 2 != 0);
        }
    }

