using System.Collections.Generic;
using System.Linq;
using ContainerShip;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ship
{
    [TestClass]
    public class TestShip
    {
        [TestMethod]
        public void TestSmallShip_FIllingContainers_Balanced()
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
        public void  TestBigShip_FillContainers_Balanced()
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
        public void TestBalanceWithOneContainer_UnBalanced()
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
        public void TestShipBalanceSixContainer_Unbalanced()
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
            Assert.IsFalse(ship.Balance());
        }

        [TestMethod]
        public void TestThirthyContainers_Balanced()
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
        public void TestSmallShipBalance()
        {
            Ship ship = new Ship(2, 2);
            List<IContainer> containers = new List<IContainer>();

            for (int i = 0; i < 30; i++)
            {
                containers.Add(new Cooled() { ContainerWeight = 30000, Type = ContainerType.Cooled });
            }
            ship.PlaceAllContainers(containers);
            Assert.IsTrue(ship.Balance());
        }

        [TestMethod]
        public void TestStackweight()
        {
            List<IContainer> containers = new List<IContainer>();
            containers.Add(new Standard(){ContainerWeight = 30000, Type = ContainerType.Normal});
            Ship ship = new Ship(2,2);
            ship.PlaceAllContainers(containers);
            Assert.AreEqual(30000, ship.ToTalWeight);

              
        }
        [TestMethod]
        public void TestStackweightMax()
        {
            List<IContainer> containers = new List<IContainer>();
            containers.Add(new Standard() { ContainerWeight = 30000, Type = ContainerType.Normal });
            containers.Add(new Standard() { ContainerWeight = 30000, Type = ContainerType.Normal });
            containers.Add(new Standard() { ContainerWeight = 30000, Type = ContainerType.Normal });
            containers.Add(new Standard() { ContainerWeight = 30000, Type = ContainerType.Normal });
            containers.Add(new Standard() { ContainerWeight = 30000, Type = ContainerType.Normal });
            Ship ship = new Ship(2, 2);
            ship.PlaceAllContainers(containers);
            Assert.AreEqual(150000, ship.ToTalWeight);

        }
        [TestMethod]
        public void TestStackinvalid()
        {
            List<IContainer> containers = new List<IContainer>();
            containers.Add(new Standard() { ContainerWeight = 30000, Type = ContainerType.Normal });
            containers.Add(new Standard() { ContainerWeight = 30000, Type = ContainerType.Normal });
            containers.Add(new Standard() { ContainerWeight = 30000, Type = ContainerType.Normal });
            containers.Add(new Standard() { ContainerWeight = 30000, Type = ContainerType.Normal });
            containers.Add(new Standard() { ContainerWeight = 30000, Type = ContainerType.Normal });
            Ship ship = new Ship(2, 2);
            ship.PlaceAllContainers(containers);
            Assert.AreNotEqual(160000, ship.ToTalWeight);
        }

        [TestMethod]
        public void TestBalancing()
        {
            Ship ship = new Ship(2,2);
            List<IContainer> containers = new List<IContainer>();
            containers.Add(new Standard() { ContainerWeight = 30000, Type = ContainerType.Normal });
            ship.PlaceAllContainers(containers);
            Assert.IsFalse(ship.Balance()); 
        }
    }
}
