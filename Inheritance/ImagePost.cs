using System;

namespace Inheritance
{
    internal class ImagePost : Post
    {
        public string ImageURL { get; set; }
        public ImagePost() { }
        // base class constructor is called implicitly
        public ImagePost(string title, string sentByUser, bool isPublic, string imageURL)
        {
            Id = GetNextId();
            Title = title;
            SentByUser = sentByUser;
            IsPublic = isPublic;
            ImageURL = imageURL;
        }
        public override string ToString()
        {
            return String.Format($"{Id} - {Title} - by {SentByUser} - {ImageURL}");
        }
    }

}
