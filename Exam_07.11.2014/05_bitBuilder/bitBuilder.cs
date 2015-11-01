using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_bitBuilder
{
    class bitBuilder
    {
        static void Main(string[] args)
        {
            int number = 255;
            int firstBit = 0;
            string firstString = "flip";
            int secondBit = 10;
            string secondString = "insert";
            int thirdBit = 1;
            string thirdString = "remove";
            int forthBit = 8;
            string forthString = "skip";
            StringBuilder numberAsString = new StringBuilder();
            numberAsString.Append(Convert.ToString(number, 2));
            Console.WriteLine(numberAsString);

            if (firstBit == 0 && firstString == "flip")
                numberAsString[numberAsString.Length - 1 - firstBit] = '1';
            else if (firstBit == 1 && firstString == "flip")
                numberAsString[numberAsString.Length - 1 - firstBit] = '0';
            else if (firstString == "remove")
                numberAsString.Remove((numberAsString.Length - 1 - firstBit), 1);
            else if (firstString == "remove")
                numberAsString.Remove((numberAsString.Length - 1 - firstBit), 1);
            if (secondBit == 0 && secondString == "flip")
                numberAsString[numberAsString.Length - 1 - secondBit] = '1';
            else if (secondBit == 0 && secondString == "flip")
                numberAsString[numberAsString.Length - 1 - secondBit] = '0';
            else if (thirdString == "remove")
                numberAsString.Remove((numberAsString.Length - 1 - thirdBit), 1);
            if (thirdBit == 0 && thirdString == "flip")
                numberAsString[numberAsString.Length - 1 - thirdBit] = '1';
            else if (thirdBit == 0 && thirdString == "flip")
                numberAsString[numberAsString.Length - 1 - thirdBit] = '0';
            else if (thirdString == "remove")
                numberAsString.Remove((numberAsString.Length - 1 - thirdBit), 1);
            if (forthBit == 0 && forthString == "flip")
                numberAsString[numberAsString.Length - 1 - forthBit] = '1';
            else if (forthBit == 0 && forthString == "flip")
                numberAsString[numberAsString.Length - 1 - forthBit] = '0';
            else if (forthString == "remove")
                numberAsString.Remove((numberAsString.Length - 1 - forthBit), 1);


        }
    }
}
