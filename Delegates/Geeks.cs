using System;

namespace Delegates
{
    internal class Geeks
    {
        public delegate void addnum(int a, int b);
        public delegate void subnum(int a, int b);

        public void add(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
        public void subtract(int a, int b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }
    }
}
