using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCTerminal.Structures
{
    internal interface ITerminal
    {
        public abstract int Id { get; }
        public abstract Player Owner { get; }
        public abstract List<TerminalFeatures> Features { get; }
        public abstract Dictionary<string, string> Files { get; }
        public abstract List<ICommand> Commands { get; }
    }
}
