using Discord;
using Discord.WebSocket;

namespace EwyBot;

public class DiscordBotService : BackgroundService
{
    private readonly DiscordSocketClient _client;

    public DiscordBotService()
    {
        _client = new DiscordSocketClient(
            new DiscordSocketConfig {
                GatewayIntents = GatewayIntents.MessageContent | GatewayIntents.Guilds | GatewayIntents.GuildMessages,
            }
        );
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var secret = Environment.GetEnvironmentVariable("secret");

        _client.Log += LogAsync;
        _client.MessageReceived += HandleMessageReceivedAsync;
        _client.Ready += Client_ReadyAsync;

        await _client.LoginAsync(TokenType.Bot, secret);
        await _client.StartAsync();

        await Task.Delay(Timeout.Infinite, stoppingToken);
    }

    private static Task LogAsync(LogMessage arg)
    {
        Console.WriteLine(arg);
        return Task.CompletedTask;
    }

    private async Task Client_ReadyAsync()
    {
        await _client.SetGameAsync("Listening to !hello");
        await _client.SetStatusAsync(UserStatus.Online);
    }

    private static async Task HandleMessageReceivedAsync(SocketMessage message)
    {
        if (message.Author.IsBot)
            return;
        
        if (message.Content.StartsWith("!hello"))
        {
            await message.Channel.SendMessageAsync("Hello there!");
        }
    }
}