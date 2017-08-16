using System;

namespace DesignPatterns.Behavioral.Mediator
{
    public class ColleagueB : IColleague
    {
        private readonly IMediator _mediator;
        private readonly string _name;

        public ColleagueB(IMediator mediator)
        {
            _mediator = mediator;
            _mediator.Add(this);
            _name = "ColleagueB";
        }

        public string Name
        {
            get { return _name; }
        }

        public void Receive(string message, string from)
        {
            Console.WriteLine($"ColleagueB received message from  {from}: {message}");
        }

        public void Send(string message)
        {
            _mediator.Send(message, _name);
        }
    }
}
