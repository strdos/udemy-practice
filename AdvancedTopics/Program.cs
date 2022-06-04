using System;

namespace AdvancedTopics
{
    // enums - basically, a set of constants for the whole library (project), should be placed at namespace level
    enum Day { Mo, Tu, Wd, Th, Fr, Sa, Su };
    // indexes can be changed
    enum Month { Jan = 1, Feb, Mar, Apr, May, Jun, Jul = 12, Aug, Sep, Oct, Nov, Dec };

    internal class Program
    {
        // structs
        struct Game
        {
            public string name;
            public string developer;
            public double rating;
            public string releaseDate;

            public void Display()
            {
                Console.WriteLine(name);
                Console.WriteLine(developer);
                Console.WriteLine(rating);
                Console.WriteLine(releaseDate);
            }
        }
        
        struct Location
        {
            public int x, y;
            public Location(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        static void Main(string[] args)
        {
            Day fr = Day.Fr;
            Day su = Day.Su;
            Day aDay = Day.Fr;
            Console.WriteLine(su);
            Console.WriteLine((int)Day.Mo);
            Console.WriteLine(aDay == fr);

            Console.WriteLine((int)Month.Feb);
            Console.WriteLine((int)Month.Jul);

            Game game1;
            game1.name = "Pokemon Go";
            game1.developer = "Niantic";
            game1.rating = 3.5;
            game1.releaseDate = "1 July 2016";

            game1.Display();

            // proves that a struct is a value type
            Location a = new Location(20, 20);
            Location b = a;  
            a.x = 100;  
            Console.WriteLine(b.x);
            // the output is 20; if Location were a class (which is a reference type), the output would be 100
        }
    }
}
