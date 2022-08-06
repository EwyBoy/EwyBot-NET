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
    [Alias("setup", "configure")]
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
            "7. Open or create a new file in any text editor" + "\n" + 
            "8. Tweak the ore property settings, and save the file" + "\n" +
            "9. Restart Minecraft and generate a new world or load some fresh chunks" + "\n"
        );
        
        guide.WithUrl("https://www.curseforge.com/minecraft/mc-mods/ore-tweaker");
        guide.WithFooter("If this does not work, you somehow fucked it up..");
        guide.WithColor(new Color(0, 255, 0));
        
        await ReplyAsync("How to install Ore Tweaker on Client / Server", false, guide.Build());
    }
    
    [Command("template 1.16")]
    [Alias("2 template", "template 2", "1.16 template")]
    [Summary("Command to show the template for 1.16")]
    public async Task Template2()
    {
        var guide = new EmbedBuilder();

        const string template = 
            "{\n" +
            "  \"oreConfig\": [\n" +
            "    {\n" +
            "      \"ore\": \"minecraft:diamond_ore\",\n" +
            "      \"filler\": \"minecraft:stone\",\n" +
            "      \"minY\": 1,\n" +
            "      \"maxY\": 16,\n" +
            "      \"maxVeinSize\": 7,\n" +
            "      \"spawnRate\": 1.0,\n" +
            "      \"biomeBlacklist\": [],\n" +
            "      \"biomeWhitelist\": []\n" +
            "    }\n" +
            "  ]\n" +
            "}";

        guide.WithDescription(
            "```json" + "\n" + template + "\n" + "```"
        );
        
        guide.WithTitle("Ore Tweaker 2 Template for Minecraft 1.16");
        guide.WithFooter("This is the template of a diamond ore entry for Ore Tweaker 2, Minecraft 1.16");
        guide.WithColor(new Color(0, 0, 255));
        
        await ReplyAsync("", false, guide.Build());
    }
    
    [Command("template 1.18")]
    [Alias("3 template", "template 3", "1.18 template")]
    [Summary("Command to show the template for 1.18")]
    public async Task Template3()
    {
        var guide = new EmbedBuilder();

        const string template = 
            "{\n" +
            "  \"oreConfig\": [\n" +
            "    {\n" +
            "      \"ore\": \"minecraft:diamond_ore\",\n" +
            "      \"fillers\": [\n" +
            "        \"minecraft:stone_ore_replaceables\"\n" +
            "      ],\n" +
            "      \"distribution\": \"TRIANGLE\",\n" +
            "      \"minY\": -144,\n" +
            "      \"maxY\": 16,\n" +
            "      \"maxVeinSize\": 4,\n" +
            "      \"spawnRate\": 7.0,\n" +
            "      \"discardChanceOnAirExposure\": 0.5,\n" +
            "      \"biomeFilters\": {\n" +
            "        \"biomeBlacklist\": [],\n" +
            "        \"biomeWhitelist\": [\n" +
            "          \"OVERWORLD\"\n" +
            "        ]\n" +
            "      },\n" +
            "      \"replace\": true\n" +
            "    }\n" +
            "  ]\n" +
            "}";
        
        guide.WithDescription(
            "```json" + "\n" + template + "\n" + "```"
        );
        
        guide.WithTitle("Ore Tweaker 3 Template for Minecraft 1.18");
        guide.WithFooter("This is the template of a diamond ore entry for Ore Tweaker 3, Minecraft 1.18");
        guide.WithColor(new Color(0, 0, 255));
        
        await ReplyAsync("", false, guide.Build());
    }
    
    [Command("path")]
    [Alias("files", "folder")]
    [Summary("Command to display the path to the config folder")]
    public async Task Path()
    {
        var guide = new EmbedBuilder();

        guide.WithDescription(
            "`"  + "/config/oretweaker/data"  + "` " + "📂"
        );
        
        guide.WithTitle("The files are located in the following folder:");
        guide.WithFooter("The config folder is located in the root of your modpacks folder 📁");
        guide.WithColor(new Color(0, 0, 255));
        
        await ReplyAsync("", false, guide.Build());
    }

}
    