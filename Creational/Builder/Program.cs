using System;

namespace DesignPatterns.Creational.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConcreteProductBuilder(); // builder is an interface for creating object (Product).
            var director = new ProductBuildDirector(); // director provides construction plan for builder
            director.Construct(builder);
            var product = builder.GetResult();

            Console.WriteLine(product.ToString());
        }
    }
}
