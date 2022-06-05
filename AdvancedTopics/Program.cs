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
        // Math
        public static double ConvertToRadians(double angle)
        {         
            return (Math.PI / 180) * angle;
        }
        public static double GetUserInput()
        {
            Console.WriteLine("Please enter an angle.");
            string input = Console.ReadLine();
            if (!double.TryParse(input, out double inputAsDouble))
            {
                Console.WriteLine("Wrong input. Please enter a number.");
                GetUserInput();
            }
            else if (inputAsDouble < 0 || inputAsDouble > 180)
            {
                Console.WriteLine("Wrong input. Please enter a number between 0 and 180.");
                GetUserInput();
            }           
            return inputAsDouble;
        }
        static void Main(string[] args)
        {
            // Random class
            Random dice = new Random();
            int numDots;
            for (int i = 0; i < 10; i++)
            {
                numDots = dice.Next(1,7);
                Console.WriteLine(numDots);
            }

            Random yesNoMaybe = new Random();
            int num;
            for (int i = 0; i < 10; i++)
            {
                num = yesNoMaybe.Next(0,3);
                switch(num)
                {
                    case 0: Console.WriteLine("Yes");
                        break;
                    case 1: Console.WriteLine("Maybe");
                        break;
                    case 2: Console.WriteLine("No");
                        break;
                }
            }

            //// Math class
            //double x = 15.3, y = 18.4, z = -5;
            //Console.WriteLine($"The ceiling of {x} is: " + Math.Ceiling(x));
            //Console.WriteLine($"The floor of {x} is: " + Math.Floor(x));
            //Console.WriteLine($"The lower of {x} and {y} is: " + Math.Min(x, y));
            //Console.WriteLine($"{x} to the power of {y} is: " + Math.Pow(x, y));
            //Console.WriteLine($"The absolute value of {z} is: " + Math.Abs(z));

            //double inputAsDouble = GetUserInput();
            //Console.WriteLine($"The cosine of this angle is: " + Math.Cos(ConvertToRadians(inputAsDouble)));
            //Console.WriteLine($"The sine of this angle is: " + Math.Sin(ConvertToRadians(inputAsDouble)));
            //Console.WriteLine($"The tangent of this angle is: " + Math.Tan(ConvertToRadians(inputAsDouble)));


            //// enums
            //Day fr = Day.Fr;
            //Day su = Day.Su;
            //Day aDay = Day.Fr;
            //Console.WriteLine(su);
            //Console.WriteLine((int)Day.Mo);
            //Console.WriteLine(aDay == fr);

            //Console.WriteLine((int)Month.Feb);
            //Console.WriteLine((int)Month.Jul);

            //// structs
            //Game game1;
            //game1.name = "Pokemon Go";
            //game1.developer = "Niantic";
            //game1.rating = 3.5;
            //game1.releaseDate = "1 July 2016";
            //game1.Display();

            //// proves that a struct is a value type
            //Location a = new Location(20, 20);
            //Location b = a;  
            //a.x = 100;  
            //Console.WriteLine(b.x);
            //// the output is 20; if Location were a class (which is a reference type), the output would be 100
        }
    }
}
