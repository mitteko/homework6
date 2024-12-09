using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTheme
{
    internal class Employees : CowshedItem
    {
        private double weeklySalary;

        public override string name { get; } // профессия
        public override double price { get; set; } // зарплата сотрудника
        public ushort days { get; set; } // сколько дней в неделю работает

        public Employees(string name, double price, ushort days)
        {
            this.name = name;
            this.price = price;
            this.days = days;
        }

        public Employees(string name)
        {
            this.name = name;
        }

        public void UpdatePrice(double newPrice)
        {
            price = newPrice; // обновление зарплаты
        }

        public void UpdateDays(ushort newDays)
        {
            days = newDays; // изменение графика
        }

        public void WeeklySalary(double price)
        {
            weeklySalary=price/4; // доход в неделю
        }

        public string GetInfo()
        {
            return $"Специальность: {name}, Зарплата: {price} в месяц, Работает {days} дней в неделю";
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Специальность: {name}, Зарплата: {price} в месяц, Работает {days} дней в неделю");
        }
    }
}
