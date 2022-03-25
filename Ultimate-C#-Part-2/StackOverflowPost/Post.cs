using System;
using System.Collections.Generic;
using System.Text;

namespace StackOverflowPost
{
    class Post
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime Created { get; private set; }
        public int Votes { get; private set; }

        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            this.Created = DateTime.Now;
            this.Votes = 0;
        }

        public void Upvote()
        {
            this.Votes++;
            Console.WriteLine("Current Votes: {0}", Votes);
        }
        public void Downvote()
        {
            this.Votes--;
            Console.WriteLine("Current Votes: {0}", Votes);
        }
    }
}
