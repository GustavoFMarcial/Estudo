namespace MyProgram
{
    public class EmailSender : INotificationSystem
    {
        public string Type { get; private set; } = "Email";

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