using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Student_Cables_14._04._2014
{
    class StudentCables
    {
        static void Main(string[] args)
        {
            int numberOfCables = int.Parse(Console.ReadLine());
            int[] cableLength = new int[numberOfCables];
            string[] measure = new string[numberOfCables];
            int sum = 0;
            int count = 0;
            

            for (int i = 0; i < numberOfCables; i++)
            {
                for (int j = 0; j < 2; j++)
			    {
                    if (j == 0)
                    {
                        cableLength[i] = int.Parse(Console.ReadLine());
                    }
                    if (j == 1)
                    {
                        measure[i] = Console.ReadLine();
                        if (measure[i] == "meters")
                        {
                            cableLength[i] *= 100;
                        }
                    }
                }
            }
            for (int i = 0; i < numberOfCables; i++)
            {
                if (cableLength[i] < 20)
                {
                    continue;
                }
                sum += cableLength[i];
                count += 1;
            }

            int cable = sum - ((count - 1) * 3);
            int numOfStudentCables = cable / 504;
            int theRemainder = cable - (numOfStudentCables * 504);

            
            Console.WriteLine(numOfStudentCables);
            Console.WriteLine(theRemainder);
        }
    }
}
