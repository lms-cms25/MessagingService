using Microsoft.AspNetCore.OpenApi;
using Microsoft.OpenApi;

namespace MessagingService.Api.OpenApi;

public class OpenApiDocumentTransformer : IOpenApiDocumentTransformer
{
    public Task TransformAsync(OpenApiDocument document, OpenApiDocumentTransformerContext context, CancellationToken cancellationToken)
    {
        document.Components ??= new OpenApiComponents();

        document.Info.Description = """
            ## Messaging Service API

            Welcome to the heart of the LMS communication engine. This service powers real-time interactions, 
            bridging the gap between educators and students through:

            *   **Live Class Engagement:** Dynamic question flagging and upvoting.
            *   **Persistent Knowledge:** Archiving classroom discussions for future study.
            *   **Scalable Messaging:** Built to handle everything from global lectures to private mentorship.

            *Status: In active development.*
            """;

        document.Info.Title = "LMS Messaging Service";
        document.Info.Version = "v1.0.0";
        document.Info.Contact = new OpenApiContact
        {
            Name = "Miguel Garay/Grupp 2",
        };

        return Task.CompletedTask;
    }
}
