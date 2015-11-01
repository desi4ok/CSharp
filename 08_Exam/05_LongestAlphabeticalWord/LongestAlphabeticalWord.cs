using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LongestAlphabeticalWord
{
    class LongestAlphabeticalWord
    {
        static void Main(string[] args)
        {
            string w = "softwareuniversity";
            int n = 7;
            int numOfLetters = n * n;
            double numOfW = numOfLetters / w.Length;
            string longW = w;
            int count = 0;
            int maxCount = 0;

            string[] arrayOfW = new string[n];
            char[] charArray;
            List<char> listOfChars = new List<char>();
            int[] counts;
            for (int i = 0; i < numOfW; i++)
            {
                longW += w;
            }
            string www = longW.Substring(0, 49);
            for (int i = 0; i < n * n; i+=7)
            {
                int j = 0;
                arrayOfW[j] = longW.Substring(i, n);
                j++;
            }

            charArray = longW.ToCharArray();
            

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < (n * n) - 7; j++)
                {
                    listOfChars.Add(charArray[j]);
                    if (charArray[j] < charArray[j + 7]) ;
                    {
                        count++;
                        listOfChars.Add(charArray[j + 7]);
                        Console.WriteLine(charArray[j + 7]);
                    }
                    
                }
                if (maxCount == 0 && maxCount < count)
                {
                    maxCount = count;
                    
                }
                else if (maxCount > 0 && maxCount < count)
                {
                    maxCount = count;
                }
                count = 0;
            }

            


            
            




            
        }
    }
}
