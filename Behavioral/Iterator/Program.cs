using System;

namespace DesignPatterns.Behavioral.Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Iterator pattern is used to traverse a container and access the container's elements
            var collection = new Collection() { "element1", "element2", "element3" };
            foreach (var element in collection)
                Console.WriteLine(element);
        }
    }
}
