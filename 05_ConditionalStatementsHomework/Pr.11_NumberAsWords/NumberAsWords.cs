using System;

    class NumberAsWords
    {
        static void Main()
        {
            Console.Write("Enter a number in the range [0...999]: ");
            int num = int.Parse(Console.ReadLine());
            
            string[] unitsAndHundreds = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] tens = { "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

            int hundredsDigit = num / 100;
            int tensDigit = (num / 10) % 10;
            int unitsDigit = num % 10;

            if (num < 0 || num > 999)
            {
                Console.WriteLine("Invalid number");
            }
            else if (num > 99 && num < 1000)
            {
                Console.Write("{0} hundred and ", unitsAndHundreds[hundredsDigit - 1]);
                if (num % 100 < 19)
                {
                    Console.WriteLine("{0}", unitsAndHundreds[(num % 100) - 1].ToLower());
                }
                else if (num % 100 > 19)
                {
                    Console.Write("{0} ", tens[tensDigit - 2].ToLower());
                    if (unitsDigit > 0)
                    {
                        Console.WriteLine("{0}", unitsAndHundreds[unitsDigit - 1].ToLower());
                    }
                }
            }
            else if (19 < num && num < 99)
            {
                Console.Write("{0} ", tens[tensDigit - 2]);
                if (unitsDigit > 0)
                {
                    Console.WriteLine("{0}", unitsAndHundreds[unitsDigit - 1].ToLower());
                }
            }
            else if (num % 100 < 19)
            {
                Console.WriteLine("{0}", unitsAndHundreds[(num % 100) - 1]);
            }
        }
    }

