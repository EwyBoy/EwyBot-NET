using Discord.Commands;

namespace EwyBot.Commands.Modules;

public class BotModule : ModuleBase<SocketCommandContext>
{
    
    [Command("!woo")]
    [Alias("!wooo", "!yey", "!yeey")]
    [Summary("Says wooo!")]
    public async Task Woo()
    {
        await ReplyAsync("🥳💃🎈🎉🎊🪅");
    }
    
}