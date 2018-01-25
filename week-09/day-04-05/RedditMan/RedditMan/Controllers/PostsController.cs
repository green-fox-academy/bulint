using Microsoft.AspNetCore.Mvc;
using RedditMan.Models;
using RedditMan.Repositories;
using RedditMan.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditMan.Controllers
{
    [Route("")]
    public class PostsController : Controller
    {
        private PostRepository postRepo;

        public PostsController(PostRepository postRepo)
        {
            this.postRepo = postRepo;
        }

        [HttpGet("posts")]
        public IActionResult ListPosts()
        {
            return Json(new { posts = postRepo.GetList() });
        }
    }
}
