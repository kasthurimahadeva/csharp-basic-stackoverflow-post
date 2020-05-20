using System;

namespace StackOverFlowPost
{
    public class Post
    {
        public string Title { get; }
        private string _description;
        private DateTime _createdTime;
        public int CurrentVote { get; private set; }


        public Post(string title, string description)
        {
            Title = title;
            _description = description;
            _createdTime = DateTime.Now;
            CurrentVote = 0;
        }
        public void UpVote()
        {
            CurrentVote += 1;
            Console.WriteLine("Successfully up-voted");
        }

        public void DownVote()
        {
            CurrentVote -= 1;
            Console.WriteLine("Successfully down-voted");
        }
    }
}