using System;

class SortingNumbers
{
    //ima i po-kratyk variant, no treniram metodite :)

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] numsInArray = ArrayOfNnums(n);
        PrintingSortedArray(numsInArray);
    }
    static int[] ArrayOfNnums (int n)
    {
        int[] nums = new int [n];
        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());            
        }
        return nums;
    }
    static void PrintingSortedArray(int[] nums)
    {
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine(nums[i]);
        }
    }
}
