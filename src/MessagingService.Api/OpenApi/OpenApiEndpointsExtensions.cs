using Scalar.AspNetCore;

namespace MessagingService.Api.OpenApi;

public static class OpenApiEndpointsExtensions
{
    public static WebApplication MapOpenApiEndpoints(this WebApplication app)
    {
        app.MapOpenApi();

        app.MapScalarApiReference("/docs", options =>
        {
            options.WithTitle("Documentation for Messaging Service");
            options.DefaultHttpClient = new(ScalarTarget.JavaScript, ScalarClient.Fetch);
        });

        return app;
    }
}
