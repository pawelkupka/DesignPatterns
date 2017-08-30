using System;

namespace DesignPatterns.Creational.ObjectPool
{
    public class PooledObject
    {
        public DateTime CreatedAt => DateTime.Now;
        public string TempData { get; set; }
    }
}
