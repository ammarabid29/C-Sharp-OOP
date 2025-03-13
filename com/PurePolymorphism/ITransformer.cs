using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_OOP.com.PurePolymorphism
{
    interface ITransformer
    {
        void Run();
    }
    interface IExample
    {
        void Run();
    }
    //multiple class can't be inherited in c# but interface can 
    class Car : ITransformer, IExample
    {
        void ITransformer.Run()
        {
           Console.WriteLine("Run ITransformer");
        }

        void IExample.Run()
        {
           Console.WriteLine("Run IExample");
        }
    }
}
