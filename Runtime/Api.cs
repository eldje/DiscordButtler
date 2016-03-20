using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DiscordButtler.Runtime
{
    public static class Api
    {
        public static List<Command> Commands { get; set; }= new List<Command>();

        public static string ParseCommand(string imperative)
        {
            try
            {
                var command = Commands.Find(x => x.CommandString == imperative);

                if (command == null)
                {
                    return "Sorry, i could'nt understand!";
                }

                return command.Call.Method.Invoke(new object(), new object[] {}).ToString();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
