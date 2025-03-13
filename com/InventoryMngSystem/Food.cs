using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_OOP.com.InventoryMngSystem
{
    // sealed class can't be inherited
    sealed class Food:Product
    {
        public DateTime ExpiryDate { get; set; }
        public Food(string n):base(n)
        {
            Console.WriteLine("Food Constructor");
        }
    }
}
