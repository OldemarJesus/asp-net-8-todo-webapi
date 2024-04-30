using backend.Domain;

namespace backend.Services
{
    public interface IAppUserService
    {
        AppUser? GetAppUserByUsername(string username);
    }
}
