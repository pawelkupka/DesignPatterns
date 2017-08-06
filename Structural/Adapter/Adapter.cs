namespace DesignPatterns.Structural.Adapter
{
    public class Adapter : Adaptee, IAdapter
    {
        public void AdaptedMethod(string firstMessage, string secondMessage)
        {
            base.AdapteeMethod($"{firstMessage} {secondMessage}");
        }
    }
}
