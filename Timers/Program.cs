using System;
using System.Timers;

namespace Timers
{
    // https://docs.microsoft.com/en-us/dotnet/standard/threading/timers
    // https://docs.microsoft.com/en-us/dotnet/api/system.timers.timer?view=net-6.0
    // https://docs.microsoft.com/en-us/dotnet/api/system.threading.timercallback?view=net-6.0
    internal class Program
    {
        private static Timer aTimer;
        static void Main(string[] args)
        {
            SetTimer();

            Console.WriteLine("\nPress the Enter key to exit the application...\n");
            Console.WriteLine("The application started at {0:HH:mm:ss.fff}", DateTime.Now);
            Console.ReadLine();
            aTimer.Stop();
            aTimer.Dispose();

            Console.WriteLine("Terminating the application...");
        }
        private static void SetTimer()
        {
            // create a new timer with 2 sec interval
            aTimer = new Timer(2000);
            // hook up Elapsed event for the timer
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}", e.SignalTime);
        }
    }
}
