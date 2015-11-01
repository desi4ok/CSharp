using System;
using System.Text;

    class IsoscelesTriangle
    {
        static void Main()
        {
            char a = '\u00a9';
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("    " + a);
            Console.WriteLine("   " + a + " " + a);
            Console.WriteLine("  " + a + "   " + a);
            Console.WriteLine(" " + a + " " + a + " " + a + " " + a);
        }
    }

