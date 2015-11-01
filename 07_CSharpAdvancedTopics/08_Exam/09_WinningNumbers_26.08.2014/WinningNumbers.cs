using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_WinningNumbers_26._08._2014
{
    class WinningNumbers
    {
        static void Main()
        {
            string s = Console.ReadLine();
            string nonCapitalS = s.ToLower();
            char[] lettersArray = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            int stringLength = nonCapitalS.Length;
            char[] charOfString = new char[stringLength];
            int sum = 0;
            int count = 0;
            charOfString = nonCapitalS.ToCharArray();
            for (int i = 0; i < lettersArray.Length; i++)
            {
                for (int j = 0; j < stringLength; j++)
                {
                    if (lettersArray[i] == charOfString[j])
                    {
                        sum += (i + 1);
                    }
                }
            }
            for (int a = 1; a < 10; a++)
            {
                for (int b = 1; b < 10; b++)
                {
                    for (int c = 1; c < 10; c++)
                    {
                        for (int d = 1; d < 10; d++)
                        {
                            for (int e = 1; e < 10; e++)
                            {
                                for (int f = 1; f < 10; f++)
                                {
                                    if (a * b * c == d * e * f && a * b * c == sum && a < 10 && b < 10 && c < 10 && d < 10 && e < 10 && f < 10)
                                    {
                                        count += 1;
                                        Console.WriteLine("{0}{1}{2}-{3}{4}{5}", a, b, c, d, e, f);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (count == 0)
                Console.WriteLine("No");
        }
    }
}
