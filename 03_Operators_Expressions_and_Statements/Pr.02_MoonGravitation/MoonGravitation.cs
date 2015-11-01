using System;

    class MoonGravitation
    {
        static void Main()
        {
            Console.Write("Please enter your weight on Earth: ");
            double weightOnEarth = double.Parse(Console.ReadLine());
            double gOnEarth = 9.80665;
            double gOnMoon = (gOnEarth*17)/100;
            double weightOnMoon = (weightOnEarth * gOnMoon) / gOnEarth;
            
            Console.WriteLine("Your weight on Moon would be: " + weightOnMoon);
        }
    }

