using MessagingService.Api.Endpoints;
using MessagingService.Api.Hubs;
using MessagingService.Api.OpenApi;
using MessagingService.Api.Security;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCorsConfiguration();
builder.Services.AddOpenApiConfiguration();
builder.Services.AddSignalR();



var app = builder.Build();

app.UseCors("All");
//app.UseHttpsRedirection();

app.MapHub<ChatHub>("/chathub");
app.MapOpenApiEndpoints();
app.MapMessagingEndpoints();

app.Run();