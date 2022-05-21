using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_FactoryMethodDesignPattern
{
    public interface ICreator
    {
        IProduct FactoryMethod();        
    }

    public class ConcreteCreator1 : ICreator
    {
        public IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }

    public class ConcreteCreator2 : ICreator
    {
        public IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
