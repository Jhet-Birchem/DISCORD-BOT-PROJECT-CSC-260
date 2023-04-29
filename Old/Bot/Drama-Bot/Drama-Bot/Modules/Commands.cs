using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace Drama_Bot.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("drama")]
        public async Task Drama()
        {
            await ReplyAsync("Your mom!");
        }
    }
}
