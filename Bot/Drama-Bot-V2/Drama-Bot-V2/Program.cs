using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drama_Bot_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the bot class.
            var bot = new Bot();
            // Allows us to await the completion of an asynchronous task.
            //
            // NOTE*** The asynchronous nature of the program is important
            // for the fact that many tasks are not handled on the local
            // machine exclusively.
            //
            bot.RunAsync().GetAwaiter().GetResult();
        }
    }
}
