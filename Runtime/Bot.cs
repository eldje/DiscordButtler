using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Discord;
using DiscordButtler.Runtime.Logging;
using Newtonsoft.Json;

namespace DiscordButtler.Runtime
{
    public static class Bot
    {
        public static AuthCredentials BotCredentials { get; set; } = new AuthCredentials();

        private static DiscordClient client = new DiscordClient();

        public static async Task<bool> Run()
        {
            LoadCredentials();

            HookEvents();
            ExtensionLoader.LoadExtensions();

            client.ExecuteAndWait(async () =>
            {
                await client.Connect(BotCredentials.Email, BotCredentials.Password);

                Logger.Write(LogType.Info, ModuleType.Core, $"Successfully authenticated {BotCredentials.Email}");
                Logger.Write(LogType.Info, ModuleType.Core, $"Username: {client.CurrentUser.Name}");
            });
            return true;
        }

        private static void LoadCredentials(string filename = "Data/Credentials.json")
        {
            var fs = new FileStream(filename, FileMode.Open);
            var streamReader = new StreamReader(fs);

            if (!fs.CanRead || !File.Exists(filename))
            {
                Logger.Write(LogType.Error, ModuleType.Core, "Cannot read Configs! Make sure you renamed Credentials.json.dist!");
                throw new FileLoadException();
            }

            BotCredentials = JsonConvert.DeserializeObject<AuthCredentials>(streamReader.ReadToEnd());
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
