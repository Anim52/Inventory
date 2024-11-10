using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Core
{
    public enum Rarities {Common,Umcommon,Rare,Epic,Legend}
    internal interface ISomeitems
    {
        public string Title { get; set; }
        public Rarities rarities { get; set;}

        void Info()
        {
            if(rarities == Rarities.Common)
            {
                Console.BackgroundColor = ConsoleColor.White;
            }
            if(rarities == Rarities.Umcommon)
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            if(rarities == Rarities.Rare)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            if(rarities == Rarities.Epic)
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
            }
            if (rarities == Rarities.Legend)
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }

            Console.WriteLine($"Предмет:{Title} редкость:{rarities}");
        }

    }
}
