using System;

namespace InheritanceChallenge2
{
    internal class Employee
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }

        public Employee(string name, string firstName, int salary)
        {
            Name = name;
            FirstName = firstName;
            Salary = salary;
        }
        public virtual void Work() => Console.WriteLine("I am working.");
        public virtual void Pause() => Console.WriteLine("I am resting.");
    }
}
