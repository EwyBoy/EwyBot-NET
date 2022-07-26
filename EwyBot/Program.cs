using System.Text;
using Discord;
using Discord.WebSocket;

namespace EwyBot;

public static class Program
{
    public static Task Main(string[] args) => MainAsync();

    private static DiscordSocketClient _client;

    private static async Task MainAsync()
    {
        var client = new DiscordSocketClient();
        client.MessageReceived += HandleCommandAsync;
        
        client.Log += Log;
        
        var secret = Environment.GetEnvironmentVariable("secret");
        
        await client.LoginAsync(TokenType.Bot, secret);
        await client.StartAsync();

        await Task.Delay(-1);
    }
    
    private static Task HandleCommandAsync(SocketMessage message)
    {
        if (message is not SocketUserMessage)
        {
            return Task.CompletedTask;
        }
        
        if (message.Author.IsBot)
        {
            return Task.CompletedTask;
        }

        if (!message.Content.StartsWith('!'))
        {
            return Task.CompletedTask;
        }

        var chatInput = message.Content.Substring(1, message.Content.Length - 1).ToLower();
        
        switch (chatInput)
        {
            case "test":
                SendCommandsResponse(message, $"Hello {message.Author.Mention}! This is a test message.");
                break;
            case "help":
                SendCommandsResponse(message, 
                    "Here is a list of all commands: " 
                    + "\n !test - test command" + " " 
                    + "\n !help - help command" + " "
                );
                break;
            default:
                SendUnknownCommandResponse(message);
                break;
        }

        return Task.CompletedTask;
    }

    private static void SendCommandsResponse(SocketMessage message, string response)
    {
        message.Channel.SendMessageAsync(response);
        Log(new LogMessage(LogSeverity.Info, "COMMAND", response));
    }

    private static void SendUnknownCommandResponse(SocketMessage message)
    {
        SendCommandsResponse(message, $"**{message.Content}** is an invalid command. Please use !help for a list of available commands.");
    }

    private static Task Log(LogMessage msg)
    {
        Console.WriteLine(msg.ToString());
        return Task.CompletedTask;
    }
}