using System;
using DiscordButtler.Runtime;

namespace DiscordButtler.Extensions
{
    public class Core : IExtension
    {
        public string CommandDomain { get; set; } = "";

        public void Setup()
        {
            Api.Commands.Add(new Command
            {
                CommandDomain = CommandDomain,
                CommandString = "help",
                CommandDescription = "Shows a Description of all Commands",
                Call = new Func<string>(Help)
            });
        }


        public static string Help()
        {
            return "Works! Hi from eldje";
        }
    }
}