using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Core
{
    internal interface ICharacters
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public float Luck { get; set; }
        public int Damage { get; set; }
        public ICollection<ISomeitems> Inventory { get; set; }

    }
}
