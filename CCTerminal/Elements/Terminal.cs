using CCTerminal.Structures;
using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCTerminal.Elements
{
    internal class Terminal : ITerminal
    {
        public int Id { get; }

        public Player Owner { get; }

        public float Battery { get; internal set; }

        public bool IsActive { get; set; }

        public List<TerminalFeatures> Features { get; }

        public Dictionary<string, string> Files { get; internal set; }

        public List<ICommand> Commands { get; internal set; }

        public Dictionary<ICommand, ulong> CommandCooldownHandler { get; internal set; } = new();

        public Terminal(int id, Player owner, List<TerminalFeatures> features, Dictionary<string, string> files, List<ICommand> commands)
        {
            Id = id;
            Owner = owner;
            Features = features;
            Files = files;
            Commands = commands;
            Battery = 100;
            IsActive = false;
        }

        public Terminal(int id, Player owner, List<TerminalFeatures> features, List<ICommand> commands)
        {
            Id = id;
            Owner = owner;
            Features = features;
            Files = new();
            Commands = commands;
            Battery = 100;
            IsActive = false;
        }

        public void Execute(string CommandInput)
        {
            if (!IsActive)
            {
                return;
            }
            List<string> Command = CommandInput.ToLower().Split(' ').ToList();
            ICommand CommandData = Commands.Where(cmd => cmd.Name == Command[0]).FirstOrDefault();
            if (CommandData is default(ICommand))
            {
                // Not found
                Owner.SendConsoleMessage($"Sorry but the command '{Command[0]}' does not exists!");
            } 
            else
            {

            }
        }

        public void Tick()
        {
            if (IsActive)
            {
                Battery =- Plugin.Instance.Config.TickBattery;
            }
        }
    }
}
