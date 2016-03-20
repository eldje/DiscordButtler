using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands.Permissions.Visibility;

namespace DiscordButtler.Extensions
{
    public interface IExtension
    {
        void Setup();
        string CommandDomain { get; set; }
    }
}
