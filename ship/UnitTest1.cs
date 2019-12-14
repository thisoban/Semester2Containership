using System;
using System.Collections.Generic;
using algorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ship
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSmallShip()
        {
            Ship ship = new Ship(2,2);

            List<IContainer> containers = new List<IContainer>()
            {
                new Cooled(){ContainerWeight = 10000,Type = ContainerType.Cooled},
                new Cooled(){ContainerWeight = 20000,Type = ContainerType.Cooled},
                new Cooled(){ContainerWeight = 5000,Type = ContainerType.Cooled},
                new Cooled(){ContainerWeight = 10000,Type = ContainerType.Cooled},
                new Valuable(){ContainerWeight = 20000,Type = ContainerType.Valuable},
                new Valuable(){ContainerWeight = 20000,Type = ContainerType.Valuable},
                new Valuable(){ContainerWeight = 15000,Type = ContainerType.Valuable},
                new Valuable(){ContainerWeight = 10000,Type = ContainerType.Valuable},
                new Standard(){ContainerWeight = 10000,Type = ContainerType.Normal},
                new Standard(){ContainerWeight = 30000,Type = ContainerType.Normal},
                new Standard(){ContainerWeight = 10000,Type = ContainerType.Normal},
                new Standard(){ContainerWeight = 30000,Type = ContainerType.Normal}
            };

            for(int i =0; i <10; i++)
            {
                containers.Add(new Standard() { ContainerWeight = 30000, Type = ContainerType.Normal });
            }
        }
    }
}
