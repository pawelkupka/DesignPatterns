namespace DesignPatterns.Structural.Twin
{
    public class Child2 : Parent2
    {
        private readonly Child1 _twin;

        public Child2()
        {
            _twin = new Child1();
        }

        public void OperationFromParent1()
        {
            _twin.OperationFromParent1();
        }
    }
}
