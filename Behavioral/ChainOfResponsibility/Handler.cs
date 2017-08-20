namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public abstract class Handler
    {
        protected readonly Handler _next;

        public Handler(Handler next)
        {
            _next = next;
        }

        public abstract void HandleRequest();
    }
}
