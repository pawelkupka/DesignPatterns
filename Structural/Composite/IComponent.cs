namespace DesignPatterns.Structural.Composite
{
    public interface IComponent
    {
        IComponent Add(IComponent component);
        IComponent Remove(IComponent component);
        void Operation();
    }
}
