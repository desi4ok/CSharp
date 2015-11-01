using System;

class ThirdDigitIsSeven
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine((a/100) % 10 == 7);
    }
}
