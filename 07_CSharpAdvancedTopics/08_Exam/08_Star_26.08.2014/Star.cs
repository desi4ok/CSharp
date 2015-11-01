using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Star_26._08._2014
{
    class Star
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int lower = N;
            int upper = N;
            
            int height = N * 2 - (N / 2 - 1);
            int width = 2 * N + 1;

            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    if (col == lower || col == upper)
                        Console.Write("*");
                    else if (row == N / 2 && (col < N / 2 + 1 || col >= 2 * N - (N / 2)))
                    {
                        Console.Write("*");

                    }
                    else if (row >= N && (col == lower + (N / 2) || col == upper - (N / 2)))
                        Console.Write("*");
                    else if (row == N*2 - N/2 && (col < N / 2 + 1 || col >= 2 * N - (N/2)))
                    {
                        Console.Write("*");

                    }
                    else
                        Console.Write(".");
                }
                if (row < N / 2)
                {
                    lower--;
                    upper++;
                }
                else if (row == N / 2)
                {
                    lower = 1;
                    upper = 2 * N - 1;
                }
                else if (row > N / 2 && row < N)
                {
                    lower++;
                    upper--;
                }
                else if (row >= N)
                {
                    lower--;
                    upper++;
                }
                Console.WriteLine();
            }
        }
    }
}
