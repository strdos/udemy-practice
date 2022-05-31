using System;

namespace Interfaces
{
    internal class Furniture
    {
        public string Color { get; set; }
        public string Material { get; set; }
        public Furniture()
        {
            Color = "white";
            Material = "wood";
        }

        public Furniture(string color, string material)
        {
            Color = color;
            Material = material;
        }
    }
}
