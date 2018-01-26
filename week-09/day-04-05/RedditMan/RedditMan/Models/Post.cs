using System;

namespace RedditMan.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;
        public int Score { get; set; }
    }
}
