using Discord;
using Discord.Commands;
using EwyBot.Helpers;

namespace EwyBot.Commands.Modules;

[Group("!oretweaker")]
public class OreTweakerModule : ModuleBase<SocketCommandContext>
{

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
    
    [Command("1")]
    [Alias("1.12", "1.12.1", "1.12.2")]
    [Summary("Info about Ore Tweaker 1")]
    public async Task One()
    {
        await ReplyAsync(
            "Ore Tweaker 1 was released " + 
            BotHelper.GetYearsSince(new DateTime(2016, 3, 3)) +  
            " years ago for Minecraft 1.12 and is no longer supported"
        );
    }
    
    [Command("2")]
    [Alias("1.16", "1.16.1", "1.16.2", "1.16.3", "1.16.4", "1.16.5", "1.17", "1.17.1")]
    [Summary("Info about Ore Tweaker 2")]
    public async Task Two()
    {
        await ReplyAsync("Ore Tweaker 2 - is for released for all versions of Minecraft 1.16 and 1.17");
    }
    
    [Command("3")]
    [Alias("1.18", "1.18.1", "1.18.2")]
    [Summary("Info about Ore Tweaker 3")]
    public async Task Three()
    {
        await ReplyAsync("Ore Tweaker 3 - is for released for all versions of Minecraft 1.18");
    }
    
    [Command("4")]
    [Alias("1.19", "1.19.1", "1.19.2")]
    [Summary("Info about Ore Tweaker 4")]
    public async Task Four()
    {
        await ReplyAsync("https://github.com/EwyBoy/OreTweaker/discussions/80");
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
    
    
    [Command("tool")]
    [Alias("tools")]
    [Summary("Command to show the template for 1.18")]
    public async Task Tools()
    {
        var guide = new EmbedBuilder();
        
        guide.WithTitle("Click here to download World Stripper");

        guide.WithDescription(
            "You can use World Stripper to easy locate your ores and see how they spawn.\n" + 
            "---------------------------------------------------------------------------\n" + 
            "1. Simply download right version of the mod by clicking the link above\n" + 
            "2. Place the mods folder 📂\n" + 
            "3. Launch Minecraft and open a world here you are in `Creative Mode`\n" + 
            "4. Simply press the `DELETE` key on the keyboard ⌨️\n" +
            "5. Watch the world get stripped away to reveal all the ore generation"
        );
        
        guide.WithImageUrl("https://i.imgur.com/p5wE1QN.jpeg");
        guide.WithUrl("https://www.curseforge.com/minecraft/mc-mods/world-stripper");
        guide.WithFooter("https://www.curseforge.com/minecraft/mc-mods/world-stripper");
        guide.WithColor(new Color(0, 0, 255));
        
        await ReplyAsync("", false, guide.Build());
    }
    
    [Command("config")]
    [Alias("cf", "configuration", "config-file")]
    [Summary("Command to display the path to the config folder")]
    public async Task Config()
    {
        var guide = new EmbedBuilder();
        
        guide.WithTitle("Ore Tweaker Configuration File - **oretweaker.yml**");

        const string config = 
            "#Ore Tweaker - Settings File\n" +
            "[SETTINGS]\n" +
            "    #Enables debug mode\n" +
            "    debug = false\n" +
            "\n" +
            "[TEMPLATES]\n" +
            "    #Attempts to generate default templates if not present\n" +
            "    generate_templates = false\n" +
            "    #Attempts to generate default settings if not present\n" +
            "    generate_default_settings = false\n" +
            "\n" +
            "[GENERATOR]\n" +
            "    #Attempts to auto generate deepslate variants if present\n" +
            "    auto_generate_deepslate_variants = true\n" +
            "    #Disables large veins from generating\n" +
            "    disable_large_veins = true";

        guide.WithDescription(
            "```python\n"  + config  + "\n```"
        );
        
        guide.WithFooter("The config folder is located in the root of your modpacks folder 📁");
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
    