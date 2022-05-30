using System;
using System.Threading;

namespace Inheritance
{
    internal class VideoPost : Post
    {
        // fields
        protected bool isPlaying = false;
        protected double currentPosition = 0;
        Timer timer;
        
        // properties
        protected string VideoURL { get; set; }
        protected double VideoLength { get; set; }
        public VideoPost() { }
        public VideoPost(string title, string sentByUser, bool isPublic, string videoURL, double videoLength)
        {
            Id = GetNextId();
            Title = title;
            SentByUser = sentByUser;
            IsPublic = isPublic;
            VideoURL = videoURL;
            VideoLength = videoLength;
        }
        public override string ToString()
        {
            return String.Format($"{Id} - {Title} - by {SentByUser} - duration {VideoLength} sec. - {VideoURL}");
        }
        private void TimerCallback(object o)
        {
            if (currentPosition < VideoLength)
            {
                currentPosition++;
                Console.WriteLine($"Video at {currentPosition} sec.");
                GC.Collect();
            }
            else
                Stop();
        }
        public void Play()
        {
            if(!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing the video.");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }
        public void Stop()
        {
            if(isPlaying)
            {
                isPlaying=false;
                Console.WriteLine($"Video stopped at {currentPosition} sec.");
                currentPosition = 0;
                timer.Dispose();
            }
        }
    }
}
