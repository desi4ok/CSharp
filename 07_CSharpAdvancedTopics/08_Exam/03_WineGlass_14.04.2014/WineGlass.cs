using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_WineGlass_14._04._2014
{
    class WineGlass
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int lower = 0;
            int upper = n-1;
            for (int row = 0; row < n / 2; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (col == lower)
                        Console.Write("\\");
                    else if (col == upper)
                        Console.Write("/");
                    else if (col > lower && col < upper)
                        Console.Write("*");
                    else if (col < lower || col > upper)
                        Console.Write(".");
                }
                lower++;
                upper--;
                Console.WriteLine();
            }

            upper = n / 2;
            lower = (n / 2) - 1;
            if (n < 12)
            {
                for (int row = 0; row < (n / 2) - 1; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (col < lower || col > upper)
                            Console.Write(".");
                        else
                            Console.Write("|");
                    }
                    Console.WriteLine();
                }
            
                for (int i = 0; i < n; i++)
                {
                    Console.Write("-");
                }
            }
            else if (n >= 12)
            {
                for (int row = 0; row < (n / 2) - 2; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (col < lower || col > upper)
                            Console.Write(".");
                        else
                            Console.Write("|");
                    }
                    Console.WriteLine();
                }
                for (int row = 0; row < 2; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        Console.Write("-");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
