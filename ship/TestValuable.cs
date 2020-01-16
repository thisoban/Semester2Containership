using System;
using System.Collections.Generic;
using System.Linq;
using ContainerShip;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ship
{
    [TestClass]
    public class TestValuable
    {
        [TestMethod]
        public void TestSpaceNotAvailableForValuable()
        {
            Ship ship = new Ship(2,2);
            Valuable value = new Valuable{ ContainerWeight = 20000, Type = ContainerType.Valuable};
            List<IContainer> containers = new List<IContainer>()
            {
                new Cooled {ContainerWeight = 30000, Type = ContainerType.Cooled},
                new Cooled {ContainerWeight = 30000, Type = ContainerType.Cooled},
                new Cooled {ContainerWeight = 30000, Type = ContainerType.Cooled},
                new Cooled {ContainerWeight = 30000, Type = ContainerType.Cooled},
                new Cooled {ContainerWeight = 30000, Type = ContainerType.Cooled},
                new Cooled {ContainerWeight = 30000, Type = ContainerType.Cooled},
                new Cooled {ContainerWeight = 30000, Type = ContainerType.Cooled},
                new Cooled {ContainerWeight = 30000, Type = ContainerType.Cooled},
                new Cooled {ContainerWeight = 30000, Type = ContainerType.Cooled},
                new Cooled {ContainerWeight = 30000, Type = ContainerType.Cooled},
                new Valuable{ ContainerWeight = 20000, Type = ContainerType.Valuable},
                new Valuable{ ContainerWeight = 20000, Type = ContainerType.Valuable}
               
            };
            ship.PlaceAllContainers(containers);
           Assert.IsNull(value.SearchSpace(ship.Columns.ToList()));
        }

        [TestMethod]
        public void TestSpaceAvailableForValuable()
        {

            Ship ship = new Ship(2, 2);
            Valuable value = new Valuable { ContainerWeight = 20000, Type = ContainerType.Valuable };
            List<IContainer> containers = new List<IContainer>()
            {
                new Cooled {ContainerWeight = 30000, Type = ContainerType.Cooled},
                new Cooled {ContainerWeight = 30000, Type = ContainerType.Cooled},
                new Cooled {ContainerWeight = 30000, Type = ContainerType.Cooled},
                new Cooled {ContainerWeight = 30000, Type = ContainerType.Cooled},
                new Cooled {ContainerWeight = 30000, Type = ContainerType.Cooled},
                new Cooled {ContainerWeight = 30000, Type = ContainerType.Cooled},
                new Cooled {ContainerWeight = 30000, Type = ContainerType.Cooled},
                new Cooled {ContainerWeight = 30000, Type = ContainerType.Cooled},
                new Cooled {ContainerWeight = 30000, Type = ContainerType.Cooled},
                new Cooled {ContainerWeight = 30000, Type = ContainerType.Cooled}, 
                new Valuable{ ContainerWeight = 20000, Type = ContainerType.Valuable}
            };
            ship.PlaceAllContainers(containers);
            Assert.IsNotNull(value.SearchSpace(ship.Columns.ToList()));
        }
    }
}
