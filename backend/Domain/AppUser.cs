using Microsoft.AspNetCore.Identity;

namespace backend.Domain
{
    public class AppUser : IdentityUser
    {
        public IList<Note> Notes { get; private set; } = new List<Note>();
     }
}
