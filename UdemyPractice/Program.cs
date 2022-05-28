using System;

namespace UdemyPractice
{
    internal class Program
    {
        public static string[] names = new string[] { "Alexey", "Yana", "Arina", "Steven", "Eva", "Anna", "Liza", "Michael", "Maya" };      
        public static int numberOfFriends = 5;

        static void Main(string[] args)
        {
            // Challenge - find 3 shortest names in an array            
            if (names == null)
                throw new ArgumentNullException("names", "Array 'Names' cannot be null.");
            if (numberOfFriends > names.Length || numberOfFriends < 1)
                throw new ArgumentOutOfRangeException("numberOfFriends", "Number of Friends cannot exceed number of names in the array and cannot be less than one.");

            ShortestNamesChallenge.SortArray(names);
            ShortestNamesChallenge.PrintShortestNames(numberOfFriends);   

            //MakingDecisions.TemperatureCheck();
            #region ternary operator
            //// ternary operator
            //string stateOfMatter;
            //int temperature = 101;
            //stateOfMatter = temperature > 100 ? "gas" : temperature > 0 ? "liquid" : "solid";
            //Console.WriteLine(stateOfMatter);
            #endregion

            //MakingDecisions.CheckHighScore();
            //MakingDecisions.UserLogin();
            //MakingDecisions.DivisibleByThreeOrSeven(215);
            //MakingDecisions.WhatIsTheWeather();
            //Methods.Multiply();
        }
    }
}
