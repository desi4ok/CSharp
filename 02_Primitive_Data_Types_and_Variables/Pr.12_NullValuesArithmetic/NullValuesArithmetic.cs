using System;

    class NullValuesArithmetic
    {
        static void Main()
        {
            int? a = null;
            double? b = null;
            Console.WriteLine(a + null);
            Console.WriteLine(b + 3);
        }
    }
