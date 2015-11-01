using System;

    class QuotesInStrings
    {
        static void Main()
        {
            string quotedString = "The \"use\" of quotations causes difficulties.";
            string prefixedString = @"The ""use"" of quotations causes difficulties.";

            Console.WriteLine(quotedString);
            Console.WriteLine(prefixedString);
        }
    }
