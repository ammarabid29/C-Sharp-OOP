using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_OOP.com.Decepticon
{
    abstract class Transformer
    {
        public Transformer()
        {
            Console.WriteLine("Transformer Constructor");
        }
        public abstract void Run();
        public void Show()
        {
            Console.WriteLine("Transformer is running");
        }
    }

    //class Car : Transformer
    //{
    //    public override void Run()
    //    {
    //        Console.WriteLine("Car is running");
    //    }
    //}
}
