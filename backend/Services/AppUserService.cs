using backend.Domain;
using backend.Repositories;

namespace backend.Services
{
    public class AppUserService : IAppUserService
    {
        private readonly IAppUserRepository _repository;

        public AppUserService(IAppUserRepository repository)
        {
            _repository = repository;
        }

        AppUser? IAppUserService.GetAppUserByUsername(string username)
        {
            AppUser? appUser = _repository.List().Where(user => user.UserName == username).FirstOrDefault();
            return appUser;
        }
    }
}
