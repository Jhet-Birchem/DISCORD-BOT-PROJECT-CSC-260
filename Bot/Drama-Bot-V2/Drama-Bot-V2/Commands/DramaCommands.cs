using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drama_Bot_V2.Commands
{
    // Inherit the BaseCommandModule for fundamental command functionality.
    public class DramaCommands : BaseCommandModule
    {

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        // Declaring existance of the drama command.
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


        // Declaring the existance of the main drama command.
        [Command("drama")]

        // Declaring main drama command method for no name.
        public async Task Drama (CommandContext ctx)
        {
            #region Random Victim
            // Making a list of all members/users for command usage.
            var members = ctx.Guild.Members.Values.ToArray<DiscordMember>();

            // Getting the role id for dramaless for later in the loop.
            var role = ctx.Guild.GetRole(1102776164008865832);
            
            // Saving a count of all members.
            int count = members.Length;

            // Pre-making loop condition to not use dramaless users in the drama messages.
            bool selectedMemberDramaless;

            // Prepare the prefix @ for the resulting user.
            string victim = "@";

            do
            {
                // Pick a random id for a member in the list, save it.
                Random rnd = new Random();
                int result = rnd.Next(count);

                // Check if the member corresponding to the array location at result is dramaless.
                if (members[result].Roles.Contains(role))
                {
                    // Keep looping if ineligible.
                    selectedMemberDramaless = true;
                }
                else
                {
                    // Otherwise, they're eligible to be the victim. Save them.
                    selectedMemberDramaless = false;
                    victim = victim + members[result].DisplayName;
                }

            } while (selectedMemberDramaless == true);
            #endregion

            #region Noun
            // Now to select a noun. Get a random value 1 - 10.
            await Task.Delay(1000);
            Random random = new Random();
            int result2 = random.Next(1, 11);

            // Declaring an empty string to store the noun.
            string noun = string.Empty;

            // Depending on the case, set the string noun to the word corresponding to the number.
            switch (result2)
            {
                case 1:
                    noun = "skateboard";
                    break;
                case 2:
                    noun = "shark";
                    break;
                case 3:
                    noun = "tube of toothpaste";
                    break;
                case 4:
                    noun = "$#!%";
                    break;
                case 5:
                    noun = "smartphone";
                    break;
                case 6:
                    noun = "flashdrive";
                    break;
                case 7:
                    noun = "2014 Subaru Legacy";
                    break;
                case 8:
                    noun = "microphone";
                    break;
                case 9:
                    noun = "rolled-up newspaper";
                    break;
                case 10:
                    noun = "violin bow";
                    break;
            }
            #endregion

            #region Verb
            // Now to select a verb. Get a random value 1 - 10.
            await Task.Delay(1000);
            Random random2 = new Random();
            int result3 = random2.Next(1, 11);

            // Declaring an empty string to store the noun.
            string verb = string.Empty;

            // Depending on the case, set the string noun to the word corresponding to the number.
            switch (result3)
            {
                case 1:
                    verb = "swam";
                    break;
                case 2:
                    verb = "evaded";
                    break;
                case 3:
                    verb = "$#!%ed";
                    break;
                case 4:
                    verb = "ran";
                    break;
                case 5:
                    verb = "danced";
                    break;
                case 6:
                    verb = "yodeled";
                    break;
                case 7:
                    verb = "teleported";
                    break;
                case 8:
                    verb = "flew";
                    break;
                case 9:
                    verb = "fell";
                    break;
                case 10:
                    verb = "ate";
                    break;
            }
            #endregion

            #region Printing
            // Now, randomly choose a method template to print from. Get a random value 1 - 5.
            await Task.Delay(1000);
            Random random3 = new Random();
            int result4 = random3.Next(1, 6);

            string printable;
            // Depending on case, that's the output message.
            switch (result4)
            {
                case 1:
                    printable = "I saw " + victim + " return a " + noun + " to Walmart yesterday." +
                        " They claimed it was faulty and that it never even " + verb + " once!";

                    await ctx.Channel.SendMessageAsync(printable);
                    break;
                case 2:
                    printable = "I saw a " + noun + " drop out of " + victim + "'s pocket when they " +
                        verb + " away from the police!";

                    await ctx.Channel.SendMessageAsync(printable);
                    break;
                case 3:
                    printable = "I saw " + victim + " assault a staff member at Chili’s with a " + noun + "! They " +
                        verb + " away before I could talk to them!";

                    await ctx.Channel.SendMessageAsync(printable);
                    break;
                case 4:
                    printable = "I heard that " + victim + " " + verb + " the whole way to Hawaii with nothing but a  " + noun +
                        "! A " + noun + "!";

                    await ctx.Channel.SendMessageAsync(printable);
                    break;
                case 5:
                    printable = "I could have sworn that I saw " + victim + " steal a " + noun + " from a baby yesterday." +
                    " They " + verb + " away so fast that I couldn't get a picture of them!";

                    await ctx.Channel.SendMessageAsync(printable);
                    break;
            }
            #endregion

        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        // Declaring the existance of the main drama command.
        [Command("drama")]

        // Declaring main drama command method for one name.
        public async Task DramaTwo (CommandContext ctx, string one)
        {
            #region Set Victim (1 args)
            string victim = "@" + one;
            #endregion

            #region Noun
            // Now to select a noun. Get a random value 1 - 10.
            await Task.Delay(1000);
            Random random = new Random();
            int result2 = random.Next(1, 11);

            // Declaring an empty string to store the noun.
            string noun = string.Empty;

            // Depending on the case, set the string noun to the word corresponding to the number.
            switch (result2)
            {
                case 1:
                    noun = "skateboard";
                    break;
                case 2:
                    noun = "shark";
                    break;
                case 3:
                    noun = "tube of toothpaste";
                    break;
                case 4:
                    noun = "$#!%";
                    break;
                case 5:
                    noun = "smartphone";
                    break;
                case 6:
                    noun = "flashdrive";
                    break;
                case 7:
                    noun = "2014 Subaru Legacy";
                    break;
                case 8:
                    noun = "microphone";
                    break;
                case 9:
                    noun = "rolled-up newspaper";
                    break;
                case 10:
                    noun = "violin bow";
                    break;
            }
            #endregion

            #region Verb
            // Now to select a verb. Get a random value 1 - 10.
            await Task.Delay(1000);
            Random random2 = new Random();
            int result3 = random2.Next(1, 11);

            // Declaring an empty string to store the noun.
            string verb = string.Empty;

            // Depending on the case, set the string noun to the word corresponding to the number.
            switch (result3)
            {
                case 1:
                    verb = "swam";
                    break;
                case 2:
                    verb = "evaded";
                    break;
                case 3:
                    verb = "$#!%ed";
                    break;
                case 4:
                    verb = "ran";
                    break;
                case 5:
                    verb = "danced";
                    break;
                case 6:
                    verb = "yodeled";
                    break;
                case 7:
                    verb = "teleported";
                    break;
                case 8:
                    verb = "flew";
                    break;
                case 9:
                    verb = "fell";
                    break;
                case 10:
                    verb = "ate";
                    break;
            }
            #endregion

            #region Printing
            // Now, randomly choose a method template to print from. Get a random value 1 - 5.
            await Task.Delay(1000);
            Random random3 = new Random();
            int result4 = random3.Next(1, 6);

            string printable;
            // Depending on case, that's the output message.
            switch (result4)
            {
                case 1:
                    printable = "I saw " + victim + " return a " + noun + " to Walmart yesterday." +
                        " They claimed it was faulty and that it never even " + verb + " once!";

                    await ctx.Channel.SendMessageAsync(printable);
                    break;
                case 2:
                    printable = "I saw a " + noun + " drop out of " + victim + "'s pocket when they " +
                        verb + " away from the police!";

                    await ctx.Channel.SendMessageAsync(printable);
                    break;
                case 3:
                    printable = "I saw " + victim + " assault a staff member at Chili’s with a " + noun + "! They " +
                        verb + " away before I could talk to them!";

                    await ctx.Channel.SendMessageAsync(printable);
                    break;
                case 4:
                    printable = "I heard that " + victim + " " + verb + " the whole way to Hawaii with nothing but a  " + noun +
                        "! A " + noun + "!";

                    await ctx.Channel.SendMessageAsync(printable);
                    break;
                case 5:
                    printable = "I could have sworn that I saw " + victim + " steal a " + noun + " from a baby yesterday." +
                    " They " + verb + " away so fast that I couldn't get a picture of them!";

                    await ctx.Channel.SendMessageAsync(printable);
                    break;
            }
            #endregion
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        // Declaring the existance of the main drama command.
        [Command("drama")]

        // Declaring main drama command method for two names.
        public async Task DramaTwo(CommandContext ctx, string one, string two)
        {
            #region Set Victim (2 args)
            string victim = "@" + one + " " + two;
            #endregion

            #region Noun
            // Now to select a noun. Get a random value 1 - 10.
            await Task.Delay(1000);
            Random random = new Random();
            int result2 = random.Next(1, 11);

            // Declaring an empty string to store the noun.
            string noun = string.Empty;

            // Depending on the case, set the string noun to the word corresponding to the number.
            switch (result2)
            {
                case 1:
                    noun = "skateboard";
                    break;
                case 2:
                    noun = "shark";
                    break;
                case 3:
                    noun = "tube of toothpaste";
                    break;
                case 4:
                    noun = "$#!%";
                    break;
                case 5:
                    noun = "smartphone";
                    break;
                case 6:
                    noun = "flashdrive";
                    break;
                case 7:
                    noun = "2014 Subaru Legacy";
                    break;
                case 8:
                    noun = "microphone";
                    break;
                case 9:
                    noun = "rolled-up newspaper";
                    break;
                case 10:
                    noun = "violin bow";
                    break;
            }
            #endregion

            #region Verb
            // Now to select a verb. Get a random value 1 - 10.
            await Task.Delay(1000);
            Random random2 = new Random();
            int result3 = random2.Next(1, 11);

            // Declaring an empty string to store the noun.
            string verb = string.Empty;

            // Depending on the case, set the string noun to the word corresponding to the number.
            switch (result3)
            {
                case 1:
                    verb = "swam";
                    break;
                case 2:
                    verb = "evaded";
                    break;
                case 3:
                    verb = "$#!%ed";
                    break;
                case 4:
                    verb = "ran";
                    break;
                case 5:
                    verb = "danced";
                    break;
                case 6:
                    verb = "yodeled";
                    break;
                case 7:
                    verb = "teleported";
                    break;
                case 8:
                    verb = "flew";
                    break;
                case 9:
                    verb = "fell";
                    break;
                case 10:
                    verb = "ate";
                    break;
            }
            #endregion

            #region Printing
            // Now, randomly choose a method template to print from. Get a random value 1 - 5.
            await Task.Delay(1000);
            Random random3 = new Random();
            int result4 = random3.Next(1, 6);

            string printable;
            // Depending on case, that's the output message.
            switch (result4)
            {
                case 1:
                    printable = "I saw " + victim + " return a " + noun + " to Walmart yesterday." +
                        " They claimed it was faulty and that it never even " + verb + " once!";

                    await ctx.Channel.SendMessageAsync(printable);
                    break;
                case 2:
                    printable = "I saw a " + noun + " drop out of " + victim + "'s pocket when they " +
                        verb + " away from the police!";

                    await ctx.Channel.SendMessageAsync(printable);
                    break;
                case 3:
                    printable = "I saw " + victim + " assault a staff member at Chili’s with a " + noun + "! They " +
                        verb + " away before I could talk to them!";

                    await ctx.Channel.SendMessageAsync(printable);
                    break;
                case 4:
                    printable = "I heard that " + victim + " " + verb + " the whole way to Hawaii with nothing but a  " + noun +
                        "! A " + noun + "!";

                    await ctx.Channel.SendMessageAsync(printable);
                    break;
                case 5:
                    printable = "I could have sworn that I saw " + victim + " steal a " + noun + " from a baby yesterday." +
                    " They " + verb + " away so fast that I couldn't get a picture of them!";

                    await ctx.Channel.SendMessageAsync(printable);
                    break;
            }
            #endregion
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        // Declaring the existance of the main drama command.
        [Command("drama")]

        // Declaring main drama command method for three names.
        public async Task DramaTwo(CommandContext ctx, string one, string two, string three)
        {
            #region Set Victim (3 args)
            string victim = "@" + one + " " + two + " " + three;
            #endregion

            #region Noun
            // Now to select a noun. Get a random value 1 - 10.
            await Task.Delay(1000);
            Random random = new Random();
            int result2 = random.Next(1, 11);

            // Declaring an empty string to store the noun.
            string noun = string.Empty;

            // Depending on the case, set the string noun to the word corresponding to the number.
            switch (result2)
            {
                case 1:
                    noun = "skateboard";
                    break;
                case 2:
                    noun = "shark";
                    break;
                case 3:
                    noun = "tube of toothpaste";
                    break;
                case 4:
                    noun = "$#!%";
                    break;
                case 5:
                    noun = "smartphone";
                    break;
                case 6:
                    noun = "flashdrive";
                    break;
                case 7:
                    noun = "2014 Subaru Legacy";
                    break;
                case 8:
                    noun = "microphone";
                    break;
                case 9:
                    noun = "rolled-up newspaper";
                    break;
                case 10:
                    noun = "violin bow";
                    break;
            }
            #endregion

            #region Verb
            // Now to select a verb. Get a random value 1 - 10.
            await Task.Delay(1000);
            Random random2 = new Random();
            int result3 = random2.Next(1, 11);

            // Declaring an empty string to store the noun.
            string verb = string.Empty;

            // Depending on the case, set the string noun to the word corresponding to the number.
            switch (result3)
            {
                case 1:
                    verb = "swam";
                    break;
                case 2:
                    verb = "evaded";
                    break;
                case 3:
                    verb = "$#!%ed";
                    break;
                case 4:
                    verb = "ran";
                    break;
                case 5:
                    verb = "danced";
                    break;
                case 6:
                    verb = "yodeled";
                    break;
                case 7:
                    verb = "teleported";
                    break;
                case 8:
                    verb = "flew";
                    break;
                case 9:
                    verb = "fell";
                    break;
                case 10:
                    verb = "ate";
                    break;
            }
            #endregion

            #region Printing
            // Now, randomly choose a method template to print from. Get a random value 1 - 5.
            await Task.Delay(1000);
            Random random3 = new Random();
            int result4 = random3.Next(1, 6);

            string printable;
            // Depending on case, that's the output message.
            switch (result4)
            {
                case 1:
                    printable = "I saw " + victim + " return a " + noun + " to Walmart yesterday." +
                        " They claimed it was faulty and that it never even " + verb + " once!";

                    await ctx.Channel.SendMessageAsync(printable);
                    break;
                case 2:
                    printable = "I saw a " + noun + " drop out of " + victim + "'s pocket when they " +
                        verb + " away from the police!";

                    await ctx.Channel.SendMessageAsync(printable);
                    break;
                case 3:
                    printable = "I saw " + victim + " assault a staff member at Chili’s with a " + noun + "! They " +
                        verb + " away before I could talk to them!";

                    await ctx.Channel.SendMessageAsync(printable);
                    break;
                case 4:
                    printable = "I heard that " + victim + " " + verb + " the whole way to Hawaii with nothing but a  " + noun +
                        "! A " + noun + "!";

                    await ctx.Channel.SendMessageAsync(printable);
                    break;
                case 5:
                    printable = "I could have sworn that I saw " + victim + " steal a " + noun + " from a baby yesterday." +
                    " They " + verb + " away so fast that I couldn't get a picture of them!";

                    await ctx.Channel.SendMessageAsync(printable);
                    break;
            }
            #endregion
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        #region Unused Scraps
        /////////////////////////////////////////////////////////////////////


        /*
         * Console.WriteLine("{0}", count);

            foreach (var member in members)
            {
                Console.WriteLine($"{member.Username}\n");
            }

            await ctx.Channel.SendMessageAsync("Anyone's mom!");
        */


        /////////////////////////////////////////////////////////////////////


        /*
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
        */


        /////////////////////////////////////////////////////////////////////
        #endregion
    }
}
