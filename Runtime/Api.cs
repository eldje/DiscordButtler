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

        public static string ParseCommand(string[] commandParams)
        {
            try
            {
                var namespaces = Commands.FindAll(x => string.Equals(x.CommandDomain, commandParams[0], StringComparison.CurrentCultureIgnoreCase));
                if (namespaces.Count == 0)
                {
                    return "Sorry, i could'nt understand!";
                }

                var command = namespaces.Find(x => string.Equals(x.CommandString, commandParams[1], StringComparison.CurrentCultureIgnoreCase));


                List<string> args = new List<string>();
                for(int i = 2; i < commandParams.Length; i++)
                    args.Add(commandParams[i]);
                
                return command?.Call.Method.Invoke(new object(), args.ToArray()).ToString() ?? "Sorry, i could'nt understand!";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
