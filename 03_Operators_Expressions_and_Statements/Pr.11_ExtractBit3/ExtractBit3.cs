using System;

    class ExtractBit3
    {
        static void Main()
        {
            Console.Write("Enter an integer n = ");
            int n = int.Parse(Console.ReadLine());
            int p = 3;
            int nRightP = n >> p;
            int bit = nRightP & 1;
            Console.WriteLine("The third bit of the integer {0} is {1}", n, bit);
        }
    }

