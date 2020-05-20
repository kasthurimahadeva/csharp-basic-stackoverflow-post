using System;

namespace StackOverFlowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Welcome to Panda-Karady StackOverFlow ***");
            Console.WriteLine("Enter your post title");
            var title = Console.ReadLine();
            Console.WriteLine("Enter your post description");
            var description = Console.ReadLine();
            var post = new Post(title, description);
            Console.WriteLine("Press 1 - up-vote, 2 - down-vote, 0 - exit");
            while (true)
            {
                var userInput = Console.ReadLine();
                var isNumeric = int.TryParse(userInput, out var value);
                if (isNumeric)
                {
                    if (value == 1)
                    {
                        post.UpVote();
                    } else if (value == 2)
                    {
                        post.DownVote();
                    } else if (value == 0)
                    {
                        Console.WriteLine($"CurrentVote for your {post.Title} post is {post.CurrentVote}");
                        Console.WriteLine("**********************");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not valid input. Try again...");
                    }
                }
                else
                {
                    Console.WriteLine("Not valid input. Try again...");
                }
            }
        }
    }
}