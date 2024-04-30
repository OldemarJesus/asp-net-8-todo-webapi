using backend.Contracts.Request;
using backend.Domain;
using backend.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/notes")]
    [Authorize]
    public class NoteController : ControllerBase
    {
        private readonly INoteService _noteService;
        private readonly IAppUserService _appUserService;

        public NoteController(INoteService noteService, IAppUserService appUserService)
        {
            _noteService = noteService;
            _appUserService = appUserService;
        }

        [HttpGet()]
        public IActionResult GetNotes()
        {
            return Ok(_noteService.GetAllNotes());
        }

        [HttpPost()]
        public IActionResult AddNote([FromBody] NoteRequest request)
        {
            System.Security.Principal.IIdentity? authUserIdentity = HttpContext.User.Identity;

            if (authUserIdentity == null)
            {
                return BadRequest("Invalid authenticated user");
            }

            string? authUserIdentifier = authUserIdentity.Name;

            if (authUserIdentifier == null)
            {
                return BadRequest("Invalid authenticated user");
            }

            AppUser? appUser = _appUserService.GetAppUserByUsername(authUserIdentifier);

            if (appUser == null)
            {
                return BadRequest("Invalid authenticated user");
            }

            Note newNote = new Note(request.title,
                                    request.description,
                                    appUser);

            bool result = _noteService.AddNote(newNote);

            if (result)
            {
                return Ok();
            }

            return BadRequest("Could not store the note");
        }
    }
}
