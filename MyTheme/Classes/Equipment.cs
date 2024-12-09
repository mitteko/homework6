using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTheme
{
    
    internal class Equipment : CowshedItem
    {
        public override string name { get; }
        public override double price { get; set; } // стоимость
        public string maintenance {  get; private set; } // график обслуживания
        public string manufacture { get; private set; } // производитель

        public Equipment(string name, double price, string maintenance, string manufacture)
        {
            this.name = name;
            this.price = price;
            this.maintenance = maintenance;
            this.manufacture = manufacture;
        }

        public Equipment(string name) //консруктор для одного параметра
        {
            this.name = name;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Название оборудования: {name}, Стоимость: {price} руб, Обслуживается {maintenance}, Производитель: {manufacture}");
        }

    }
}
