using System;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Human john = new Human();
            //john.firstName = "John";
            //john.lastName = "Brown";
            //john.IntroduceMyself();
            
            //Human anna = new Human();
            //anna.firstName = "Anna";
            //anna.lastName = "Rose";
            //anna.IntroduceMyself();

            Human george = new Human("George", "Madman", "blue", 1);
            george.IntroduceMyself();

            Human arianna = new Human("Arianna", "Newman", "green");
            arianna.IntroduceMyself();

            Human elon = new Human("Elon", "Husk");
            elon.IntroduceMyself();

            Human human = new Human();
            human.IntroduceMyself();

            Property property1 = new Property();
            Console.WriteLine($"Property 1 volume is {property1.Volume}");
            property1.Volume = 50;
            Console.WriteLine($"Property 1 volume is {property1.Volume}");

        }
    }
}
