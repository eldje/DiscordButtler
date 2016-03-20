using System;
using DiscordButtler.Runtime;

namespace DiscordButtler.Extensions
{
    public class Bob : IExtension
    {
        public string CommandDomain { get; set; } = "bob";

        public void Setup()
        {
            Api.Commands.Add(new Command
            {
                CommandDomain = CommandDomain,
                CommandString = "whoareyou",
                CommandDescription = "Shows a Description of all Commands",
                Call = new Func<string>(WhoAreYou)
            });
        }


        public static string WhoAreYou()
        {
            return "https://www.youtube.com/watch?v=KQuob3UACF8";
        }
    }
}