namespace Test
{
    public class Subject
    {
        private IObserver _observer = new ConcreteObserver(null, null);

        public void RegisterObserver(IObserver observer)
        {
            _observer = observer;
        }

        public void UnregisterObserver(IObserver observer)
        {
            _observer = null;
        }

        public void NotifyObserver(int points)
        {
            _observer.Update(points);
        }
    }
}