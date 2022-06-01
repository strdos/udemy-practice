using System;

namespace Interfaces
{
    internal class Dog
    {
        public string Name { get; set; }
        public bool IsNaughtyDog { get; set; }
        public Dog(string name, bool isNaughtyDog)
        {
            Name = name;
            IsNaughtyDog = isNaughtyDog;
        }
        public void GiveTreat(int numberOfTreats) => Console.WriteLine($"{Name} said 'woof' {numberOfTreats} times.");
    }
}
