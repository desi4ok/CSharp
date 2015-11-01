using System;

    class FibonacciNumbers
    {
        static void Main()
        {
            Console.Write("Enter number n > 0, n = ");
            int n = int.Parse(Console.ReadLine());
            int firstNum = 0;
            int secondNum = 1;
            int num;
            if (n == 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.Write(0 + ", " + 1 + ", ");
                for (int i = 0; i < n - 2; i++)
                {
                    num = firstNum + secondNum;
                    Console.Write(fibonacciNum + ", ");
                    firstNum = secondNum;
                    secondNum = num;
                }
            }
        }
    }


