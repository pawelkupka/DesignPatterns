using System;

namespace DesignPatterns.Behavioral.State
{
    public class StateB : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("StateB");
            context.ChangeState(new StateA());
        }
    }
}
