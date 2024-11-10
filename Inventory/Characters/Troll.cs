using Inventory.Core;
using Inventory.IItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Characters
{
    internal class Troll : ICharacters
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public float Luck { get; set; }
        public int Damage { get; set; }
        public ICollection<ISomeitems> Inventory { get; set; } = new List<ISomeitems>();

        public void ShowInventory()
        {

            Console.WriteLine($"Инвенталь персонажа:{Name}");
            foreach (var item in Inventory)
            {
                Console.WriteLine(item.Title);
            }
        }
        public bool Steal(ICharacters target)
        {
   
            Random rand = new Random();
            bool success = rand.Next(0, 100) < Luck;

            if (success && target.Inventory.Any())
            {
                var stolenItem = target.Inventory.First();
                target.Inventory.Remove(stolenItem);
                Inventory.Add(stolenItem);
                Console.WriteLine($"{Name} успешно украл предмет {stolenItem.Title} у {target.Name}!");
            }
            else
            {
                Console.WriteLine($"{Name} не удалосьб украсть предмет у {target.Name}.");
            }

            return success;
        }
        public bool Trade(ICharacters target, ISomeitems myItem, ISomeitems targetItem)
        {
            if (Inventory.Contains(myItem) && target.Inventory.Contains(targetItem))
            {
             
                Inventory.Remove(myItem);
                target.Inventory.Remove(targetItem);

                Inventory.Add(targetItem);
                target.Inventory.Add(myItem);

                Console.WriteLine($"{Name} обменял {myItem.Title} на {targetItem.Title} с {target.Name}.");
                return true;
            }
            else
            {
                Console.WriteLine("Обмен не удался: один из предметов отсутствует в инвентаре.");
                return false;
            }
        }


    }
}
