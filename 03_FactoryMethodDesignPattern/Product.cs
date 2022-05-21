using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_FactoryMethodDesignPattern
{
    public interface IProduct
    {
        string Operation();
    }

    public class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "ConcreteProduct1";
        }
    }

    public class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "ConcreteProduct2";
        }
    }
}
