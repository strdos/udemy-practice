using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class AverageScore
    {
//calculates the average score of his students. So he wants to be able to enter each score individually and then get the final average score once he enters -1.
//So the tool should check if the entry is a number and should add that to the sum.Finally once he is done entering scores, the program should write onto the console
//what the average score is.
//The numbers entered should only be between 0 and 20. Make sure the program doesn't crash if the teacher enters an incorrect value.

        static double averageScore = 0;
        static int totalScore = 0;
        static int studentCount = 0;
        static string userInput = string.Empty;
        static int userInputAsNum = 0;

        public static void AverageScoreImproved()
        {
            while (userInput != "-1")
            {
                Console.WriteLine("Last number was {0}", userInputAsNum);
                Console.WriteLine("Total student count is {0}", studentCount);
                Console.WriteLine("Please enter the next score.");
                Console.WriteLine("Please enter '-1' to see the average score.");

                userInput = Console.ReadLine();

                if (userInput == "-1")
                {
                    averageScore = (double) totalScore / (double) studentCount;
                    Console.WriteLine("The average score is {0}", averageScore);
                }
                if (int.TryParse(userInput, out userInputAsNum) && userInputAsNum > 0 && userInputAsNum <21)
                {
                    totalScore += userInputAsNum;
                    studentCount++;
                }
                else
                {
                    if (userInput != "-1")
                    {
                        Console.WriteLine("Please enter a number between 1 and 20.");
                    }
                    continue;
                }
            }
        }
        
        public static void AverageScoreMethod()
        {
            Console.WriteLine("Please enter your students' scores (between 0 and 20) one by one.");
            Console.WriteLine("When done, please enter '-1'");

            while (true) 
            {
                userInput = Console.ReadLine();
                if (!int.TryParse(userInput, out userInputAsNum))
                {
                    Console.WriteLine("Wrong format. Please restart the program.");
                    break;
                }
                if (userInputAsNum < -1 || userInputAsNum > 20)
                {
                    Console.WriteLine("Number out of range. Please restart the program.");
                    break;
                }
                if (userInputAsNum == -1)
                {
                    averageScore = (double)totalScore / (double)studentCount;
                    Console.WriteLine($"The average score is {averageScore}");
                    Console.WriteLine($"total score:  {totalScore}");
                    Console.WriteLine($"total student count:  {studentCount}");
                    break;
                }

                    totalScore += userInputAsNum;
                    studentCount++;
            }
        }
        
        


    }
}
