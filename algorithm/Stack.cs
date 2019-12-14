using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm
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
