using HPCProjectTemplate.Shared;
using Microsoft.AspNetCore.Mvc;

namespace HPCProjectTemplate.Server.Controllers
{
    public class AIController : Controller
    {
        private readonly OpenAIService _ai;

        public AIController(OpenAIService ai)
        {
            _ai = ai;
        }

        [HttpPost("api/ai")]
        public async Task<ActionResult> GetDetails([FromBody] List<Message> conv)
        {
            
            var assistantResponse = await _ai.CreateChatCompletion(conv);

            return Ok(assistantResponse);
        }
    }
}
