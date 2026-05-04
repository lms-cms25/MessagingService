using MessagingService.Api.Endpoints;
using MessagingService.Api.OpenApi;
using MessagingService.Api.Security;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCorsConfiguration();
builder.Services.AddOpenApiConfiguration();



var app = builder.Build();

app.UseCors("All");
app.UseHttpsRedirection();

app.MapOpenApiEndpoints();
app.MapMessagingEndpoints();

app.Run();