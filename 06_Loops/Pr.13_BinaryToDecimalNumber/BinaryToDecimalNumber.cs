using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        string num = Console.ReadLine();
        
        ulong binaryNum = ulong.Parse(num);
        ulong sum = 0;

        if (binaryNum % 10 == 1)
        {
            sum = 1;
        }
        else 
        {
            sum = 0;
        }
        
        for (int i = 0; i < 60; i++)
        {
            if (binaryNum % 10 == 1)
            {
                binaryNum /= 10;
                sum
            }
        }
       
    }
}
