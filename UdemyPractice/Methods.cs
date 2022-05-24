using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyPractice
{
    internal class Methods
    {
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method.");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }

        public static void Multiply()
        {
            Console.WriteLine("Please enter the first number: ");
            string userInput1 = Console.ReadLine();

            Console.WriteLine("Please enter the second number: ");
            string userInput2 = Console.ReadLine();

            int num1;
            int num2;

            try
            {
                num1 = int.Parse(userInput1);
            }
            catch (Exception)
            {

                throw;
            }

            try
            {
                num2 = int.Parse(userInput2);
            }
            catch (Exception)
            {

                throw;
            }

            int result = num1 * num2;

            Console.WriteLine($"{num1} multiplied by {num2} equals {result}");
        }
    }
}
