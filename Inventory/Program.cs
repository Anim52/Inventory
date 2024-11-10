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
            Troll troll = new Troll() { Name ="Troll",Damage = 12, Health = 100, Luck = 10};
            Warevolf warevolf = new Warevolf() { Name = "Oboroten", Damage = 12, Health = 100, Luck = 10 };
            human.Inventory.Add(artifact);
            troll.Inventory.Add(potion);
            warevolf.Inventory.Add(resource);


            while (true)
            {
                Console.Clear();
                Console.WriteLine("Добро пожаловать!");
                Console.WriteLine("Желаете просмотреть предметы?");
                Console.WriteLine("Да или Нет?");

                string check = Console.ReadLine()?.Trim().ToLower();

                if (check == "да")
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Нажмите -> для просмотра информации о предметах.");
                        Console.WriteLine("Нажмите F для выхода.");

                        ConsoleKeyInfo keyInfo = Console.ReadKey();

                        if (keyInfo.Key == ConsoleKey.RightArrow)
                        {
                            Console.Clear();
                            artifact.Info();
                            Console.WriteLine("\nНажмите любую клавишу для перехода к следующему предмету...");
                            Console.ReadKey();

                            Console.Clear();
                            potion.Info();
                            Console.WriteLine("\nНажмите любую клавишу для перехода к следующему предмету...");
                            Console.ReadKey();

                            Console.Clear();
                            resource.Info();
                            Console.WriteLine("\nПросмотр завершен. Нажмите любую клавишу для возврата в меню.");
                            Console.ReadKey();
                        }
                        else if (keyInfo.Key == ConsoleKey.F)
                        {
                            break;
                        }
                    }
                }
                else if (check == "нет")
                {
                    Console.Clear();
                    Console.WriteLine("Желаете просмотреть инвентари персонажей?");
                    Console.WriteLine("Напишите Да, если согласны, или Нет, если не согласны.");

                    string yesOrNo = Console.ReadLine()?.Trim().ToLower();

                    if (yesOrNo == "да")
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Нажмите -> для просмотра инвентаря персонажей.");
                            Console.WriteLine("Нажмите F для завершения просмотра.");

                            ConsoleKeyInfo key = Console.ReadKey();

                            if (key.Key == ConsoleKey.RightArrow)
                            {
                                Console.Clear();
                                human.ShowInventory();
                                Console.WriteLine("\nНажмите любую клавишу для перехода к следующему персонажу...");
                                Console.ReadKey();

                                Console.Clear();
                                troll.ShowInventory();
                                Console.WriteLine("\nНажмите любую клавишу для перехода к следующему персонажу...");
                                Console.ReadKey();

                                Console.Clear();
                                warevolf.ShowInventory();
                                Console.WriteLine("\nПросмотр завершен. Нажмите любую клавишу для возврата в главное меню.");
                                Console.ReadKey();
                            }
                            else if (key.Key == ConsoleKey.F)
                            {
                                break;
                            }
                        }
                    }
                    else if (yesOrNo == "нет")
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Желаете провести кражу или обмен?");
                            Console.WriteLine("Введите 'Обмен' для обмена предметами или 'Кража' для кражи.");
                            Console.WriteLine("Введите 'Назад' для возврата в главное меню.");

                            string action = Console.ReadLine()?.Trim().ToLower();

                            if (action == "обмен")
                            {
                                Console.Clear();
                                Console.WriteLine("Человек и Тролль обмениваются предметами...");

                                // Проводим обмен между человеком и троллем
                                if (human.Inventory.Contains(artifact) && troll.Inventory.Contains(potion))
                                {
                                    human.Trade(troll, artifact, potion);
                                }
                                else
                                {
                                    Console.WriteLine("Обмен не удался: один из предметов отсутствует.");
                                }

                                Console.WriteLine("Нажмите любую клавишу для продолжения...");
                                Console.ReadKey();
                            }
                            else if (action == "кража")
                            {
                                Console.Clear();
                                Console.WriteLine("Оборотень пытается украсть предмет у Тролля...");

                                // Оборотень пытается украсть предмет у тролля
                                warevolf.Steal(troll);

                                Console.WriteLine("Нажмите любую клавишу для продолжения...");
                                Console.ReadKey();
                            }
                            else if (action == "назад")
                            {
                                break; // Выход в главное меню
                            }
                            else
                            {
                                Console.WriteLine("Неверный ввод. Пожалуйста, выберите 'Обмен', 'Кража' или 'Назад'.");
                            }
                        }
                    }
                }
            }

        }
    }
}
