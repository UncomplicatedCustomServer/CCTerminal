using CCTerminal.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCTerminal.Elements
{
    internal class StringCommand : IStringCommand
    {
        public string Name { get; set; } = "uwu";

        public string Description { get; set; } = "A command to uwu people";

        public string[] Alias { get; set; } = new string[0];

        public List<TerminalFeatures> Permissions { get; set; } = new()
        {
            TerminalFeatures.Base
        };

        public float Cooldown { get; set; } = 10f;

        public string CooldownMessage { get; set; } = "Sorry but you need to wait %cooldown% seconds!";

        public string Response { get; set; } = "OH NO UWUWUWUWUWUWUUW";

    }
}
