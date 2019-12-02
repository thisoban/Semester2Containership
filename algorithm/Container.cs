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
        public ContainerType ContainerType { get; set; }

        public override string ToString()
        {
            return "Type: " + ContainerType + " Weight: " + ContainerWeight;
        }
        public bool ContainerFitsInColumn(Column column)
        {
            if (column.Containers.Count != 0)
            {
                int WeightColumn = (column.Containers.Sum(x => x.ContainerWeight) - (column.Containers.First().ContainerWeight));
                return (WeightColumn + ContainerWeight <= 120000);
            }
            return true;
        }

    }
}
