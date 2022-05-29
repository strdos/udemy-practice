using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog("Bobby", 12);
            Console.WriteLine($"{myDog.Name} is {myDog.Age} years old.");
            myDog.MakeSound();
            myDog.Play();
            myDog.Eat();
            
            //Radio myRadio = new Radio(true, "Bluetrend");
            //TV myTV = new TV(false, "Panasonic");
            //myRadio.ListenToRadio();
            //myTV.WatchTV();
            //myTV.TurnOn();
            //myTV.WatchTV();
        }
    }
}
