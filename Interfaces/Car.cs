using System;
using System.Collections.Generic;

namespace Interfaces
{
    internal class Car : Vehicle, IDestroyable
    {
        public string DestructionSound { get; set; }

        // declare a field to store destroyable objects nearby
        public List<IDestroyable> DestroyablesNearby;
        
        public Car(float speed, string color) : base(speed, color) 
        {
            DestructionSound = "CarExplosionSound.mp3";
            // initialize the list of destroyable objects
            DestroyablesNearby = new List<IDestroyable>();
        }        

        public void Destroy()
        {
            Console.WriteLine($"Playing destruction sound {DestructionSound}");
            Console.WriteLine("Create fire effect");
            foreach  (IDestroyable o in DestroyablesNearby)
            {
                o.Destroy();
            }
        }
    }
}
