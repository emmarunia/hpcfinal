using HPCProjectTemplate.Server.Data;
using HPCProjectTemplate.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace HPCProjectTemplate.Server.Controllers
{
    public class DiscussionController : Controller
    {
        private readonly ApplicationDbContext _context;
        public DiscussionController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("api/add-post")]
        public async Task AddPost([FromBody] Posts Post)
        {
    
            _context.Posts.Add(Post);
            
            var res = _context.SaveChanges();
            int temp = 1;
        }

        [HttpPost("api/reply")]
        public async Task AddReply([FromBody] Replies Rep)
        {
            _context.Replies.Add(Rep);
            _context.SaveChanges();
        }

        [HttpPost("api/add-reply-to-post")]
        public async Task AddReplyToPost([FromBody] Replies rep)
        {
            var post = await (from p in  _context.Posts
                              where p.Id == rep.PostId
                              select p).FirstOrDefaultAsync();
            //Replies replies = new Replies { TopicId = rep.PostId };

            post.Replies.Add(rep);
            _context.SaveChanges();

            //return Ok(replies);
        }

        //sets content on discussion board home page
        [HttpGet("api/topics")]
        public async Task<ActionResult<TopicList>> AllTopics()
        {
            var board = _context.Topics
                .Select(board => new Topics
                {
                    Id = board.Id,
                    Title = board.Title,
                    Description = board.Description
                });

            var topicList = new TopicList()
            {
                ListOfTopics = board
            };

            return Ok(topicList);
        }

        [HttpGet("api/get-posts")]
        public async Task<ActionResult<PostsList>> GetPosts()
        {

            var posts = _context.Posts
                .Select(posts => new Posts
                {
                    Id = posts.Id,
                    ImageUrl = posts.ImageUrl,
                    Title = posts.Title,
                    Content = posts.Content,
                    Created = posts.Created,
                    TopicId = posts.TopicId,
                    UserName = posts.UserName
                });

            var postList = new PostsList()
            {
                ListOfPosts = posts
            };

            return Ok(postList);
        }  
    }
}
