using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndMultiCastDelegates
{
    internal class GameEventManager
    {
        // a new delegate type
        public delegate void GameEvent();

        // two variables of the created delegate type
        public static GameEvent OnGameStart, OnGameOver; 
        // more precise would be to use 'event' keyword (events can be called 'restricted' delegates)
        // public static event GameEvent OnGameStart, OnGameOver;

        // a static method to trigger OnGameStart
        public static void TriggerGameStart()
        {
            // checks if OnGameStart event is not empty, i.e. that other methods have already subscribed to it
            if (OnGameStart != null)
            {
                Console.WriteLine("The game has started.");
            }
            // calling this method will trigger all the methods that are subscribed to it
            OnGameStart();
        }
        public static void TriggerGameOver()
        {
            if (OnGameOver != null)
            {
                Console.WriteLine("The game is over.");
            }
            OnGameOver();
        }
    }
}
