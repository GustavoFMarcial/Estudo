namespace MyProgram
{
    public class NotificationSystem
    {
        private readonly List<INotificationObserver> _observer = new List<INotificationObserver>();
        public IReadOnlyList<INotificationObserver> Observer => _observer;

        public void AddObserver(INotificationObserver observer)
        {
            if (observer == null) throw new InvalidOperationException("Item can't be null");

            _observer.Add(observer);
        }

        public void RemoveObserver(INotificationObserver observer)
        {
            if (observer == null) throw new InvalidOperationException("Item can't be null");

            _observer.Remove(observer);
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