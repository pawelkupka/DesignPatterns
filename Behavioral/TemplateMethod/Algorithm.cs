namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class Algorithm
    {
        public void TemplateMethod(IPrimitives primitives)
        {
            primitives.Operation1();
            primitives.Operation2();
        }
    }
}
