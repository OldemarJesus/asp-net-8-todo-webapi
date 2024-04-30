using backend.Context;
using backend.Domain;

namespace backend.Repositories
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly ApplicationDbContext _context;

        public AppUserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        IQueryable<AppUser> IAppUserRepository.List()
        {
            List<AppUser> appUsers = _context.Users.ToList();
            return appUsers.AsQueryable();
        }
    }
}
