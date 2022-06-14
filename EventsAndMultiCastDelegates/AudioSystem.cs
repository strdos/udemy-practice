using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndMultiCastDelegates
{
    internal class AudioSystem
    {
        public AudioSystem()
        {
            // subscribing to OnGameStart and OnGameOver events
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }
        private void StartGame()
        {
            Console.WriteLine("Audio system started.");
            Console.WriteLine("Playing audio...");
        }
        private void GameOver()
        {
            Console.WriteLine("Audio system stopped.");
        }
    }
}
