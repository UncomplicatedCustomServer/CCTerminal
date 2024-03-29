using Exiled.API.Features;
using MapGeneration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCTerminal
{
    internal class Plugin : Plugin<Config>
    {
        public override string Prefix => "CCTerminal";
        public override string Author => "FoxWorn3365";
        public override string Name => "CCTerminal";
        public override Version Version => new(0, 5, 0);
        public override Version RequiredExiledVersion => new(8, 8, 0);
        public static Plugin Instance;
        public static Terminal
        public override void OnEnabled()
        {
            base.OnEnabled();
        }
    }
}
