using System;

namespace Polymorphism
{
    internal class Sphere : Shape
    {
        public double Radius { get; set; }
        public Sphere(double radius)
        {
            Name = "Sphere";
            Radius = radius;
        }
        public override double CalculateVolume() => Math.PI * 4 / 3 * Math.Pow(Radius, 3);
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"The sphere has a radius of {Radius}.");
        }
    }
}
