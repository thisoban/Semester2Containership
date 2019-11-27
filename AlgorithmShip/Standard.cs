using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmShip
{
    public class Standard : Container, IContainer
    {
        public ContainerType Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
