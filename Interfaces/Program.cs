using System;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IEnumerable, IEnumerator practice
            DogShelter shelter = new DogShelter();
            foreach  (Dog d in shelter)
            {
                if (d.IsNaughtyDog)
                    d.GiveTreat(1);
                else
                    d.GiveTreat(2);
            }
            
            // IShootable interface challenge
            //Gun pist = new Gun();
            //pist.Label();
            //pist.Shoot();
            //// verify interface and parent class
            //if (pist is IShootable && pist is Weapon)
            //    Console.WriteLine("Yes, these are my parents.");
            
            // IDestroyable interface example
            //Chair officeChair = new Chair("brown", "plastic");
            //Chair gamingChair = new Chair("red", "leather");
            //Car damagedCar = new Car(80f, "blue");

            //damagedCar.DestroyablesNearby.Add(officeChair);
            //damagedCar.DestroyablesNearby.Add(gamingChair);
            //damagedCar.Destroy();

            // example with Ticket Class
            //Ticket t1 = new Ticket(10);
            //Ticket t2 = new Ticket(10);
            //Console.WriteLine(t2.Equals(t1));
        }
    }
}
