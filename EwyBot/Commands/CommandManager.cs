using Discord;
using Discord.WebSocket;

namespace EwyBot.Commands;

public static class CommandManager
{
    public static Task HandleCommandAsync(SocketMessage message)
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
        Program.Log(new LogMessage(LogSeverity.Info, "COMMAND", response));
    }

    private static void SendUnknownCommandResponse(SocketMessage message)
    {
        SendCommandsResponse(message, $"**{message.Content}** is an invalid command. Please use !help for a list of available commands.");
    }
}