using System.Reflection;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EwyBot.Commands;

public class CommandCenter
    {
        private readonly CommandService _commands;
        private readonly DiscordSocketClient _client;
        private readonly IServiceProvider _services;

        public CommandCenter(IServiceProvider services)
        {

            _commands = services.GetRequiredService<CommandService>();
            _client = services.GetRequiredService<DiscordSocketClient>();
            _services = services;

            // Event handlers
            _client.MessageReceived += HandleCommandAsync;
        }

        private async Task HandleCommandAsync(SocketMessage inputMessage)
        {
            
            if (inputMessage is not SocketUserMessage message) return;
            
            if (inputMessage.Author.IsBot) return;
            
            if (!inputMessage.Content.StartsWith("!")) return;

            var context = new SocketCommandContext(_client, message);

            int argPos = 0;

            var result = await _commands.ExecuteAsync(context, argPos, _services);

            if (!result.IsSuccess && result.Error.HasValue)
            {
                await context.Channel.SendMessageAsync($":x: {result.ErrorReason}");
            }   
        }

        public async Task InitializeAsync() => await _commands.AddModulesAsync(Assembly.GetEntryAssembly(), _services);
    }