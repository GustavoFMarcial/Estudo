using System.Transactions;

namespace MyProgram
{
    public class Order
    {
        private string Id { get; set; }
        private Client Client { get; set; }
        private List<IItem> Items { get; set; } = new List<IItem>();
        private IOrderType OrderType { get; set; }
        private NotificationSystem Observer = new NotificationSystem();
        private IPaymentType PaymentType { get; set; }

        public Order(Client client, List<IItem> items, IOrderType orderType, IPaymentType paymentType)
        {
            Id = "O" + Guid.NewGuid().ToString("N").Substring(0, 4);
            Client = client ?? throw new InvalidOperationException("Client can't be null");
            Items = items ?? throw new InvalidOperationException("Items can't be null");
            OrderType = orderType ?? throw new InvalidOperationException("Type can't be null");
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
            Observer.AddObserver(observer);
        }

        public void RemoveObserver(INotificationObserver observer)
        {
            Observer.RemoveObserver(observer);
        }

        public void ConfirmOrder()
        {
            Observer.NotifyObservers(OrderType.GetConfirmedMessage());
        }

        public void OrderReady()
        {
            Observer.NotifyObservers(OrderType.GetReadyMessage());
        }

        public void OrderDone()
        {
            Observer.NotifyObservers(OrderType.GetDoneMessage());
        }

    }
}