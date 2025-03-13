using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_OOP.com.InventoryMngSystem
{
    class Product
    {
        protected int ProductID { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public Product(string name)
        {
            this.Name = name;
            Console.WriteLine("Product Constructor");
        }
        public void Show()
        {
            Console.WriteLine("Product Show");
        }

    }
}
