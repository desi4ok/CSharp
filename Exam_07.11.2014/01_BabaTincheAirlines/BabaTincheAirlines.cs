using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BabaTincheAirlines
{
    class BabaTincheAirlines
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string business = Console.ReadLine();
            string economy = Console.ReadLine();

            string[] firstString = first.Split(' ');
            string[] businessString = business.Split(' ');
            string[] economyString = economy.Split(' ');

            int[] firstClass = Array.ConvertAll<string, int>(firstString, int.Parse);
            int[] businessClass = Array.ConvertAll<string, int>(businessString, int.Parse);
            int[] economyClass = Array.ConvertAll<string, int>(economyString, int.Parse);

            double max = 12 * 7000 + 12 * 35 + 28 * 3500 + 28 * 17.5 + 50 * 1000 + 50 * 5;
            int maxIncome = (int)max;
            double incomeDouble = (firstClass[0] - firstClass[1]) * 7000 + firstClass[1] * 2100 + firstClass[2] * 35 + (businessClass[0] - businessClass[1]) * 3500 + businessClass[1] * 1050 + businessClass[2] * 17.5 + (economyClass[0] - economyClass[1]) * 1000 + economyClass[1] * 300 + economyClass[2] * 5;
            int income = (int)incomeDouble;

            Console.WriteLine(income);
            Console.WriteLine(maxIncome - income);

        }
    }
}
