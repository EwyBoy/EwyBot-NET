using Discord;
using Discord.Commands;
using Discord.Rest;
using Discord.WebSocket;

namespace EwyBot;

public class LogManager
{
    public LogManager(BaseDiscordClient client, CommandService command)
    {
        client.Log += LogAsync;
        command.Log += LogAsync;
    }
    
    public static Task Log(LogMessage msg)
    {
        Console.WriteLine(msg.ToString());
        return Task.CompletedTask;
    }

    private static Task LogAsync(LogMessage message)
    {
        if (message.Exception is CommandException exception)
        {
            Console.WriteLine(exception);
        }
        else
        {
            Console.WriteLine(message.ToString());
        }
        
        return Task.CompletedTask;
    }
}