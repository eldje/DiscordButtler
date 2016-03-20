using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscordButtler.Extensions;

namespace DiscordButtler.Runtime
{
    public static class ExtensionLoader
    {

        public static void LoadExtensions()
        {
            Core coreModule = new Core();
            coreModule.Setup();
        }
    }
}
