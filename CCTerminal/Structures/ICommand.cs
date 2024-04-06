using Exiled.API.Features;
using System;
using System.Collections.Generic;

namespace CCTerminal.Structures
{
    internal interface ICommand
    {
        public abstract CommandType Type { get; }
        public abstract string Name { get; }
        public abstract string[] Alias { get; }
        public abstract string Description { get; }
        public abstract float Cooldown { get; }
        public abstract string CooldownMessage { get; }
        public abstract float BatteryConsume { get; }
        public abstract List<TerminalFeatures> Permissions { get; }
        public abstract Action<Player, List<string>> Executor { get; }
    }
}
