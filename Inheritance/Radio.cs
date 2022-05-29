using System;

namespace Inheritance
{
    internal class Radio : Device
    {
        public Radio(bool isOn, string brand) : base(isOn, brand)
        {
        }
        public void ListenToRadio()
        {
            if (IsOn)
                Console.WriteLine("Listening to the radio!");
            else
                Console.WriteLine("The radio is off, please turn it on first.");
        }
    }
}
