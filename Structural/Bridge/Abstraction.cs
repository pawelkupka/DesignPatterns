namespace DesignPatterns.Structural.Bridge
{
    public class Abstraction
    {
        private readonly IBridge _bridge;

        public Abstraction(IBridge bridge)
        {
            _bridge = bridge;
        }

        public void Operation()
        {
            _bridge.OperationImp();
        }
    }
}
