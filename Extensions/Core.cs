using DiscordButtler.Runtime;

namespace DiscordButtler.Extensions
{
    public class Core : IExtension
    {
        public string CommandDomain { get; set; } = "";

        public void Setup()
        {
            Api.Commands.Add(new Command());
        }

    }
}