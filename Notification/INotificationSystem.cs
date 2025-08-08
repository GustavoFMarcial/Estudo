namespace MyProgram
{
    public interface INotificationSystem
    {
        public string Type { get; }

        public void SendNotificationConfirmed();
        public void SendNotificationReady();
    }
}