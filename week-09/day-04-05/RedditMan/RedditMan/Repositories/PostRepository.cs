using RedditMan.Entities;
using RedditMan.Models;
using System.Collections.Generic;
using System.Linq;

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

        public Post Add(Post post)
        {
            postContext.Reddit.Add(post);
            postContext.SaveChanges();
            return post;
        }
    }
}
