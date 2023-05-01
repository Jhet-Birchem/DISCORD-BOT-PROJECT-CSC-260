using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drama_Bot_V2.Commands
{
    // Inherit the BaseCommandModule for fundamental command functionality.
    public class DramaCommands : BaseCommandModule
    {
        // Declaring existance of the drama command.
        [Command("drama")]

        // Declaring a method of a command.
        // NOTE*** ctx represents which channel that the user that used the command.
        public async Task DramaVOne(CommandContext ctx)
        {
            //Command writing is done in here.

            //Temp: send a message.
            await ctx.Channel.SendMessageAsync("Your mom!");
        }


        // Declaring existance of an add command.
        [Command("add")]

        // Declaring method of add command with parameters.
        public async Task Addition(CommandContext ctx, int number1, int number2)
        {
            int answer = number1 + number2;
            await ctx.Channel.SendMessageAsync(answer.ToString());
        }


        // Declaring the existance of an embedded message command.
        [Command("embed")]

        // Declaring a method of the embedded message command.
        public async Task SendEmbedMessage (CommandContext ctx)
        {
            var embedMessage = new DiscordMessageBuilder()
                .AddEmbed(new DiscordEmbedBuilder()

                .WithTitle("This is a Title")
                .WithDescription("This is the description")
                );

            await ctx.Channel.SendMessageAsync(embedMessage);
        }
    }
}
