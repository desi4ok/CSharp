using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_gambling
{
    class gambling
    {
        static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            string inputString = Console.ReadLine();
            string[] inputCards = inputString.Split(' ');
            decimal strength = 0;
            decimal winningHandsCount = 0;
            decimal notWinningHandsCount = 0;
            decimal sum;
            decimal ratio;
            decimal expectedWinings;
            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            for (int i = 0; i < 4; i++)
			{
                for (int j = 0; j < 13; j++)
                {
                    if (inputCards[i] == cards[j])
                    {
                        strength += 2;
                        strength += j;
                    }
                }
            }

            for (int a  = 2; a <= 14; a++)
            {
                for (int b = 2; b <= 14; b++)
                {
                    for (int c = 2; c <= 14; c++)
                    {
                        for (int d = 2; d <= 14; d++)
                        {
                            if ((a + b + c + d) > strength)
                                winningHandsCount++;
                            else
                                notWinningHandsCount++;
                        }
                    }
                }
            }
            sum = winningHandsCount + notWinningHandsCount;
            ratio = (winningHandsCount * 100) / sum;
            expectedWinings = 2 * cash * ratio / 100;
            if (ratio < 50)
            {
                Console.WriteLine("FOLD");
                Console.WriteLine("{0:F2}", expectedWinings);
            }
            else if (ratio >= 50)
            {
                Console.WriteLine("DRAW");
                Console.WriteLine("{0:F2}", expectedWinings);
            }
        }
    }
}
