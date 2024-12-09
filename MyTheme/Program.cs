using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTheme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //список коров
            List<Cows> cows = new List<Cows>
            {
                new Cows("Голштинская корова", 150, 7000, 3.8, 3.2),
                new Cows("Джерсейская корова", 400, 3000, 6, 3.9),
                new Cows("Айрширская корова", 230, 7000, 5, 3.5)
            };

            //список оборудования
            List<Equipment> equipment = new List<Equipment>
            {
                new Equipment("Доильный аппарат", 25000, "каждые 6 месяцев", "DairyTech"),
                new Equipment("Водопоилка", 7000, "каждые 6 месяцев", "AgriSupply"),
                new Equipment("Кормушка", 5000, "каждые 12 месяцев", "FarmEquip")
            };

            Console.WriteLine("Какую информацию вы хотите узнать? 1 - коровы, 2 - оборудование");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("Выберите вид коровы:");
                    for (int i = 0; i < cows.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}: {cows[i].name}");
                    }
                    int choiseCow = int.Parse(Console.ReadLine())-1;
                    cows[choiseCow].PrintInfo();
                    break;
                case 2:
                    Console.WriteLine("Выберите оборудование:");
                    for (int i = 0; i < equipment.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}: {equipment[i].name}");
                    }
                    int choiseEquip = int.Parse(Console.ReadLine())-1;
                    equipment[choiseEquip].PrintInfo();
                    break;
                default:
                    Console.WriteLine("Некорректные данные");
                    break;
            }

            Console.ReadKey();

        }
    }
}
