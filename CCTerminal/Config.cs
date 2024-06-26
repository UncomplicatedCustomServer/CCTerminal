﻿using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCTerminal
{
    internal class Config : IConfig
    {
        [Description("Is the plugin enabled?")]
        public bool IsEnabled { get; set; } = true;
        [Description("Do enable the developer (debug) mode")]
        public bool Debug { get; set; } = false;
        [Description("The battery amout that will be removed every tick (1s)")]
        public float TickBattery { get; set; } = 0.3f;
    }
}
