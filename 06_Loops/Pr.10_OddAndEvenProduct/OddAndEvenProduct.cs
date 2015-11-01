using System;

    class OddAndEvenProduct
    {
        static void Main()
    {
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());
            int oddNums = 1;
            int evenNums = 1;

            for (int i = 1; i <= n; i++)
            {
                int index = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenNums *= index;
                }
                else
                {
                    oddNums *= index;
                }
            }
            if (evenNums == oddNums)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = " + evenNums);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product = " + oddNums);
                Console.WriteLine("even_product = " + evenNums);
            }
        }
    }

