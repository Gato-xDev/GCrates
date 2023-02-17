using Rocket.API;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace GCrates.Commands
{
    public class GCratesCommand : IRocketCommand 
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "lootboxes";

        public string Help => "";

        public string Syntax => "";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string>();

        public void Execute(IRocketPlayer caller, string[] command)
        {
            if (caller is UnturnedPlayer player)
            {
                int lowTierCases = 0;
                int highTierCases = 0;
                for (byte p = 0; p < PlayerInventory.PAGES - 2; p++)
                {
                    var itemJars = player.Player.inventory.items[p].items;
                    if (itemJars == null) continue;

                    foreach (var item in itemJars)
                    {
                        if(item.item.id == lowTierCaseID) lowTierCases++;
                        if(item.item.id == highTierCaseID) highTierCases++;
                    }
                }
                EffectManager.sendUIEffect(23423, 999, player.Player.channel.owner.transportConnection, true, lowTierCases.ToString(), highTierCases.ToString());
            }
        }
    }
}
