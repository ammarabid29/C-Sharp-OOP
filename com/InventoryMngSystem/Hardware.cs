using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_OOP.com.InventoryMngSystem
{
    class Hardware:Product
    {
        public int Size { get; set; }
        public Hardware(string name,int id):base(name)
        {
            this.ProductID = id;
            Console.WriteLine("Hardware Constructor");
        }
        public void Details()
        {
            Console.WriteLine($"ProductId: {this.ProductID}");
        }
        //public new void Show()
        //{
        //    Console.WriteLine("Hardware Show");
        //}

    }
}
