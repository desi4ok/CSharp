using System;

    class ExtractBitFromInteger
    {
        static void Main()
        {
            Console.Write("Enter an integer n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter an index p = ");
            int p = int.Parse(Console.ReadLine());
            int nRightP = n >> p;
            int bit = nRightP & 1;
            Console.WriteLine("The value of the index {0} is {1} ", p, bit);
        }
    }

