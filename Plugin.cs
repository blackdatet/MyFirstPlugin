using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstPlugin
{
    internal class Plugin : RocketPlugin<Config>
    {
        public static Plugin Instance;

        protected override void Load()
        {
            Instance = this;
            U.Events.OnPlayerConnected += Events_OnPlayerConnected;
        }

        private void Events_OnPlayerConnected(UnturnedPlayer player)
        {
            EffectManager.sendUIEffect(Instance.Configuration.Instance.EffectID, Instance.Configuration.Instance.LayerID, player.CSteamID, true);
        }

        protected override void Unload()
        {
            
        }
    }
}
