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

        public Column SearchSpace(List<Column> columns)
        {
            if (columns.OrderBy(x => x.ColumnWeight).Where(x => this.ContainerFitsInColumn(x)).ToList().Count() == 0)
            {
                return null;
            }

            return columns.OrderBy(x => x.ColumnWeight).Where(x => this.ContainerFitsInColumn(x)).ToList().First();
        }
    }
}
