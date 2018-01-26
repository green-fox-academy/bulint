using RedditMan.Models;
using RedditMan.Repositories;
using System.Collections.Generic;

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

        public Post Add(Post post)
        {
            return postRepository.Add(post);
        }
    }
}
