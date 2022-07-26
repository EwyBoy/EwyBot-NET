using Discord;
using Discord.WebSocket;
using EwyBot.Commands;

namespace EwyBot;

public static class Program
{
    public static Task Main(string[] args) => MainAsync();

    private static DiscordSocketClient _client;
    
    public static Task Log(LogMessage msg)
    {
        Console.WriteLine(msg.ToString());
        return Task.CompletedTask;
    }

    private static async Task MainAsync()
    {
        var client = new DiscordSocketClient();
        
        client.MessageReceived += CommandManager.HandleCommandAsync;
        
        client.Log += Log;
        
        var secret = Environment.GetEnvironmentVariable("secret");
        
        await client.LoginAsync(TokenType.Bot, secret);
        await client.StartAsync();

        await Task.Delay(-1);
    }
}