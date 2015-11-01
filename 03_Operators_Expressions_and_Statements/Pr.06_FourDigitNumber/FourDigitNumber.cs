using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a four-digit number, which cannot start with 0: ");
        int fourDigitNum = int.Parse(Console.ReadLine());
        int a = fourDigitNum / 1000;
        int bHelp = fourDigitNum / 100;
        int b = bHelp % 10;
        int cHelp = fourDigitNum / 10;
        int c = cHelp % 10;
        int d = fourDigitNum % 10;
        Console.WriteLine(a + b + c + d);
        Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
    }
}
