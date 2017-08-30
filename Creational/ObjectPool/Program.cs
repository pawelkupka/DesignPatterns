using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.ObjectPool
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object pool pattern uses a set of initialized objects 
            // kept ready to use – a "pool" – rather than allocating and destroying them on demand
            var pooledObject = Pool.GetObject();
            pooledObject.TempData = "Hello World!";
            Pool.ReleaseObject(pooledObject);
        }
    }
}
