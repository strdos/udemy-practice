﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9};
            OddNumbers(numbers);
        }
        static void OddNumbers(int[] numbers)
        {
            IEnumerable<int> oddNumbers = from number in numbers where number % 2 != 0 select number;
            Console.WriteLine("The odd numbers are: ");
            //Console.WriteLine(oddNumbers);
            foreach (int number in oddNumbers)
            {
                Console.Write(number + " ");
            }
                
        }
    }
}
