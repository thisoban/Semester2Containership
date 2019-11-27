using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmShip
{
   public class Column
    {
        private List<IContainer> _containers = new List<IContainer>();
        public IReadOnlyCollection<IContainer> Containers { get => _containers; }

        public int Horizontal { get; set; }
        public int Vertical { get; set; }
        public int  ColumnWeight { get; set; }

        public void PlaceContinaer(IContainer container)
        {
            _containers.Add(container);
            ColumnWeight += container.ContainerWeight;
        }
    }
}
