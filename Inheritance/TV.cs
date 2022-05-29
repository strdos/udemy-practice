using System;

namespace Inheritance
{
    internal class TV : Device
    {
        public TV(bool isOn, string brand) : base(isOn, brand)
        {
        }
        public void WatchTV()
        {
            if (IsOn)
                Console.WriteLine("Watching TV!");
            else
                Console.WriteLine("The TV is off, please turn it on first.");
        }
    }
}
