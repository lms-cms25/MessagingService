namespace MessagingService.Api.Endpoints;

public static class MessagingEndpoints
{
    public static void MapMessagingEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/api/messaging")
            .WithTags("Messaging")
            .WithDescription("Handles real-time and persistent communication for live classes and users");
    }
}
