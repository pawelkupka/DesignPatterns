using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Mediator
{
    public class Mediator : IMediator
    {
        private readonly IList<IColleague> _colleagues;

        public Mediator()
        {
            _colleagues = new List<IColleague>();
        }

        public void Send(string message, string from)
        {
            foreach (var colleague in _colleagues)
            {
                colleague.Receive(message, from);
            }
        }

        public void Add(IColleague colleague)
        {
            _colleagues.Add(colleague);
        }
    }
}
