using Discord;
using Discord.Commands;
using Discord.WebSocket;
using EwyBot.Commands;
using Microsoft.Extensions.DependencyInjection;

namespace EwyBot;

public class Program
{
    
    public static Task Main(string[] args)
    {
        return new Program().MainAsync();
    }


    public async Task MainAsync()
    {
        using var services = ConfigureServices();

        var client = services.GetRequiredService<DiscordSocketClient>();
        
        client.Log += LogManager.Log;

        services.GetRequiredService<CommandService>().Log += Log;
        
        var secret = Environment.GetEnvironmentVariable("secret");
        
        await client.LoginAsync(TokenType.Bot, secret);
        await client.StartAsync();
        
        await services.GetRequiredService<CommandCenter>().InitializeAsync();

        await Task.Delay(-1);
    }

    public ServiceProvider ConfigureServices()
    {
        return new ServiceCollection()
            .AddSingleton(new DiscordSocketClient(new DiscordSocketConfig 
            { 
                MessageCacheSize = 500,
                LogLevel = LogSeverity.Info
            }))
            .AddSingleton(new CommandService(new CommandServiceConfig
            { 
                LogLevel = LogSeverity.Info,
                DefaultRunMode = RunMode.Async,
                CaseSensitiveCommands = false 
            }))
            .AddSingleton<CommandCenter>()
            .BuildServiceProvider();
    }

    private Task Log(LogMessage log)
    {
        Console.WriteLine(log.ToString());
        return Task.CompletedTask;
    }
    
}