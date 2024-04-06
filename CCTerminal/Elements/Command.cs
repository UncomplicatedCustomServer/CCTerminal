using CCTerminal.Structures;
using Exiled.API.Features;
using System;
using System.Collections.Generic;

namespace CCTerminal.Elements
{
    internal class Command : ICommand
    {
        public CommandType Type { get; }

        public string Name { get; }

        public string[] Alias { get; }

        public string Description { get; }

        public float Cooldown { get; }

        public string CooldownMessage { get; }

        public float BatteryConsume { get; }

        public List<TerminalFeatures> Permissions { get; set; }

        public Action<Player, List<string>> Executor { get; internal set; }

        public Command(CommandType type, string name, string[] alias, string description, float cooldown, string cooldownMessage, float batteryConsume, List<TerminalFeatures> permissions, Action<Player, List<string>> executor)
        {
            Type = type;
            Name = name;
            Alias = alias;
            Description = description;
            Cooldown = cooldown;
            CooldownMessage = cooldownMessage;
            BatteryConsume = batteryConsume;
            Permissions = permissions;
            Executor = executor;
        }
    }
}
