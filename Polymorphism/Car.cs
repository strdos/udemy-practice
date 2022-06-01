using System;

namespace Polymorphism
{
    internal class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        // 'has a' inheritance relationship, i.e. every Car has CarIdInfo
        protected CarIdInfo CarIdInfo = new CarIdInfo();
        public void SetCarIdInfo(int idNum, string owner)
        {
            CarIdInfo.IdNum = idNum;
            CarIdInfo.Owner = owner;
        }
        public void GetCarIdInfo() => Console.WriteLine($"The ID for this car is {CarIdInfo.IdNum} and the owner is {CarIdInfo.Owner}.");

        public Car(int hP, string color)
        {
            HP = hP;
            Color = color;
        }
        public void ShowDetails() => Console.WriteLine($"The car has {HP} hp and is {Color}.");
        public virtual void Repair() => Console.WriteLine("The car was repaired.");
    }
}
