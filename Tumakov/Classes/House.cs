using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov
{
    internal class House
    {

        private static uint intGen = 1;

        private uint num;
        private ushort hightOfHouse;
        private int floor;
        private int flatsOfHouse;
        private int entranceOfHouse;


        public House()
        {
            num = intGen++;

            this.hightOfHouse = hightOfHouse;
            this.floor = floor;
            this.flatsOfHouse = flatsOfHouse;
            this.entranceOfHouse = entranceOfHouse;
        }
        public void Information()
        {
            ShowMessage($"Номер здания: {num}\nВысота здания: {hightOfHouse}\nКоличество этажей: {floor}\nКоличество квартир: {flatsOfHouse}\nКоличество подъездов: {entranceOfHouse}");
        }

        private void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void CalculatingTheHeighFloor()
        {
            float heightFloor = hightOfHouse / floor;
            Console.WriteLine($"Высота этажа: {heightFloor:F1}");
        }

        public void CalculatingThecountFlatsInEntrance()
        {
            int countFlatsInEntrance = flatsOfHouse / entranceOfHouse;
            Console.WriteLine($"Количество квартир в подъезде: {countFlatsInEntrance}");

        }

        public void CalculatingThecountFlatsInFloor()
        {
            int countFlatsInFloor = flatsOfHouse / entranceOfHouse / floor;
            Console.WriteLine($"Количество квартир на этаже: {countFlatsInFloor}");

        }

    }
}
