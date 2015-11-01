using System;

    class PrintAsciiTable
    {
        static void Main()
        {
            ushort decNum = 0;
            char symbol;
            for (int i = 0; i <= 255; i++)
            {
                symbol = Convert.ToChar(decNum);
                Console.WriteLine("Decimal number {0} is the symbol: {1}", decNum, symbol);
                decNum++;
            }
        }
    }

