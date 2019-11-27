using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmShip
{
    public interface IContainer
    {
        ContainerType Type { get; set; }
        int ContainerWeight { get; set; }
        Column SearchSpace(List<Column> columns);
    }
}
