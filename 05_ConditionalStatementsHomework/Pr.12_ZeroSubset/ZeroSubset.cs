using System;

    class ZeroSubset
    {
        static void Main()
            {
                int a, b, c, d, e;
                Console.Write("Enter a: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Enter b: ");
                b = int.Parse(Console.ReadLine());
                Console.Write("Enter c: ");
                c = int.Parse(Console.ReadLine());
                Console.Write("Enter d: ");
                d = int.Parse(Console.ReadLine());
                Console.Write("Enter e: ");
                e = int.Parse(Console.ReadLine());
                int i = 0;

                if ((a + b) == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", a, b);
                    i++;
                }
                if ((a + c) == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", a, c);
                    i++;
                }
                if ((a + d) == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", a, d);
                    i++;
                }
                if ((a + e) == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", a, e);
                    i++;
                }
                if ((b + c) == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", b, c);
                    i++;
                }
                if ((b + d) == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", b, d);
                    i++;
                }
                if ((b + e) == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", b, e);
                    i++;
                }
                if ((c + d) == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", c, d);
                    i++;
                }
                if ((c + e) == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", c, e);
                    i++;
                }
                if ((d + e) == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", d, e);
                    i++;
                }
                if ((a + b + c) == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", a, b, c);
                    i++;
                }
                if ((a + b + d) == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", a, b, d);
                    i++;
                }
                if ((a + b + e) == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", a, b, e);
                    i++;
                }
                if ((a + c + d) == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", a, c, d);
                    i++;
                }
                if ((a + c + e) == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", a, c, e);
                    i++;
                }
                if ((a + d + e) == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", a, d, e);
                    i++;
                }
                if ((b + c + d) == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", b, c, d);
                    i++;
                }
                if ((b + c + e) == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", b, c, e);
                    i++;
                }
                if ((b + d + e) == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", b, d, e);
                    i++;
                }
                if ((c + d + e) == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", c, d, e);
                    i++;
                }
                if ((a + b + c + d) == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, d);
                    i++;
                }
                if ((a + b + c + e) == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, e);
                    i++;
                }
                if ((a + c + d + e) == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, c, d, e);
                    i++;
                }
                if ((a + b + d + e) == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, d, e);
                    i++;
                }
                if ((a + b + c + d + e) == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", a, b, c, d, e);
                    i++;
                }

                if (i == 0)
                {
                    Console.WriteLine("no zero subset");
                }
            }
        }

