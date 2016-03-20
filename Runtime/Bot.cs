using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Discord;

namespace DiscordButtler.Runtime
{
    public static class Bot
    {
        public static AuthCredentials BotCredentials { get; } = new AuthCredentials();

        private static DiscordClient client = new DiscordClient();

        public static async Task<bool> Run()
        {
            await client.Connect(BotCredentials.Email, BotCredentials.Password);
            HookLogging();
            return true;
        }

        private static void HookLogging()
        {
            
        }

    }
}
