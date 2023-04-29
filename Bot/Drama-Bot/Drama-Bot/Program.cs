using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.DependencyInjection;

namespace Drama_Bot
{
    #region Preamble
    //---------------------------------------------------------------------------------------//
    // Video watched: https://www.youtube.com/watch?v=e2iaRVf4sho
    //---------------------------------------------------------------------------------------//
    //
    //   This is my result after viewing this tutorial. Planning to add comments explaining
    //   what different parts are doing. To do this, I plan to spend time reading some of
    //   the documentation for the Discord.Net NuGet Package I have added.
    //
    //                                    - Jhet Birchem
    //
    //---------------------------------------------------------------------------------------//
    // Link to the NuGet Package Documentation:
    // https://discordnet.dev/
    //
    // Most Relevant Sections:
    // https://discordnet.dev/api/Discord.WebSocket.html --> (using Discord.WebSocket)
    // https://discordnet.dev/api/Discord.Commands.html --> (using Discord.Commands)
    //
    // Link to the GitHub Repo of the Discord.Net NuGet Package:
    // https://github.com/discord-net/Discord.Net
    //---------------------------------------------------------------------------------------//
    #endregion
    internal class Program
    {
        static void Main(string[] args) => new Program().RunBotAsync().GetAwaiter().GetResult();

        private DiscordSocketClient _client;
        private CommandService _commands;
        private IServiceProvider _services;

        public async Task RunBotAsync()
        {
            _client = new DiscordSocketClient();
            _commands = new CommandService();

            _services = new ServiceCollection()
                .AddSingleton(_client)
                .AddSingleton(_commands)
                .BuildServiceProvider();

            string token = "MTEwMTU4OTE5NDA1ODQ5ODEyOQ.GixUtp.MABGwJHGA-G5sB5JAdeTT87QF7Kwr21Jij9ldQ";

            _client.Log += _client_Log;

            await RegisterCommandsAsync();

            await _client.LoginAsync(TokenType.Bot, token);

            await _client.StartAsync();

            await Task.Delay(-1);

        }

        private Task _client_Log(LogMessage arg)
        {
            Console.WriteLine(arg);
            return Task.CompletedTask;
        }

        public async Task RegisterCommandsAsync()
        {
            _client.MessageReceived += HandleCommandAsync;
            await _commands.AddModulesAsync(Assembly.GetEntryAssembly(), _services);
        }

        private async Task HandleCommandAsync(SocketMessage arg)
        {
            var message = arg as SocketUserMessage;
            var context = new SocketCommandContext(_client, message);

            if (message.Author.IsBot) return;

            int argPos = 0;
            if (message.HasStringPrefix("#", ref argPos))
            {
                var result = await _commands.ExecuteAsync(context, argPos, _services);
                if (!result.IsSuccess) Console.WriteLine(result.ErrorReason);
                if (result.Error.Equals(CommandError.UnmetPrecondition)) await message.Channel.SendMessageAsync(result.ErrorReason);
            }
        }
    }
}
