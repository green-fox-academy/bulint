using RedditMan.Entities;
using RedditMan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditMan.Repositories
{
    public class PostRepository
    {
        private PostContext postContext;

        public PostRepository(PostContext postContext)
        {
            this.postContext = postContext;
        }

        public List<Post> GetList()
        {
            return postContext.Reddit.ToList();
        }
        
        public void Add(Post post)
        {
            postContext.Reddit.Add(post);
            postContext.SaveChanges();
        }
    }
}
