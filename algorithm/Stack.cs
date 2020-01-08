using System.Collections.Generic;

namespace ContainerShip
{
    public class Stack
    {
        private readonly List<IContainer> _containers = new List<IContainer>();
        public IReadOnlyCollection<IContainer> Containers { get => _containers; }

        public int Horizontal { get; set; }
        public int Vertical { get; set; }
        public int StackWeight { get; set; }

        public void PlaceContinaer(IContainer container)
        {
            _containers.Add(container);
            StackWeight += container.ContainerWeight;
        }
    }
}
