using System;
using static Delegates.Geeks;
using static Delegates.Program;

namespace Delegates
{
    internal class Program
    {
        // https://www.geeksforgeeks.org/c-sharp-delegates/
        static void Main(string[] args)
        {
            Geeks geek = new Geeks();
            addnum del_geekAdd = new addnum(geek.add);
            subnum del_geekSub = new subnum(geek.subtract);
            del_geekAdd(100, 40);
            del_geekSub(100, 40);
        }
    }
}
