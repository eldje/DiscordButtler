using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Discord;
using DiscordButtler.Runtime.Logging;

namespace DiscordButtler.Runtime
{
    public static class Bot
    {
        public static AuthCredentials BotCredentials { get; set; } = new AuthCredentials();

        private static DiscordClient client = new DiscordClient();

        public static async Task<bool> Run()
        {
            HookEvents();
            ExtensionLoader.LoadExtensions();

            client.ExecuteAndWait(async () =>
            {
                await client.Connect(BotCredentials.Email, BotCredentials.Password);
                HookLogging();
            });
            return true;
        }

        private static void HookLogging()
        {
            Logger.Write(LogType.Info, ModuleType.Core, $"Successfully authenticated {BotCredentials.Email}");
            Logger.Write(LogType.Info, ModuleType.Core, $"Username: {client.CurrentUser.Name}");
        }

        private static void HookEvents()
        {
            client.MessageReceived += async (s, e) =>
            {
                if (!e.Message.Text.StartsWith("!"))
                    return;

                var response = Api.ParseCommand(e.Message.Text.Replace("!", ""));
                await e.Channel.SendMessage(response);
            };
        }
    }
}
