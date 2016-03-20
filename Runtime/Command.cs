using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordButtler.Runtime
{
    public class Command
    {
        public string CommandDomain { get; set; }
        public string CommandString { get; set; }
        public string CommandDescription { get; set; }
        public Delegate Call { get; set; }
    }
}
