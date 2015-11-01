using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Roklq
{
    class Roklq
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < 3 * n; i++)
            {
                if (i >= n && i < 2 * n)
                    Console.Write("*");
                else
                    Console.Write(".");
            }
            Console.WriteLine();

            int lower = n - 2;
            int upper = 2 * n + 1;
            for (int i = 0; i < (n - 1) / 2; i++)
            {
                for (int j = 0; j < 3 * n; j++)
                {
                    if (j == lower || j == upper)
                        Console.Write("*");
                    else
                        Console.Write(".");
                }
                lower -= 2;
                upper += 2;
                Console.WriteLine();
            }
            

            lower = n - 1;
            upper = 2 * n;
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < 3 * n; j++)
                {
                    if (j == 0 || j == n - 1 || j == 3 * n - 1 || j == 2 * n || j == lower || j == upper)
                        Console.Write("*");
                    else
                        Console.Write(".");
                }
                lower -= 2;
                upper += 2;
                Console.WriteLine();
            }

            lower = n - 1;
            upper = 2 * n;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < 3 * n; j++)
                {
                    if (j == lower || j == upper)
                        Console.Write("*");
                    else
                        Console.Write(".");
                }
                lower--;
                upper++;
                Console.WriteLine();
            }

            for (int i = 0; i < 3 * n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
