namespace MyProgram
{
    public class NotificationSystem
    {
        private List<INotificationObserver> Observer { get; set; } = new List<INotificationObserver>();

        public void AddObserver(INotificationObserver observer)
        {
            if (observer == null) throw new InvalidOperationException("Item can't be null");

            Observer.Add(observer);
        }

        public void RemoveObserver(INotificationObserver observer)
        {
            if (observer == null) throw new InvalidOperationException("Item can't be null");

            Observer.Remove(observer);
        }

        public void NotifyObservers(string message)
        {
            foreach (INotificationObserver observer in Observer)
            {
                observer.Notify(message);
            }
        }
    }
}