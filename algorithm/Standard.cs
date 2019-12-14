using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm
{
    public class Standard : Container,IContainer
    {
        public ContainerType Type { get ; set; }

        public Stack SearchSpace(List<Stack> columns)
        {
            if (columns.OrderBy(x => x.StackWeight).Where(x => this.ContainerFitsInColumn(x)).ToList().Count() == 0)
            {
                return null;
            }

            return columns.OrderBy(x => x.StackWeight).Where(x => this.ContainerFitsInColumn(x)).ToList().First();
        }
    }
}
