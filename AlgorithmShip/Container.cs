﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmShip
{
    public class Container
    {
        public int ContainerWeight { get; set; }
        public ContainerType containerType { get; set; }

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
