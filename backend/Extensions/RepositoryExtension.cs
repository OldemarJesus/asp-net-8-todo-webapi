using backend.Domain;
using backend.Repositories;

namespace backend.Extensions
{
    public static class RepositoryExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IRepository<Note>, NoteRepository>();
            return services;
        }
    }
}
