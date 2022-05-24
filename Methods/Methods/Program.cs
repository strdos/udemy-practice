using System;

namespace Methods
{
    internal class Program
    {
        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        
        public static void GreetFriend (string name)
        {
            Console.WriteLine($"Hi {name}, my friend!");
        }
        
        static void Main(string[] args)
        {
            //Console.WriteLine(Multiply(5.23, 3.18));
            GreetFriend("David");
            GreetFriend("Angela");
            GreetFriend("John");
        }
    }

    // overflow exception

    //public static double Multiply(double num1, double num2)
    //{
    //    return Multiply(num1, num2);
    //}
}
