using System;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IDestroyable interface example
            Chair officeChair = new Chair("brown", "plastic");
            Chair gamingChair = new Chair("red", "leather");
            Car damagedCar = new Car(80f, "blue");

            damagedCar.DestroyablesNearby.Add(officeChair);
            damagedCar.DestroyablesNearby.Add(gamingChair);

            damagedCar.Destroy();


            // example with Ticket Class
            //Ticket t1 = new Ticket(10);
            //Ticket t2 = new Ticket(10);
            //Console.WriteLine(t2.Equals(t1));
        }
    }
}
