using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm
{
    public class Ship
    {
        private readonly List<Stack> stack = new List<Stack>();
        public int Horizon { get; set; }
        public int Vertical { get; set; }
        public IReadOnlyCollection<Stack> Columns
        {
            get => stack;
        }
        public Ship(int horizon, int vertical)
        {
            Horizon = horizon;
            Vertical = vertical;
            InitStacks();
        }

        private void InitStacks()
        {
            for (int b = 0; b < Vertical; b++)
            {
                for (int l = 0; l < Horizon; l++)
                {
                    stack.Add(new Stack() { Horizontal = (b + 1), Vertical = (l + 1), StackWeight = 0 });
                }
            }
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
            bool ShipBalanced = (stack.Sum(x => x.StackWeight) >= (stack.Count * 150000) / 2);
            bool ColumnBalanced = ((ColumnLightestSide().Sum(x => x.StackWeight) * 100) / stack.Sum(x => x.StackWeight) >= 40);

            if (!ColumnBalanced || !ShipBalanced)
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
            if (Lightside() == Side.Left)
            {
                return stack.Where(x => x.Horizontal <= (Vertical / 2)).ToList();

            }
            else
            {
                return stack.Where(x => x.Horizontal > (Vertical / 2)).ToList();
            }
        }

        private Side Lightside()
        {

            int LeftWeight = stack.Where(x => x.Horizontal <= (Vertical / 2)).Sum(x => x.StackWeight);
            int RightWeight = stack.Where(x => x.Horizontal > (Vertical / 2)).Sum(x => x.StackWeight);

            if (LeftWeight > RightWeight)
            {
                return Side.Right;
            }
            else
            {
                return Side.Left;
            }
        }

        public enum Side
        {
            Left,
            Right
        }
    }
}
  



