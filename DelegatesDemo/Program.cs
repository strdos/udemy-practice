using System;
using System.Collections.Generic;

namespace DelegatesDemo
{
    internal class Program
    {
        // declaring a delegate that takes a Person object and returns a bool
        public delegate bool FilterDelegate(Person p);
        static void Main(string[] args)
        {
            Person p1 = new Person("Adam", 15);
            Person p2 = new Person("Baker", 25);
            Person p3 = new Person("Charles", 35);
            Person p4 = new Person("David", 45);

            List<Person> people = new List<Person>() { p1, p2, p3, p4 };

            DisplayPeople("A list of minors: ", people, IsMinor);
            DisplayPeople("A list of adults: ", people, IsAdult);

            // creating a variable filter of FilterDelegate type and assigning an anonymous method to it
            FilterDelegate filter = delegate (Person p)
            {
                return p.Age < 20;
            };
            DisplayPeople("Under 20", people, filter);

            // another example of anonymous method, this time it is passed as a parameter
            DisplayPeople("Under 20", people, delegate (Person p) { return p.Age < 20; });

            // using lambda expression
            string searchKeyword = "r";
            DisplayPeople("Names with " + searchKeyword, people, p => 
            {
                if (p.Name.Contains(searchKeyword))
                    return true;
                else 
                    return false;
            }     
            );

            // same but in one line
            DisplayPeople("Names with " + searchKeyword, people, p => p.Name.Contains(searchKeyword) ? true : false);


            //    // example 
            //    List<string> names = new List<string>() { "Adam", "Baker", "Charles", "David" };

            //    // before
            //    foreach (string name in names)
            //    {
            //        Console.WriteLine(name);
            //    }

            //    names.RemoveAll(Filter);

            //    // after
            //    foreach (string name in names)
            //    {
            //        Console.WriteLine(name);
            //    }
            //}

            //static bool Filter(string s)
            //{
            //    return s.Contains("i");
            //}
        }

        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(title);
            foreach (Person p in people)
            {
                if (filter(p))
                {
                    Console.WriteLine($"{p.Name}, {p.Age} years old.");
                }                
            }
        }

        // filters (methods which can be called by the delegate)
        static bool IsMinor(Person p)
        {
            return p.Age < 18;
        }
        static bool IsAdult(Person p)
        {
            return p.Age >= 18;
        }

    }
}
