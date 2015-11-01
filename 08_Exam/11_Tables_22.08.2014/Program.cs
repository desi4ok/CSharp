using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Tables_22._08._2014
{
    class Program
    {
        static void Main(string[] args)
        {
            int packs1 = int.Parse(Console.ReadLine());
            int packs2 = int.Parse(Console.ReadLine());
            int packs3 = int.Parse(Console.ReadLine());
            int packs4 = int.Parse(Console.ReadLine());
            int T = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int sumOfLegs = packs1 + (packs2 * 2) + (packs3 * 3) + (packs4 * 4);
            int normOfaLegs = N*4;

            if (T == N && normOfaLegs == sumOfLegs)
                Console.WriteLine("Just enough tables made: {0}", N);
            else if (T < N || normOfaLegs > sumOfLegs)
            {
                Console.WriteLine("less: {0}", (T - N));
                Console.WriteLine("tops needed: {0}, legs needed {1}", (N - T), (normOfaLegs - sumOfLegs));
            }
            else if (T > N || normOfaLegs < sumOfLegs)
            {
                Console.WriteLine("more: {0}", (T - N));
                Console.WriteLine("table tops left: {0}, legs left: {1}", (T - N), (sumOfLegs - normOfaLegs));
            }
        }
    }
}
