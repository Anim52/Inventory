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
            Potion potion = new Potion() {Title = "Герыч", rarity = Rarities.Uncommon};
            Resource resource = new Resource() {Title = "Кокаин",rarity = Rarities.Rare};
            Human human = new Human() {Name = "Bob", Damage = 12, Health = 100,Luck = 10};
            Troll troll = new Troll() { Name ="Troll",Damage = 12, Health = 100, Luck = 1010};
            human.Inventory.Add(artifact);
            human.Inventory.Add(potion);
            troll.Inventory.Add(potion);
            troll.Inventory.Add(resource);

            human.Trade(troll, artifact, potion);
        }
    }
}
