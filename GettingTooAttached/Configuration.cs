﻿using Dalamud.Configuration;
using Dalamud.Plugin;
using System;

namespace GettingTooAttached
{
    [Serializable]
    public class Configuration : IPluginConfiguration
    {
        public int Version { get; set; } = 0;

        public bool enableLooping { get; set; } = false;
        public int attemptDelay { get; set; } = 500;
        public int loopAmt { get; set; } = 500;

        // the below exist just to make saving less cumbersome
        [NonSerialized]
        private DalamudPluginInterface? PluginInterface;

        public void Initialize(DalamudPluginInterface pluginInterface)
        {
            this.PluginInterface = pluginInterface;
        }

        public void Save()
        {
            this.PluginInterface!.SavePluginConfig(this);
        }
    }
}
