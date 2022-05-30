using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Post
    {
        public static int currentPostId;

        // properties
        protected int Id { get; set; }
        protected string Title { get; set; }
        protected string SentByUser { get; set; }
        protected bool IsPublic { get; set; }

        public Post()
        {
            Id = 0;
            Title = "Random post";
            SentByUser = "Unknown";
            IsPublic = true;
        }
        public Post(string title, string sentByUser, bool isPublic)
        {
            Id = GetNextId();
            Title = title;
            SentByUser = sentByUser;
            IsPublic = isPublic;
        }
        protected int GetNextId()
        {
            return ++currentPostId;
        }
        public void Update(string title, bool isPublic)
        {
            Title = title;
            IsPublic =isPublic;
        }
        // a method that overrides ToString method implicitly inherited from System.Object
        public override string ToString()
        {
            return String.Format($"{Id} - {Title} - by {SentByUser}");
        }
    }
}
