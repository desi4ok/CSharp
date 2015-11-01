using System;

    class DevidedBySevenAndFive
    {
        static void Main()
        {
            Console.Write("Please write an integer: ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("The result is: ");
            Console.WriteLine((i % 5 == 0) & (i % 7 == 0));
        }
    }

