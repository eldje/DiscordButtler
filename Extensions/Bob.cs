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

            Api.Commands.Add(new Command
            {
                CommandDomain = CommandDomain,
                CommandString = "SayMyName",
                CommandDescription = "Shows a Description of all Commands",
                Call = new Func<string, string>(SayMyName)
            });
        }


        public static string WhoAreYou()
        {
            return "https://www.youtube.com/watch?v=KQuob3UACF8";
        }

        public static string SayMyName(string name)
        {
            return $"I say your name, {name}";
        }
    }
}