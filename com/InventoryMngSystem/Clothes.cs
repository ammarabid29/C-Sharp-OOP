using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_OOP.com.InventoryMngSystem
{
    class Clothes:Product
    {
        public string Color { get; set; }
        public Clothes(string n) : base(n)
        {
            Console.WriteLine("Clothes Constructor");
        }
    }
}
