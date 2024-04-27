using Microsoft.AspNetCore.Identity;

namespace backend.Domain
{
    public class AppUser : IdentityUser
    {
        public IEnumerable<Note>? Notes { get; set; }
    }
}
