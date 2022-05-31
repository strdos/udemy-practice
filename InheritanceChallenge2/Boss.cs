using System;

namespace InheritanceChallenge2
{
    internal class Boss : Employee
    {
        public bool CompanyCar { get; set; }
        public Boss(string name, string firstName, int salary, bool companyCar) : base(name, firstName, salary)
            {
            //Name = name;
            //FirstName = firstName;
            //Salary = salary;
            CompanyCar = companyCar;
        }
        public void Lead() => Console.WriteLine("I am leading");
    }
}
