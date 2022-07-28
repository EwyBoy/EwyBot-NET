using Discord;
using Discord.Commands;

namespace EwyBot.Commands.Modules;


[Group("!oretweaker")]
public class OreTweakerModule : ModuleBase<SocketCommandContext>
{

    [Command]
    [Summary("Default command")]
    public async Task OreTweaker()
    {
        await ReplyAsync("This is the Ore Tweaker module!");
    }

    [Command("wiki")]
    [Summary("Command to get the wiki link")]
    public async Task Wiki()
    {
        await ReplyAsync("https://github.com/EwyBoy/OreTweaker/wiki");
    }

    [Command("link")]
    [Alias("curseforge", "download", "curse-forge")]
    [Summary("Links to Ore Tweaker CurseForge page")]
    public async Task Link()
    {
        await ReplyAsync("https://www.curseforge.com/minecraft/mc-mods/ore-tweaker");
    }
    
    [Command("install")]
    [Summary("Command to install the mod")]
    public async Task Install()
    {
        var guide = new EmbedBuilder();
        
        guide.WithTitle("Click here to go to the download page");
        guide.WithDescription(
            "1. Download the mod from the link above" + "\n" +
            "2. Place the mods jar file in the mods folder 📂" + "\n" +
            "3. Start Minecraft once to generate Ore Tweakers files 📃" + "\n" +
            "4. Open the config folder and find the oretweaker folder 📂" + "\n" +
            "5. Open the oretweaker folder and find the data folder 📂" + "\n" +
            "6. Inside the data folder find the ores you wanna tweaks json file 📃" + "\n" +
            "7. Open the any " + "\n" +
        );
        guide.WithUrl("https://www.curseforge.com/minecraft/mc-mods/ore-tweaker");
        guide.WithFooter("If this does not work, you somehow fucked it up..");
        guide.WithColor(new Color(0, 255, 0));
        
        await ReplyAsync("How to install Ore Tweaker on Client / Server", false, guide.Build());
    }
}
    