namespace MyProgram
{
    public class EmailSender : INotificationSystem
    {
        public string Type { get; private set; } = "Email";

        public void SendNotificationOrderConfirmed()
        {
            Console.WriteLine($"{Type}: Order Confirmed");
        }

        public void SendNotificationOrderReady(IOrderType orderType)
        {
            Console.WriteLine($"{Type}: {orderType.GetReadyMessage()}");
        }

        public void SendNotificationOrderDone(IOrderType orderType)
        {
            Console.WriteLine($"{Type}: {orderType.GetDoneMessage()}");
        }
    }
}