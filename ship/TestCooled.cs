using System;
using System.Collections.Generic;
using System.Linq;
using ContainerShip;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ship
{
    [TestClass]
    public class TestCooled
    {
        [TestMethod]
        public void TestContainerDoesntFit()
        {
            Cooled cc = new Cooled(){ContainerWeight = 30000, Type = ContainerType.Cooled};
            Ship ship = new Ship(2,2);
            List<IContainer> containers = new List<IContainer>()
            {
                new Cooled(){ContainerWeight = 30000, Type = ContainerType.Cooled},
                new Cooled(){ContainerWeight = 30000, Type = ContainerType.Cooled},
                new Cooled(){ContainerWeight = 30000, Type = ContainerType.Cooled},
                new Cooled(){ContainerWeight = 30000, Type = ContainerType.Cooled},
                new Cooled(){ContainerWeight = 30000, Type = ContainerType.Cooled},
                new Cooled(){ContainerWeight = 30000, Type = ContainerType.Cooled},
                new Cooled(){ContainerWeight = 30000, Type = ContainerType.Cooled},
                new Cooled(){ContainerWeight = 30000, Type = ContainerType.Cooled},
                new Cooled(){ContainerWeight = 30000, Type = ContainerType.Cooled},
                
                new Cooled(){ContainerWeight = 30000, Type = ContainerType.Cooled}
            };
            ship.PlaceAllContainers(containers);
            
            Assert.IsNull(cc.SearchSpace(ship.Columns.ToList()));
        }

        [TestMethod]
        public void TestCooledContainerFit()
        {
            Cooled cc = new Cooled(){ ContainerWeight = 30000, Type = ContainerType.Cooled};
            Ship ship = new Ship(2, 2);
            List<IContainer> containers = new List<IContainer>()
            {
                
            };
            ship.PlaceAllContainers(containers);

            Assert.IsNotNull(cc.SearchSpace(ship.Columns.ToList()));
        }
    }
}
