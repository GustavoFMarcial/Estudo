namespace MyProgram
{
    public class Delivery : IOrderType
    {
        public string Type { get; private set; } = "Delivery";

        public void ProcessOrderType(INotificationSystem notificationType)
        {
            notificationType.SendNotificationConfirmed();
            notificationType.SendNotificationReady();
        }
    }
}