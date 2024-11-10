using Inventory.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Characters
{
    internal class Human : ICharacters
    {
        public string Name { get ; set ; }
        public int Health { get ; set ; }
        public float Luck { get ; set ; }
        public int Damage { get ; set ; }
        public ICollection<ISomeitems> Inventory { get ; set ; } = new List<ISomeitems>();
   
        public void ShowInventory()
        {
            
            Console.WriteLine($"Инвенталь персонажа:{Name}");
            foreach ( var item in Inventory )
            {
                Console.WriteLine(item.Title);
            }
        }
        public bool Steal(ICharacters target)
        {
            // Simple steal logic based on luck
            Random rand = new Random();
            bool success = rand.NextDouble() < (Luck / 100.0);

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
    }
}
