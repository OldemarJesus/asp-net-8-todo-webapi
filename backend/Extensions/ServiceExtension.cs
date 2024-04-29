using backend.Services;

namespace backend.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<INoteService, NoteService>();
            return services;
        }
    }
}
