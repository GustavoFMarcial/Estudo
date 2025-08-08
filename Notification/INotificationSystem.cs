namespace MyProgram
{
    public interface INotificationSystem
    {
        public string Type { get; }

        public void SendNotificationOrderConfirmed();
        public void SendNotificationOrderReady(IOrderType orderType);
        public void SendNotificationOrderDone(IOrderType orderType);
    }
}