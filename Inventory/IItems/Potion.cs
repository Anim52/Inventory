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
        public void Info()
        {
            switch (rarity)
            {
                case Rarities.Common:
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case Rarities.Uncommon:
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case Rarities.Rare:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case Rarities.Epic:
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case Rarities.Legend:
                    Console.ForegroundColor = ConsoleColor.Red;

                    break;
            }

            Console.WriteLine($"Предмет: {Title}, редкость: {rarity}");
            Console.ResetColor();

        }
    }
}
