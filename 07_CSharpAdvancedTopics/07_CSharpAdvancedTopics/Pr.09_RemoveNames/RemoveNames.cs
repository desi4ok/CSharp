using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RemoveNames
{
    static void Main()
    {
        Console.WriteLine("Enter the first list of names, separated by a space: ");
        string first = Console.ReadLine();
        string[] firstNames = first.Split(new char[] { ' ' });
        List<string> firstList = new List<string>();

        Console.WriteLine("Enter the second list of names, separated by a space: ");
        string second = Console.ReadLine();
        string[] secondNames = second.Split(new char[] { ' ' });
        List<string> secondList = new List<string>();


        foreach (var name in firstNames)
        {
            firstList.Add(name);
        }

        foreach (var name in secondNames)
        {
            secondList.Add(name);
        }

        for (int i = 0; i < secondList.Count; i++)
        {
            for (int j = 0; j < firstList.Count; j++)
            {
                if (secondList[i] == firstList[j])
                {
                    firstList.RemoveAt(j);
                }
            }
        }
        foreach (var name in firstList)
        {
            Console.Write(name + " ");
        }
        Console.WriteLine();
    }
}

