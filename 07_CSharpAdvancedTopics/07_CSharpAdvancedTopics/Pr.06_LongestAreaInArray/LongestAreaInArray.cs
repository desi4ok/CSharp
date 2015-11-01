using System;
using System.Collections.Generic;
using System.Linq;


class LongestAreaInArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<string> elements = new List<string>();
        int count = 0;
        int biggerCount = 0;
        int biggestCount = 0;

        for (int i = 0; i < n; i++)
        {   
            elements.Add(Console.ReadLine());
        }

        for (int i = 0; i < n-1; i++)
        {

            bool equalElements = (elements[i] == elements[i + 1]);
                
            if (equalElements)
            {
                count++;
                if (count > biggerCount)
                {
                    biggerCount = count;
                }
                else if (count > biggerCount && biggerCount > 0)
                {
                    elements.RemoveAt(i);
                }
            }

           /* else if (equalElements == false && count == 0)
            {
                if ((elements[i]).Length < (elements[i + 1]).Length && i < n - 2)
                {
                    elements.RemoveAt(i);
                }
            }*/

            else if (equalElements == false && count > 0);
            {
                if (biggestCount == 0)
                {
                    count = 0;
                    biggestCount = biggerCount;
                    biggerCount = 0;
                }
                else if (biggestCount > 0 && biggerCount < biggestCount)
                {
                    for (int j = (i - count); j <= i; j++)
                    {
                        elements.RemoveAt(j);
                    }
                    count = 0;
                    biggerCount = 0;
                }
                else if (biggestCount > 0 && biggerCount >= biggestCount)
                {
                    for (int j = 0; j <= biggestCount; i++)
                    {
                        elements.RemoveAt(j);
                    }
                    biggestCount = biggerCount;
                    count = 0;
                    biggerCount = 0;
                }
            }
        }

        foreach (var element in elements)
        {
            Console.WriteLine(element);
        }
    }
}

