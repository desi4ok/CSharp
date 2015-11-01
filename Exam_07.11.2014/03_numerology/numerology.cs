using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _03_numerology
{
    class numerology
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] inputString = input.Split(' ', '.');
            int[] date = new int[3];
            for (int i = 0; i < 3; i++)
            {
                date[i] = Convert.ToInt32(inputString[i]);
            }
            string name = inputString[3];
            char[] chars = new char[name.Length];
            chars = name.ToCharArray();
            int charsSum = 0;
            int count = 0;
            int biggerCount = 0;
            int biggestCount = 0;
            BigInteger outputNumber = 0;
            BigInteger dateProduct = date[0] * date[1] * date[2];
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] >= 'A' && chars[i] <= 'Z')
                {
                    charsSum += (chars[i] - 'A' + 1) * 2;
                }
                else if (chars[i] >= 'a' && chars[i] <= 'z')
                {
                    charsSum += chars[i] - 'a' + 1;
                }
                else if (chars[i] >= '0' && chars[i] <= '9')
                {
                    charsSum += chars[i] - '0';
                }
            }
            if (date[1] % 2 == 0)
            {
                outputNumber = dateProduct + charsSum;
            }
            else if (date[1] % 2 != 0)
            {
                outputNumber += (dateProduct * dateProduct) + charsSum;
            }

            string outputNumberString = outputNumber.ToString();
            int[] index = new int[outputNumberString.Length];
            for (int i = 0; i < outputNumberString.Length; i++)
            {
                index[i] = outputNumberString[i] - '0';
                count += index[i];
            }
            if (count <= 13)
                Console.WriteLine(count);

            else if (count > 13)
            {
                string biggerNumber = count.ToString();
                int[] biggerIndex = new int[biggerNumber.Length];
                for (int i = 0; i < biggerNumber.Length; i++)
                {
                    biggerIndex[i] = biggerNumber[i] - '0';
                    biggerCount += biggerIndex[i];
                }
                if (biggerCount <= 13)
                    Console.WriteLine(biggerCount);
                else if (biggerCount > 13)
                {
                    string biggestNumber = biggerCount.ToString();
                    int[] biggestIndex = new int[biggestNumber.Length];
                    for (int i = 0; i < biggestNumber.Length; i++)
                    {
                        biggestIndex[i] = biggestNumber[i] - '0';
                        biggestCount += biggestIndex[i];
                    }
                    Console.WriteLine(biggestCount);
                }
            }
        }
    }
}
