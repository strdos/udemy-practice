using System;

namespace Inheritance
{
    internal class Device
    {
        public bool IsOn { get; set; }
        public string Brand { get; set; }

        public Device (bool isOn, string brand)
        {
            IsOn = isOn;
            Brand = brand;
        }

        public void TurnOn()
        {
            IsOn = true;
        }
        public void TurnOff()
        {
            IsOn = false;
        }
    }
}
