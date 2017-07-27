namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            LazylyInitializedSingleton.Instance.SayHelloWorld();
            StaticallyInitializedSingleton.Instance.SayHelloWorld();
            MultithreadedSingleton.Instance.SayHelloWorld();
        }
    }
}
