using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditMan.Models
{
    public class Post
    {
        public long? Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public long? TimeStamp { get; set; }
        public long? Score { get; set; }
    }
}
