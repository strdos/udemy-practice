using System;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static List<int> myList = new List<int>();
        public static List<int> EvenNumbers()
        {
            for (int i = 100; i < 171; i += 2)
            {
                myList.Add(i);
            }
            return myList;
        }
        static void Main(string[] args)
        {
            EvenNumbers();

            foreach (int number in myList)
            {
                Console.Write(number + " ");
            }
        }
    }
}
