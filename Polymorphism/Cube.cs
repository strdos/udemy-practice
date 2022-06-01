using System;

namespace Polymorphism
{
    internal class Cube : Shape
    {
        public double Length { get; set; }
        public Cube(double length)
        {
            Name = "Cube";
            Length = length;
        }
        public override double CalculateVolume() => Math.Pow(Length, 3);
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"The cube has a length of {Length}.");
        }
    }
}
