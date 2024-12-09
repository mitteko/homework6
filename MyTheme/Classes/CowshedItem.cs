using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTheme
{
    internal abstract class CowshedItem
    {
        //коровы, оборудование и специальности
        public abstract string name { get; } 
        public abstract double price { get; set; }

        //список коров
        protected static List<Cows> cows { get; } = new List<Cows>
            {
                new Cows("Голштинская корова", 150, 7000, 3.8, 3.2),
                new Cows("Джерсейская корова", 400, 3000, 6, 3.9),
                new Cows("Айрширская корова", 230, 7000, 5, 3.5)
            };

        //список оборудования
        protected static List<Equipment> equipment = new List<Equipment>
            {
                new Equipment("Доильный аппарат", 25000, "каждые 6 месяцев", "DairyTech"),
                new Equipment("Водопоилка", 7000, "каждые 6 месяцев", "AgriSupply"),
                new Equipment("Кормушка", 5000, "каждые 12 месяцев", "FarmEquip")
            };

        //список профессий в коровнике
        protected static List<Employees> employees = new List<Employees>
            {
                new Employees("Дояр", 50000, 6),
                new Employees("Кормилец", 38000, 6),
                new Employees("Ветеринар", 80000, 5)
            };

        public abstract void PrintInfo();
    }
}
