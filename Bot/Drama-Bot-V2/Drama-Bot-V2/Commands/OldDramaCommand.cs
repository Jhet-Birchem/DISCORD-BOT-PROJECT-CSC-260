using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drama_Bot_V2.Commands
{
    public class OldDramaCommand : BaseCommandModule
    {
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        // Declaring existance of the olddrama command.
        [Command("olddrama")]

        // Declaring a method of a command.
        // NOTE*** ctx represents which channel that the user that used the command.
        public async Task DramaOld(CommandContext ctx)
        {
            //Command writing is done in here.

            //Temp: send a message.
            await ctx.Channel.SendMessageAsync("Your mom!");
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
