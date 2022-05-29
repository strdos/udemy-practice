using System;

namespace Inheritance
{
    internal class Dog: Animal
    {
        public bool IsHappy { get; set; }
        public Dog(string name, int age) : base(name, age)
        {
            IsHappy = true;
        }           
        public override void MakeSound()
        {
            Console.WriteLine("Woof");
        }
        public override void Eat()
        {
            base.Eat();
        }
        public override void Play()
        {
            if (IsHappy)
                base.Play();
        }
    }
}
