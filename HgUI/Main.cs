using Rocket.API;
using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using SDG.Unturned;
using Steamworks;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Alosha 
{
    public class Main : RocketPlugin<myConfig>
    {
        protected override void Load()
        {
            base.Load();
            U.Events.OnPlayerConnected += Events_OnPlayerConnected;
            EffectManager.onEffectButtonClicked += botn;
        }
        void botn(Player caller, string button)
        {
            if(button == "HgUI_Button_K")
            {
                var player = UnturnedPlayer.FromPlayer(caller);
                EffectManager.askEffectClearByID(Configuration.Instance.id, player.CSteamID);
                caller.serversideSetPluginModal(false);
            }
        }

        private void Events_OnPlayerConnected(UnturnedPlayer player)
        {
            EffectManager.sendUIEffect(Configuration.Instance.id, 909, player.CSteamID, true, Configuration.Instance.SunucuIsmi, Configuration.Instance.Alt_baslik);
            EffectManager.sendUIEffectImageURL(909, player.CSteamID, true, "my_sunucuLogusu", Configuration.Instance.SunucuLogosu);
            player.Player.serversideSetPluginModal(true);
        }

        protected override void Unload()
        {
            base.Unload();
            U.Events.OnPlayerConnected -= Events_OnPlayerConnected;
            EffectManager.onEffectButtonClicked -= botn;
        }
    }
}
