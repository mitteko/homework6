﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyTheme
{

    internal class Cows : CowshedItem
    {
        public int countOfCows { get; private set; }
        public override string name { get; } // вид коровы
        public override double price { get; set; } // цена (руб/кг)
        public double yields { get; private set; } // удои (кг/год)
        public double fatness { get; private set; } // жирность молока (%)
        public double protein { get; private set; } // белок (%)

        public Cows(string name, double price, double yields, double fatness, double protein)
        {
            this.name = name;
            this.price = price;
            this.yields = yields;
            this.fatness = fatness;
            this.protein = protein;
        }

        public Cows(string name) //консруктор для одного параметра
        {
            this.name = name;
        }

        public void CountOfCows(List<Cows> cows)
        {
            countOfCows=cows.Count; // сколько разновидностей коров в коровнике
        }

        public void UpdatePrice(double newPrice)
        {
            price = newPrice; // изменение стоимости коровы
        }

        public void UpdateYields(double newYields)
        {
            yields = newYields; // изменение удоев в год
        }

        public string GetInfo()
        {
            return $"Вид коровы: {name}, Цена: {price} руб/кг, Удои: {yields} кг/год, Жирность: {fatness}%, Белок: {protein}%";
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Вид коровы: {name}, Цена: {price} руб/кг, Удои: {yields} кг/год, Жирность: {fatness}%, Белок: {protein}%");
        }
    }
}
