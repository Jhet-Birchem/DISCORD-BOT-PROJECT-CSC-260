using Drama_Bot_V2.Commands;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.Entities;
using DSharpPlus.EventArgs;
using DSharpPlus.Interactivity;
using DSharpPlus.Interactivity.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Drama_Bot_V2
{
    public class Bot
    {
        // The three main things needed to interact with Discord.
        public DiscordClient Client { get; private set; }
        public InteractivityExtension Interactivity { get; private set; }
        public CommandsNextExtension Commands { get; private set; }

        public async Task RunAsync()
        {
            // Declare an empty string variable to read in the config.json file.
            //                                 V
            // The config.json file contains the token that connects the executable
            // to the Discord Bot, making it appear online and active. The config.json
            // file also contains a designated prefix "#" for accessing bot commands.
            //
            var json = string.Empty;

            // Then, read the config.json file in it's entirety.
            using (var fs = File.OpenRead("config.json"))
            using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
                json = await sr.ReadToEndAsync();

            // Deserialize the config.json file into the ConfigJSON format.
            var configJson = JsonConvert.DeserializeObject<ConfigJSON>(json);

            // Set the token of the bot within the portion below.
            var config = new DiscordConfiguration()
            {
                Intents = DiscordIntents.All,
                Token = configJson.Token,
                TokenType = TokenType.Bot,
                // If the connect is interrupted to the bot profile, automatically reconnect.
                AutoReconnect = true
            };

            // Configure the Client with the "var config" detailed right above this.
            Client = new DiscordClient(config);
            Client.UseInteractivity(new InteractivityConfiguration()
            {
                // If the bot doesn't receive anything for 30 minutes, time itself out.
                Timeout = TimeSpan.FromMinutes(30)
            });

            // Where commands are configured.
            var commandsConfig = new CommandsNextConfiguration()
            {
                // Set the commands prefix from the config.json.
                StringPrefixes = new string[] { configJson.Prefix },
                // Allows the prefix to be used.
                EnableMentionPrefix = true,
                // Allows the bot to send direct messages to users.
                EnableDms = true,
                // Disable the built in help command.
                EnableDefaultHelp = false
            };

            // The line enabling commands to be used.
            Commands = Client.UseCommandsNext(commandsConfig);

            // Tell the bot that the DramaCommands class exists.
            Commands.RegisterCommands<DramaCommands>();

            // Allows the bot to actually come online/establish the connect to the executable.
            await Client.ConnectAsync();
            // Prevents the connection from timing out/giving up.
            await Task.Delay(-1);
        }

        // Return the "Task Complete" for the client being ready for use,
        private Task OnClientReady(ReadyEventArgs e)
        {
            return Task.CompletedTask;
        }
    }
}
