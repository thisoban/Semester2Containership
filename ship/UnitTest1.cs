using System;
using System.Collections.Generic;
using System.Linq;
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

        [TestMethod]
        public void  BigShip()
        {
            Ship ship = new Ship(4, 6);
            List<IContainer> containers = new List<IContainer>()
            {
                new Cooled(){ContainerWeight = 30000, Type = ContainerType.Cooled},
                new Cooled(){ContainerWeight = 30000, Type = ContainerType.Cooled},
                new Cooled(){ContainerWeight = 30000, Type = ContainerType.Cooled},
                new Cooled(){ContainerWeight = 30000, Type = ContainerType.Cooled},
                new Valuable(){ContainerWeight = 20000, Type = ContainerType.Valuable},
                new Valuable(){ContainerWeight = 20000, Type = ContainerType.Valuable},
                new Valuable(){ContainerWeight = 10000, Type = ContainerType.Valuable},
                new Valuable(){ContainerWeight = 10000, Type = ContainerType.Valuable},
                new Standard(){ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard(){ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard(){ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard(){ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard(){ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard(){ContainerWeight = 30000, Type = ContainerType.Normal}
            };

            for (int i = 0; i < 60; i++)
            {
                containers.Add(new Standard(){ContainerWeight = 30000, Type = ContainerType.Normal});
            }
            ship.PlaceAllContainers(containers);
            List<IContainer> ContainersOnDeck = new List<IContainer>();
            foreach (Stack stack in ship.Columns)
            {
                foreach (IContainer container in stack.Containers)
                {
                    ContainersOnDeck.Add(container);
                }
            }
            Assert.IsTrue(containers.All(ContainersOnDeck.Contains) && containers.Count == ContainersOnDeck.Count && ship.Balance());
        }

        [TestMethod]
        public void TestEmptyShipBalance()
        {
            Ship ship = new Ship(3,3);
            Assert.IsTrue( ship.IsBalanced);
        }
    }
}
