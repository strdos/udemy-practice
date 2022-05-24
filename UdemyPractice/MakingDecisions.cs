using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyPractice
{
    internal class MakingDecisions
    {
        static int highScore = 0;
        static string highScorePlayer = "Robot";

        public static void TemperatureCheck()
        {
            int temperatureAsInt;
            string weatherMessage;
            Console.WriteLine("Please enter a temperature: ");
            string temperature = Console.ReadLine();
            if (int.TryParse(temperature, out temperatureAsInt))
            {
                weatherMessage = temperatureAsInt <= 15 ? "It is too cold here." : temperatureAsInt <= 28 ? "It is ok." : "It is hot here.";
                Console.WriteLine(weatherMessage);
            }
            else
            {
                Console.WriteLine("Not a valid temperature. Please restart the program.");
            }
        }
        public static void CheckHighScore()
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your score: ");
            string score = Console.ReadLine();
            int scoreAsNumber = 0;
            if (int.TryParse(score, out scoreAsNumber))
            {
                if (scoreAsNumber > highScore)
                {
                    highScore = scoreAsNumber;
                    highScorePlayer = name;
                    Console.WriteLine($"Congratulations! The new high score is {highScore} by {name}.");
                }
                else
                {
                    Console.WriteLine("The high score has not been beaten. Good luck next time.");
                }
            }
            else
            {
                Console.WriteLine("Wrong format. Please restart the program.");
            }
            
        }
        public static void UserLogin()
        {
            // checks if the user has entered correct username and password

            Console.WriteLine("Welcome to the registration page.\nPlease create your username: ");
            string userRegistrationName = Console.ReadLine();
            Console.WriteLine("Please create your password: ");
            string userRegistrationPassword = Console.ReadLine();
            Console.WriteLine("You have successfully registered.");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Please enter your username to log in: ");
            string userLoginName = Console.ReadLine();
            if (userLoginName == userRegistrationName)
            {
                Console.WriteLine("Please enter your password to log in: ");
                string userLoginPassword = Console.ReadLine();
                if (userLoginPassword == userRegistrationPassword)
                {
                    Console.WriteLine("You have logged in successfully.");
                }
                else
                {
                    Console.WriteLine("The password you have entered is incorrect.");
                }
            }
            else
            {
                Console.WriteLine("The username you have entered is incorrect.");
            }
        }
        public static void DivisibleByThreeOrSeven(int number)
        {
            // calculates if a number is divisible by 3 or 7

            if (number % 3 == 0)
            {
                Console.WriteLine("Divisible by 3.");
            }
            else if (number % 7 == 0)
            {
                Console.WriteLine("Divisible by 7.");
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine("Even number.");
            }
            else
            {
                Console.WriteLine("Odd number.");
            }
        }
        public static void WhatIsTheWeather()
        {
            Console.WriteLine("How many degrees is it outside?");
            string degrees = Console.ReadLine();
            int degreesAsInt = 0;
            bool success = int.TryParse(degrees, out degreesAsInt);

            if (success)
            {
                if (degreesAsInt > 20)
                {
                    Console.WriteLine("Nice!");
                }
                else if (degreesAsInt == 20)
                {
                    Console.WriteLine("My favorite temperature!");
                }
                else
                {
                    Console.WriteLine("A little chilly!");
                }
            }

            else
            {
                Console.WriteLine("Wrong format. Please enter a number.");
            }
        }

       
    }
}
