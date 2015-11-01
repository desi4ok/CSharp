using System;
using System.Numerics;

namespace _07_TicTacToePower_26._08._2014
{
    class TicTacToePower
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());
            int value = (v - 1);
            int index = 0;
            BigInteger c = 1;
            if (v == 0)
                Console.WriteLine(index);
            else
            {
                for (int row = 0; row <= y; row++)
                {
                    for (int col = 0; col <= 2; col++)
                    {
                        value += 1;
                        index += 1;
                        if (col == x && row == y)
                            break;
                    }
                }

                for (int i = 0; i < index; i++)
                {
                    c *= value;
                }
                Console.WriteLine(c);

            }
        }
    }
}
