using System.Transactions;

namespace MyProgram
{
    public class Order
    {
        private string Id { get; set; }
        private Client Client { get; set; }
        private List<IItem> Items { get; set; } = new List<IItem>();
        private IOrderType OrderType { get; set; }
        private INotificationSystem NotificationType { get; set; }
        private IPaymentType PaymentType { get; set; }

        public Order(Client client, List<IItem> items, IOrderType orderType, INotificationSystem notificationType, IPaymentType paymentType)
        {
            Id = Id = "O" + Guid.NewGuid().ToString("N").Substring(0, 4);
            Client = client ?? throw new InvalidOperationException("Invalid client");
            Items = items ?? throw new InvalidOperationException("Invalid list of items");
            OrderType = orderType ?? throw new InvalidOperationException("Invalid order type");
            NotificationType = notificationType ?? throw new InvalidOperationException("Invalid notification type");
            PaymentType = paymentType ?? throw new InvalidOperationException("Invalid payment type");
        }

        public void ProcessPayment()
        {
            PaymentType.ProcessPayment();
        }

        public void AddItems(IItem item)
        {
            if (item == null) throw new InvalidOperationException("Invalid item");

            Items.Add(item);
        }

        public void SendNotificationOrderConfirmed()
        {
            NotificationType.SendNotificationOrderConfirmed();
        }

        public void SendNotificationOrderReady()
        {
            NotificationType.SendNotificationOrderReady(OrderType);
        }

        public void SendNotificationOrderDone()
        {
            NotificationType.SendNotificationOrderDone(OrderType);
        }

    }
}