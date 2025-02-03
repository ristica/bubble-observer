using System;

namespace Test
{
    public class ConcreteObserver : IObserver
    {
        public ConcreteObserver(ConcreteObserver parent, string name)
        {
            Parent = parent;
            Name = name;

            Id = Guid.NewGuid();
        }

        public ConcreteObserver Parent { get; }
        public Guid Id { get; private set; }
        public int Points { get; set; }
        public string Name { get; private set; }

        public void Update(int points)
        {
            Points += points;

            Parent?.Update(points);
        }
    }
}