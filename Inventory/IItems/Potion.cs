using Inventory.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.IItems
{
    internal class Potion : ISomeitems
    {
        public string Title { get; set; }
        public Rarities rarity { get; set; }
    }
}
