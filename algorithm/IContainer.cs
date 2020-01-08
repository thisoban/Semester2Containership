using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerShip
{
    public interface IContainer
    {
        ContainerType Type { get; set; }
        int ContainerWeight { get; set; }
        Stack SearchSpace(List<Stack> columns);
    }
}
