using System;

namespace Interfaces
{
    internal class Chair : Furniture, IDestroyable
    {
        public string DestructionSound { get; set; }
        public Chair(string color, string material) : base(color, material) 
        {
            DestructionSound = "ChairDestructionSound.mp3";
        }
        public void Destroy()
        {
            Console.WriteLine($"The {Color} chair was destroyed.");
            Console.WriteLine($"Playing destruction sound {DestructionSound}");
            Console.WriteLine("Spawning chair parts.");
        }
    }
}
