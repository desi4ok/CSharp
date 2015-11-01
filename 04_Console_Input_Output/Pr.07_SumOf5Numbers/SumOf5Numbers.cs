using System;

    class SumOf5Numbers
    {
        static void Main()
        {
            double sum = 0;
            string numbers = Console.ReadLine();
            string[] nums = numbers.Split(' ');
            for (int i = 0; i < nums.Length; i++)
            {
                double numberI = double.Parse(nums[i]);
                sum += numberI;
            }
            Console.WriteLine(sum);
        }
    }

