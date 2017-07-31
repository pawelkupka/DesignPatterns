using System;

namespace DesignPatterns.Creational.Singleton
{
    public class LazylyInitializedSingleton
    {
        private static LazylyInitializedSingleton _instance;

        private LazylyInitializedSingleton() { }

        public static LazylyInitializedSingleton Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LazylyInitializedSingleton();
                return _instance;
            }
        }

        public void SayHelloWorld()
        {
            Console.WriteLine("Hello world!");
        }
    }
}
