using System;

namespace MainArgs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // a program where a user must enter 3 arguments in cmd
            
            if (args.Length != 3)
            {
                Console.WriteLine("Invalid input. Please input 'help for instructions.");
            }
            else if (args[0].ToLower() == "help")
            {
                Console.WriteLine("************************************************************");
                Console.WriteLine("Use one of the commands below followed by two numbers:");
                Console.WriteLine("'add' - to add two numbers");
                Console.WriteLine("'sub' - to subtract the second number from the first one");
                Console.WriteLine("************************************************************");
            }
            else
            {
                bool isNum1Parsed = float.TryParse(args[1], out float num1);
                bool isNum2Parsed = float.TryParse(args[2], out float num2);
                if (!isNum1Parsed || !isNum2Parsed)
                    {
                        Console.WriteLine("Error. Failed to read the numbers you entered.");
                        return;
                    }
                float result;
                switch(args[0].ToLower())
                {
                    case "add":
                        result = num1 + num2;
                        Console.WriteLine($"{num1} + {num2} = {result}");
                        break;
                    case "sub":
                        result = num1 - num2;
                        Console.WriteLine($"{num1} - {num2} = {result}");
                        break;
                    default:
                        Console.WriteLine("Error. Invalid command.");
                        break;
                }
            }
            
            //// basic args example
            //if (args.Length != 0)
            //    Console.WriteLine($"Hello, " + args[0] + "!");
        }
    }
}
