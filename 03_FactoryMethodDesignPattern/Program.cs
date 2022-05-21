using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_FactoryMethodDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ConcreteCreator1");
            IProduct product1 = new ConcreteCreator1().FactoryMethod();
            Console.WriteLine("Created {0}", product1.Operation());
            Console.WriteLine("");
            Console.WriteLine("ConcreteCreator2");
            IProduct product2 = new ConcreteCreator2().FactoryMethod();
            Console.WriteLine("Created {0}", product2.Operation());    
            Console.ReadLine();
        }
    }
}
