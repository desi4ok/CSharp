using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_MagicCarNumbers
{
    class MagicCarNumbers
    {
        static void Main(string[] args)
        {
            int magicNum = int.Parse(Console.ReadLine());
            int[] weight = { 10, 20, 30, 50, 80, 110, 130, 160, 200, 240 };
            int count = 0;

            for (int a = 0; a < 10; a++)
            {
                for (int b = 0; b < 10; b++)
                {
                    for (int c = 0; c < 10; c++)
                    {
                        for (int d = 0; d < 10; d++)
                        {
                            for (int x = 0; x < 10; x++)
                            {
                                for (int y = 0; y < 10; y++)
                                {
                                    if ((a == b && b == c && c == d) || (a != b && b == c && c == d) || (a == b && b == c && d != c) || (a == b && c == d && a != c) || (a == c && b == d && c != d) || (a == d && b == c && a != b)) 
                                        
                                    {
                                        int temp = 40 + a + b + c + d + weight[x] + weight[y];
                                        if (temp == magicNum)
                                        {
                                            count++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
