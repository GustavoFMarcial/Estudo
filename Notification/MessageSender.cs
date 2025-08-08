namespace MyProgram
{
    public class MessageSender : INotificationSystem
    {
        public string Type { get; private set; } = "Message";

        public void SendNotificationConfirmed()
        {
            Console.WriteLine("Order is Confirmed");
        }

        public void SendNotificationReady()
        {
            Console.WriteLine("Order is ready");
        }
    }
}