using System;

namespace IEnumerablePractice
{
    internal class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public Contact(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }
        public void Call() => Console.WriteLine($"Calling {Name}. Phone number is {PhoneNumber}.");
    }
}
