using EwyBot;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHostedService<DiscordBotService>();

var app = builder.Build();
app.MapGet("/", () => "Hello World!");
await app.RunAsync();