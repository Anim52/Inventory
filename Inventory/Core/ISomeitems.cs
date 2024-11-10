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
        public Rarities rarities { get; set;}

        void Info()
        {
            switch (rarities)
            {
                case Rarities.Common:
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case Rarities.Uncommon:
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
                case Rarities.Rare:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                case Rarities.Epic:
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    break;
                case Rarities.Legend:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
            }

            Console.WriteLine($"Предмет:{Title} редкость:{rarities}");
        }

    }
}
