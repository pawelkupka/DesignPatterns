using System;

namespace DesignPatterns.Behavioral.State
{
    public class StateA : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("StateA");
            context.ChangeState(new StateB());
        }
    }
}
