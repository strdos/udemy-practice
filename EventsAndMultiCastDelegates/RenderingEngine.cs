using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndMultiCastDelegates
{
    internal class RenderingEngine
    {
        public RenderingEngine()
        {
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }
        private void StartGame()
        {
            Console.WriteLine("Rendering engine started");
            Console.WriteLine("Drawing visuals...");
        }
        private void GameOver()
        {
            Console.WriteLine("Rendering engine stopped");
        }
    }
}
