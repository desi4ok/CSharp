using System;

    class Palindromes
    {
        static void Main()
        {
            Console.WriteLine("Enter number for row and col");
            Console.Write("row = ");
            int r = int.Parse(Console.ReadLine());
            Console.Write("col = ");
            int c = int.Parse(Console.ReadLine());

            string[,] matrix = new string[r, c];

            for (int row = 0; row < r; row++)
            {
                for (int col = 0 ; col < c; col++)
                {
                    matrix[row, col] = "" + (char)('a' + row) + (char)('a' + col + row) + (char)('a' + row);
                }
            }

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            
            /*string[] alphabet = new string[26];
            for (int i = 0; i < 26; ++i) 
            {
            string[i] = (char)('a') + i;
            }*/
             
        }
    }

    
