using System;

namespace Test
{
    public class ConcreteObserver : IObserver
    {
        public ConcreteObserver Parent { get; private set; }
        public Guid Id { get; private set; }
        public int Points { get; set; }
        public string Name { get; private set; }

        public ConcreteObserver(ConcreteObserver parent, string name)
        {
            this.Parent = parent;
            this.Name = name;

            this.Id = Guid.NewGuid();
        }

        public void Update(int points)
        {
            this.Points += points;

            if (this.Parent != null)
            {
                this.Parent.Update(points);
            }
        }
    }
}
