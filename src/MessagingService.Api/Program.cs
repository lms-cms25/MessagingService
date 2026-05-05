using MessagingService.Api.Endpoints;
using MessagingService.Api.OpenApi;
using MessagingService.Api.Security;
using MessagingService.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCorsConfiguration();
builder.Services.AddOpenApiConfiguration();
builder.Services.AddInfrastructure(builder.Configuration);


var app = builder.Build();

app.UseCors("All");
app.UseHttpsRedirection();

app.MapOpenApiEndpoints();
app.MapMessagingEndpoints();

app.Run();