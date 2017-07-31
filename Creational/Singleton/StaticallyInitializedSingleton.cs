using System;

namespace DesignPatterns.Creational.Singleton
{
    public class StaticallyInitializedSingleton
    {
        private static readonly StaticallyInitializedSingleton _instance = new StaticallyInitializedSingleton();

        private StaticallyInitializedSingleton() { }

        public static StaticallyInitializedSingleton Instance
        {
            get
            {
                return _instance;
            }
        }

        public void SayHelloWorld()
        {
            Console.WriteLine("Hello world!");
        }
    }
}
