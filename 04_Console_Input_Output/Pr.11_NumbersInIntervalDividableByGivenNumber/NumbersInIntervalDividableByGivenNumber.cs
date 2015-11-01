using System;

    class NumbersInIntervalDividableByGivenNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b = ");
            int b = int.Parse(Console.ReadLine());

            if (a < b)
            { 
                for (int num = a; num <= b; num++)
                {
                    if (num % 5 == 0 || num % 10 == 0)
                    {
                    Console.Write(num + ", ");
                    }
                }
            }


            else
            {
                for (int num = b; num <= a; num++)
                {
                    if (num % 5 == 0 || num % 10 == 0)
                    {
                        Console.Write(num + ", ");
                    }
                }
            }


        }
    }
