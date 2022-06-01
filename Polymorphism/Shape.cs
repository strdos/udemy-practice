using System;

namespace Polymorphism
{
    // abstract class, i.e. we will not create objects of Shape class but we will use its members
    abstract class Shape
    {
        public string Name { get; set; }
        public virtual void GetInfo() => Console.WriteLine($"\nThis is a {Name}.");
        
        // abstract method
        public abstract double CalculateVolume();
    }
}
