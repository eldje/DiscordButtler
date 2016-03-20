using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using DiscordButtler.Runtime;
using Nito.AsyncEx.Synchronous;

namespace DiscordButtler
{
    class Program
    {
        static void Main(string[] args)
        {
            Bot.Run().WaitAndUnwrapException();
        }
    }
}
