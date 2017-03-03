namespace Test
{
    public class Subject
    {
        private IObserver _observer = new ConcreteObserver(null, null);

        public void RegisterObserver(IObserver observer)
        {
            this._observer = observer;
        }

        public void UnregisterObserver(IObserver observer)
        {
            this._observer = null;
        }

        public void NotifyObserver(int points)
        {
            this._observer.Update(points);
        }
    }
}
