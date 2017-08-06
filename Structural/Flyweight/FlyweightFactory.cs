using System.Collections.Generic;

namespace DesignPatterns.Structural.Flyweight
{
    public class FlyweightFactory
    {
        private readonly IDictionary<string, IFlyweight> _cache;

        public FlyweightFactory()
        {
            _cache = new Dictionary<string, IFlyweight>();
        }

        public IFlyweight GetFlyweight(string key)
        {
            if (!_cache.ContainsKey(key))
                _cache.Add(key, new Flyweight(key));
            return _cache[key];
        }


    }
}
