using System.Collections.Generic;
using System.Linq;

namespace ContainerShip
{
    public class Standard : Container, IContainer
    {
        public Stack SearchSpace(List<Stack> columns)
        {
            if (columns.OrderBy(x => x.StackWeight).Where(x => ContainerFitsInColumn(x)).ToList().Count() ==
                0) return null;

            return columns.OrderBy(x => x.StackWeight).Where(x => ContainerFitsInColumn(x)).ToList().First();
        }
    }
}