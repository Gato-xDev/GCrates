using Rocket.Core.Logging;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCrates.ButtonEvents
{
    public class Button
    {
        public static void OnEffectButtonClicked(Player player, string buttonName)
        {
            if (buttonName == "open_1")
            {
                if (true)
                {
                    // check if player has required item

                    // do some magic 
                    Logger.Log("Gato is crazy!");
                }
            }
        }
    }
}
