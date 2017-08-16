namespace DesignPatterns.Behavioral.Mediator
{
    public interface IMediator
    {
        void Send(string message, string from);
        void Add(IColleague colleague);
    }
}
