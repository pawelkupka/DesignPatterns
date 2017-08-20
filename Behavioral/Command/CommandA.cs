namespace DesignPatterns.Behavioral.Command
{
    public class CommandA : ICommand
    {
        private readonly Receiver _receiver;

        public CommandA(Receiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.Action("CommandA");
        }
    }
}
