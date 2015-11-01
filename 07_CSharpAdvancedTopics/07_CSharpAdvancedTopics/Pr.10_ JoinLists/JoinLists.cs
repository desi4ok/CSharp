using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr._10__JoinLists
{
    class JoinLists
    {
        static void Main()
        {
            Console.WriteLine("Enter the first list of integers, separated by a space: ");
            //string first = Console.ReadLine();
            //string[] firstInts = first.Split(new char[] { ' ' });

            //string[] firstInts = Console.ReadLine().Split(new char[] { ' ' });
            List<string> firstList = new List<string>(Console.ReadLine().Split(new char[] { ' ' }));

            Console.WriteLine("Enter the second list of integers, separated by a space: ");
            string second = Console.ReadLine();
            string[] secondInts = second.Split(new char[] { ' ' });
            List<string> secondList = new List<string>();


            foreach (var ints in secondInts)
            {
                secondList.Add(ints);
            }

            foreach (var ints in secondList)
            {
                firstList.Add(ints);
            }

           /* for (int i = 0; i < firstList.Count - 1; i++)
            {
                for (int j = i+1; j < firstList.Count; j++)
                {
                    if (firstList[i] == firstList[j])
                    {
                        firstList.RemoveAt(j);
                    }
                }
            }*/
            firstList = firstList.Distinct().ToList();
            firstList.Sort();

            foreach (var ints in firstList)
            {
                Console.Write(ints + " ");
            }
            Console.WriteLine();


            
        }
    }
}
