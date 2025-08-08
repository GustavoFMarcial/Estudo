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
            if (orderType is Delivery)
            {
                Console.WriteLine($"{Type}: Order on the way");
            }
            else
            {
                Console.WriteLine($"{Type}: Order ready to pickup");
            }
        }

        public void SendNotificationOrderDone(IOrderType orderType)
        {
            if (orderType is Delivery)
            {
                Console.WriteLine($"{Type}: Order delivered");
            }
            else
            {
                Console.WriteLine($"{Type}: Order picked up");
            }
        }
    }
}