using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTheme
{
    internal abstract class CowshedItem
    {
        //коровы и оборудование
        public abstract string name { get; } 
        public abstract double price { get; set; }

        public abstract void PrintInfo();
    }
}
