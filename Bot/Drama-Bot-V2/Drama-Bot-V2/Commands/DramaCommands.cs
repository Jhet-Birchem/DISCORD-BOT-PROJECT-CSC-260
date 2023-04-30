using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
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
    }
}
