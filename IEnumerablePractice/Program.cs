using System;
using System.Collections.Generic;

namespace IEnumerablePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // phone book contacts challenge
            Phonebook myPhoneBook = new Phonebook();
            foreach (Contact c in myPhoneBook)
            {
                c.Call();
            }
            
            //IEnumerable<int> unknownCollection; // unknownCollection is of IEnumerable type and so can accept any List type, e.g. List, Queue, Array
            //unknownCollection = GetCollection(1);
            //Console.WriteLine(unknownCollection.GetType());
            //foreach (int i in unknownCollection)
            //    Console.Write(i + " ");
            //Console.WriteLine();
            //unknownCollection = GetCollection(2);
            //Console.WriteLine(unknownCollection.GetType());
            //foreach (int i in unknownCollection)
            //    Console.Write(i + " ");
            //Console.WriteLine();
            //unknownCollection = GetCollection(0);
            //Console.WriteLine(unknownCollection.GetType());
            //foreach (int i in unknownCollection)
            //    Console.Write(i + " ");
            //Console.WriteLine();

            //CollectionSum(GetCollection(1));
            //CollectionSum(GetCollection(2));
            //CollectionSum(GetCollection(0));

        }
        static IEnumerable<int> GetCollection(int option)
        {
            // create a list and initialize it
            List<int> numbersList = new List<int> { 1, 2, 3, 4, 5 };

            // create a queue and add numbers to it
            Queue<int> numbersQueue = new Queue<int>();
            numbersQueue.Enqueue(6);
            numbersQueue.Enqueue(7);
            numbersQueue.Enqueue(8);
            numbersQueue.Enqueue(9);
            numbersQueue.Enqueue(10);

            // create an array
            int[] numbersArray = new int[] { 11, 12, 13, 14, 15 };

            if (option == 1)
                return numbersList;
            else if (option == 2)
                return numbersQueue;
            else
                return numbersArray;            
        }

        static void CollectionSum(IEnumerable<int> anyCollection)
        {
            // sum variable stores sum of numbers in any collection
            int sum = 0;
            foreach (int num in anyCollection)
            {
                sum += num;
            }
            Console.WriteLine("Sum is {0}", sum);
        }
    }
}
