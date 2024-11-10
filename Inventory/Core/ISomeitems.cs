using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Core
{
    public enum Rarities {Common,Uncommon,Rare,Epic,Legend}
    internal interface ISomeitems
    {
        public string Title { get; set; }
        public Rarities rarity { get; set; }


        public void Info()
        {
        }
    }
    
    
}
