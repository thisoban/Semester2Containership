using System.Collections.Generic;

namespace ContainerShip
{
    public class Stack
    {
        private readonly List<IContainer> _containers = new List<IContainer>();
        public IReadOnlyCollection<IContainer> Containers => _containers;

        public int Horizontal { get;  }
        public int Vertical { get; }
        public int StackWeight { get; set; }

        public void PlaceContinaer(IContainer container)
        {
            _containers.Add(container);
            StackWeight += container.ContainerWeight;
        }
    }
}