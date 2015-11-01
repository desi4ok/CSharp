using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_NakovsMatching_25._07._2014
{
    class NakovsMatching
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int d = int.Parse(Console.ReadLine());
            int sumA = 0;
            int sumB = 0;
            int aLeft = 0;
            int bLeft = 0;
            int aRight;
            int bRight;
            int nakovs;

            char[] charsA = new char[a.Length];
            char[] charsB = new char[b.Length];
            charsA = a.ToCharArray();
            charsB = b.ToCharArray();
            int[] intA = new int[a.Length];
            int[] intB = new int[b.Length];

            for (int i = 0; i < a.Length; i++)
            {
                sumA += charsA[i];
                intA[i] = charsA[i];
            }

            for (int i = 0; i < b.Length; i++)
            {
                sumB += charsB[i];
                intB[i] = charsB[i];
            }

            for (int i = 0; i < a.Length; i++)
            {
                aLeft += intA[i];
                aRight = sumA - aLeft;
                for (int j = 0; j < b.Length; j++)
                {   
                    bLeft += intB[j];
                    bRight = sumB - bLeft;
                    nakovs = Math.Abs((aLeft * bRight) - (aRight * bLeft));
                    if (nakovs <= d)
                    {
                        if (i == a.Length - 1)
                            break;
                        if (j == b.Length - 1)
                            continue;
                        Console.WriteLine("(" + a.Substring(0, i + 1) + "|" + a.Substring(i + 1, a.Length - j - 1 ) + ") matches (" + b.Substring(0, j + 1) + "|" + b.Substring(j + 1, b.Length - j - 1 ) + ") by {0} nakovs", nakovs);
                       
                    }
                }
                bLeft = 0;
            }



        }
    }
}
