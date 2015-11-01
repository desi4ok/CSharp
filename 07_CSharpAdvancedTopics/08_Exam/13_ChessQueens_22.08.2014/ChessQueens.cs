using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ChessQueens_22._08._2014
{
    class ChessQueens
    {
        static void Main(string[] args)
        {
            /* 60/ 100 */



            int n = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            double N = (double)(n);
            double D = (double)(d);
            int count = 0;
            string[] letters = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            for (int letter1 = 0; letter1 < N; letter1++)
            {
                for (int index1 = 1; index1 <= N; index1++)
                {
                    for (int letter2 = 0; letter2 < N; letter2++)
                    {
                        for (int index2 = 1; index2 <= N; index2++)
                        {
                            if (index1 == index2 && letter1 == letter2)
                                continue;
                            else if (letter1 == letter2 && (index2 - index1) % (D + 1) == 0)
                            {
                                Console.WriteLine("{0}{1} - {2}{3}", letters[letter1], index1, letters[letter2], index2);
                                count++;
                            }
                            else if ((letter2 - letter1) % (D + 1) == 0 && index1 == index2)
                            {
                                Console.WriteLine("{0}{1} - {2}{3}", letters[letter1], index1, letters[letter2], index2);
                                count++;
                            }
                            else if ((letter2 - letter1) % (D + 1) == 0 && (index2 - index1) % (D + 1) == 0)
                            {
                                Console.WriteLine("{0}{1} - {2}{3}", letters[letter1], index1, letters[letter2], index2);
                                count++;
                            }
                            else if (letter1 == letter2 && (index1 - index2) % (D + 1) == 0)
                            {
                                Console.WriteLine("{0}{1} - {2}{3}", letters[letter1], index1, letters[letter2], index2);
                                count++;
                            }
                            
                        }
                    }
                }
            }
            if (count == 0)
                Console.WriteLine("No valid positions");
        }
    }
}
