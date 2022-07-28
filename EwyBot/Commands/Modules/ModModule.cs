using Discord.Commands;

namespace EwyBot.Commands.Modules;


[Group("!mod")]
public class ModModule : ModuleBase<SocketCommandContext>
{
    
    [Command("ore tweaker")]
    [Alias("ot", "oretweaker", "ore-tweaker")]
    [Summary("Links to Ore Tweaker CurseForge page")]
    public async Task OreTweaker()
    {
        await ReplyAsync("https://www.curseforge.com/minecraft/mc-mods/ore-tweaker");
    }
    
    [Command("world stripper")]
    [Alias("ws", "worldstripper", "world-stripper")]
    [Summary("Links to World Stripper CurseForge page")]
    public async Task WorldStripper()
    {
        await ReplyAsync("https://www.curseforge.com/minecraft/mc-mods/world-stripper");
    }
    
    [Command("barista")]
    [Alias("bar", "barita")]
    [Summary("Links to Barista CurseForge page")]
    public async Task Barista()
    {
        await ReplyAsync("https://www.curseforge.com/minecraft/mc-mods/barista");
    }
    
    [Command("bibliotheca")]
    [Alias("biblib", "biblioteca")]
    [Summary("Links to Bibliotheca CurseForge page")]
    public async Task Bibliotheca()
    {
        await ReplyAsync("https://www.curseforge.com/minecraft/mc-mods/bibliotheca");
    }
    
    [Command("block tweaker")]
    [Alias("bt", "blocktweaker", "block-tweaker")]
    [Summary("Links to Block Tweaker CurseForge page")]
    public async Task BlockTweaker()
    {
        await ReplyAsync("https://www.curseforge.com/minecraft/mc-mods/block-tweaker");
    }
    
    [Command("craftable hourse armor & saddle")]
    [Alias("chas", "cha-s", "cha&s", "craftablehoursearmorandsaddle")]
    [Summary("Links to Craftable Hourse Armor & Saddle CurseForge page")]
    public async Task CraftableHourseArmorAndSaddle()
    {
        await ReplyAsync("https://www.curseforge.com/minecraft/mc-mods/cha-s");
    }
    
    [Command("clay worldgen")]
    [Alias("cwg", "clayworldgen", "clay-worldgen")]
    [Summary("Links to Clay WorldGen CurseForge page")]
    public async Task ClayWorldGen()
    {
        await ReplyAsync("https://www.curseforge.com/minecraft/mc-mods/clay-worldgen");
    }
    
    [Command("e-vaporate")]
    [Alias("ev", "evaporate", "e vaporate")]
    [Summary("Links to E Vaporate CurseForge page")]
    public async Task E_Vaporate()
    {
        await ReplyAsync("https://www.curseforge.com/minecraft/mc-mods/e-vaporate");
    }
    
    [Command("cultivated tech")]
    [Alias("ct", "cultivatedtech", "cultivated-tech")]
    [Summary("Links to Cultivated Tech CurseForge page")]
    public async Task CultivatedTech()
    {
        await ReplyAsync("https://www.curseforge.com/minecraft/mc-mods/cultivated-tech");
    }
    
    [Command("engineer's workshop")]
    [Alias("ew", "engineersworkshop", "engineers-workshop")]
    [Summary("Links to Engineer's Workshop CurseForge page")]
    public async Task EngineersWorkshop()
    {
        await ReplyAsync("https://www.curseforge.com/minecraft/mc-mods/engineers-workshop");
    }
    
    [Command("floating rails")]
    [Alias("fr", "floatingrails", "floating-rails")]
    [Summary("Links to Floating Rails CurseForge page")]
    public async Task FloatingRails()
    {
        await ReplyAsync("https://www.curseforge.com/minecraft/mc-mods/floating-rails");
    }
    
    [Command("fps monitor")]
    [Alias("fm", "fps", "fpsmonitor", "fps-monitor")]
    [Summary("Links to FPS Monitor CurseForge page")]
    public async Task FPSMonitor()
    {
        await ReplyAsync("https://www.curseforge.com/minecraft/mc-mods/fps-monitor");
    }
    
    [Command("hammer time")]
    [Alias("ht", "hammertime", "hammer-time")]
    [Summary("Links to Hammer Time CurseForge page")]
    public async Task HammerTime()
    {
        await ReplyAsync("https://www.curseforge.com/minecraft/mc-mods/hammer-time");
    }
    
    [Command("itank")]
    [Alias("it", "itank", "i-tank")]
    [Summary("Links to I-Tank CurseForge page")]
    public async Task I_Tank()
    {
        await ReplyAsync("https://www.curseforge.com/minecraft/mc-mods/itank");
    }
    
    [Command("quick harvest")]
    [Alias("qh", "quickharvest", "quick-harvest")]
    [Summary("Links to Quick Harvest CurseForge page")]
    public async Task QuickHarvest()
    {
        await ReplyAsync("https://www.curseforge.com/minecraft/mc-mods/quick-harvest");
    }
    
    [Command("seed drop")]
    [Alias("sd", "seeddrop", "seed-drop")]
    [Summary("Links to Seed Drop CurseForge page")]
    public async Task SeedDrop()
    {
        await ReplyAsync("https://www.curseforge.com/minecraft/mc-mods/seed-drop");
    }
    
    [Command("team up")]
    [Alias("tu", "teamup", "team-up")]
    [Summary("Links to Team Up CurseForge page")]
    public async Task TeamUp()
    {
        await ReplyAsync("https://www.curseforge.com/minecraft/mc-mods/team-up");
    }
    
    [Command("world spawn")]
    [Alias("worldspawn", "world-spawn")]
    [Summary("Links to World Spawn CurseForge page")]
    public async Task WorldSpawn()
    {
        await ReplyAsync("https://www.curseforge.com/minecraft/mc-mods/world-spawn");
    }
    
}