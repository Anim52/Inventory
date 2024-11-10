using Inventory.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.IItems
{
    internal class Artifact : ISomeitems
    {
        public string Title { get; set; }
        public Rarities rarities { get; set; }
    }
}
