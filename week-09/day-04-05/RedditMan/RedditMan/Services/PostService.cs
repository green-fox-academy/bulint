using RedditMan.Models;
using RedditMan.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditMan.Services
{
    public class PostService
    {
        private PostRepository postRepository;

        public PostService(PostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

        public List<Post> GetList()
        {
            return postRepository.GetList();
        }
    }
}
