using System;

namespace UdemyPractice
{
    internal class Program
    {

        

        static void Main(string[] args)
        {
            // Challenge - find 3 shortest names in an array
            string[] names = new string[] { "Adam", "Baker", "Charles", "David", "Edgar", "Fred", "Giovanni", "Yu", "John" };

            ShortestNamesChallenge.SortArray(names);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(names[i]);
            }


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
