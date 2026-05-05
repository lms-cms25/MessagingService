namespace MessagingService.Api.Security;

public static class CorsConfiguration
{
    public static IServiceCollection AddCorsConfiguration(this IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddPolicy("All", policy =>
            {
                policy
                    .WithOrigins("http://127.0.0.1:5500", "http://localhost:3000")
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials();
            });
        });


        return services;
    }
}
