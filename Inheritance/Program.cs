using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Radio myRadio = new Radio(true, "Bluetrend");
            TV myTV = new TV(false, "Panasonic");

            myRadio.ListenToRadio();
            myTV.WatchTV();
            myTV.TurnOn();
            myTV.WatchTV();
        }
    }
}
