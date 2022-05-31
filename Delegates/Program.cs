using System;
using static Delegates.Geeks;

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

            // another delegate example
            Message m; // creating an instance of the delegate
            m = PrintMessage; // assigning the method to the delegate's instance 
            // could be done in one line: Message m = PrintMessage;
            m(); // calling (invoking) the delegate, same as mes1.Invoke();
        }
        // another delegate example
        public delegate void Message(); // creating a delegate (rather a delegate type?)
        public static void PrintMessage() => Console.WriteLine("Printing a message."); // a method with the same signature and return type as the delegate
               
    }
}
