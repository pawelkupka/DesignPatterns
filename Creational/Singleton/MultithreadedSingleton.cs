using System;

namespace DesignPatterns.Creational.Singleton
{
    public class MultithreadedSingleton
    {
        private static volatile MultithreadedSingleton _instance;
        private static object _syncRoot = new Object();

        private MultithreadedSingleton() { }

        public static MultithreadedSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncRoot)
                    {
                        if (_instance == null)
                            _instance = new MultithreadedSingleton();
                    }
                }
                return _instance;
            }
        }

        public void SayHelloWorld()
        {
            Console.WriteLine("Hello world!");
        }
    }
}
