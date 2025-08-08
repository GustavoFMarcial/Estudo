namespace MyProgram
{
    public class Pickup : IOrderType
    {
        public string Type { get; private set; } = "Pickup";

        public void ProcessOrderType(INotificationSystem notificationType)
        {
            notificationType.SendNotificationConfirmed();
            notificationType.SendNotificationReady();
        }
    }
}