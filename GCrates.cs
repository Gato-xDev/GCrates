using GCrates.ButtonEvents;
using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCrates
{
    public class GCrates : RocketPlugin<GCratesConfiguration>
    {

        protected override void Load()
        {
            Logger.Log($"{Name} {Assembly.GetName().Version} has been loaded!");
            EffectManager.onEffectButtonClicked += Button.OnEffectButtonClicked;
        }

        protected override void Unload()
        {
            Logger.Log($"{Name} has been unloaded!");
            EffectManager.onEffectButtonClicked -= Button.OnEffectButtonClicked;
        }
    }
}
