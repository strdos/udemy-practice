using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Human
    {
        public string firstName;
        public string lastName;
        public string eyeColor;
        public int age;

        public void IntroduceMyself()
        {
            if (age != 0 && eyeColor != null && lastName != null && firstName != null)
                Console.WriteLine($"Hello, I am {firstName} {lastName}, {age} years old, and I have {eyeColor} eyes.");
            else if (eyeColor != null && lastName != null && firstName != null)
                Console.WriteLine($"Hello, I am {firstName} {lastName}, and I have {eyeColor} eyes.");
            else if (lastName != null && firstName != null)
                Console.WriteLine($"Hello, I am {firstName} {lastName}.");
            else
                Console.WriteLine($"Hello, I am a human created by the default constructor.");
        }

        public Human()
        {

        }

        public Human(string firstName, string lastName)
        {
            this.firstName =firstName;
            this.lastName = lastName;
        }

        public Human (string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

     }
}
