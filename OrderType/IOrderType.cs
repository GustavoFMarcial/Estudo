namespace MyProgram
{
    public interface IOrderType
    {
        public string Type { get; }

        public void ProcessOrderType(INotificationSystem notificationType);
    }
}