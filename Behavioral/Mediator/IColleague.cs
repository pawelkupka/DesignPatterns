namespace DesignPatterns.Behavioral.Mediator
{
    public interface IColleague
    {
        void Receive(string message, string from);
        void Send(string message);
        string Name { get; }
    }
}
