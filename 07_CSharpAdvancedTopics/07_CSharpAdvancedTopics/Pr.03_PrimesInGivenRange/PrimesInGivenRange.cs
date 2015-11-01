using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrimesInGivenRange
{
    static void Main()
    {
        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());

        if (startNum > endNum)
        {
            Console.WriteLine("Empty list");
        }
        else
        {
            List<int> theList = FindPrimesInRange(startNum, endNum);
        }
    }
    static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primeList = new List<int>();
        bool isPrime = true;

        Console.Write("All primes in their range are: ");
       
            for (int i = startNum; i <= endNum; i++)
            {
                for (int j = 2; j < endNum; j++)
                {
                    if ((i != j && i % j == 0) || i < 2)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeList.Add(i);
                }
                isPrime = true;
            }
        foreach (var prime in primeList)
        {
            Console.Write(prime + ", ");
        }
        return primeList;
    }
}

