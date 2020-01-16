using System;
using System.Collections.Generic;
using System.Linq;
using ContainerShip;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ship
{
    [TestClass]
    public class TestNormal
    {
        [TestMethod]
        public void TestSpaceNotAvailableForNormal()
        {
            Ship ship = new Ship(2, 2);
            Standard standard = new Standard() { ContainerWeight = 20000, Type = ContainerType.Normal };
            List<IContainer> containers = new List<IContainer>()
            {
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal}
              
               
            };
            ship.PlaceAllContainers(containers);
            Assert.IsNull(standard.SearchSpace(ship.Columns.ToList()));
        }
        [TestMethod]
        public void TestSpaceAvailableForNormal()
        {
            Ship ship = new Ship(2, 2);
            Standard standard = new Standard() { ContainerWeight = 20000, Type = ContainerType.Normal };
            List<IContainer> containers = new List<IContainer>()
            {
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard {ContainerWeight = 30000, Type = ContainerType.Normal}
            };
            ship.PlaceAllContainers(containers);
            Assert.IsNotNull(standard.SearchSpace(ship.Columns.ToList()));
        }
    }
}
