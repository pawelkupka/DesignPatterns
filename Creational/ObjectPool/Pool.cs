using System.Collections.Generic;

namespace DesignPatterns.Creational.ObjectPool
{
    public static class Pool
    {
        private static List<PooledObject> _available = new List<PooledObject>();
        private static List<PooledObject> _inUse = new List<PooledObject>();

        public static PooledObject GetObject()
        {
            lock (_available)
            {
                if (_available.Count != 0)
                {
                    var pooledObject = _available[0];
                    _inUse.Add(pooledObject);
                    _available.RemoveAt(0);
                    return pooledObject;
                }
                else
                {
                    var pooledObject = new PooledObject();
                    _inUse.Add(pooledObject);
                    return pooledObject;
                }
            }
        }

        public static void ReleaseObject(PooledObject pooledObject)
        {
            CleanUp(pooledObject);
            lock (_available)
            {
                _available.Add(pooledObject);
                _inUse.Remove(pooledObject);
            }
        }

        private static void CleanUp(PooledObject pooledObject)
        {
            pooledObject.TempData = null;
        }
    }
}
