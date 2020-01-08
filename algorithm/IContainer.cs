using System.Collections.Generic;

namespace ContainerShip
{
    public interface IContainer
    {
        ContainerType Type { get; set; }
        int ContainerWeight { get; set; }
        Stack SearchSpace(List<Stack> columns);
    }
}