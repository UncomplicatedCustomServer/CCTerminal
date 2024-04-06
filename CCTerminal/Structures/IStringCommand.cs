using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCTerminal.Structures
{
    internal interface IStringCommand
    {
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }
        public abstract string[] Alias { get; set; }
        public abstract List<TerminalFeatures> Permissions { get; set; }
        public abstract float Cooldown { get; set; }
        public abstract string CooldownMessage { get; set; }
        public abstract string Response { get; set; }
    }
}
