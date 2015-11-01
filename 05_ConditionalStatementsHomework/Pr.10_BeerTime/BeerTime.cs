using System;


    class BeerTime
    {
        static void Main()
        {
            string time = Console.ReadLine();
            DateTime startBeer = DateTime.Parse("1:00 PM");
            DateTime endBeer = DateTime.Parse("3:00 AM");
            DateTime beer;
            bool result = DateTime.TryParseExact(time, "h:mm tt", new System.Globalization.CultureInfo("en-US"), System.Globalization.DateTimeStyles.None, out beer);
            bool beerTime = (startBeer <= beer) || (beer < endBeer);
            
            if (result)
            {
                if (beerTime)
                {
                    Console.WriteLine("beer time");
                }
                else
                {
                    Console.WriteLine("non beer time");
                }
            }
            else
            {
                Console.WriteLine("Invalid time");
            }
        }
    }

