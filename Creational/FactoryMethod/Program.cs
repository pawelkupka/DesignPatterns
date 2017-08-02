using System;

namespace DesignPatterns.Creational.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var creator = new Creator();
            var product1 = creator.FactoryMethod(ProductType.Product1); // factory method creates objects without having to specify 
            var product2 = creator.FactoryMethod(ProductType.Product2); // the exact class of the object that will be created

            Console.WriteLine(product1.Name);
        }
    }
}
