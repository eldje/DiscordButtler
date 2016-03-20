using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordButtler.Runtime.Logging
{
    public static class Logger
    {
        public static void Write(LogType logType, ModuleType moduleType, string messageInfo)
        {
            Console.WriteLine($"{DateTime.Now} {moduleType} {logType}: {messageInfo}");
        }
    }
}
