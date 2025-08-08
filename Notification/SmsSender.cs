namespace MyProgram
{
    public class SmsSender : INotificationSystem
    {
        public string Type { get; private set; } = "SMS";

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