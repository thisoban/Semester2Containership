using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm
{
    public class Container
    {
        public int ContainerWeight { get; set; }
        public ContainerType type { get; set; }
        public override string ToString()
        {
            return "Type: " + type + " Weight: " + ContainerWeight;
        }
        public bool ContainerFitsInColumn(Stack stack)
        {
            if (stack.Containers.Count != 0)
            {
                int WeightColumn = (stack.Containers.Sum(x => x.ContainerWeight) - (stack.Containers.First().ContainerWeight));
                return (WeightColumn + ContainerWeight <= 120000);
            }
            return true;
        }

    }
}
