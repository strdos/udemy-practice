using System;

namespace Interfaces
{
    internal class Gun : Weapon, IShootable
    {
        public Gun() => Name = "Gun";
        public Gun(string name) : base(name) { }
        public void Shoot() => Console.WriteLine("Bang!");
    }
}
