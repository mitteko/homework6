using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static Tumakov.Program;

namespace Tumakov
{
    public enum accountType
    {
        cберегательный,
        текущий
    }

    internal class Bank
    {

        private uint id;
        private double balance;
        private accountType isaccType;
        private static uint idgen;




        public void Information(uint isid)
        {
            this.id = isid;
  
        }

        public void VvodInformation(double balance, accountType istype)
        {
            this.balance = balance;
        }




        public void InformationForGen(uint isid)
        {
            this.id = IdForGen();

        }

        private uint IdForGen()
        {
            idgen++;
            return idgen;
        }



        public void Input(double summa)
        {
            if (summa<balance) 
            {
                this.balance -= summa;
                Console.WriteLine("Деньги успешно сняты!");
            }
            else
            {
                Console.WriteLine("На счете недостаточно средств");
            }
        }

        public void Output(double summa)
        {
            this.balance += summa;
            Console.WriteLine("Счет успешно пополнен!");
        }
        



        public void Print()
        {
            Console.WriteLine($"Номер счета: {id}\nБаланс: {balance}\nТип банковского счета: {isaccType}");
        }

        
    }
    
}
