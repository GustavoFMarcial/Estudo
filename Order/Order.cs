using System.Transactions;

namespace MyProgram
{
    public class Order
    {
        public string Id { get; private set; }
        public Client Client { get; private set; }
        public List<IItem> Items { get; private set; } = new List<IItem>();
        public IOrderType OrderType { get; private set; }
        public INotificationSystem NotificationType { get; private set; }
        public IPaymentType PaymentType { get; private set; }

        public Order(Client client, List<IItem> items, IOrderType orderType, INotificationSystem notificationType, IPaymentType paymentType)
        {
            Id = Id = "O" + Guid.NewGuid().ToString("N").Substring(0, 4);
            Client = client ?? throw new InvalidOperationException("Invalid client");
            Items = items ?? throw new InvalidOperationException("Invalid list of items");
            OrderType = orderType ?? throw new InvalidOperationException("Invalid order type");
            NotificationType = notificationType ?? throw new InvalidOperationException("Invalid notification type");
            PaymentType = paymentType ?? throw new InvalidOperationException("Invalid payment type");
        }

    }
}