using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tumakov
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Task1();
            Task2();
            Task3();
            Task4();

        }



        /* 7.1 Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип
       банковского счета(использовать перечислимый тип из упр. 3.1). Предусмотреть методы для
       доступа к данным – заполнения и чтения.Создать объект класса, заполнить его поля и
       вывести информацию об объекте класса на печать. */
        static void Task1()
        {
            Console.WriteLine("Номер 7.1");

            Bank bank = new Bank();

            bool Flag = true;
            while (Flag)
            {
                Console.WriteLine("Введите номер счета: ");
                uint id = uint.Parse(Console.ReadLine());

                bank.Information(id);

                Console.WriteLine("Введите баланс на вашем счету: ");
                double balance = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите тип счёта. \n0 - Текущий, 1 - Сберегательный");
                char numType = char.Parse(Console.ReadLine());
                switch (numType)
                {
                    case '0':
                        bank.VvodInformation(balance, accountType.текущий);
                        break;
                    case '1':
                        bank.VvodInformation(balance, accountType.cберегательный);
                        break;
                    default:
                        Console.WriteLine("Вы ввели не то число");
                        break;

                }
                bank.Print();
                break;
            }

        }


        /* 7.2 Изменить класс счет в банке из упражнения 7.1 таким образом, чтобы
        номер счета генерировался сам и был уникальным. Для этого надо создать в классе
        статическую переменную и метод, который увеличивает значение этого переменной.*/
        static void Task2()
        {
            Console.WriteLine("Номер 7.2");

            Bank bank = new Bank();

            bool Flag = true;
            while (Flag)
            {
                Console.WriteLine("Введите номер счета: ");
                uint id = uint.Parse(Console.ReadLine());

                bank.Information(id);

                Console.WriteLine("Введите баланс на вашем счету: ");
                double balance = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите тип счёта. \n0 - Текущий, 1 - Сберегательный");
                char numType = char.Parse(Console.ReadLine());
                switch (numType)
                {
                    case '0':
                        bank.VvodInformation(balance, accountType.текущий);
                        break;
                    case '1':
                        bank.VvodInformation(balance, accountType.cберегательный);
                        break;
                    default:
                        Console.WriteLine("Некорректный ввод");
                        break;

                }
                bank.Print();
                break;
            }
        }


        /* 7.3 Добавить в класс счет в банке два метода: снять со счета и положить на
        счет. Метод снять со счета проверяет, возможно ли снять запрашиваемую сумму, и в случае
        положительного результата изменяет баланс.*/
        static void Task3()
        {
            Console.WriteLine("Номер 7.2");

            Bank bank = new Bank();

            bool Flag = true;
            while (Flag)
            {
                Console.WriteLine("Введите номер счета: ");
                uint id = uint.Parse(Console.ReadLine());

                bank.Information(id);

                Console.WriteLine("Введите баланс на вашем счету: ");
                double balance = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите тип счёта. \n0 - Текущий, 1 - Сберегательный");
                char numType = char.Parse(Console.ReadLine());
                switch (numType)
                {
                    case '0':
                        bank.VvodInformation(balance, accountType.текущий);
                        break;
                    case '1':
                        bank.VvodInformation(balance, accountType.cберегательный);
                        break;
                    default:
                        Console.WriteLine("Вы ввели не то число");
                        break;

                }
                bank.Print();

                Console.WriteLine("Напишите 0, если хотите снять со счета, и 1, если хотите положить на счет");
                double sum;
                switch (char.Parse(Console.ReadLine()))
                {
                    case '0':
                        sum = double.Parse(Console.ReadLine());
                        bank.Input(sum);
                        break;
                    case '1':
                        sum = double.Parse(Console.ReadLine());
                        bank.Output(sum);
                        break;
                    default:
                        Console.WriteLine("Некорректный ввод");
                        break;
                }
                bank.Print();
            }
        }

        /*Домашнее задание 7.1 Реализовать класс для описания здания (уникальный номер здания,
        высота, этажность, количество квартир, подъездов). Поля сделать закрытыми,
        предусмотреть методы для заполнения полей и получения значений полей для печати.
        Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества
        квартир на этаже и т.д. Предусмотреть возможность, чтобы уникальный номер здания
        генерировался программно. Для этого в классе предусмотреть статическое поле, которое бы
        хранило последний использованный номер здания, и предусмотреть метод, который
        увеличивал бы значение этого поля.*/
        static void Task4()
        {
            Console.WriteLine("Номер 7.1");

            House house = new House();

            bool Flag = true;
            while (Flag)
            {
                Console.WriteLine("Введите номер здания: ");
                uint numOfHouse = uint.Parse(Console.ReadLine());
                Console.WriteLine("Введите высоту здания: ");
                ushort highOfHouse = ushort.Parse(Console.ReadLine());
                Console.WriteLine("Введите этажность здания: ");
                ushort floorsOfHouse = ushort.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество квартир в здании: ");
                ushort flatsOfHouse = ushort.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество подъездов в здании: ");
                ushort entranceOfHouse = ushort.Parse(Console.ReadLine());

                house.Information();
                house.CalculatingTheHeighFloor();
                house.CalculatingThecountFlatsInEntrance();
                house.CalculatingThecountFlatsInFloor();
            }
        }
    }
}
