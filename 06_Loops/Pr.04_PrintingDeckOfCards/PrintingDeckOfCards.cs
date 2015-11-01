using System;
class PrintingDeckOfCards
{
    static void Main()
    {
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        char spades = '\u2660';
        char hearts = '\u2665';
        char diams = '\u2666';
        char clubs = '\u2663';
        
        for (int i = 0; i < cards.Length; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                switch (j)
                {
                    case 1:
                        Console.Write(cards [i] + clubs + " "); 
                        break;

                    case 2:
                        Console.Write(cards [i] + diams + " "); 
                        break;

                    case 3:
                        Console.Write(cards[i] + hearts + " "); 
                        break;

                    case 4:
                        Console.Write(cards[i] + spades + " ");
                        break;         
                }
                
            }
            Console.WriteLine();
        }
    }
}

