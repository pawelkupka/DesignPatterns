using System;

namespace DesignPatterns.Behavioral.Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mediator pattern allows communication between a set of objects through the mediator object
            var mediator = new Mediator();
            var colleagueA = new ColleagueA(mediator);
            var colleagueB = new ColleagueB(mediator);

            colleagueA.Send("Hello");
            colleagueB.Send("Hi");
            colleagueA.Send("How are you?");
            colleagueB.Send("I'm fine");
            colleagueB.Send("Thank you");
        }
    }
}
