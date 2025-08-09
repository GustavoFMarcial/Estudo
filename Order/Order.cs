using System.Dynamic;
using System.Transactions;

namespace MyProgram
{
    public class Order
    {
        public string Id { get; set; }
        public Client Client { get; set; }
        private List<IItem> Items { get; set; } = new List<IItem>();
        private IOrderType OrderType { get; set; }
        private NotificationSystem NotificationSystem { get; set; }
        private IPaymentType PaymentType { get; set; }

        public Order(Client client, List<IItem> items, IOrderType orderType, NotificationSystem notificationSystem, IPaymentType paymentType)
        {
            Id = "O" + Guid.NewGuid().ToString("N").Substring(0, 4);
            Client = client ?? throw new InvalidOperationException("Client can't be null");
            Items = items ?? throw new InvalidOperationException("Items can't be null");
            OrderType = orderType ?? throw new InvalidOperationException("Type can't be null");
            NotificationSystem = notificationSystem ?? throw new InvalidOperationException("Notification system can't be null");
            PaymentType = paymentType ?? throw new InvalidOperationException("Payment can't be null");
        }

        public void ProcessPayment()
        {
            PaymentType.ProcessPayment();
        }

        public void AddItems(IItem item)
        {
            if (item == null) throw new InvalidOperationException("Item can't be null");

            Items.Add(item);
        }

        public void AddObserver(INotificationObserver observer)
        {
            NotificationSystem.AddObserver(observer);
        }

        public void RemoveObserver(INotificationObserver observer)
        {
            NotificationSystem.RemoveObserver(observer);
        }

        public void ConfirmOrder()
        {
            NotificationSystem.NotifyObservers(OrderType.GetMessage(OrderStatus.Confirmed));
        }

        public void OrderReady()
        {
            NotificationSystem.NotifyObservers(OrderType.GetMessage(OrderStatus.Ready));
        }

        public void OrderDone()
        {
            NotificationSystem.NotifyObservers(OrderType.GetMessage(OrderStatus.Done));
        }

    }
}