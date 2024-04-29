using Microsoft.OpenApi.Models;

namespace backend.Extensions
{
    public static class PresentationExtension
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(options => {
                    options.SwaggerDoc("v1", new OpenApiInfo { Title = " ToDo", Version = "v1" });

                    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme(){
                            Name = "Authorization",
                            Type = SecuritySchemeType.ApiKey,
                            Scheme = "Bearer",
                            BearerFormat = "JWT",
                            In = ParameterLocation.Header,
                            Description = "JWT Authorization header using the Bearer scheme."
                            });

                    options.AddSecurityRequirement(new OpenApiSecurityRequirement
                            {
                                {
                                    new OpenApiSecurityScheme
                                    {
                                        Reference = new OpenApiReference
                                        {
                                            Type = ReferenceType.SecurityScheme,
                                            Id = "Bearer"
                                        }
                                    },
                                    new string[] {}
                                }
                            });
                    });

            // repos
            services.AddRepositories();
            // services
            services.AddServices();

            return services;
        }
    }
}
