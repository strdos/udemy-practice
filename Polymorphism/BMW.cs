using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class BMW : Car
    {
        private string brand = "BMW";
        public string Model { get; set; }
        

        public BMW(string model, int hP, string color) : base(hP, color)
        {
            Model = model;
        }
        public new void ShowDetails() => Console.WriteLine($"This is {brand}, model {Model}, and it has {HP} hp and is {Color}.");
        public override void Repair() => Console.WriteLine($"The {brand} {Model} was repaired.");
    }
}
