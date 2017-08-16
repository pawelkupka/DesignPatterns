namespace DesignPatterns.Behavioral.State
{
    public class Context
    {
        private IState _state;

        public Context()
        {
            _state = new StateA();
        }

        public void ChangeState(IState state)
        {
            _state = state;
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }
}
