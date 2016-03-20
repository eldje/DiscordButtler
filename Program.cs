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
            try
            {
                Bot.Run().WaitAndUnwrapException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.Read();
        }
    }
}
