using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Car_22._08._2014
{
    class Car
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int lower;
            int upper;
            for (int col = 0; col < 3 * N; col++)
			{
			  if (col >= N && col < 2 * N)
                  Console.Write("*");
              else
                  Console.Write(".");
			}
            Console.WriteLine();

            lower = N - 1;
            upper = 2 * N;
            for (int row = 0; row < (N / 2 - 1); row++)
            {
                for (int col = 0; col < 3 * N; col++)
                {
                    if (col == lower || col == upper)
                        Console.Write("*");
                    else
                        Console.Write(".");
                }
                lower--;
                upper++;
                Console.WriteLine();
            }

            for (int col = 0; col < 3 * N; col++)
            {
                if (col < (N / 2 + 1) || col >= 3 * N - (N / 2 + 1))
                    Console.Write("*");
                else
                    Console.Write(".");
            }
            Console.WriteLine();

            lower = 0;
            upper = 3 * N - 1;
            for (int row = 0; row < N / 2 - 2; row++)
            {
                for (int col = 0; col < 3 * N; col++)
                {
                    if (col == lower || col == upper)
                        Console.Write("*");
                    else
                        Console.Write(".");
                }
                Console.WriteLine();
            }

            for (int col = 0; col < 3 * N; col++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            lower = N / 2;
            upper = 3 * N - N / 2 - 1;
            for (int row = 0; row < N / 2 - 2; row++)
            {
                for (int col = 0; col < 3 * N; col++)
                {
                    if (col == lower || col == lower + N / 2 || col == upper || col == upper - N / 2)
                        Console.Write("*");
                    else
                        Console.Write(".");
                }
                Console.WriteLine();
            }

            for (int col = 0; col < 3 * N; col++)
            {
                if ((col >= lower && col <= lower + N / 2) || (col <= upper && col >= upper - N / 2))
                    Console.Write("*");
                else
                    Console.Write(".");
            }
            Console.WriteLine();
        }
    }
}
