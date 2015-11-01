using System;

    class SumOFnNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                double index = double.Parse(Console.ReadLine());
                sum += index;
            }
            Console.WriteLine(sum);
        }
    }

