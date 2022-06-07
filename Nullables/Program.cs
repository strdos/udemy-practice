using System;

namespace Nullables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ways to declare and assign nullables
            int? num1 = null;
            int? num2 = 1337;
            double? num3 = new double?();
            double? num4 = 3.1415;
            bool? boolVal = new bool?();

            Console.WriteLine("Our nullable data is: {0}, {1}, {2}, {3}, and {4}", num1, num2, num3, num4, boolVal);

            double? num5 = null;
            double num6 = 4.1245;
            double num7 = num5 ?? num6; // ?? null coalescing operator checks if a value to the left is null
            Console.WriteLine(num7);
        }
    }
}
