namespace DesignPatterns.Structural.Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Proxy is a wrapper or agent object that is being called by the client 
            // to access the real serving object behind the scenes
            var subject = new Subject();
            var proxy = new Proxy(subject);
            proxy.Operation();
            proxy.Authenticate();
            proxy.Operation();
        }
    }
}
