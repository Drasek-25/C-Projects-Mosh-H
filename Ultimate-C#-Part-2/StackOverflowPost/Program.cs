using System;

namespace StackOverflowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var post1 = new Post("Test Post Please Ignore", "This is just a Test Post");
            post1.Upvote();
            post1.Upvote();
            post1.Upvote();
            post1.Upvote();
            post1.Upvote();
            post1.Downvote();
            post1.Downvote();
            Console.WriteLine(post1.Title);
            Console.WriteLine(post1.Description);
        }
    }
}
