using Inventory.Characters;
using Inventory.Core;
using Inventory.IItems;

namespace Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Artifact artifact = new Artifact() {Title = "Мефедрон", rarity = Rarities.Legend};
            Human human = new Human() {Name = "Bob", Damage = 12, Health = 100};
            human.Inventory.Add(artifact);
            human.ShowInventory()
            { 
                hu
            }
        }
    }
}
