﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerShip
{
    public class Ship
    {
        private readonly List<Stack> stack = new List<Stack>();
        public int Horizon { get; set; }
        public int Vertical { get; set; }
        public bool IsBalanced => Balance();
        public IReadOnlyCollection<Stack> Columns => stack;

        public Ship(int horizon, int vertical)
        {
            Horizon = horizon;
            Vertical = vertical;
            InitStacks();
        }

        private void InitStacks()
        {
            for (var b = 0; b < Vertical; b++)
            for (var l = 0; l < Horizon; l++)
                stack.Add(new Stack {Horizontal = b + 1, Vertical = l + 1, StackWeight = 0});
        }
        public void PlaceAllContainers(List<IContainer> containers)
        {
            foreach (IContainer container in containers.OrderBy(x => x.Type).ThenByDescending(x => x.ContainerWeight))
            {
                PlaceContainer(container);
            }
        }

        private void PlaceContainer(IContainer container)
        {
            try
            {
                Stack stack = container.SearchSpace(ColumnLightestSide());
                stack.PlaceContinaer(container);
            }
            catch (Exception)
            {
                Console.WriteLine("Schip is niet groot genoeg");
            }
        }

        public bool Balance()
        {
            bool ShipBalance = (stack.Sum(x => x.StackWeight) >= (stack.Count * 150000) / 2);
            bool StackBalanced = ((ColumnLightestSide().Sum(x => x.StackWeight) * 100) / stack.Sum(x => x.StackWeight) >= 40);

            if (!StackBalanced || !ShipBalance)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private List<Stack> ColumnLightestSide()
        {
            if (LightSide() == Side.Left)
            {
                return stack.Where(x => x.Horizontal <= (Vertical / 2)).ToList();
            }
            else
            {
                return stack.Where(x => x.Horizontal > (Vertical / 2)).ToList();
            }
        }

        private Side LightSide()
        {
            var LeftWeight = stack.Where(x => x.Horizontal <= (Vertical / 2)).Sum(x => x.StackWeight);
            var RightWeight = stack.Where(x => x.Horizontal > (Vertical / 2)).Sum(x => x.StackWeight);

            if (LeftWeight > RightWeight) return Side.Right;

            return Side.Left;
            
        }

        private enum Side
        {
            Left,
            Right
        }
    }
}




