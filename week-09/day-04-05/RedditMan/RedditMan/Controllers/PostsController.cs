using Microsoft.AspNetCore.Mvc;
using RedditMan.Models;
using RedditMan.Services;

namespace RedditMan.Controllers
{
    [Route("")]
    public class PostsController : Controller
    {
        private PostService postService;

        public PostsController(PostService postService)
        {
            this.postService = postService;
        }

        [HttpGet("posts")]
        public IActionResult ListPosts()
        {
            return Json(new { posts = postService.GetList() });
        }

        [HttpPost("posts")]
        public IActionResult AddPosts([FromBody]Post post)
        {
            var postJson = postService.Add(post);
            return Json(new
            {
                id = postJson.Id,
                title = postJson.Title,
                url = postJson.Url,
                timeStamp = postJson.TimeStamp,
                score = postJson.Score
            });
        }
    }
}
