namespace MyProgram
{
    public class SmsSender : INotificationObserver
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Sending SMS: {message}");
        }
    }
}