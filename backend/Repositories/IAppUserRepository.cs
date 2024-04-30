using backend.Domain;

namespace backend.Repositories
{
    public interface IAppUserRepository
    {
        IQueryable<AppUser> List();
    }
}
