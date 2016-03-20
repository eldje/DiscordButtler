using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscordButtler.Extensions;
using System.Reflection;

namespace DiscordButtler.Runtime
{
    public static class ExtensionLoader
    {

        public static void LoadExtensions()
        {
            Type[] typelist = GetTypesInNamespace(Assembly.GetExecutingAssembly(), "DiscordButtler.Extensions");
            for (int i = 0; i < typelist.Length; i++)
            {
                if (typeof(IExtension).IsAssignableFrom(typelist[i]) && typelist[i] != typeof(IExtension)) 
                {
                    var extension = Activator.CreateInstance(typelist[i]);
                    ((IExtension)extension).Setup();
                }
            }
        }

        private static Type[] GetTypesInNamespace(Assembly assembly, string nameSpace)
        {
            return assembly.GetTypes().Where(t => string.Equals(t.Namespace, nameSpace, StringComparison.Ordinal)).ToArray();
        }
    }
}
