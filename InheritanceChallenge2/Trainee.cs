using System;

namespace InheritanceChallenge2
{
    internal class Trainee : Employee
    {
        public string WorkHours { get; set; }
        public string SchoolHours { get; set; }
        public Trainee(string name, string firstName, int salary, string workHours, string schoolHours) : base(name, firstName, salary)
        {
            //Name = name;
            //FirstName = firstName;
            //Salary = salary;
            WorkHours = workHours;
            SchoolHours = schoolHours;
        }
        public override void Work() => Console.WriteLine($"My work hours are: {WorkHours}.");
    }
}
