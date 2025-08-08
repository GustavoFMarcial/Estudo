namespace MyProgram
{
    public class EmailSender : INotificationObserver
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Sending email: {message}");
        }
    }
}