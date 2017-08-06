namespace DesignPatterns.Structural.Twin
{
    public class Child1 : Parent1
    {
        private readonly Child2 _twin;

        public Child1()
        {
            _twin = new Child2();
        }

        public void OperationFromParent2()
        {
            _twin.OperationFromParent2();
        }
    }
}
