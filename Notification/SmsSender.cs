namespace MyProgram
{
    public class SmsSender : INotificationSystem
    {
        public string Type { get; private set; } = "SMS";

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