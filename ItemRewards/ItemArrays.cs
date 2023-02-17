using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GCrates.ItemRewards
{
    public class ItemArrays
    {
        public string Name { get; set; }

        [XmlArrayItem("ItemID")]

        public ushort[] Items { get; set; }
    }
}
