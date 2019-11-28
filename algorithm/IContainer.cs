using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm
{
    public interface IContainer
    {
        ContainerType Type { get; set; }
        int ContainerWeight { get; set; }
        Column SearchSpace(List<Column> columns);
    }
}
