using System;

namespace Interfaces
{
    internal class Weapon
    {
        public string Name { get; set; }
        public Weapon() => Name = "Weapon";
        public Weapon(string name) =>  Name = name;        
        public void Label() => Console.WriteLine($"This is {Name}!");
    }
}
