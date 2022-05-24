using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class DataTypeChallenge
    {
        public static void CheckDataType()
        {

            Console.WriteLine("Please enter any input: ");
            string userInput = Console.ReadLine();
            Console.WriteLine("What data type was that?\n Press 1 for string\n Press 2 for int\n Press 3 for bool");
            string userType = Console.ReadLine();

            switch (userType)
            {
                case "1":
                    //if (userInput.GetType() == typeof(string))
                    if (IsAllAlphabetic(userInput))
                    {
                        Console.WriteLine($"You have entered the following data: {userInput}");
                        Console.WriteLine($"The type is valid: String");
                    }
                    else
                    {
                        Console.WriteLine($"You have entered the following data: {userInput}");
                        Console.WriteLine($"The type is not all alphabetic as it contains characters other than Unicode letters.");
                    }
                    break;
                case "2":
                    if (int.TryParse(userInput, out int userTypeAsNum))
                    {
                        Console.WriteLine($"You have entered the following data: {userInput}");
                        Console.WriteLine($"The type is valid: Integer");
                    }
                    else
                    {
                        Console.WriteLine($"You have entered the following data: {userInput}");
                        Console.WriteLine($"The type is not Integer.");
                    }
                    break;

                case "3":
                    if (bool.TryParse(userInput, out bool userTypeAsBool))
                    {
                        Console.WriteLine($"You have entered the following data: {userInput}");
                        Console.WriteLine($"The type is valid: Boolean");
                    }
                    else
                    {
                        Console.WriteLine($"You have entered the following data: {userInput}");
                        Console.WriteLine($"The type is not Boolean.");
                    }
                    break;

                default:
                    Console.WriteLine("Wrong format. Please press 1 to restart the program or any other key to quit the program.");
                    string userAnswer = Console.ReadLine();
                    if (userAnswer == "1")
                    {
                        CheckDataType();
                    }
                    break;                       
                                   
            }
            
        }
        public static bool IsAllAlphabetic(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c))
                    return false;
            }
                return true; 
            
        }
    }
}
