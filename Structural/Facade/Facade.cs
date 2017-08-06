namespace DesignPatterns.Structural.Facade
{
    public class Facade
    {
        private readonly SubsystemA _subsystemA;
        private readonly SubsystemB _subsystemB;

        public Facade()
        {
            _subsystemA = new SubsystemA();
            _subsystemB = new SubsystemB();
        }

        public void Operation1()
        {
            _subsystemA.OperationA();
        }

        public void Operation2()
        {
            _subsystemB.OperationB();
        }
    }
}
