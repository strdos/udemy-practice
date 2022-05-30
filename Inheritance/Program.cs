using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("post 1", "Adam", true);
            Console.WriteLine(post1.ToString());
            ImagePost imagePost1 = new ImagePost("image post 1", "Baker", true, "http://www.example.org/imagepost1.png");
            Console.WriteLine(imagePost1.ToString());
            VideoPost videoPost1 = new VideoPost("video post 1", "Charles", true, "https://www.example.org/videopost1.mkv", 5);
            Console.WriteLine(videoPost1.ToString());
            videoPost1.Play();
            Console.WriteLine("Please press any key to stop the video.");
            Console.ReadKey();
            videoPost1.Stop();
            
            //Dog myDog = new Dog("Bobby", 12);
            //Console.WriteLine($"{myDog.Name} is {myDog.Age} years old.");
            //myDog.MakeSound();
            //myDog.Play();
            //myDog.Eat();
            
            //Radio myRadio = new Radio(true, "Bluetrend");
            //TV myTV = new TV(false, "Panasonic");
            //myRadio.ListenToRadio();
            //myTV.WatchTV();
            //myTV.TurnOn();
            //myTV.WatchTV();
        }
    }
}
