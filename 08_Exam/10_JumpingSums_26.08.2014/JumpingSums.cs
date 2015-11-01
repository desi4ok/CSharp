using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_JumpingSums_26._08._2014
{
    class JumpingSums
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int j = int.Parse(Console.ReadLine());
            string[] sArray = s.Split(' ');
            int[] numbers = Array.ConvertAll<string, int>(sArray, int.Parse);
            int nextIndex = 0;
            int sum = 0;
            int maxSum = 0;
            int index = 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int jump = 0; jump < j; jump++)
                {                     
                    nextIndex += ((numbers[index] + index) % numbers.Length);
                    sum += numbers[index];
                    if (nextIndex < numbers.Length)
                    {
                        index = nextIndex;
                    }
                    else if (nextIndex >= numbers.Length)
                    {
                        index = 0;
                    }
                    nextIndex = 0;
                    if (jump == j - 1)
                        sum += numbers[index];
                }

                if (sum > maxSum)
                {
                    maxSum = sum;
                }
                sum = 0;
                index = i + 1;
            }
            Console.WriteLine("max sum = {0}", maxSum);
        }
    }
}
