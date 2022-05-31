using System;

namespace InheritanceChallenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee("Baker", "Adam", 55000);
            Boss b = new Boss("Smith", "David", 150000, true);
            Trainee t = new Trainee("Miller", "Edgar", 25000, "4 pm to 8 pm", "9 am to 3 pm");

            t.Work();
            b.Lead();
        }
    }
}
