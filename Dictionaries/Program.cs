using System;
using System.Collections.Generic;

namespace Dictionaries
{
    internal class Program
    {
        public static Dictionary<int, string> myDictionary = new Dictionary<int, string>()
        {
            {0, "zero" },
            {1, "one" },
            {2, "two" },
            {3, "three" },
            {4, "four" },
            {5, "five" }
        };

        public static string SpellOutNumber(int i)
        {
            string result = "nope";
            if (myDictionary.ContainsKey(i))
            {
                result = myDictionary[i];
            }
            Console.WriteLine(result);
            return result;
            

        }
        static void Main(string[] args)
        {
            SpellOutNumber(3);
            SpellOutNumber(10);
            SpellOutNumber(5);
        }
    }
}
