namespace MyProgram
{
    public class MessageSender : INotificationObserver
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Sending message: {message}");
        }
    }
}