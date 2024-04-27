using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/notes")]
    public class NoteController : ControllerBase
    {
        [HttpGet()]
        public IActionResult GetNote()
        {
            return Ok("nothing");
        }
    }
}
