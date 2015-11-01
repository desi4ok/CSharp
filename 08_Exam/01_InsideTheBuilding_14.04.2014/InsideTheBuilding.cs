using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_InsideTheBuilding_14._04._2014
{
    class InsideTheBuilding
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int[] coordinates = new int[10];
            for (int i = 0; i < 10; i++)
            {
                coordinates[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i <= 8; i+=2)
			{
                int j = i + 1;
                bool firstCondition = coordinates[i] >= 0 && coordinates[i] <= h && coordinates[j] >= 0 && coordinates[j] <= h;
                bool secondCondition = coordinates[i] >= h && coordinates[i] <= 2*h && coordinates[j] >= 0 && coordinates[j] <= 4*h;
                bool thirdCondition = coordinates[i] >= 2*h && coordinates[i] <= 3*h && coordinates[j] >= 0 && coordinates[j] <= h;

                if (firstCondition || secondCondition || thirdCondition)
                {
                    Console.WriteLine("inside");
                    
                }
                else
                {
                    Console.WriteLine("outside");
                }
			}
        }
    }
}
