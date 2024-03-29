using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCTerminal.Structures
{
    internal interface ICommand
    {
        public abstract string Name { get; }
        public abstract string[] Alias { get; }
        public abstract string Description { get; }
        public abstract void Executor(Player Player, List<string> Args);
    }
}
