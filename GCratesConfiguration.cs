using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GCrates.ItemRewards;

namespace GCrates
{
    public class GCratesConfiguration : IRocketPluginConfiguration
    {

        public string LoadMessage { get; set; }

        public ItemArrays[] Rewards { get; set; }

        public void LoadDefaults()
        {
            Rewards = new ItemArrays[]
            {
                new ItemArrays()
                {
                    Name = "default",
                    
                    Items =  new ushort[]
                    {
                        363,
                        6,
                        6
                    }
                }
            }
        }
    }
}
