using System.Collections.Generic;
using System.Linq;
using ContainerShip;
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
            
            ship.PlaceAllContainers(containers);
            List<IContainer> containersOnDeck = new List<IContainer>();
            foreach (Stack stack in ship.Columns)
            {
                foreach (IContainer container in stack.Containers)
                {
                    containersOnDeck.Add(container);
                }
            }

            Assert.IsTrue(containers.All(containersOnDeck.Contains) && containers.Count == containersOnDeck.Count && ship.Balance());
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
            List<IContainer> containersOnDeck = new List<IContainer>();
            foreach (Stack stack in ship.Columns)
            {
                foreach (IContainer container in stack.Containers)
                {
                    containersOnDeck.Add(container);
                }
            }
            Assert.IsTrue(containers.All(containersOnDeck.Contains) && containers.Count == containersOnDeck.Count && ship.Balance());
        }

        [TestMethod]
        public void TestBalanceWithOneContainer()
        {
            Ship ship = new Ship(3,3);
            List<IContainer> containers = new List<IContainer>
            {
                new Standard() { ContainerWeight = 30000, Type = ContainerType.Normal }
            };
            ship.PlaceAllContainers(containers);
            Assert.IsFalse( ship.IsBalanced);
        }

        [TestMethod]
        public void TestShipBalanceOneContainer()
        {
            Ship ship = new Ship(6, 6);
            List<IContainer> containers = new List<IContainer>()
            {
                new Standard() {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard() {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard() {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard() {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard() {ContainerWeight = 30000, Type = ContainerType.Normal},
                new Standard() {ContainerWeight = 30000, Type = ContainerType.Normal}
              
            };
           
            ship.PlaceAllContainers(containers);
            Assert.IsFalse(ship.IsBalanced);
        }

        [TestMethod]
        public void TestListContainers()
        {
            Ship ship = new Ship(3,3);
            List<IContainer> containers = new List<IContainer>();

            for (int i = 0; i < 30; i++)
            {
                containers.Add(new Standard() { ContainerWeight = 30000, Type = ContainerType.Normal });
            }
            ship.PlaceAllContainers(containers);
            Assert.IsTrue(ship.IsBalanced);
        }

        [TestMethod]
        public void TestShipBalance()
        {
            Ship ship = new Ship(2, 2);
            List<IContainer> containers = new List<IContainer>();

            for (int i = 0; i < 30; i++)
            {
                containers.Add(new Standard() { ContainerWeight = 30000, Type = ContainerType.Normal });
            }
            ship.PlaceAllContainers(containers);
            Assert.IsTrue(ship.IsBalanced);
        }
    }
}
