namespace DesignPatterns.Behavioral.Servant
{
    public class Servant
    {
        public void DisplayMessage(IService service, string message)
        {
            service.ShowMessage(message);
        }
    }
}
